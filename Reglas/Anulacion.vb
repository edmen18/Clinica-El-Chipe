Imports System.Data.SqlClient
Imports datos
Imports System.Windows.Forms

Public Class Anulacion
    Dim cFunDB As New cFuncionesDB
    Private s_CodAnulacion As String
    Private d_Fecha As Date
    Private o_Personal As Personal
    Private s_MotivoAnulacion As String
    Private o_Venta As Venta
    Dim anul As String
    Public Property CodAnulacion() As String
        Get
            Return s_CodAnulacion
        End Get
        Set(ByVal value As String)
            s_CodAnulacion = value
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
    Public Property Personal() As Personal
        Get
            Return o_Personal
        End Get
        Set(ByVal value As Personal)
            o_Personal = value
        End Set
    End Property
    Public Property MotivoAnulacion() As String
        Get
            Return s_MotivoAnulacion
        End Get
        Set(ByVal value As String)
            s_MotivoAnulacion = value
        End Set
    End Property
    Public Property Venta() As Venta
        Get
            Return o_Venta
        End Get
        Set(ByVal value As Venta)
            o_Venta = value
        End Set
    End Property
    Public Function RegistrarAnulacion(ByVal usuario As String, ByVal motivo As String, ByVal codventa As String) As Boolean
        Try
            Dim csql As String = "Insert into anulacion(CodAnulacion,Fecha,Hora,CodUsuario,MotivoAnulacion,CodVenta) values('" + anul + "','" + Now.Date + "', '" & Now.Hour & ":" & Now.Minute & " ','" & usuario & "','" & motivo & "','" & codventa & "')"
            Dim db As BaseDatos = New BaseDatos()
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            db.ConfirmarTransaccion()
            db.Desconectar()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Sistema de Consultas e Historias Clinicas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
            Return False
        End Try
    End Function
    Function generaranul()
        Try
            Dim sql As String = "select count(*)+1 as codigo from anulacion"
            anul = cFunDB.ConsultaUnDato(sql, 0)
            'MsgBox(anul, MsgBoxStyle.Critical)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Sistema de Consultas e Historias Clinicas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
        End Try
    End Function


End Class
