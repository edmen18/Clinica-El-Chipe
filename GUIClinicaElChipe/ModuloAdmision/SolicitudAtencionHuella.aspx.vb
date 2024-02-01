Imports datos
Imports Reglas
Imports System.Windows.Forms
Partial Class ModuloAdmision_SolicitudAtencionHuella
    Inherits System.Web.UI.Page
    Dim cFun As New cFuncionesDB
    Dim esp As New Especialidad
    Dim detallePro As New DetalleProgramacionMedica
    Dim sa As New SolicitudAtencion
    Dim tur As New Turno
    Dim v As New Venta
    Dim c As New Cama
    Dim pas As New Paciente
    Dim medi As New Medico
    Dim hc As New HistoriaClinica
    Dim u As New Usuario
    Dim s As New Servicio
    Dim var As New variables
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '*** Con el PreviousPage se copian los datos del web form BusquedaParaTicket a este formulario
        Me.LblPaciente.Text = Request.QueryString("paciente")
        Me.LblCodPaciente.Text = Request.QueryString("codpaciente")
        Me.LblNHC.Text = Request.QueryString("historia")

        LblUsu.Text = Request.QueryString("Valor1")
        If Page.IsPostBack = False Then
            cFun.FillListaOrCombo(tur.ListaTurno(), DdTurno, "NomTurno", "CodTurno")
            DdTurno.Items.Insert(0, "-Seleccione-")
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
        Else
        End If
    End Sub
    Protected Sub DdEspecialidad_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DdEspecialidad.SelectedIndexChanged
        LblCodTiComprobar.Text = cFun.ConsultaUnDato(sa.CalcularSolicitudAtencionPaciente(LblCodPaciente.Text, LblNHC.Text, LblFechaAtencion.Text, DdTurno.Text), 0)
        LblNTiComprobar.Text = cFun.ConsultaUnDato(sa.CalcularSolicitudAtencionPaciente(LblCodPaciente.Text, LblNHC.Text, LblFechaAtencion.Text, DdTurno.Text), 1)
        LblEsComprueba.Text = cFun.ConsultaUnDato(sa.CalcularSolicitudAtencionPaciente(LblCodPaciente.Text, LblNHC.Text, LblFechaAtencion.Text, DdTurno.Text), 2)
        LblMeComprueba.Text = cFun.ConsultaUnDato(sa.CalcularSolicitudAtencionPaciente(LblCodPaciente.Text, LblNHC.Text, LblFechaAtencion.Text, DdTurno.Text), 3)
        If DdEspecialidad.Text = "E5" Then
            Panel2.Visible = True
        ElseIf DdEspecialidad.Text = "E6" Then
            Panel2.Visible = True
        Else
            Panel2.Visible = False
        End If
        If LblEsComprueba.Text <> DdEspecialidad.SelectedItem.Text Then
            LblCodEspecialidad.Text = DdEspecialidad.Text
            cFun.FillListaOrCombo(medi.ListaMedicos(DdTurno.Text, LblFechaAtencion.Text, LblCodEspecialidad.Text), DdMedicos, "MEDICO", "CodMedico")
            DdMedicos.Items.Insert(0, "---Seleccione Médico---")
            LblDpm.Text = cFun.ConsultaUnDato(medi.ListaMedicos(DdTurno.Text, LblFechaAtencion.Text, LblCodEspecialidad.Text), 2)
            Try
                If DdMedicos.SelectedValue.ToString = "" Then
                    MessageBox.Show("Disculpe pero no hay atención para la especialidad de " + DdEspecialidad.SelectedItem.Text + " en el turno " + DdTurno.SelectedItem.Text + ". Si desea puede elegir otro turno", "Sistema de Consultas y Hospitalización", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                    limpiar()
                Else
                    DdMedicos.Visible = True
                    Lblcama.Text = cFun.ConsultaUnDato(c.ListaCama(LblDpm.Text), 0)
                    If Lblcama.Text = "" Then
                    Else
                        cFun.FillListaOrCombo(s.CargarServicio(), DdMotivoHospitalizacion, "NomServicio", "CodServicio")
                        DdMotivoHospitalizacion.Items.Insert(0, "---- Seleccione Motivo ----")
                        Panel2.Visible = True
                    End If
                End If
            Catch ex As Exception

            End Try
        Else
            MessageBox.Show("Lo sentimos pero no se podrá registrar la solicitud de atención del paciente " + LblPaciente.Text + " porque ya ha sacado la solicitud N° " + LblNTiComprobar.Text + " en el turno " + DdTurno.SelectedItem.Text + " para la misma especialidad de " + LblEsComprueba.Text + " con el médico " + LblMeComprueba.Text + ". Puede sacar otra solicitud para otra especialidad", "Sistema de Consultas y Hospitalización", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
            limpiar()
            Server.Transfer("~/ModuloAdmision/ModuloAdmision.aspx")
        End If
    End Sub

    Protected Sub CFecha_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CFecha.SelectionChanged
        LblFechaAtencion.Text = CFecha.SelectedDate
        If CDate(LblFechaAtencion.Text) < CDate(LblFecha.Text) Then
            MessageBox.Show("Ingrese la Fecha correctamente", "Sistema de Consultas y Hospitalización", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
        Else
            DdEspecialidad.Enabled = True
            DdTurno.Enabled = True
            CFecha.Enabled = False
        End If
    End Sub
    Sub limpiar()
        LblCodSoliAten.Text = ""
        LblCodEspecialidad.Text = ""
        LblFechaAtencion.Text = ""
        LblCantidad.Text = ""
        CFecha.Enabled = True
        CFecha.EnableViewState = False
        DdEspecialidad.Items.Clear()
        DdEspecialidad.Enabled = False
        DdTurno.Items.Clear()
        cFun.FillListaOrCombo(tur.ListaTurno(), DdTurno, "NomTurno", "CodTurno")
        DdTurno.Items.Insert(0, "-Seleccione-")
        DdTurno.Enabled = False
        Panel2.Visible = False
        DdMotivoHospitalizacion.Items.Clear()
        Lblcama.Text = ""
        Try
            If DdMedicos.SelectedItem.Text = "" Then
                DdMedicos.Visible = True
            Else
                DdMedicos.SelectedItem.Text = ""
            End If
        Catch ex As Exception
        End Try
    End Sub

    Protected Sub DdTurno_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DdTurno.SelectedIndexChanged
        LblCodTurno.Text = DdTurno.Text
        cFun.FillListaOrCombo(esp.CargarEspecialidad(DdTurno.Text, LblFechaAtencion.Text), DdEspecialidad, "NomEspecialidad", "CodEspecialidad")
        DdEspecialidad.Items.Insert(0, "--Seleccione--")
    End Sub
    Protected Sub LinkButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkButton1.Click
        Server.Transfer("~/ModuloAdmision/ModuloAdmision.aspx?Valor1=" + LblUsu.Text)
    End Sub
    Protected Sub LinkButton2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkButton2.Click
        Server.Transfer("~/ModuloAdmision/BusquedaParaSolicitudAtencion.aspx?Valor1=" + LblUsu.Text)
    End Sub

    Sub estado(ByRef valor As Boolean)
        Label4.Visible = valor
        Label3.Visible = valor
        LblEspecialidad.Visible = valor
        Label21.Visible = valor
        LblTurno2.Visible = valor
        Label22.Visible = valor
        LblMedico.Visible = valor
        Label23.Visible = valor
        LblNumCon.Visible = valor
        Label25.Visible = valor
        Label6.Visible = valor
        Label7.Visible = valor
        Label23.Visible = valor
    End Sub

    Protected Sub BtnRegistrar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles BtnRegistrar.Click
        'Dim hora As String
        'Dim b As Double = "0.0"
        'Dim c As Date = "01/01/1990"
        'Button2.Enabled = True
        'If sa.GeneraCodigoSolicitudAtencion() = "" Then
        '    LblCodigo.Text = 1
        'Else
        '    LblCodigo.Text = CStr(CInt(sa.GeneraCodigoSolicitudAtencion()) + 1)
        'End If

        'If sa.GeneraCodSolicitudAtencion(LblFechaAtencion.Text) = "" Then
        '    LblCodSoliAten.Text = 1
        'Else
        '    LblCodSoliAten.Text = CStr(CInt(sa.GeneraCodSolicitudAtencion(LblFechaAtencion.Text)) + 1)
        'End If

        'If sa.GeneraNumSolicitudAtencion(LblFechaAtencion.Text, LblCodEspecialidad.Text, LblCodTurno.Text, DdMedicos.Text) = "" Then
        '    LblNumSA.Text = 1
        'Else
        '    LblNumSA.Text = CStr(CInt(sa.GeneraNumSolicitudAtencion(LblFechaAtencion.Text, LblCodEspecialidad.Text, LblCodTurno.Text, DdMedicos.Text)) + 1)
        'End If
        'LblContar.Text = CStr(CInt(sa.ContarNumSolicitudAtencion(LblFechaAtencion.Text, LblCodEspecialidad.Text, LblCodTurno.Text, DdMedicos.Text)) + 1)

        'LblNumCon.Text = Val(LblCantidad.Text) - Val(LblContar.Text)
        'If LblNumCon.Text < 0 Then
        '    MessageBox.Show("Lo sentimos, comunicar al paciente " + LblPaciente.Text + " que para la especialidad de " + DdEspecialidad.SelectedItem.Text + " en el turno " + DdTurno.SelectedItem.Text + " con el médico " + DdMedicos.SelectedItem.Text + " ya no hay solicitudes de atención disponibles. Intente con otra fecha, médico o turno. Gracias por su comprensión", "Sistema de Consultas y Hospitalización", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
        '    LblCodDetalleProgramacionMedica.Text = ""
        '    LblCodEspecialidad.Text = ""
        '    LblFechaAtencion.Text = ""
        '    LblCantidad.Text = ""
        '    CFecha.Enabled = True
        '    CFecha.EnableViewState = False
        '    LblEspecialidad.Text = ""
        '    LblMedico.Text = ""
        '    LblNumCon.Text = ""
        '    LblTurno.Text = ""
        '    DdMedicos.SelectedItem.Text = ""
        '    cFun.FillListaOrCombo(esp.ListarEspecialidad(), DdEspecialidad, "NomEspecialidad", "CodEspecialidad")
        '    estado(False)
        '    DdEspecialidad.Enabled = False
        '    BtnRegistrar.Enabled = False
        'Else
        '    LblCodV.Text = "V" & cFun.ConsultaUnDato(v.GeneraCodigoVenta(), 0)
        '    Button2.Enabled = False
        '    BtnRegistrar.Enabled = True
        'End If
        'hora = LblHora.Text & " " & LblHoraampm.Text
        'If LblCodV.Text = "" Or LblCodPaciente.Text = "" Or LblCodTurno.Text = "" Then
        '    Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('No es posible guardar el registro porque los datos están incompletos');</script>"))
        'Else
        '    If v.AgregarVenta(LblCodV.Text, "A00001", LblCodTurno.Text, LblCodU.Text, LblCodPaciente.Text, b, "P", LblFecha.Text, hora, "False", "", b) = True Then
        '    Else
        '    End If
        'End If

        'If LblCodigo.Text = "" Or LblCodSoliAten.Text = "" Or LblNumSA.Text = "" Or LblCodDetalleProgramacionMedica.Text = "" Or LblNHC.Text = "" Or LblFechaAtencion.Text = "" Or LblFecha.Text = "" Or LblCodV.Text = "" Then
        '    Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('No es posible guardar el registro porque los datos están incompletos');</script>"))
        'Else
        '    If Lblcama.Text = "" Then
        '        If sa.AgregarSolicitudAtencion(LblCodigo.Text, LblCodSoliAten.Text, LblNumSA.Text, LblCodDetalleProgramacionMedica.Text, LblNHC.Text, LblFechaAtencion.Text, LblFecha.Text, hora, LblCodU.Text, c, LblCodV.Text, "False", "False", c, "") = True Then
        '            MessageBox.Show("Solicitud de Atención guardadada correctamente", "Sistema de Consultas e Historias Clinicas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
        '            Server.Transfer("~/ModuloAdmision/ModuloAdmision.aspx")
        '        Else
        '            Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('No es posible guardar los datos');</script>"))
        '        End If
        '    Else
        '        'If DdMotivoHospitalizacion.SelectedItem.Text = "---- Seleccione Motivo ----" Then
        '        'MessageBox.Show("Disculpe pero los datos están incompletos", "Sistema de Consultas y Hospitalización", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
        '        'Else
        '        If sa.AgregarSolicitudAtencion(LblCodigo.Text, LblCodSoliAten.Text, LblNumSA.Text, LblCodDetalleProgramacionMedica.Text, LblNHC.Text, LblFechaAtencion.Text, LblFecha.Text, hora, LblCodU.Text, c, LblCodV.Text, "False", "False", c, DdMotivoHospitalizacion.SelectedItem.Text) = True Then
        '            MessageBox.Show("Solicitud de Atención guardadada correctamente", "Sistema de Consultas e Historias Clinicas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
        '            Server.Transfer("~/ModuloAdmision/ModuloAdmision.aspx")
        '        Else
        '            Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('No es posible guardar los datos');</script>"))
        '        End If
        '        'End If
        '    End If
        '    End If

        Dim hora As String
        Dim b As Double = "0.0"
        Dim c As Date = "01/01/1990"
        Button2.Enabled = True
        If sa.GeneraCodigoSolicitudAtencion() = "" Then
            LblCodigo.Text = 1
        Else
            LblCodigo.Text = CStr(CInt(sa.GeneraCodigoSolicitudAtencion()) + 1)
        End If
        If sa.GeneraCodSolicitudAtencion(LblFechaAtencion.Text) = "" Then
            LblCodSoliAten.Text = 1
        Else
            LblCodSoliAten.Text = CStr(CInt(sa.GeneraCodSolicitudAtencion(LblFechaAtencion.Text)) + 1)
        End If
        If sa.GeneraNumSolicitudAtencion(LblFechaAtencion.Text, LblCodEspecialidad.Text, LblCodTurno.Text, DdMedicos.Text) = "" Then
            LblNumSA.Text = 1
        Else
            LblNumSA.Text = CStr(CInt(sa.GeneraNumSolicitudAtencion(LblFechaAtencion.Text, LblCodEspecialidad.Text, LblCodTurno.Text, DdMedicos.Text)) + 1)
        End If
        LblContar.Text = CStr(CInt(sa.ContarNumSolicitudAtencion(LblFechaAtencion.Text, LblCodEspecialidad.Text, LblCodTurno.Text, DdMedicos.Text)) + 1)

        LblNumCon.Text = Val(LblCantidad.Text) - Val(LblContar.Text)
        If LblNumCon.Text < 0 Then
            MessageBox.Show("Lo sentimos, comunicar al paciente " + LblPaciente.Text + " que para la especialidad de " + DdEspecialidad.SelectedItem.Text + " en el turno " + DdTurno.SelectedItem.Text + " con el médico " + DdMedicos.SelectedItem.Text + " ya no hay solicitudes de atención disponibles. Intente con otra fecha, médico o turno. Gracias por su comprensión", "Sistema de Consultas e Historias Clinicas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
            LblCodDetalleProgramacionMedica.Text = ""
            LblCodEspecialidad.Text = ""
            LblFechaAtencion.Text = ""
            LblCantidad.Text = ""
            CFecha.Enabled = True
            CFecha.EnableViewState = False
            LblEspecialidad.Text = ""
            LblMedico.Text = ""
            LblNumCon.Text = ""
            LblTurno.Text = ""
            DdMedicos.SelectedItem.Text = ""
            cFun.FillListaOrCombo(esp.ListarEspecialidad(), DdEspecialidad, "NomEspecialidad", "CodEspecialidad")
            estado(False)
            DdEspecialidad.Enabled = False
            BtnRegistrar.Enabled = False
        Else
            LblCodV.Text = "V" & cFun.ConsultaUnDato(v.GeneraCodigoVenta(), 0)
            Button2.Enabled = False
            BtnRegistrar.Enabled = True
        End If
        hora = LblHora.Text & " " & LblHoraampm.Text
        If LblCodV.Text = "" Or LblCodPaciente.Text = "" Or LblCodTurno.Text = "" Then
            Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('No es posible guardar el registro porque los datos están incompletos');</script>"))
        Else
            If v.AgregarVenta(LblCodV.Text, "A00001", LblCodTurno.Text, LblCodU.Text, LblCodPaciente.Text, b, "P", LblFecha.Text, hora, "False", "", b) = True Then
            Else
            End If
        End If

        If LblCodigo.Text = "" Or LblCodSoliAten.Text = "" Or LblNumSA.Text = "" Or LblCodDetalleProgramacionMedica.Text = "" Or LblNHC.Text = "" Or LblFechaAtencion.Text = "" Or LblFecha.Text = "" Or LblCodV.Text = "" Then
            Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('No es posible guardar el registro porque los datos están incompletos');</script>"))
        Else
            If Lblcama.Text = "" Then
                If sa.AgregarSolicitudAtencion(LblCodigo.Text, LblCodSoliAten.Text, LblNumSA.Text, LblCodDetalleProgramacionMedica.Text, LblNHC.Text, LblFechaAtencion.Text, LblFecha.Text, hora, LblCodU.Text, c, LblCodV.Text, "False", "False", c, "") = True Then
                    MessageBox.Show("Solicitud de Atención guardadada correctamente", "Sistema de Consultas y Hospitalización", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                    Server.Transfer("~/ModuloAdmision/ModuloAdmision.aspx")
                Else
                    Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('No es posible guardar los datos');</script>"))
                End If
            Else
                If sa.AgregarSolicitudAtencion(LblCodigo.Text, LblCodSoliAten.Text, LblNumSA.Text, LblCodDetalleProgramacionMedica.Text, LblNHC.Text, LblFechaAtencion.Text, LblFecha.Text, hora, LblCodU.Text, c, LblCodV.Text, "False", "False", c, DdMotivoHospitalizacion.SelectedItem.Text) = True Then
                    MessageBox.Show("Solicitud de Atención guardadada correctamente", "Sistema de Consultas y Hospitalización", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                    Server.Transfer("~/ModuloAdmision/ModuloAdmision.aspx")
                Else
                    Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('No es posible guardar los datos');</script>"))
                End If
            End If
        End If
    End Sub

    Protected Sub DdMedicos_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DdMedicos.SelectedIndexChanged
        Try
            If LblCodTurno.Text = "" Or LblCodEspecialidad.Text = "" Or DdMedicos.Text = "" Or LblFechaAtencion.Text = "" Then
                MessageBox.Show("No es posible realizar la verificación porque los datos están incompletos", "Sistema de Consultas y Hospitalización", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
            Else
                LblCantidad.Text = cFun.ConsultaUnDato(detallePro.CantidadPacientes(LblFechaAtencion.Text, LblCodEspecialidad.Text, LblCodTurno.Text, DdMedicos.Text), 0)
                LblCodDetalleProgramacionMedica.Text = cFun.ConsultaUnDato(detallePro.ListaCodDetalleProgramacionMedica(LblCodTurno.Text, LblFechaAtencion.Text, Val(LblCantidad.Text), LblCodEspecialidad.Text, DdMedicos.Text), 0)
                estado(True)
                LblEspecialidad.Text = DdEspecialidad.SelectedItem.ToString
                LblTurno2.Text = DdTurno.SelectedItem.ToString
                LblMedico.Text = DdMedicos.SelectedItem.ToString
                Label7.Text = sa.ContarNumSolicitudAtencion(LblFechaAtencion.Text, LblCodEspecialidad.Text, LblCodTurno.Text, DdMedicos.Text)
                If sa.GeneraNumSolicitudAtencion(LblFechaAtencion.Text, LblCodEspecialidad.Text, LblCodTurno.Text, DdMedicos.Text) = "" Then
                    LblNumSA.Text = 1
                Else
                    LblNumSA.Text = CStr(CInt(sa.GeneraNumSolicitudAtencion(LblFechaAtencion.Text, LblCodEspecialidad.Text, LblCodTurno.Text, DdMedicos.Text)) + 1)
                End If
                '******LblContar realiza un count de los numsolicitudes de atención para poder obtener un valor y que este se pueda restar con la cantidad máxima de consultas

                LblNumCon.Text = Val(LblCantidad.Text)
                If LblNumCon.Text < 0 Then
                    MessageBox.Show("Lo sentimos, comunicar al paciente " + LblPaciente.Text + " que para la especialidad de " + DdEspecialidad.SelectedItem.Text + " en el turno " + DdTurno.SelectedItem.Text + " con el médico " + DdMedicos.SelectedItem.Text + " ya no hay tickets disponibles. Intente con otra fecha, médico o turno. Gracias por su comprensión", "Sistema de Consultas y Hospitalización", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                    LblCodDetalleProgramacionMedica.Text = ""
                    LblCodEspecialidad.Text = ""
                    LblFechaAtencion.Text = ""
                    LblCantidad.Text = ""
                    CFecha.Enabled = True
                    CFecha.EnableViewState = False
                    LblEspecialidad.Text = ""
                    LblMedico.Text = ""
                    LblNumCon.Text = ""
                    LblTurno.Text = ""
                    DdMedicos.SelectedItem.Text = ""
                    cFun.FillListaOrCombo(esp.ListarEspecialidad(), DdEspecialidad, "NomEspecialidad", "CodEspecialidad")
                    estado(False)
                    DdEspecialidad.Enabled = False
                    BtnRegistrar.Enabled = False
                    DdMotivoHospitalizacion.SelectedItem.Text = ""
                    Panel2.Visible = False
                    Lblcama.Text = ""
                Else
                    LblCodV.Text = "V" & cFun.ConsultaUnDato(v.GeneraCodigoVenta(), 0)
                    Button2.Enabled = False
                    BtnRegistrar.Enabled = True
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles Button2.Click
        limpiar()
    End Sub
End Class
