Imports System.Windows.Forms
Imports datos
Imports Reglas
Imports System.Data
Imports System.Web.Security
Imports System.Linq
Imports System.Web.HttpCookie
Imports System.Web.Security.FormsAuthentication
Partial Class InicioSesion
    Inherits System.Web.UI.Page
    Dim cFun As New cFuncionesDB
    Dim u As New Usuario
    Dim dt As DataTable
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Page.IsPostBack = False Then
            Me.ClientScript.RegisterStartupScript(Me.GetType(), "text/VB", "<script>  history.forward() history.back()  </script>")
            Me.LblContador.Text = "3"
        End If
    End Sub
    Protected Sub BtnIniciar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnInicioSesion.Click
        Try
            dt = cFun.ConsultaX(u.InicioSesion(TxtUsuario.Text, TxtClave.Text))
            If CStr(dt.Rows(0).Item(4)) = True And CStr(dt.Rows(0).Item(5)) = True Then
                If Me.TxtUsuario.Text = CStr(dt.Rows(0).Item(1)) And Me.TxtClave.Text = CStr(dt.Rows(0).Item(2)) Then
                    'FormsAuthentication.GetAuthCookie(TxtUsuario.Text, False)
                    If CStr(dt.Rows(0).Item(3)) = "TU01" Then 'administrador
                        Server.Transfer("~/ModuloProgramacionMedica/ModuloProgramacionMedica.aspx?Valor1=" + TxtUsuario.Text)
                    ElseIf CStr(dt.Rows(0).Item(3)) = "TU02" Then 'paciente
                    ElseIf CStr(dt.Rows(0).Item(3)) = "TU03" Then 'admision
                        Server.Transfer("~/ModuloAdmision/ModuloAdmision.aspx?Valor1=" + TxtUsuario.Text)
                    ElseIf CStr(dt.Rows(0).Item(3)) = "TU04" Then 'archivo
                        Server.Transfer("~/ModuloArchivo/ModuloArchivo.aspx?Valor1=" + TxtUsuario.Text)
                    ElseIf CStr(dt.Rows(0).Item(3)) = "TU05" Then 'caja
                        Server.Transfer("~/ModuloCaja/ModuloCaja.aspx?Valor1=" + TxtUsuario.Text)
                    ElseIf CStr(dt.Rows(0).Item(3)) = "TU06" Then 'medico consultorio
                        Server.Transfer("~/ModuloConsultorio/ModuloConsultorio.aspx?Valor1=" + TxtUsuario.Text)
                    ElseIf CStr(dt.Rows(0).Item(3)) = "TU07" Then 'medico programa
                        Server.Transfer("~/ModuloConsultorio/ModuloConsultorio.aspx?Valor1=" + TxtUsuario.Text)
                    End If
                End If
                Me.TxtClave.Text = ""
                Me.TxtUsuario.Text = ""
                Me.TxtUsuario.Enabled = False
                Me.TxtClave.Enabled = False
                Me.BtnInicioSesion.Enabled = False
            Else
                MessageBox.Show("Disculpe pero usted esta desabilitado en el sistema", "Sistema de Consultas e Historias Clinicas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                Me.TxtClave.Text = ""
                Me.TxtUsuario.Text = ""
            End If
        Catch ex As Exception
            Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('Usuario y/o clave incorrecta');</script>"))
            Me.LblContador.Text = Val(Me.LblContador.Text) - 1
            If Val(Me.LblContador.Text) = 0 Then
                Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('Lo sentimos pero usted no pertenece al sistema');</script>"))
                Page.Response.End()
            End If
            Me.TxtClave.Text = ""
            Me.TxtUsuario.Text = ""
        End Try
    End Sub
    Private _usuario As String

    Public Property Usuario() As String
        Get
            Return (CStr(dt.Rows(0).Item(0)))
        End Get
        Set(ByVal value As String)
            _usuario = value
        End Set
    End Property
End Class
