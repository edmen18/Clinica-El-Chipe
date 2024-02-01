Imports datos
Imports Reglas
Imports System.Windows.Forms
Partial Class ModuloProgramacionMedica_ModificarProgramacionMedica
    Inherits System.Web.UI.Page
    Dim cFun As New cFuncionesDB
    Dim esp As New Especialidad
    Dim t As New Turno
    Dim u As New Usuario
    Dim dpm As New DetalleProgramacionMedica
    Dim ta As New TipoAtencion
    Dim m As New Medico
    Dim medesp As New MedicoEspecialidad
    Dim sa As New SolicitudAtencion
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LblUsu.Text = Request.QueryString("Valor1")
        If Page.IsPostBack = False Then
            Cancelar()
            Activar(False)
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
        BtnModificar.Enabled = False
        BtnEliminar.Enabled = False
    End Sub
    Sub Cancelar()
        LblFechapm.Text = ""
        TxtCantidadConsultas.Text = ""
        ChkAtencion.Checked = False
        CFecha1.Enabled = True
        BtnModificar.Enabled = False
        DdEspecialidad.Items.Clear()
        DdTurno.Items.Clear()
        DdMedico.Items.Clear()
        DdTipoAtencion.Items.Clear()
        CFecha1.EnableViewState = False
        BtnEliminar.Enabled = False
        BtnModificar.Enabled = False
        BtnVer.Enabled = False
    End Sub
    Sub Activar(ByVal valor As Boolean)
        LblFechapm.Enabled = valor
        TxtCantidadConsultas.Enabled = valor
        ChkAtencion.Enabled = valor
        CFecha1.Enabled = valor
        DdEspecialidad.Enabled = valor
        DdTurno.Enabled = valor
        DdMedico.Enabled = valor
        DdTipoAtencion.Enabled = valor
    End Sub
    Sub datos()
        Dim csql As String = "Select dd.CodDetalleProgramacionMedica,dd.FechaAtencion,dd.CantidadPacientesAtender,dd.Atencion from " + _
        "DetalleProgramacionMedica dd inner join dbo.ProgramacionMedica pm " + _
        "on pm.CodProgramacionMedica=dd.CodProgramacionMedica " + _
        "where dd.Estado='True' and dd.CodTurno='" & DdTurno.Text & "' and dd.FechaAtencion='" & CFecha1.SelectedDate & "' " + _
        "and pm.CodMedicoEspecialidad='" & LblCodMedicoEspecialidad.Text & "'"
        LblCodDetalleProgramacionMedica.Text = cFun.ConsultaUnDato(csql, 0)
        LblFechapm.Text = Microsoft.VisualBasic.Left(cFun.ConsultaUnDato(csql, 1), 10)
        TxtCantidadConsultas.Text = cFun.ConsultaUnDato(csql, 2)
        LblNC.Text = cFun.ConsultaUnDato(csql, 2)
        If cFun.ConsultaUnDato(csql, 3) = "1" Then
            Me.ChkAtencion.Checked = True
        ElseIf cFun.ConsultaUnDato(csql, 3) = "0" Then
            Me.ChkAtencion.Checked = False
        End If
    End Sub
    Protected Sub DdEspecialidad_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DdEspecialidad.SelectedIndexChanged
        DdTipoAtencion.Items.Clear()
        ta.CargarTipoAtencionConsulta(DdTipoAtencion)
        DdTipoAtencion.Items.Insert(0, "---- Seleccione el Tipo de Atención ----")
        m.CargarMedicos(DdMedico, DdEspecialidad.Text)
        If DdMedico.SelectedValue.ToString = "" Then
            MessageBox.Show("No hay médico para esta especialidad. Puede elegir otra especialidad", "Sistema de Consultas y Hospitalización", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
        Else
            m.CargarMedicos(DdMedico, DdEspecialidad.Text)
        End If
    End Sub
    Protected Sub CFecha1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CFecha1.SelectionChanged
        LblFechapm.Text = CFecha1.SelectedDate
        BtnVer.Enabled = True
    End Sub
    Protected Sub BtnNuevo_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles BtnNuevo.Click
        Cancelar()
        Activar(True)
        esp.CargarEspecialidad2(DdEspecialidad)
        DdEspecialidad.Items.Insert(0, "----- Seleccione una Especialidad -----")
        t.CargarTurnos(DdTurno)
        DdTurno.Items.Insert(0, "----- Seleccione un Turno ------------------")
        ta.CargarTipoAtencionConsulta(DdTipoAtencion)
        DdTipoAtencion.Items.Insert(0, "---- Seleccione el Tipo de Atención ----")
    End Sub
    Protected Sub BtnModificar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles BtnModificar.Click
        If Me.LblFechapm.Text = "" Or Me.TxtCantidadConsultas.Text = "" Then
            MessageBox.Show("No se puede editar la programación médica, ya que no se han ingresado los datos a editar", "Sistema de Consultas y Hospitalización", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
        Else
            If Val(Me.TxtCantidadConsultas.Text) = 0 And Me.ChkAtencion.Checked = False Then
                If Me.ChkAtencion.Checked = True Then
                    LblAtencion.Text = 1
                Else
                    LblAtencion.Text = 0
                End If
                If LblSA.Text = "" Then
                    If Val(TxtCantidadConsultas.Text) >= Val(LblNC.Text) Then
                        MessageBox.Show("No se puede modificar esta programación médica porque el número de consultas ingresadas es inferior al número de consultas registradas anteriormente", "Sistema de Consultas y Hospitalización", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                        Cancelar()
                        Activar(False)
                    Else
                        dpm.ModificarDetalleProgramacion(LblAtencion.Text, TxtCantidadConsultas.Text, LblCodDetalleProgramacionMedica.Text)
                        MessageBox.Show("Datos modificados correctamente", "Sistema de Consultas y Hospitalización", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                        Cancelar()
                        Activar(False)
                    End If
                Else
                    MessageBox.Show("Disculpe, pero no se puede modificar esta programación médica porque ya generó una solicitud de atención", "Sistema de Consultas y Hospitalización", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                    Server.Transfer("~/ModuloProgramacionMedica/ModuloProgramacionMedica.aspx?Valor1=" + LblUsu.Text)
                End If
            ElseIf Val(Me.TxtCantidadConsultas.Text) > 0 And Me.ChkAtencion.Checked = True Then
                If Me.ChkAtencion.Checked = True Then
                    LblAtencion.Text = 1
                Else
                    LblAtencion.Text = 0
                End If
                If LblSA.Text = "" Then
                    If Val(TxtCantidadConsultas.Text) >= Val(LblNC.Text) Then
                        dpm.ModificarDetalleProgramacion(LblAtencion.Text, TxtCantidadConsultas.Text, LblCodDetalleProgramacionMedica.Text)
                        MessageBox.Show("Datos modificados correctamente", "Sistema de Consultas y Hospitalización", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                        Cancelar()
                        Activar(False)
                    Else
                        MessageBox.Show("No se puede modificar esta programación médica porque el número de consultas ingresadas es inferior al número de consultas registradas anteriormente", "Sistema de Consultas y Hospitalización", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                        Cancelar()
                        Activar(False)
                    End If
                Else
                    MessageBox.Show("No se puede modificar esta programación médica porque ya generó una solicitud de atención", "Sistema de Consultas y Hospitalización", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                    Server.Transfer("~/ModuloProgramacionMedica/ModuloProgramacionMedica.aspx?Valor1=" + LblUsu.Text)
                End If
            Else
                MessageBox.Show("Datos ingresados de forma incorrecta", "Sistema de Consultas y Hospitalización", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                BtnModificar.Enabled = True
            End If
        End If
    End Sub
    Protected Sub BtnCancelar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles BtnCancelar.Click
        Cancelar()
        Activar(False)
    End Sub
    Protected Sub BtnEliminar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles BtnEliminar.Click
        If LblFechapm.Text = "" Or TxtCantidadConsultas.Text = "" Then
            MessageBox.Show("No se puede eliminar la programación médica, ya que no se han ingresado los datos a eliminar", "Sistema de Consultas y Hospitalización", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
        Else
            If LblSA.Text = "" Then
                dpm.CodDetalleProgramacionMedica = LblCodDetalleProgramacionMedica.Text
                dpm.EliminarDetalleProgramacion()
                MessageBox.Show("Programación Médica eliminada correctamente", "Sistema de Consultas y Hospitalización", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                Cancelar()
                Activar(False)
            Else
                MessageBox.Show("No se puede eliminar esta programación médica porque ya generó una solicitud de atención", "Sistema de Consultas y Hospitalización", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                Server.Transfer("~/ModuloProgramacionMedica/ModuloProgramacionMedica.aspx?Valor1=" + LblUsu.Text)
            End If
        End If
    End Sub
    Protected Sub BtnVer_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles BtnVer.Click
        If LblFechapm.Text = "" Or DdEspecialidad.SelectedItem.Text = "----- Seleccione una Especialidad -----" Or DdTurno.SelectedItem.Text = "----- Seleccione un Turno ------------------" Or DdTipoAtencion.SelectedItem.Text = "---- Seleccione el Tipo de Atención ----" Then
            MessageBox.Show("Disculpe pero los datos están incompletos o no ha seleccionado la fecha", "Sistema de Consultas y Hospitalización", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
        Else
            If CFecha1.SelectedDate > Now.Date Then
                LblCodMedicoEspecialidad.Text = medesp.CargarMedicoEspecialidad(DdMedico.Text, DdEspecialidad.Text)
                datos()
                If LblFechapm.Text = "" Or TxtCantidadConsultas.Text = "" Or LblCodDetalleProgramacionMedica.Text = "" Then
                    MessageBox.Show("No se ha realizado la programación para el médico " + DdMedico.SelectedItem.Text + " en el turno " + DdTurno.SelectedItem.Text + "", "Sistema de Consultas y Hospitalización", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                Else
                    LblSA.Text = sa.MuestraCodigoSolicitudAtencion(LblCodDetalleProgramacionMedica.Text)
                    BtnModificar.Enabled = True
                    BtnEliminar.Enabled = True
                End If
            ElseIf CFecha1.SelectedDate = Now.Date Then
                If t.horaturno(DdTurno.SelectedValue) = True Then
                    LblCodMedicoEspecialidad.Text = medesp.CargarMedicoEspecialidad(DdMedico.Text, DdEspecialidad.Text)
                    datos()
                    If LblFechapm.Text = "" Or TxtCantidadConsultas.Text = "" Or LblCodDetalleProgramacionMedica.Text = "" Then
                        MessageBox.Show("No se ha realizado la programación para el médico " + DdMedico.SelectedItem.Text + " en el turno " + DdTurno.SelectedItem.Text + "", "Sistema de Consultas y Hospitalización", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                    Else
                        LblSA.Text = sa.MuestraCodigoSolicitudAtencion(LblCodDetalleProgramacionMedica.Text)
                        BtnModificar.Enabled = True
                        BtnEliminar.Enabled = True
                    End If
                Else
                    MessageBox.Show("El turno seleccionado ya prescribió", "Sistema de Consultas y Hospitalización", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                End If
            Else
                MessageBox.Show("No es posible modificar o eliminar una fecha pasada", "Sistema de Consultas y Hospitalización", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
            End If
        End If
    End Sub
    Protected Sub LinkButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkButton1.Click
        Server.Transfer("~/ModuloProgramacionMedica/ModuloProgramacionMedica.aspx?Valor1=" + LblUsu.Text)
    End Sub

    Protected Sub DdTipoAtencion_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DdTipoAtencion.SelectedIndexChanged
        TxtCantidadConsultas.Visible = True
        TxtCantidadConsultas.Text = ""
        BtnVer.Enabled = True
    End Sub
End Class
