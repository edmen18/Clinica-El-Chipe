﻿Imports Reglas
Imports datos
Partial Class ModuloProgramacionMedica_ModuloProgramacionMedica
    Inherits System.Web.UI.Page
    Dim cfun As New cFuncionesDB
    Dim u As New Usuario
    Dim t As New Turno
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LblUsu.Text = Request.QueryString("Valor1")
        If Page.IsPostBack = False Then
            LblPersonal.Text = cfun.ConsultaUnDato(u.MostrarUsuario(LblUsu.Text), 0)
            LblCodU.Text = cfun.ConsultaUnDato(u.MostrarUsuario(LblUsu.Text), 2)
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
            LblCT.Text = cfun.ConsultaUnDato(t.ListaCodTurno(), 0)
            'MessageBox.Show("Bienvenido al Sistema " + LblPersonal.Text + ",que tenga una buena " + LblTurno.Text + "", "Sistema de Consultas e Historias Clinicas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
        End If
    End Sub

    Protected Sub LinkButton6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkButton6.Click
        Server.Transfer("~/ModuloProgramacionMedica/ProgramacionMedica.aspx?Valor1=" + LblUsu.Text)
    End Sub

    Protected Sub LinkButton5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkButton5.Click
        Server.Transfer("~/ModuloProgramacionMedica/ModificarProgramacionMedica.aspx?Valor1=" + LblUsu.Text)
    End Sub
End Class