Imports Reglas
Imports System.Data
Imports datos
Imports System.Windows.Forms
Partial Class Hospitalizacion_ControlesVitales
    Inherits System.Web.UI.Page
    Dim cfun As New cFuncionesDB
    Dim hos As New Hospitalizacion
    Dim evo As New Evolucion
    Dim devo As New DetalleEvolucion
    Dim dh As New DiagnosticoHospitalizacion
    Dim tur As New Turno
    Dim u As New Usuario
    Dim cv As New ControlesVitales
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LblUsu.Text = Request.QueryString("Valor1")
        LblHospitalizacion.Text = Request.QueryString("CodHospitalizacion")
        LblPaciente.Text = Request.QueryString("Paciente")

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
            tur.NomTurno = LblTurno.Text
            LblCT.Text = cfun.ConsultaUnDato(tur.ListaCodTurno(), 0)
        End If
        Me.lbldiashospitalizado.Text = cv.diaHospitalizado(Now.Date, Me.LblHospitalizacion.Text)
        Me.lbldiasoperado.Text = cv.diaoperado(Now.Date, Me.LblHospitalizacion.Text)
    End Sub

    Protected Sub BtnRegistrar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles BtnRegistrar.Click
        Me.lblcontrol.Text = cv.verificarControl(Me.LblHospitalizacion.Text)
        If Me.lblcontrol.Text = "" Then
            Me.lblcontrol.Text = Me.cv.generar()
            Me.lbldetalle.Text = cv.generardetalle()
            If cv.AgregarControl(Me.LblHospitalizacion.Text, Me.lblcontrol.Text) = True Then
                cv.AgregarDetalle(Me.lbldetalle.Text, Me.lblcontrol.Text, CDate(Now.Date), Me.lbldiashospitalizado.Text, Me.lbldiasoperado.Text, Me.ddpresion.Text, Me.ddpulso.Text, Me.ddtemp.Text, CStr(Now.Hour), Me.txtpeso.Text, txtdeposiciones.Text, Me.txtorina.Text, txtbal.Text, txtmenstruacion.Text, Me.txtdrenaje.Text, Me.txttrans.Text, txtloquios.Text)
            End If
        Else
            Me.lblcontrol.Text = cv.generar()
            Me.lbldetalle.Text = cv.generardetalle()
            If cv.AgregarControl(Me.LblHospitalizacion.Text, Me.lblcontrol.Text) = True Then
                cv.AgregarDetalle(Me.lbldetalle.Text, Me.lblcontrol.Text, CDate(Now.Date), Me.lbldiashospitalizado.Text, Me.lbldiasoperado.Text, Me.ddpresion.Text, Me.ddpulso.Text, Me.ddtemp.Text, CStr(Now.Hour), Me.txtpeso.Text, txtdeposiciones.Text, Me.txtorina.Text, txtbal.Text, txtmenstruacion.Text, Me.txtdrenaje.Text, Me.txttrans.Text, txtloquios.Text)
            End If
        End If
           End Sub
End Class
