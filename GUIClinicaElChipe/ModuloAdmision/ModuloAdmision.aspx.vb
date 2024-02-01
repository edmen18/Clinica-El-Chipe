Imports datos
Imports Reglas
Imports System.Windows.Forms
Imports System.Web
Imports System.Configuration
Imports System.Collections
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Partial Class ModuloAdmision_ServicioAdmision
    Inherits System.Web.UI.Page
    Dim cFun As New cFuncionesDB
    Dim u As New Usuario
    Dim t As New Turno
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LblUsu.Text = Request.QueryString("Valor1")

        If Page.IsPostBack = False Then
            LblPersonal.Text = cFun.ConsultaUnDato(u.MostrarUsuario(LblUsu.Text), 0)
            LblCodU.Text = cFun.ConsultaUnDato(u.MostrarUsuario(LblUsu.Text), 2)
            LblFecha.Text = Date.Today
            LblHora.Text = TimeOfDay
            If LblHora.Text >= "00:00:00".ToString And LblHora.Text <= "06:59:59".ToString Then
                LblTurno.Text = "Madrugada"
                LblHoraampm.Text = "a.m"
            Else
                If LblHora.Text >= "07:00:00".ToString And LblHora.Text <= "12:59:59".ToString Then
                    LblTurno.Text = "Mañana"
                    LblHoraampm.Text = "a.m"
                Else
                    If LblHora.Text >= "13:00:00".ToString And LblHora.Text <= "18:59:59".ToString Then
                        LblTurno.Text = "Tarde"
                        LblHoraampm.Text = "p.m"
                    Else
                        LblTurno.Text = "Noche"
                        LblHoraampm.Text = "p.m"
                    End If
                End If
            End If
            t.NomTurno = LblTurno.Text
            LblCT.Text = cFun.ConsultaUnDato(t.ListaCodTurno(), 0)
            'MessageBox.Show("Bienvenido al Sistema " + LblPersonal.Text + ",que tenga una buena " + LblTurno.Text + "", "Sistema de Consultas e Historias Clinicas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
        End If
    End Sub
    Public texto As String
    Public Property _Texto2() As String
        Get
            Return LblUsu.Text
        End Get
        Set(ByVal value As String)
            texto = value
        End Set
    End Property

    Protected Sub LinkButton5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkButton5.Click
        Server.Transfer("~/ModuloAdmision/ElegirBusqueda.aspx?Valor1=" + LblUsu.Text)
    End Sub

    Protected Sub LinkButton7_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkButton7.Click
        Server.Transfer("~/ModuloAdmision/EliminarSolicitudAtencion.aspx?Valor1=" + LblUsu.Text)
    End Sub

    Protected Sub TrvProcesoAdmision_SelectedNodeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TrvProcesoAdmision.SelectedNodeChanged
        If TrvProcesoAdmision.Nodes(0).ChildNodes(0).Selected Then
            Server.Transfer("~/ModuloAdmision/ModuloAdmision.aspx?Valor1=" & LblUsu.Text)
        End If
        If TrvProcesoAdmision.Nodes(0).ChildNodes(1).Selected Then
            Server.Transfer("~/ModuloAdmision/Reportes/Reportes.aspx?Valor1=" & LblUsu.Text)
        End If
    End Sub

    Protected Sub LinkButton6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkButton6.Click
        Server.Transfer("~/ModuloAdmision/HistoriaClinica.aspx?Valor1=" + LblUsu.Text)
    End Sub

    Protected Sub LinkButton4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkButton4.Click
        Server.Transfer("~/ModuloAdmision/ReprogramacionSolicitudAtencion.aspx?Valor1=" + LblUsu.Text)
    End Sub
End Class
