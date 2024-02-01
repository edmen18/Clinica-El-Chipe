Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports datos
Imports System.Web.UI.WebControls
Public Class Auditoria
    Dim cFunDb As New cFuncionesDB
    Private s_CodAuditoria As String
    Private o_Usuario As Usuario
    Private s_NomTabla As String
    Private d_Fecha As Date
    Private s_HoraRegistro As String
    Private s_CodDato As String
    Private s_DatosModificados As String
    Private s_DatosAnteriores As String
    Private s_Motivo As String
    Private s_DatosRegistrados As String
    Public Property CodAuditoria() As String
        Get
            Return s_CodAuditoria
        End Get
        Set(ByVal value As String)
            s_CodAuditoria = value
        End Set
    End Property
    Public Property Usuario() As Usuario
        Get
            Return o_Usuario
        End Get
        Set(ByVal value As Usuario)
            o_Usuario = value
        End Set
    End Property
    Public Property NomTabla() As String
        Get
            Return s_NomTabla
        End Get
        Set(ByVal value As String)
            s_NomTabla = value
        End Set
    End Property
    Public Property Fecha() As Date
        Get
            Return d_Fecha
        End Get
        Set(ByVal value As Date)
            d_Fecha = value
        End Set
    End Property
    Public Property HoraRegistro() As String
        Get
            Return s_HoraRegistro
        End Get
        Set(ByVal value As String)
            s_HoraRegistro = value
        End Set
    End Property
    Public Property CodDato() As String
        Get
            Return s_CodDato
        End Get
        Set(ByVal value As String)
            s_CodDato = value
        End Set
    End Property
    Public Property DatosModificados() As String
        Get
            Return s_DatosModificados
        End Get
        Set(ByVal value As String)
            s_DatosModificados = value
        End Set
    End Property
    Public Property DatosAnteriores() As String
        Get
            Return s_DatosAnteriores
        End Get
        Set(ByVal value As String)
            s_DatosAnteriores = value
        End Set
    End Property
    Public Property Motivo() As String
        Get
            Return s_Motivo
        End Get
        Set(ByVal value As String)
            s_Motivo = value
        End Set
    End Property
    Public Property DatosRegistrados() As String
        Get
            Return s_DatosRegistrados
        End Get
        Set(ByVal value As String)
            s_DatosRegistrados = value
        End Set
    End Property
    Public Function AuditoriaReprogramacionSolicitud(ByRef codigoauditoria As String, ByRef codusuario As String, ByRef nomtabla As String, ByRef fecha As Date, ByRef hora As String, ByRef coddato As String, ByRef datosmodi As String, ByRef datosante As String, ByRef motivo As String, ByRef datosregis As String) As Boolean
        Try
            Dim csql As String = "Insert into Auditoria(CodAuditoria,CodUsuario,NomTabla,Fecha,HoraRegistro,CodDato,DatosModificados,DatosAnteriores,Motivo,DatosRegistrados)values('" & codigoauditoria & "','" & codusuario & "','" & nomtabla & "','" & fecha & "','" & hora & "','" & coddato & "','" & datosmodi & "','" & datosante & "','" & motivo & "','" & datosregis & "')"
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
    Function GeneraCodigoAuditoria() As String
        Dim sql As String
        sql = "Select Max(Convert(Int,right(CodAuditoria,100))) from Auditoria"
        Dim dato As String = cFunDb.ConsultaUnDato(sql, 0)
        Return dato
    End Function
End Class
