Imports datos
Imports Reglas
Imports System.Windows.Forms
Partial Class ModuloAdmision_ReprogramacionSolicitudAtencion
    Inherits System.Web.UI.Page
    Dim cFun As New cFuncionesDB
    Dim esp As New Especialidad
    Dim detallePro As New DetalleProgramacionMedica
    Dim sa As New SolicitudAtencion
    Dim tur As New Turno
    Dim v As New Venta
    Dim pas As New Paciente
    Dim medi As New Medico
    Dim u As New Usuario
    Dim audi As New Auditoria
    Dim com As New Comprobante
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LblUsu.Text = Request.QueryString("Valor1")
        LblFechaReprogramacion.Text = Date.Today
        If Page.IsPostBack = False Then
            cFun.FillListaOrCombo(tur.ListaTurno(), DdTurno, "NomTurno", "CodTurno")
            DdTurno.Items.Insert(0, "-Seleccione-")
            LblPersonal.Text = cFun.ConsultaUnDato(u.MostrarUsuario(LblUsu.Text), 0)
            LblCodU.Text = cFun.ConsultaUnDato(u.MostrarUsuario(LblUsu.Text), 2)
            LblFecha.Text = Date.Today
            LblHora.Text = TimeOfDay
            If LblHora.Text >= "00:00:00".ToString And LblHora.Text <= "06:59:59".ToString Then
                LblTurno2.Text = "Madrugada"
                LblHoraampm.Text = "a.m"
            Else
                If LblHora.Text >= "07:00:00".ToString And LblHora.Text <= "12:59:59".ToString Then
                    LblTurno2.Text = "Mañana"
                    LblHoraampm.Text = "a.m"
                Else
                    If LblHora.Text >= "13:00:00".ToString And LblHora.Text <= "18:59:59".ToString Then
                        LblTurno2.Text = "Tarde"
                        LblHoraampm.Text = "p.m"
                    Else
                        LblTurno2.Text = "Noche"
                        LblHoraampm.Text = "p.m"
                    End If
                End If
            End If
            tur.NomTurno = LblTurno2.Text
            LblCT.Text = cFun.ConsultaUnDato(tur.ListaCodTurno(), 0)
        End If
    End Sub
    Protected Sub GvListaCopiaTickets_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GvListaSoliAtenReprogramacion.SelectedIndexChanged
        Dim d As Date = "01/01/1990"
        LblNHC.Text = Trim(GvListaSoliAtenReprogramacion.Rows(GvListaSoliAtenReprogramacion.SelectedRow.RowIndex).Cells(1).Text)
        LblPaciente.Text = Trim(GvListaSoliAtenReprogramacion.Rows(GvListaSoliAtenReprogramacion.SelectedRow.RowIndex).Cells(2).Text)
        LblCodPaciente.Text = Trim(GvListaSoliAtenReprogramacion.Rows(GvListaSoliAtenReprogramacion.SelectedRow.RowIndex).Cells(3).Text)
        LblCodSoliAtenAnterior.Text = Trim(GvListaSoliAtenReprogramacion.Rows(GvListaSoliAtenReprogramacion.SelectedRow.RowIndex).Cells(4).Text)
        LblNumSoliAtenAnterior.Text = Trim(GvListaSoliAtenReprogramacion.Rows(GvListaSoliAtenReprogramacion.SelectedRow.RowIndex).Cells(5).Text)
        LblCodEspecialidadRepro.Text = Trim(GvListaSoliAtenReprogramacion.Rows(GvListaSoliAtenReprogramacion.SelectedRow.RowIndex).Cells(7).Text)
        LblCodVentaReprogramacion.Text = Trim(GvListaSoliAtenReprogramacion.Rows(GvListaSoliAtenReprogramacion.SelectedRow.RowIndex).Cells(12).Text)
        LblFechaReprogramacion2.Text = Trim(GvListaSoliAtenReprogramacion.Rows(GvListaSoliAtenReprogramacion.SelectedRow.RowIndex).Cells(17).Text)
        LblFecha2.Text = Trim(GvListaSoliAtenReprogramacion.Rows(GvListaSoliAtenReprogramacion.SelectedRow.RowIndex).Cells(15).Text)
        If LblFechaPrueba.Text = CDate(LblFecha2.Text) Then
            If LblFechaReprogramacion2.Text = d Then
            Else
                MessageBox.Show("Tenga en cuenta que esta solicitud de atención se originó de una reprogramación", "Sistema de Consultas e Historias Clinicas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
            End If
        Else
            MessageBox.Show("Disculpe pero esta solicitud de atención no coincide con la fecha de ingreso. Seleccione bien la solicitud de atención", "Sistema de Consultas e Historias Clinicas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
            LblNHC.Text = ""
            LblPaciente.Text = ""
            LblCodSoliAtenAnterior.Text = ""
            LblNumSoliAtenAnterior.Text = ""
            LblCodEspecialidadRepro.Text = ""
            LblCodVentaReprogramacion.Text = ""
            LblFechaPrueba.Text = ""
            LblFechaReprogramacion2.Text = ""
            LblFecha2.Text = ""
            TxtBuscar.Text = ""
            CFecha2.EnableViewState = False
        End If
    End Sub

    Protected Sub DdEspecialidad_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DdEspecialidad.SelectedIndexChanged
        LblCodTiComprobar.Text = cFun.ConsultaUnDato(sa.CalcularSolicitudAtencionPaciente(LblCodPaciente.Text, LblNHC.Text, LblFechaAtencion.Text, DdTurno.Text), 0)
        LblNTiComprobar.Text = cFun.ConsultaUnDato(sa.CalcularSolicitudAtencionPaciente(LblCodPaciente.Text, LblNHC.Text, LblFechaAtencion.Text, DdTurno.Text), 1)
        LblEsComprueba.Text = cFun.ConsultaUnDato(sa.CalcularSolicitudAtencionPaciente(LblCodPaciente.Text, LblNHC.Text, LblFechaAtencion.Text, DdTurno.Text), 2)
        LblMeComprueba.Text = cFun.ConsultaUnDato(sa.CalcularSolicitudAtencionPaciente(LblCodPaciente.Text, LblNHC.Text, LblFechaAtencion.Text, DdTurno.Text), 3)
        If LblCodTiComprobar.Text = "" Or LblNTiComprobar.Text = "" Or LblEsComprueba.Text = "" Or LblMeComprueba.Text = "" Then
            cFun.FillListaOrCombo(medi.ListaMedicos(DdTurno.Text, LblFechaAtencion.Text, LblCodEspecialidadRepro.Text), DdMedicos, "MEDICO", "CodMedico")
            DdMedicos.Items.Insert(0, "---Seleccione Médico---")
            Try
                If DdMedicos.SelectedValue.ToString = "" Then
                    MessageBox.Show("Disculpe pero no hay atención para la especialidad de " + DdEspecialidad.SelectedItem.Text + " en el turno " + DdTurno.SelectedItem.Text + ". Si desea puede elegir otro turno", "Sistema de Consultas e Historias Clinicas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                    limpiar()
                Else
                    DdMedicos.Visible = True
                End If
            Catch ex As Exception

            End Try
        Else
            MessageBox.Show("Lo sentimos pero no se le puede entregar la solicitud de atención al paciente " + LblPaciente.Text + " porque ya ha sacado la solicitud de atención N° " + LblNTiComprobar.Text + " en el mismo turno " + DdTurno.SelectedItem.Text + " en la especialidad de " + LblEsComprueba.Text + " con el médico " + LblMeComprueba.Text + ". Puede sacar otra solicitud de atención en otro turno", "Sistema de Consultas e Historias Clinicas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
            limpiar()
            Server.Transfer("~/ModuloAdmision/ModuloAdmision.aspx")
        End If
    End Sub

    Protected Sub CFecha_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CFecha.SelectionChanged
        LblFechaAtencion.Text = CFecha.SelectedDate
        If CDate(LblFechaAtencion.Text) < CDate(LblFecha.Text) Then
            MessageBox.Show("Error. Ingrese la Fecha correctamente", "Sistema de Consultas e Historias Clinicas", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
        Else
            DdEspecialidad.Enabled = True
            DdTurno.Enabled = True
            CFecha.Enabled = False
        End If
    End Sub

    Sub limpiar()
        LblCodSoliAten.Text = ""
        LblFechaAtencion.Text = ""
        LblCantidad.Text = ""
        CFecha.Enabled = True
        CFecha.EnableViewState = False
        cFun.FillListaOrCombo(esp.ListarEspecialidad(), DdEspecialidad, "NomEspecialidad", "CodEspecialidad")
        DdEspecialidad.Enabled = False
        DdTurno.Enabled = False
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
        DdEspecialidad.Items.Add(Trim(GvListaSoliAtenReprogramacion.Rows(GvListaSoliAtenReprogramacion.SelectedRow.RowIndex).Cells(6).Text))
        DdEspecialidad.Items.Insert(0, "--Seleccione--")

    End Sub

    Protected Sub CFecha2_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CFecha2.SelectionChanged
        LblFechaPrueba.Text = CFecha2.SelectedDate
    End Sub

    Protected Sub LinkButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkButton1.Click
        Server.Transfer("~/ModuloAdmision/ModuloAdmision.aspx?Valor1=" + LblUsu.Text)
    End Sub

    Protected Sub BtnImprimir_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles BtnImprimir.Click
        Dim a As String = ""
        Dim b As Double = "0.0"
        Dim c As Date = "01/01/1990"
        Dim d As String
        Dim f As String
        Dim hora As String
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

        If sa.GeneraNumSolicitudAtencion(LblFechaAtencion.Text, LblCodEspecialidadRepro.Text, LblCodTurno.Text, DdMedicos.Text) = "" Then
            LblNumSoliAten.Text = 1
        Else
            LblNumSoliAten.Text = CStr(CInt(sa.GeneraNumSolicitudAtencion(LblFechaAtencion.Text, LblCodEspecialidadRepro.Text, LblCodTurno.Text, DdMedicos.Text)) + 1)
        End If

        LblContar.Text = CStr(CInt(sa.ContarNumSolicitudAtencion(LblFechaAtencion.Text, LblCodEspecialidadRepro.Text, LblCodTurno.Text, DdMedicos.Text)) + 1)
        LblNumCon.Text = Val(LblCantidad.Text) - Val(LblContar.Text)

        If LblNumCon.Text < 0 Then
            MessageBox.Show("Lo sentimos, comunicar al paciente " + LblPaciente.Text + " que para la especialidad de " + DdEspecialidad.SelectedItem.Text + " en el turno " + DdTurno.SelectedItem.Text + " con el médico " + DdMedicos.SelectedItem.Text + " ya no hay tickets disponibles. Intente con otra fecha, médico o turno. Gracias por su comprensión", "Sistema de Consultas e Historias Clinicas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
            LblCodDetalleProgramacionMedica.Text = ""
            LblCodEspecialidadRepro.Text = ""
            LblFechaAtencion.Text = ""
            LblCantidad.Text = ""
            CFecha.Enabled = True
            CFecha.EnableViewState = False
            LblEspecialidad.Text = ""
            LblMedico.Text = ""
            LblNumCon.Text = ""
            LblTurno.Text = ""
            DdMedicos.SelectedItem.Text = ""
            Label4.Visible = False
            Label3.Visible = False
            LblEspecialidad.Visible = False
            Label21.Visible = False
            LblTurno.Visible = False
            Label22.Visible = False
            LblMedico.Visible = False
            Label23.Visible = False
            LblNumCon.Visible = False
            Label25.Visible = False
            cFun.FillListaOrCombo(esp.ListarEspecialidad(), DdEspecialidad, "NomEspecialidad", "CodEspecialidad")
            DdEspecialidad.Enabled = False
            BtnImprimir.Enabled = False
        Else
            LblCodVenta.Text = "V" & cFun.ConsultaUnDato(v.GeneraCodigoVenta(), 0)
            Button2.Enabled = False
            BtnImprimir.Enabled = True
        End If

        hora = LblHora.Text & " " & LblHoraampm.Text

        If LblCodSoliAtenAnterior.Text = "" Or LblNumSoliAtenAnterior.Text = "" Then
            Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('No es posible guardar el registro porque los datos están incompletos');</script>"))
        Else
            If sa.ModificarReprogramacion(LblCodSoliAtenAnterior.Text, LblNumSoliAtenAnterior.Text, LblFecha.Text) = True Then
            Else
                Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('No es posible guardar los datos');</script>"))
            End If
        End If

        If audi.GeneraCodigoAuditoria() = "" Then
            LblCodAuditoria.Text = 1
        Else
            LblCodAuditoria.Text = CStr(CInt(audi.GeneraCodigoAuditoria()) + 1)
        End If
        d = "FechaAtencion:" & "" & LblFechaAtencion.Text & ", Turno:" & DdTurno.SelectedItem.Text & ", CodTurno:" & LblCodTurno.Text & ", Medico:" & DdMedicos.SelectedItem.Text
        f = "CodSolicitudAtención:" & "" & Trim(GvListaSoliAtenReprogramacion.Rows(GvListaSoliAtenReprogramacion.SelectedRow.RowIndex).Cells(20).Text) & ", NumSolicitudAtencion:" & Trim(GvListaSoliAtenReprogramacion.Rows(GvListaSoliAtenReprogramacion.SelectedRow.RowIndex).Cells(5).Text) & ", CodDetalleProgramacionMedica:" & Trim(GvListaSoliAtenReprogramacion.Rows(GvListaSoliAtenReprogramacion.SelectedRow.RowIndex).Cells(16).Text) & ", NHC:" & Trim(GvListaSoliAtenReprogramacion.Rows(GvListaSoliAtenReprogramacion.SelectedRow.RowIndex).Cells(1).Text) & ", FechaAtencion:" & Trim(GvListaSoliAtenReprogramacion.Rows(GvListaSoliAtenReprogramacion.SelectedRow.RowIndex).Cells(11).Text) & ", Fecha:" & Trim(GvListaSoliAtenReprogramacion.Rows(GvListaSoliAtenReprogramacion.SelectedRow.RowIndex).Cells(15).Text) & ", HoraRegistro:" & Trim(GvListaSoliAtenReprogramacion.Rows(GvListaSoliAtenReprogramacion.SelectedRow.RowIndex).Cells(22).Text) & ", CodUsuario:" & Trim(GvListaSoliAtenReprogramacion.Rows(GvListaSoliAtenReprogramacion.SelectedRow.RowIndex).Cells(14).Text) & ", FechaReprogramacion:" & Trim(GvListaSoliAtenReprogramacion.Rows(GvListaSoliAtenReprogramacion.SelectedRow.RowIndex).Cells(17).Text) & ", CodVenta:" & Trim(GvListaSoliAtenReprogramacion.Rows(GvListaSoliAtenReprogramacion.SelectedRow.RowIndex).Cells(12).Text) & ", Reprogramado:" & Trim(GvListaSoliAtenReprogramacion.Rows(GvListaSoliAtenReprogramacion.SelectedRow.RowIndex).Cells(21).Text) & ", Anulado:" & Trim(GvListaSoliAtenReprogramacion.Rows(GvListaSoliAtenReprogramacion.SelectedRow.RowIndex).Cells(23).Text) & ", FechaAnulacion:" & Trim(GvListaSoliAtenReprogramacion.Rows(GvListaSoliAtenReprogramacion.SelectedRow.RowIndex).Cells(24).Text)
        If audi.AuditoriaReprogramacionSolicitud(LblCodAuditoria.Text, LblCodU.Text, "SolicitudAtencion", LblFecha.Text, hora, LblCodSoliAtenAnterior.Text, d, f, "", "") = True Then
        End If

        If v.ModificarVenta(Trim(GvListaSoliAtenReprogramacion.Rows(GvListaSoliAtenReprogramacion.SelectedRow.RowIndex).Cells(12).Text), Trim(GvListaSoliAtenReprogramacion.Rows(GvListaSoliAtenReprogramacion.SelectedRow.RowIndex).Cells(19).Text)) = True Then
            If Trim(GvListaSoliAtenReprogramacion.Rows(GvListaSoliAtenReprogramacion.SelectedRow.RowIndex).Cells(19).Text) = "V" Then
                If com.ModificarComprobante(Trim(GvListaSoliAtenReprogramacion.Rows(GvListaSoliAtenReprogramacion.SelectedRow.RowIndex).Cells(12).Text)) = True Then
                End If
                MessageBox.Show("Tenga en cuenta que se ha anulado una venta", "Sistema de Consultas e Historias Clinicas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
            Else
            End If
        End If

        If LblCodVenta.Text = "" Or LblCodPaciente.Text = "" Or LblCodTurno.Text = "" Then
            Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('No es posible guardar el registro porque los datos están incompletos');</script>"))
        Else
            If v.AgregarVenta(LblCodVenta.Text, "A00004", LblCodTurno.Text, LblCodU.Text, LblCodPaciente.Text, b, "P", LblFecha.Text, hora, "False", a, b) = True Then
            Else
            End If
        End If

        If LblCodigo.Text = "" Or LblCodSoliAten.Text = "" Or LblNumSoliAten.Text = "" Or LblCodDetalleProgramacionMedica.Text = "" Or LblNHC.Text = "" Or LblFechaAtencion.Text = "" Or LblFecha.Text = "" Or LblCodVenta.Text = "" Then
            Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('No es posible guardar el registro porque los datos están incompletos');</script>"))
        Else
            If sa.AgregarSolicitudAtencion(LblCodigo.Text, LblCodSoliAten.Text, LblNumSoliAten.Text, LblCodDetalleProgramacionMedica.Text, LblNHC.Text, LblFechaAtencion.Text, LblFecha.Text, hora, LblCodU.Text, c, LblCodVenta.Text, "False", "False", c, "") = True Then
                MessageBox.Show("Solicitud de Atención guardadada correctamente", "Sistema de Consultas e Historias Clinicas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                Server.Transfer("~/ModuloAdmision/ModuloAdmision.aspx")
            Else
                Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('No es posible guardar los datos');</script>"))
            End If
        End If
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
    Protected Sub DdMedicos_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DdMedicos.SelectedIndexChanged
        Try
            If LblCodTurno.Text = "" Or LblCodEspecialidadRepro.Text = "" Or DdMedicos.Text = "" Or LblFechaAtencion.Text = "" Then
                MessageBox.Show("No es posible realizar la verificación porque los datos están incompletos", "Sistema de Consultas e Historias Clinicas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
            Else
                LblCantidad.Text = cFun.ConsultaUnDato(detallePro.CantidadPacientes(LblFechaAtencion.Text, LblCodEspecialidadRepro.Text, LblCodTurno.Text, DdMedicos.Text), 0)
                LblCodDetalleProgramacionMedica.Text = cFun.ConsultaUnDato(detallePro.ListaCodDetalleProgramacionMedica(LblCodTurno.Text, LblFechaAtencion.Text, Val(LblCantidad.Text), LblCodEspecialidadRepro.Text, DdMedicos.Text), 0)
                Label4.Visible = True
                Label3.Visible = True
                LblEspecialidad.Visible = True
                Label21.Visible = True
                LblTurno.Visible = True
                Label22.Visible = True
                LblMedico.Visible = True
                Label23.Visible = True
                LblNumCon.Visible = True
                Label25.Visible = True
                LblEspecialidad.Text = DdEspecialidad.SelectedItem.ToString
                LblTurno.Text = DdTurno.SelectedItem.ToString
                LblMedico.Text = DdMedicos.SelectedItem.ToString
                Label7.Text = sa.ContarNumSolicitudAtencion(LblFechaAtencion.Text, LblCodEspecialidadRepro.Text, LblCodTurno.Text, DdMedicos.Text)
                If sa.GeneraNumSolicitudAtencion(LblFechaAtencion.Text, LblCodEspecialidadRepro.Text, LblCodTurno.Text, DdMedicos.Text) = "" Then
                    LblNumSoliAten.Text = 1
                Else
                    LblNumSoliAten.Text = CStr(CInt(sa.GeneraNumSolicitudAtencion(LblFechaAtencion.Text, LblCodEspecialidadRepro.Text, LblCodTurno.Text, DdMedicos.Text)) + 1)
                End If
                '******LblContar realiza un count de los numsolicitud atencion para poder obtener un valor y que este se pueda restar con la cantidad máxima de consultas
                LblContar.Text = sa.ContarNumSolicitudAtencion(LblFechaAtencion.Text, LblCodEspecialidadRepro.Text, LblCodTurno.Text, DdMedicos.Text)
                LblNumCon.Text = Val(LblCantidad.Text)
                estado(True)

                If LblNumCon.Text < 0 Then
                    MessageBox.Show("Lo sentimos, comunicar al paciente " + LblPaciente.Text + " que para la especialidad de " + DdEspecialidad.SelectedItem.Text + " en el turno " + DdTurno.SelectedItem.Text + " con el médico " + DdMedicos.SelectedItem.Text + " ya no hay tickets disponibles. Intente con otra fecha, médico o turno. Gracias por su comprensión", "Sistema de Consultas e Historias Clinicas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                    LblCodDetalleProgramacionMedica.Text = ""
                    LblCodEspecialidadRepro.Text = ""
                    LblFechaAtencion.Text = ""
                    LblCantidad.Text = ""
                    CFecha.Enabled = True
                    CFecha.EnableViewState = False
                    LblEspecialidad.Text = ""
                    LblMedico.Text = ""
                    LblNumCon.Text = ""
                    LblTurno.Text = ""
                    DdMedicos.SelectedItem.Text = ""
                    Label4.Visible = False
                    Label3.Visible = False
                    LblEspecialidad.Visible = False
                    Label21.Visible = False
                    LblTurno.Visible = False
                    Label22.Visible = False
                    LblMedico.Visible = False
                    Label23.Visible = False
                    LblNumCon.Visible = False
                    Label25.Visible = False
                    cFun.FillListaOrCombo(esp.ListarEspecialidad(), DdEspecialidad, "NomEspecialidad", "CodEspecialidad")
                    DdEspecialidad.Enabled = False
                    BtnImprimir.Enabled = False
                Else
                    LblCodVenta.Text = "V" & cFun.ConsultaUnDato(v.GeneraCodigoVenta(), 0)
                    Button2.Enabled = False
                    BtnImprimir.Enabled = True
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Protected Sub BtnBuscar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles BtnBuscar.Click
        cFun.FillDataGridView(sa.ListarCopiaReprogramacionSolicitudAtencion(TxtBuscar.Text, CFecha2.SelectedDate), GvListaSoliAtenReprogramacion)
    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles Button2.Click
        limpiar()
    End Sub
End Class
