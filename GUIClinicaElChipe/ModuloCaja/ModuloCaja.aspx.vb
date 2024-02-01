Imports datos
Imports Reglas
Imports System.Windows.Forms
Partial Class ModuloCaja_ModuloCaja
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
                Lblhoraampm.Text = "a.m"
            Else
                If LblHora.Text >= "07:00:00".ToString And LblHora.Text <= "12:59:59".ToString Then
                    LblTurno.Text = "Mañana"
                    Lblhoraampm.Text = "a.m"
                Else
                    If LblHora.Text >= "13:00:00".ToString And LblHora.Text <= "18:59:59".ToString Then
                        LblTurno.Text = "Tarde"
                        Lblhoraampm.Text = "p.m"
                    Else
                        LblTurno.Text = "Noche"
                        Lblhoraampm.Text = "p.m"
                    End If
                End If
            End If
            t.NomTurno = LblTurno.Text
            LblCT.Text = cFun.ConsultaUnDato(t.ListaCodTurno(), 0)
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

    Protected Sub LinkButton6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkButton6.Click
        Server.Transfer("~/ModuloCaja/BusquedaParaCaja.aspx?Valor1=" + LblUsu.Text)
    End Sub

    Protected Sub LinkButton5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkButton5.Click
        Server.Transfer("~/ModuloCaja/VentaServicio.aspx?Valor1=" + LblUsu.Text)
    End Sub

    Protected Sub LinkButton8_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkButton8.Click
        Server.Transfer("~/ModuloCaja/AnularVenta.aspx?Valor1=" + LblUsu.Text)
    End Sub
End Class
