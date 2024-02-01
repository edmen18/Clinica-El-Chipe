Imports datos
Imports Reglas
Imports System.Windows.Forms

Partial Class ModuloArchivo_MovimientosHC
    Inherits System.Web.UI.Page
    Dim cFun As New cFuncionesDB
    Dim a As New Area
    Dim m As New Movimiento
    Dim u As New Usuario
    Dim tur As New Turno

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not PreviousPage Is Nothing Then
            LblNHC.Text = PreviousPage._Texto1
            LblNumTicket.Text = PreviousPage._Texto2
            LblEspecialidad.Text = PreviousPage._Texto3
            LblPaciente.Text = PreviousPage._Texto4
            LblCodEspecialidad.Text = PreviousPage._Texto5
        End If

        LblUsu.Text = Request.QueryString("Valor1")

        If Page.IsPostBack = False Then
            LblDe.Text = "Archivo"
            cFun.FillListaOrCombo(a.ListarArea(), DdArea, "NomArea", "CodArea")
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
            tur.NomTurno = LblTurno.Text
            LblCT.Text = cFun.ConsultaUnDato(tur.ListaCodTurno(), 0)
        End If
    End Sub

    Protected Sub BtnRegistrar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnRegistrar.Click
        Dim hora As String
        hora = LblHora.Text & " " & LblHoraampm.Text
        If LblNHC.Text = "" Or LblDe.Text = "" Then
            Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('No es posible guardar el registro porque los datos están incompletos');</script>"))
        Else
            If m.AgregarMovimiento(DdArea.Text, LblNHC.Text, LblDe.Text, DdArea.SelectedItem.Text, LblFecha.Text, hora, LblCodU.Text, LblCT.Text, LblCodEspecialidad.Text) = True Then
                MessageBox.Show("Datos guardados correctamente", "Sistema de Consultas e Historias Clinicas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
            Else
                Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('No es posible guardar los datos');</script>"))
            End If
        End If
    End Sub
    Protected Sub LinkButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkButton1.Click
        Server.Transfer("~/ModuloArchivo/ModuloArchivo.aspx?Valor1=" + LblUsu.Text)
    End Sub
End Class
