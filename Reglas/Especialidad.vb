Imports System.Data.SqlClient
Imports datos
Imports System.Web.UI.WebControls

Public Class Especialidad
    Dim cFun As New cFuncionesDB
    Private s_CodEspecialidad As String
    Private s_NomEspecialidad As String
    Private b_Estado As Boolean
    Public Property CodEspecialidad() As String
        Get
            Return s_CodEspecialidad
        End Get
        Set(ByVal value As String)
            s_CodEspecialidad = value
        End Set
    End Property
    Public Property NomEspecialidad() As String
        Get
            Return s_NomEspecialidad
        End Get
        Set(ByVal value As String)
            s_NomEspecialidad = value
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
    Public Function AgregarEspecialidad(ByRef codigoespecialidad As String, ByRef especialidad As String) As Boolean
        Try
            Dim csql As String = "Insert into Especialidad(CodEspecialidad,Nomespecialidad,Estado) values ('" + codigoespecialidad + "','" + especialidad + "','1')"
            Dim db As BaseDatos = New BaseDatos()
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            db.ConfirmarTransaccion()
            db.Desconectar()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function ModificarEspecialidad(ByRef especialidad As String, ByRef codigo As String) As Boolean
        Try
            Dim csql As String = "Update Especialidad set NomEspecialidad ='" + especialidad + "' where Codespecialidad='" + codigo + "'"
            Dim db As BaseDatos = New BaseDatos()
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            db.ConfirmarTransaccion()
            db.Desconectar()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function EliminarEspecialidad(ByRef codigo As String) As Boolean
        Try
            Dim csql As String = "Update Especialidad set estado ='0' where Codespecialidad='" + codigo + "'"
            Dim db As BaseDatos = New BaseDatos()
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            db.ConfirmarTransaccion()
            db.Desconectar()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Function ListarEspecialidad() As String
        Dim sql As String
        sql = "Select CodEspecialidad, NomEspecialidad from Especialidad where estado='1'"
        Return sql
    End Function
    Public Sub CargarEspecialidad(ByVal COMBO As DropDownList) 'Para el formulario de programacion medica
        Dim csql As String = "Select CodEspecialidad, NomEspecialidad from Especialidad where estado='1' order by 2"
        cFun.FillListaOrCombo(csql, COMBO, "NOMESPECIALIDAD", "CODESPECIALIDAD")
    End Sub
    Public Sub CargarEspecialidad2(ByVal COMBO As DropDownList) 'Para el formulario de modificar programacion medica
        Dim csql As String = "Select CodEspecialidad, NomEspecialidad from Especialidad where estado='1' and CodEspecialidad<>'E5' and CodEspecialidad<>'E6' order by 2"
        cFun.FillListaOrCombo(csql, COMBO, "NOMESPECIALIDAD", "CODESPECIALIDAD")
    End Sub
    Function CargarEspecialidad(ByRef codigoturno As String, ByRef fecha As Date) As String
        Dim sql As String
        sql = "Select a.CodEspecialidad,a.NomEspecialidad from Especialidad a inner join MedicoEspecialidad b " + _
        "on a.CodEspecialidad=b.CodEspecialidad inner join ProgramacionMedica c on c.CodMedicoEspecialidad=b.CodMedicoEspecialidad " + _
        "inner join DetalleProgramacionMedica d on d.CodProgramacionMedica=c.CodProgramacionMedica " + _
        "inner join Turno e on e.CodTurno=d.CodTurno " + _
        "where e.CodTurno='" & codigoturno & "' and d.FechaAtencion='" & fecha & "' and a.Estado='True'"
        Return sql
    End Function
    Function CargarEspecialidadUnica(ByRef codigoturno As String, ByRef fecha As Date, ByRef codespe As String) As String
        Dim sql As String
        sql = "Select a.CodEspecialidad,a.NomEspecialidad from Especialidad a inner join MedicoEspecialidad b " + _
        "on a.CodEspecialidad=b.CodEspecialidad inner join ProgramacionMedica c on c.CodMedicoEspecialidad=b.CodMedicoEspecialidad " + _
        "inner join DetalleProgramacionMedica d on d.CodProgramacionMedica=c.CodProgramacionMedica " + _
        "inner join Turno e on e.CodTurno=d.CodTurno " + _
        "where e.CodTurno='" & codigoturno & "' and d.FechaAtencion='" & fecha & "' and a.Estado='True' and a.CodEspecialidad='" & codespe & "'"
        Return sql
    End Function
    Function generar()
        Dim csql As String = "select count(*)+1 from especialidad"
        Return cFun.ConsultaUnDato(csql, 0)
    End Function
End Class
