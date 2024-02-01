Imports datos
Imports Reglas
Imports System.Data
Imports System.Windows.Forms
Partial Class ModuloProgramacionMedica_ProgramacionMedica
    Inherits System.Web.UI.Page
    Dim cFun As New cFuncionesDB
    Dim pm As New ProgramacionMedica
    Dim dpm As New DetalleProgramacionMedica
    Dim esp As New Especialidad
    Dim medesp As New MedicoEspecialidad
    Dim m As New Medico
    Dim t As New Turno
    Dim ta As New TipoAtencion
    Dim so As New SalaOperacion
    Dim c As New Cama
    Dim db As New BaseDatos
    Dim i As Integer
    Dim j As Integer
    Dim table As New DataTable("tabla")
    Dim TB As DataRow
    Dim fun As New cFuncionesDB
    Dim u As New Usuario
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LblUsu.Text = Request.QueryString("Valor1")
        If Page.IsPostBack = False Then
            Cancelar()
            Activar(False)
        End If
        table.Columns.Add(New DataColumn("columna1"))
        table.Columns.Add(New DataColumn("columna2"))
        table.Columns.Add(New DataColumn("columna3"))
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
    
    Public Function listar() As Boolean
        If Val(TxtCantidadConsultas.Text) > 0 Then
            If Me.gvprogramacion.Rows.Count - 1 >= 0 Then
                For i = 0 To Me.gvprogramacion.Rows.Count - 1
                    TB = table.NewRow()
                    TB("columna1") = Me.gvprogramacion.Rows(i).Cells(1).Text
                    TB("columna2") = Me.gvprogramacion.Rows(i).Cells(2).Text
                    TB("columna3") = gvprogramacion.Rows(i).Cells(3).Text
                    table.Rows.Add(TB)
                Next
            End If
            Return True

        ElseIf Val(TxtCantidadConsultas.Text) = 0 Then
            If Me.gvprogramacion.Rows.Count - 1 >= 0 Then
                For i = 0 To Me.gvprogramacion.Rows.Count - 1
                    TB = table.NewRow()
                    TB("columna1") = Me.gvprogramacion.Rows(i).Cells(1).Text
                    TB("columna2") = Me.gvprogramacion.Rows(i).Cells(2).Text
                    TB("columna3") = gvprogramacion.Rows(i).Cells(3).Text
                    table.Rows.Add(TB)
                Next
            End If
            Return True
        ElseIf Val(LblAtencionHospi.Text) = 1 And DdTipoAtencion.Text = "TA2" Or DdTipoAtencion.Text = "TA3" Then
            If Me.gvprogramacion.Rows.Count - 1 >= 0 Then
                For i = 0 To Me.gvprogramacion.Rows.Count - 1
                    TB = table.NewRow()
                    TB("columna1") = Me.gvprogramacion.Rows(i).Cells(1).Text
                    TB("columna2") = Me.gvprogramacion.Rows(i).Cells(2).Text
                    TB("columna3") = gvprogramacion.Rows(i).Cells(3).Text
                    table.Rows.Add(TB)
                Next
            End If
            Return True
        Else
            MessageBox.Show("Los datos están incorrectos", "Sistema de Consultas y Hospitalización", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
            Return False
        End If
    End Function
    Protected Sub gvprogramacion_RowEditing(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewEditEventArgs) Handles gvprogramacion.RowEditing
        gvprogramacion.EditIndex = e.NewEditIndex
    End Sub
    Protected Sub CFecha1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CFecha1.SelectionChanged
        LblFechapm.Text = CFecha1.SelectedDate
        If CDate(LblFechapm.Text) < CDate(LblFecha.Text) Then
            MessageBox.Show("Ingrese la Fecha correctamente", "Sistema de Consultas y Hospitalización", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
            LblFechapm.Text = ""
            CFecha1.EnableViewState = False
        Else
            LblCodMedicoEspecialidad.Text = medesp.CargarMedicoEspecialidad(DdMedico.Text, DdEspecialidad.Text)
            If DdTipoAtencion.Text = "TA3" Then
                Label1.Visible = False
                Label2.Visible = False
                Panel4.Visible = True
                Panel8.Visible = True
                Panel6.Visible = True
                Panel1.Visible = True
                Panel9.Visible = True
                TxtCantidadConsultas.Text = 1
                listar()
                For i = 1 To 1
                    TB = table.NewRow()
                    TB("columna1") = LblFechapm.Text
                    table.Rows.Add(TB)
                    table.DefaultView.Sort = "columna1"
                    gvprogramacion.DataSource = table
                    gvprogramacion.DataBind()
                Next
                DdMedico.Enabled = False
                DdEspecialidad.Enabled = False
                DdTurno.Enabled = False
                DdTipoAtencion.Enabled = False
                CFecha2.Enabled = False
                CFecha1.Enabled = False
                TxtCantidadConsultas.Text = ""
                BtnRegistrar.Enabled = True
                Me.gvprogramacion.Enabled = True
                If DdTurno.Text = "T02" Then
                    DdHoraOperacion.Items.Add("07:00")
                    DdHoraOperacion.Items.Add("07:30")
                    DdHoraOperacion.Items.Add("08:00")
                    DdHoraOperacion.Items.Add("08:30")
                    DdHoraOperacion.Items.Add("09:00")
                    DdHoraOperacion.Items.Add("09:30")
                    DdHoraOperacion.Items.Add("10:00")
                    DdHoraOperacion.Items.Add("10:30")
                    DdHoraOperacion.Items.Add("11:00")
                    DdHoraOperacion.Items.Add("11:30")
                    DdHoraOperacion.Items.Add("12:00")
                    DdHoraOperacion.Items.Add("12:30")
                    DdHoraOperacion.Items.Insert(0, "Selec.")
                    Ddhora.Items.Clear()
                    Ddhora.Items.Add("a.m")
                    Ddhora.Items.Insert(0, "Selec.")
                ElseIf DdTurno.Text = "T03" Then
                    DdHoraOperacion.Items.Add("13:00")
                    DdHoraOperacion.Items.Add("13:30")
                    DdHoraOperacion.Items.Add("14:00")
                    DdHoraOperacion.Items.Add("14:30")
                    DdHoraOperacion.Items.Add("15:00")
                    DdHoraOperacion.Items.Add("15:30")
                    DdHoraOperacion.Items.Add("16:00")
                    DdHoraOperacion.Items.Add("16:30")
                    DdHoraOperacion.Items.Add("17:00")
                    DdHoraOperacion.Items.Add("17:30")
                    DdHoraOperacion.Items.Add("18:00")
                    DdHoraOperacion.Items.Add("18:30")
                    DdHoraOperacion.Items.Insert(0, "Selec.")
                    Ddhora.Items.Clear()
                    Ddhora.Items.Add("p.m")
                    Ddhora.Items.Insert(0, "Selec.")
                ElseIf DdTurno.Text = "T04" Then
                    DdHoraOperacion.Items.Add("19:00")
                    DdHoraOperacion.Items.Add("19:30")
                    DdHoraOperacion.Items.Add("20:00")
                    DdHoraOperacion.Items.Add("20:30")
                    DdHoraOperacion.Items.Add("21:00")
                    DdHoraOperacion.Items.Add("21:00")
                    DdHoraOperacion.Items.Add("21:30")
                    DdHoraOperacion.Items.Add("22:00")
                    DdHoraOperacion.Items.Add("22:30")
                    DdHoraOperacion.Items.Insert(0, "Selec.")
                    Ddhora.Items.Clear()
                    Ddhora.Items.Add("p.m")
                    Ddhora.Items.Insert(0, "Selec.")
                End If
                DdSalaOperacion.Items.Clear()
                DdSalaOperacion.Items.Insert(0, "Seleccione")
                DdCamas.Items.Clear()
                DdCamas.Items.Insert(0, "--Seleccione--")
            End If
            If DdTipoAtencion.Text = "TA2" Then
                Label1.Visible = False
                Label2.Visible = False
                Panel4.Visible = True
                Panel8.Visible = True
                Panel6.Visible = True
                Panel1.Visible = True
                Panel9.Visible = True
                listar()
                For i = 1 To 1
                    TB = table.NewRow()
                    TB("columna1") = LblFechapm.Text
                    table.Rows.Add(TB)
                    table.DefaultView.Sort = "columna1"
                    gvprogramacion.DataSource = table
                    gvprogramacion.DataBind()
                Next
                DdMedico.Enabled = False
                DdEspecialidad.Enabled = False
                DdTurno.Enabled = False
                DdTipoAtencion.Enabled = False
                CFecha2.Enabled = False
                CFecha1.Enabled = False
                TxtCantidadConsultas.Text = ""
                BtnRegistrar.Enabled = True
                Me.gvprogramacion.Enabled = True
                cFun.FillDataGridView(c.CargaCama(LblFechapm.Text), GvNumCama)
                DdCamas.Items.Insert(0, "--Seleccione--")
                If GvNumCama.Rows.Count > 0 Then
                    For i = 0 To GvNumCama.Rows.Count - 1
                        cFun.FillDataGridView(c.MuestraCama(GvNumCama.Rows(i).Cells(0).Text), GvNumCama1)
                    Next
                    For i = 0 To GvNumCama1.Rows.Count - 1
                        DdCamas.Items.Add(GvNumSala1.Rows(i).Cells(0).Text)
                    Next
                Else
                    c.CargarCama2(DdCamas)
                    DdCamas.Items.Insert(0, "--Seleccione--")
                End If
            End If
            CFecha2.Enabled = True
        End If
    End Sub
    Public Function ConsultarDoble() As Boolean 'Para evitar registrar una programacion medica para consulta y hospitalizacion por tratamiento medico dos veces.
        Dim Contador As Integer
        Dim csql As String = "Select count(*) from DetalleProgramacionMedica dpm inner join dbo.ProgramacionMedica pm on dpm.CodProgramacionMedica=pm.CodProgramacionMedica where CodTurno='" + DdTurno.SelectedValue + "' and FechaAtencion='" + CDate(LblFechapm.Text) + "' and CodMedicoEspecialidad='" + LblCodMedicoEspecialidad.Text + "'"
        Contador = fun.ConsultaUnDato(csql, 0)
        If Contador = 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Sub Cancelar()
        table.Rows.Clear()
        gvprogramacion.DataSource = Nothing
        LblFechapm.Text = ""
        TxtCantidadConsultas.Text = ""
        CFecha1.Enabled = True
        BtnRegistrar.Enabled = False
        DdEspecialidad.Items.Clear()
        DdTurno.Items.Clear()
        DdMedico.Items.Clear()
        DdTipoAtencion.Items.Clear()
        gvprogramacion.DataSourceID = Nothing
        gvprogramacion.DataSource = Nothing
        gvprogramacion.DataBind()
        CFecha1.EnableViewState = False
        CFecha2.EnableViewState = False
        LblCodDetalleProgramacionMedica.Text = ""
        LblCodMedicoEspecialidad.Text = ""
        LblCodProgramacionMedica.Text = ""
        LblAtencion.Text = ""
        LblAtencionHospi.Visible = False
        Label4.Visible = False
        DdSalaOperacion.Visible = False
        Label27.Visible = False
        DdHoraOperacion.Visible = False
        Ddhora.Visible = False
        Label28.Visible = False
        TxtDuracionOperacion.Visible = False
        DdHoraOperacion.Items.Clear()
        TxtDuracionOperacion.Text = ""
        Panel1.Visible = False
        GvNumSala.DataSource = Nothing
        GvNumSala1.DataSource = Nothing
        CFecha2.Visible = False
        Label1.Visible = True
        Label2.Visible = True
        Panel4.Visible = False
        Panel8.Visible = False
        Panel6.Visible = False
        Panel2.Visible = False
        Panel9.Visible = False
    End Sub
    Sub Activar(ByVal valor As Boolean)
        gvprogramacion.DataSource = Nothing
        gvprogramacion.Enabled = valor
        LblFechapm.Enabled = valor
        TxtCantidadConsultas.Enabled = valor
        CFecha1.Enabled = valor
        DdEspecialidad.Enabled = valor
        DdTurno.Enabled = valor
        DdMedico.Enabled = valor
        DdTipoAtencion.Enabled = valor
    End Sub
    Protected Sub DdEspecialidad_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DdEspecialidad.SelectedIndexChanged
        DdTipoAtencion.Items.Clear()
        If DdEspecialidad.Text = "E6" Then
            ta.CargarTipoAtencionHIQ(DdTipoAtencion)
        Else
            If DdEspecialidad.Text = "E5" Then
                ta.CargarTipoAtencionHTM(DdTipoAtencion)
            Else
                ta.CargarTipoAtencionConsulta(DdTipoAtencion)
            End If
        End If
        DdTipoAtencion.Items.Insert(0, "---- Seleccione el Tipo de Atención ----")
        m.CargarMedicos(DdMedico, DdEspecialidad.Text)
        If DdMedico.SelectedValue.ToString = "" Then
            MessageBox.Show("Disculpe pero no hay médico para esta especialidad. Puede elegir otra especialidad", "Sistema de Consultas y Hospitalización", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
            DdTipoAtencion.Items.Clear()
            DdTipoAtencion.Items.Insert(0, "---- Seleccione el Tipo de Atención ----")
            DdEspecialidad.Items.Clear()
            esp.CargarEspecialidad(DdEspecialidad)
            DdEspecialidad.Items.Insert(0, "----- Seleccione una Especialidad -----")
        Else
            m.CargarMedicos(DdMedico, DdEspecialidad.Text)
        End If
    End Sub
    Protected Sub DdTipoAtencion_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DdTipoAtencion.SelectedIndexChanged
        If DdTipoAtencion.Text = "TA3" Then
            LblAtencionHospi.Visible = True
            TxtCantidadConsultas.Visible = False
            TxtCantidadConsultas.Text = ""
            Label4.Visible = True
            DdSalaOperacion.Visible = True
            Label27.Visible = True
            DdHoraOperacion.Visible = True
            Ddhora.Visible = True
            Label28.Visible = True
            TxtDuracionOperacion.Visible = True
            CFecha2.Visible = False
        ElseIf DdTipoAtencion.Text = "TA2" Then
            LblAtencionHospi.Visible = True
            TxtCantidadConsultas.Visible = False
            TxtCantidadConsultas.Text = ""
            Label4.Visible = False
            DdSalaOperacion.Visible = False
            Label27.Visible = False
            DdHoraOperacion.Visible = False
            Ddhora.Visible = False
            Label28.Visible = False
            TxtDuracionOperacion.Visible = False
            DdHoraOperacion.Text = ""
            TxtDuracionOperacion.Text = ""
            CFecha2.Visible = False
        ElseIf DdTipoAtencion.Text = "TA1" Then
            TxtCantidadConsultas.Visible = True
            TxtCantidadConsultas.Text = ""
            LblAtencionHospi.Visible = False
            Label4.Visible = False
            DdSalaOperacion.Visible = False
            Label27.Visible = False
            DdHoraOperacion.Visible = False
            Ddhora.Visible = False
            Label28.Visible = False
            TxtDuracionOperacion.Visible = False
            DdHoraOperacion.Text = ""
            TxtDuracionOperacion.Text = ""
            CFecha2.Visible = True
        End If

    End Sub

    Protected Sub BtnNue_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles BtnNue.Click
        Cancelar()
        Activar(True)
        esp.CargarEspecialidad(DdEspecialidad)
        DdEspecialidad.Items.Insert(0, "----- Seleccione una Especialidad -----")
        t.CargarTurnos(DdTurno)
        DdTurno.Items.Insert(0, "----- Seleccione un Turno ------------------")
        DdTipoAtencion.Items.Insert(0, "---- Seleccione el Tipo de Atención ----")
    End Sub

    Protected Sub BtnNuevo_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles BtnNuevo.Click
        Cancelar()
        Activar(True)
        esp.CargarEspecialidad(DdEspecialidad)
        DdEspecialidad.Items.Insert(0, "----- Seleccione una Especialidad -----")
        t.CargarTurnos(DdTurno)
        DdTurno.Items.Insert(0, "----- Seleccione un Turno ------------------")
        DdTipoAtencion.Items.Insert(0, "---- Seleccione el Tipo de Atención ----")
    End Sub

    Protected Sub BtnRegistrar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles BtnRegistrar.Click
        Dim a As String
        If Me.gvprogramacion.Rows.Count > 0 Then
            If pm.GeneraCodigoProgramacionMedica() = "" Then
                LblCodProgramacionMedica.Text = "PM"
            Else
                LblCodProgramacionMedica.Text = "PM" & CStr(pm.GeneraCodigoProgramacionMedica())
            End If
            pm.FechaProMedica = Now.Date
            If pm.AgregarProgramacionMedica(LblCodProgramacionMedica.Text, LblCodMedicoEspecialidad.Text, LblFecha.Text, LblCodU.Text) = True Then
                For i = 0 To gvprogramacion.Rows.Count - 1
                    If dpm.GeneraCodigoDetalleProgramacionMedica() = "" Then
                        LblCodDetalleProgramacionMedica.Text = 1
                    Else
                        LblCodDetalleProgramacionMedica.Text = CStr(dpm.GeneraCodigoDetalleProgramacionMedica())
                    End If
                    If DdTipoAtencion.Text = "TA2" Then
                        TxtCantidadConsultas.Text = 1
                        If DdCamas.SelectedItem.Text = "--Seleccione--" Then
                            MessageBox.Show("Disculpe pero los datos no están completos", "Sistema de Consultas y Hospitalización", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                        Else
                            dpm.AgregarDetalleProgramacion(LblCodDetalleProgramacionMedica.Text, LblCodProgramacionMedica.Text, DdTurno.Text, LblFechapm.Text, LblFecha.Text, Ch1, TxtCantidadConsultas, DdTipoAtencion.Text, "True", "", "", "", TxtCodCama.Text)
                            c.ModificarEstadoCama(DdCamas.SelectedItem.Text)
                            MessageBox.Show("Datos guardados correctamente", "Sistema de Consultas y Hospitalización", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                            Cancelar()
                            Activar(False)
                        End If
                    ElseIf DdTipoAtencion.Text = "TA3" Then
                        TxtCantidadConsultas.Text = 1
                        If DdSalaOperacion.SelectedItem.Text = "Seleccione" Or DdHoraOperacion.SelectedItem.Text = "Selec." Or Ddhora.SelectedItem.Text = "Selec." Or TxtDuracionOperacion.Text = "" Or DdCamas.SelectedItem.Text = "--Seleccione--" Then
                            MessageBox.Show("Disculpe pero los datos no están completos", "Sistema de Consultas y Hospitalización", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                        Else
                            a = DdHoraOperacion.SelectedItem.Text + " " + Ddhora.SelectedItem.Text
                            dpm.AgregarDetalleProgramacion(LblCodDetalleProgramacionMedica.Text, LblCodProgramacionMedica.Text, DdTurno.Text, LblFechapm.Text, LblFecha.Text, Ch1, TxtCantidadConsultas, DdTipoAtencion.Text, "True", TxtCodSala.Text, a, TxtDuracionOperacion.Text, TxtCodCama.Text)
                            c.ModificarEstadoCama(DdCamas.SelectedItem.Text)
                            MessageBox.Show("Datos guardados correctamente", "Sistema de Consultas y Hospitalización", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                            Cancelar()
                            Activar(False)
                        End If
                    Else
                        dpm.AgregarDetalleProgramacion(LblCodDetalleProgramacionMedica.Text, LblCodProgramacionMedica.Text, DdTurno.Text, gvprogramacion.Rows(i).Cells(0).Text, LblFecha.Text, gvprogramacion.Rows(i).Cells(2).FindControl("Ckeckbox1"), gvprogramacion.Rows(i).Cells(1).FindControl("Txt1"), DdTipoAtencion.Text, "True", "", "", "", "")
                    End If
                Next
                If DdTipoAtencion.Text = "TA1" Then
                    MessageBox.Show("Datos guardados correctamente", "Sistema de Consultas y Hospitalización", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                    Cancelar()
                    Activar(False)
                End If
            End If
        End If
    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Cancelar()
        CFecha2.Enabled = False
        Activar(False)
    End Sub

    Protected Sub BtnImprimir_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles BtnImprimir.Click
        Server.Transfer("REPORTE.aspx")
    End Sub

    Protected Sub Ddhora_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Ddhora.SelectedIndexChanged
        LblHoraope.Text = DdHoraOperacion.SelectedItem.Text + " " + Ddhora.SelectedItem.Text
        cFun.FillDataGridView(so.CargarSalaOperacion(LblFechapm.Text, LblHoraope.Text), GvNumSala)
        If GvNumSala.Rows.Count > 0 Then
            If GvNumSala.Rows.Count = 1 Then
                cFun.FillDataGridView(so.MostrarSala(GvNumSala.Rows(0).Cells(0).Text, "", "", "", ""), GvNumSala1)
            ElseIf GvNumSala.Rows.Count = 2 Then
                cFun.FillDataGridView(so.MostrarSala(GvNumSala.Rows(0).Cells(0).Text, GvNumSala.Rows(1).Cells(0).Text, "", "", ""), GvNumSala1)
            ElseIf GvNumSala.Rows.Count = 3 Then
                cFun.FillDataGridView(so.MostrarSala(GvNumSala.Rows(0).Cells(0).Text, GvNumSala.Rows(1).Cells(0).Text, GvNumSala.Rows(2).Cells(0).Text, "", ""), GvNumSala1)
            ElseIf GvNumSala.Rows.Count = 4 Then
                cFun.FillDataGridView(so.MostrarSala(GvNumSala.Rows(0).Cells(0).Text, GvNumSala.Rows(1).Cells(0).Text, GvNumSala.Rows(2).Cells(0).Text, GvNumSala.Rows(3).Cells(0).Text, ""), GvNumSala1)
            ElseIf GvNumSala.Rows.Count = 5 Then
                cFun.FillDataGridView(so.MostrarSala(GvNumSala.Rows(0).Cells(0).Text, GvNumSala.Rows(1).Cells(0).Text, GvNumSala.Rows(2).Cells(0).Text, GvNumSala.Rows(3).Cells(0).Text, GvNumSala.Rows(4).Cells(0).Text), GvNumSala1)
            End If

            For i = 0 To GvNumSala1.Rows.Count - 1
                DdSalaOperacion.Items.Add(GvNumSala1.Rows(i).Cells(0).Text)
            Next
        Else
            so.CargarSala(DdSalaOperacion)
            DdSalaOperacion.Items.Insert(0, "Seleccione")
        End If


        If GvNumCama.Rows.Count > 0 Then
            For i = 0 To GvNumCama.Rows.Count - 1
                cFun.FillDataGridView(c.MuestraCama(GvNumCama.Rows(i).Cells(0).Text), GvNumCama1)
            Next
            For i = 0 To GvNumCama1.Rows.Count - 1
                DdCamas.Items.Add(GvNumSala1.Rows(i).Cells(0).Text)
            Next
        Else
            c.CargarCama2(DdCamas)
            DdCamas.Items.Insert(0, "--Seleccione--")
        End If
    End Sub

    Protected Sub LinkButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkButton1.Click
        Server.Transfer("~/ModuloProgramacionMedica/ModuloProgramacionMedica.aspx?Valor1=" + LblUsu.Text)
    End Sub

    Protected Sub CFecha2_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CFecha2.SelectionChanged
        If CDate(CFecha2.SelectedDate) < CDate(LblFechapm.Text) Then
            MessageBox.Show("Ingrese la Fecha correctamente", "Sistema de Consultas y Hospitalización", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
        Else
            LblCodMedicoEspecialidad.Text = medesp.CargarMedicoEspecialidad(DdMedico.Text, DdEspecialidad.Text)
            If DdTipoAtencion.Text = "TA1" Then
                Label1.Visible = False
                Label2.Visible = False
                Panel4.Visible = True
                Panel2.Visible = True
                Panel6.Visible = True
                Panel1.Visible = False
                Panel9.Visible = True
                If ConsultarDoble() = True Then
                    If CFecha1.SelectedDate = Nothing Or CFecha1.SelectedDate = Nothing Then
                        MessageBox.Show("Debe elegir un rango de fechas", "Sistema de Consultas y Hospitalización", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                    Else
                        If CFecha1.SelectedDate < Now.Date Or CFecha2.SelectedDate < Now.Date Or (CFecha2.SelectedDate < CFecha1.SelectedDate) Then
                            MessageBox.Show("Rango de fechas incorrecto", "Sistema de Consultas y Hospitalización", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                        Else
                            DdMedico.Enabled = False
                            DdEspecialidad.Enabled = False
                            DdTurno.Enabled = False
                            DdTipoAtencion.Enabled = False
                            Dim var As Date
                            CFecha2.Enabled = False
                            CFecha1.Enabled = False
                            listar()
                            For i = 0 To Val(CFecha2.SelectedDate)
                                If CFecha1.SelectedDate <= CFecha2.SelectedDate Then
                                    TB = table.NewRow()
                                    TB("columna1") = LblFechapm.Text
                                    table.Rows.Add(TB)
                                    table.DefaultView.Sort = "columna1"
                                    gvprogramacion.DataSource = table
                                    gvprogramacion.DataBind()
                                    If CFecha1.SelectedDate = CDate(Me.LblFechapm.Text) Then
                                        var = CFecha1.SelectedDate.AddDays(1)
                                        CFecha1.SelectedDate = var
                                        Me.LblFechapm.Text = CFecha1.SelectedDate
                                    Else
                                        Me.LblFechapm.Text = CFecha1.SelectedDate
                                    End If
                                End If
                            Next
                            TxtCantidadConsultas.Text = ""
                            BtnRegistrar.Enabled = True
                            CFecha2.Enabled = False
                        End If
                    End If
                    Me.gvprogramacion.Enabled = True
                Else
                    MessageBox.Show("No es posible agregar estos datos debido a que ya se encuentran ingresados", "Sistema de Consultas e Historias Clínicas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                    Cancelar()
                End If

            End If
        End If
    End Sub

    Protected Sub DdSalaOperacion_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DdSalaOperacion.SelectedIndexChanged
        If GvNumSala.Rows.Count > 0 Then
            TxtCodSala.Text = cFun.ConsultaUnDato(so.Muestracodsala(DdSalaOperacion.Text), 0)
        Else
            TxtCodSala.Text = DdSalaOperacion.Text
        End If
    End Sub

    Protected Sub DdHoraOperacion_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DdHoraOperacion.SelectedIndexChanged
        If DdTurno.Text = "T02" Then
            Ddhora.Items.Clear()
            Ddhora.Items.Add("a.m")
            Ddhora.Items.Insert(0, "Selec.")
        ElseIf DdTurno.Text = "T03" Then
            Ddhora.Items.Clear()
            Ddhora.Items.Add("p.m")
            Ddhora.Items.Insert(0, "Selec.")
        ElseIf DdTurno.Text = "T04" Then
            Ddhora.Items.Clear()
            Ddhora.Items.Add("p.m")
            Ddhora.Items.Insert(0, "Selec.")
        End If
        DdSalaOperacion.Items.Clear()
        DdSalaOperacion.Items.Insert(0, "Seleccione")
        DdCamas.Items.Clear()
        DdCamas.Items.Insert(0, "--Seleccione--")
    End Sub

    Protected Sub DdCamas_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DdCamas.SelectedIndexChanged
        If GvNumCama.Rows.Count > 0 Then
            TxtCodCama.Text = cFun.ConsultaUnDato(c.Muestracodcama(DdCamas.Text), 0)
        Else
            TxtCodCama.Text = DdCamas.Text
        End If
    End Sub
End Class
