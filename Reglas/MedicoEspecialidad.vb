Imports System.Data.SqlClient
Imports datos

Public Class MedicoEspecialidad
    Dim cFun As New cFuncionesDB
    Private s_CodMedicoEspecialidad As String
    Private o_Medico As Medico
    Private o_Especialidad As Especialidad
    Private b_Estado As Boolean
    Public Property CodMedicoEspecialidad() As String
        Get
            Return s_CodMedicoEspecialidad
        End Get
        Set(ByVal value As String)
            s_CodMedicoEspecialidad = value
        End Set
    End Property
    Public Property Medico() As Medico
        Get
            Return o_Medico
        End Get
        Set(ByVal value As Medico)
            o_Medico = value
        End Set
    End Property
    Public Property Especialidad() As Especialidad
        Get
            Return o_Especialidad
        End Get
        Set(ByVal value As Especialidad)
            o_Especialidad = value
        End Set
    End Property
    Public Property Estado() As Boolean
        Get
            Return b_Estado
        End Get
        Set(ByVal value As Boolean)
            b_Estado = value
        End Set
    End Property
    Function CargarMedicoEspecialidad(ByRef codigomedico As String, ByRef codigoespecialidad As String)
        Dim sql As String
        sql = "Select CodMedicoEspecialidad from MedicoEspecialidad where CodMedico='" + codigomedico + "' and CodEspecialidad='" + codigoespecialidad + "' and Estado='1'"
        Dim dato As String = cFun.ConsultaUnDato(sql, 0)
        Return dato
    End Function
    Function GeneraCodigoMedicoEspecialidad()
        Dim sql As String
        sql = "Select count(*)+1 from MedicoEspecialidad"
        Dim dato As String = cFun.ConsultaUnDato(sql, 0)
        Return dato
    End Function
    Public Function AgregarMedicoESP(ByVal MES As String, ByRef codigomediCo As String, ByRef ESPECIALIDAD As String) As Boolean
        Try
            Dim csql As String = "Insert into MedicoEspecialidad(CodMedicoEspecialidad,CodMedico,CodEspecialidad,estado) values ('" + MES + "','" + codigomediCo + "','" + ESPECIALIDAD + "','1')"
            Dim db As BaseDatos = New BaseDatos()
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            db.ConfirmarTransaccion()
            db.Desconectar()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Return False
        End Try
    End Function
    Public Function EliminarMedicoESP(ByVal MES As String) As Boolean
        Try
            Dim csql As String = "UPDATE MedicoEspecialidad SET ESTADO ='0'  WHERE CodMedicoEspecialidad='" + MES + "'"
            Dim db As BaseDatos = New BaseDatos()
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            db.ConfirmarTransaccion()
            db.Desconectar()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Return False
        End Try
    End Function
End Class
