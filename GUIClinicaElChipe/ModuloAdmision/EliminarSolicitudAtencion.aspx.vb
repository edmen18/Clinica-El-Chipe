Imports System.Windows.Forms
Imports datos
Imports Reglas

Partial Class ModuloAdmision_EliminarSolicitudAtencion
    Inherits System.Web.UI.Page
    Dim cFun As New cFuncionesDB
    Dim sa As New SolicitudAtencion
    Dim dpm As New DetalleProgramacionMedica
    Dim t As New Turno
    Dim u As New Usuario
    Dim c As New Consulta
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

    Sub ColorButton(ByVal a As String, ByVal Color As Drawing.Color)
        If Me.GvNumSoliAten.Rows.Count - 1 >= 0 Then
            If a = 1 Then
                Button1.BackColor = Color
            Else
                If a = 2 Then
                    Button1.BackColor = Color
                    Button2.BackColor = Color
                Else
                    If a = 3 Then
                        Button1.BackColor = Color
                        Button2.BackColor = Color
                        Button3.BackColor = Color
                    Else
                        If a = 4 Then
                            Button1.BackColor = Color
                            Button2.BackColor = Color
                            Button3.BackColor = Color
                            Button4.BackColor = Color
                        Else
                            If a = 5 Then
                                Button1.BackColor = Color
                                Button2.BackColor = Color
                                Button3.BackColor = Color
                                Button4.BackColor = Color
                                Button5.BackColor = Color
                            Else
                                If a = 6 Then
                                    Button1.BackColor = Color
                                    Button2.BackColor = Color
                                    Button3.BackColor = Color
                                    Button4.BackColor = Color
                                    Button5.BackColor = Color
                                    Button6.BackColor = Color
                                Else
                                    If a = 7 Then
                                        Button1.BackColor = Color
                                        Button2.BackColor = Color
                                        Button3.BackColor = Color
                                        Button4.BackColor = Color
                                        Button5.BackColor = Color
                                        Button6.BackColor = Color
                                        Button7.BackColor = Color
                                    Else
                                        If a = 8 Then
                                            Button1.BackColor = Color
                                            Button2.BackColor = Color
                                            Button3.BackColor = Color
                                            Button4.BackColor = Color
                                            Button5.BackColor = Color
                                            Button6.BackColor = Color
                                            Button7.BackColor = Color
                                            Button8.BackColor = Color
                                        Else
                                            If a = 9 Then
                                                Button1.BackColor = Color
                                                Button2.BackColor = Color
                                                Button3.BackColor = Color
                                                Button4.BackColor = Color
                                                Button5.BackColor = Color
                                                Button6.BackColor = Color
                                                Button7.BackColor = Color
                                                Button8.BackColor = Color
                                                Button9.BackColor = Color
                                            Else
                                                If a = 10 Then
                                                    Button1.BackColor = Color
                                                    Button2.BackColor = Color
                                                    Button3.BackColor = Color
                                                    Button4.BackColor = Color
                                                    Button5.BackColor = Color
                                                    Button6.BackColor = Color
                                                    Button7.BackColor = Color
                                                    Button8.BackColor = Color
                                                    Button9.BackColor = Color
                                                    Button10.BackColor = Color
                                                Else
                                                    If a = 11 Then
                                                        Button1.BackColor = Color
                                                        Button2.BackColor = Color
                                                        Button3.BackColor = Color
                                                        Button4.BackColor = Color
                                                        Button5.BackColor = Color
                                                        Button6.BackColor = Color
                                                        Button7.BackColor = Color
                                                        Button8.BackColor = Color
                                                        Button9.BackColor = Color
                                                        Button10.BackColor = Color
                                                        Button11.BackColor = Color
                                                    Else
                                                        If a = 12 Then
                                                            Button1.BackColor = Color
                                                            Button2.BackColor = Color
                                                            Button3.BackColor = Color
                                                            Button4.BackColor = Color
                                                            Button5.BackColor = Color
                                                            Button6.BackColor = Color
                                                            Button7.BackColor = Color
                                                            Button8.BackColor = Color
                                                            Button9.BackColor = Color
                                                            Button10.BackColor = Color
                                                            Button11.BackColor = Color
                                                            Button12.BackColor = Color
                                                        Else
                                                            If a = 13 Then
                                                                Button1.BackColor = Color
                                                                Button2.BackColor = Color
                                                                Button3.BackColor = Color
                                                                Button4.BackColor = Color
                                                                Button5.BackColor = Color
                                                                Button6.BackColor = Color
                                                                Button7.BackColor = Color
                                                                Button8.BackColor = Color
                                                                Button9.BackColor = Color
                                                                Button10.BackColor = Color
                                                                Button11.BackColor = Color
                                                                Button12.BackColor = Color
                                                                Button13.BackColor = Color
                                                            Else
                                                                If a = 14 Then
                                                                    Button1.BackColor = Color
                                                                    Button2.BackColor = Color
                                                                    Button3.BackColor = Color
                                                                    Button4.BackColor = Color
                                                                    Button5.BackColor = Color
                                                                    Button6.BackColor = Color
                                                                    Button7.BackColor = Color
                                                                    Button8.BackColor = Color
                                                                    Button9.BackColor = Color
                                                                    Button10.BackColor = Color
                                                                    Button11.BackColor = Color
                                                                    Button12.BackColor = Color
                                                                    Button13.BackColor = Color
                                                                    Button14.BackColor = Color
                                                                Else
                                                                    If a = 15 Then
                                                                        Button1.BackColor = Color
                                                                        Button2.BackColor = Color
                                                                        Button3.BackColor = Color
                                                                        Button4.BackColor = Color
                                                                        Button5.BackColor = Color
                                                                        Button6.BackColor = Color
                                                                        Button7.BackColor = Color
                                                                        Button8.BackColor = Color
                                                                        Button9.BackColor = Color
                                                                        Button10.BackColor = Color
                                                                        Button11.BackColor = Color
                                                                        Button12.BackColor = Color
                                                                        Button13.BackColor = Color
                                                                        Button14.BackColor = Color
                                                                        Button15.BackColor = Color
                                                                    Else
                                                                        If a = 16 Then
                                                                            Button1.BackColor = Color
                                                                            Button2.BackColor = Color
                                                                            Button3.BackColor = Color
                                                                            Button4.BackColor = Color
                                                                            Button5.BackColor = Color
                                                                            Button6.BackColor = Color
                                                                            Button7.BackColor = Color
                                                                            Button8.BackColor = Color
                                                                            Button9.BackColor = Color
                                                                            Button10.BackColor = Color
                                                                            Button11.BackColor = Color
                                                                            Button12.BackColor = Color
                                                                            Button13.BackColor = Color
                                                                            Button14.BackColor = Color
                                                                            Button15.BackColor = Color
                                                                            Button16.BackColor = Color
                                                                        Else
                                                                            If a = 17 Then
                                                                                Button1.BackColor = Color
                                                                                Button2.BackColor = Color
                                                                                Button3.BackColor = Color
                                                                                Button4.BackColor = Color
                                                                                Button5.BackColor = Color
                                                                                Button6.BackColor = Color
                                                                                Button7.BackColor = Color
                                                                                Button8.BackColor = Color
                                                                                Button9.BackColor = Color
                                                                                Button10.BackColor = Color
                                                                                Button11.BackColor = Color
                                                                                Button12.BackColor = Color
                                                                                Button13.BackColor = Color
                                                                                Button14.BackColor = Color
                                                                                Button15.BackColor = Color
                                                                                Button16.BackColor = Color
                                                                                Button17.BackColor = Color
                                                                            Else
                                                                                If a = 18 Then
                                                                                    Button1.BackColor = Color
                                                                                    Button2.BackColor = Color
                                                                                    Button3.BackColor = Color
                                                                                    Button4.BackColor = Color
                                                                                    Button5.BackColor = Color
                                                                                    Button6.BackColor = Color
                                                                                    Button7.BackColor = Color
                                                                                    Button8.BackColor = Color
                                                                                    Button9.BackColor = Color
                                                                                    Button10.BackColor = Color
                                                                                    Button11.BackColor = Color
                                                                                    Button12.BackColor = Color
                                                                                    Button13.BackColor = Color
                                                                                    Button14.BackColor = Color
                                                                                    Button15.BackColor = Color
                                                                                    Button16.BackColor = Color
                                                                                    Button17.BackColor = Color
                                                                                    Button18.BackColor = Color
                                                                                Else
                                                                                    If a = 19 Then
                                                                                        Button1.BackColor = Color
                                                                                        Button2.BackColor = Color
                                                                                        Button3.BackColor = Color
                                                                                        Button4.BackColor = Color
                                                                                        Button5.BackColor = Color
                                                                                        Button6.BackColor = Color
                                                                                        Button7.BackColor = Color
                                                                                        Button8.BackColor = Color
                                                                                        Button9.BackColor = Color
                                                                                        Button10.BackColor = Color
                                                                                        Button11.BackColor = Color
                                                                                        Button12.BackColor = Color
                                                                                        Button13.BackColor = Color
                                                                                        Button14.BackColor = Color
                                                                                        Button15.BackColor = Color
                                                                                        Button16.BackColor = Color
                                                                                        Button17.BackColor = Color
                                                                                        Button18.BackColor = Color
                                                                                        Button19.BackColor = Color
                                                                                    Else
                                                                                        If a = 20 Then
                                                                                            Button1.BackColor = Color
                                                                                            Button2.BackColor = Color
                                                                                            Button3.BackColor = Color
                                                                                            Button4.BackColor = Color
                                                                                            Button5.BackColor = Color
                                                                                            Button6.BackColor = Color
                                                                                            Button7.BackColor = Color
                                                                                            Button8.BackColor = Color
                                                                                            Button9.BackColor = Color
                                                                                            Button10.BackColor = Color
                                                                                            Button11.BackColor = Color
                                                                                            Button12.BackColor = Color
                                                                                            Button13.BackColor = Color
                                                                                            Button14.BackColor = Color
                                                                                            Button15.BackColor = Color
                                                                                            Button16.BackColor = Color
                                                                                            Button17.BackColor = Color
                                                                                            Button18.BackColor = Color
                                                                                            Button19.BackColor = Color
                                                                                            Button20.BackColor = Color
                                                                                        Else
                                                                                            If a = 21 Then
                                                                                                Button1.BackColor = Color
                                                                                                Button2.BackColor = Color
                                                                                                Button3.BackColor = Color
                                                                                                Button4.BackColor = Color
                                                                                                Button5.BackColor = Color
                                                                                                Button6.BackColor = Color
                                                                                                Button7.BackColor = Color
                                                                                                Button8.BackColor = Color
                                                                                                Button9.BackColor = Color
                                                                                                Button10.BackColor = Color
                                                                                                Button11.BackColor = Color
                                                                                                Button12.BackColor = Color
                                                                                                Button13.BackColor = Color
                                                                                                Button14.BackColor = Color
                                                                                                Button15.BackColor = Color
                                                                                                Button16.BackColor = Color
                                                                                                Button17.BackColor = Color
                                                                                                Button18.BackColor = Color
                                                                                                Button19.BackColor = Color
                                                                                                Button20.BackColor = Color
                                                                                                Button21.BackColor = Color
                                                                                            Else
                                                                                                If a = 22 Then
                                                                                                    Button1.BackColor = Color
                                                                                                    Button2.BackColor = Color
                                                                                                    Button3.BackColor = Color
                                                                                                    Button4.BackColor = Color
                                                                                                    Button5.BackColor = Color
                                                                                                    Button6.BackColor = Color
                                                                                                    Button7.BackColor = Color
                                                                                                    Button8.BackColor = Color
                                                                                                    Button9.BackColor = Color
                                                                                                    Button10.BackColor = Color
                                                                                                    Button11.BackColor = Color
                                                                                                    Button12.BackColor = Color
                                                                                                    Button13.BackColor = Color
                                                                                                    Button14.BackColor = Color
                                                                                                    Button15.BackColor = Color
                                                                                                    Button16.BackColor = Color
                                                                                                    Button17.BackColor = Color
                                                                                                    Button18.BackColor = Color
                                                                                                    Button19.BackColor = Color
                                                                                                    Button20.BackColor = Color
                                                                                                    Button21.BackColor = Color
                                                                                                    Button22.BackColor = Color
                                                                                                Else
                                                                                                    If a = 23 Then
                                                                                                        Button1.BackColor = Color
                                                                                                        Button2.BackColor = Color
                                                                                                        Button3.BackColor = Color
                                                                                                        Button4.BackColor = Color
                                                                                                        Button5.BackColor = Color
                                                                                                        Button6.BackColor = Color
                                                                                                        Button7.BackColor = Color
                                                                                                        Button8.BackColor = Color
                                                                                                        Button9.BackColor = Color
                                                                                                        Button10.BackColor = Color
                                                                                                        Button11.BackColor = Color
                                                                                                        Button12.BackColor = Color
                                                                                                        Button13.BackColor = Color
                                                                                                        Button14.BackColor = Color
                                                                                                        Button15.BackColor = Color
                                                                                                        Button16.BackColor = Color
                                                                                                        Button17.BackColor = Color
                                                                                                        Button18.BackColor = Color
                                                                                                        Button19.BackColor = Color
                                                                                                        Button20.BackColor = Color
                                                                                                        Button21.BackColor = Color
                                                                                                        Button22.BackColor = Color
                                                                                                        Button23.BackColor = Color
                                                                                                    Else
                                                                                                        If a = 24 Then
                                                                                                            Button1.BackColor = Color
                                                                                                            Button2.BackColor = Color
                                                                                                            Button3.BackColor = Color
                                                                                                            Button4.BackColor = Color
                                                                                                            Button5.BackColor = Color
                                                                                                            Button6.BackColor = Color
                                                                                                            Button7.BackColor = Color
                                                                                                            Button8.BackColor = Color
                                                                                                            Button9.BackColor = Color
                                                                                                            Button10.BackColor = Color
                                                                                                            Button11.BackColor = Color
                                                                                                            Button12.BackColor = Color
                                                                                                            Button13.BackColor = Color
                                                                                                            Button14.BackColor = Color
                                                                                                            Button15.BackColor = Color
                                                                                                            Button16.BackColor = Color
                                                                                                            Button17.BackColor = Color
                                                                                                            Button18.BackColor = Color
                                                                                                            Button19.BackColor = Color
                                                                                                            Button20.BackColor = Color
                                                                                                            Button21.BackColor = Color
                                                                                                            Button22.BackColor = Color
                                                                                                            Button23.BackColor = Color
                                                                                                            Button24.BackColor = Color
                                                                                                        Else
                                                                                                            If a = 25 Then
                                                                                                                Button1.BackColor = Color
                                                                                                                Button2.BackColor = Color
                                                                                                                Button3.BackColor = Color
                                                                                                                Button4.BackColor = Color
                                                                                                                Button5.BackColor = Color
                                                                                                                Button6.BackColor = Color
                                                                                                                Button7.BackColor = Color
                                                                                                                Button8.BackColor = Color
                                                                                                                Button9.BackColor = Color
                                                                                                                Button10.BackColor = Color
                                                                                                                Button11.BackColor = Color
                                                                                                                Button12.BackColor = Color
                                                                                                                Button13.BackColor = Color
                                                                                                                Button14.BackColor = Color
                                                                                                                Button15.BackColor = Color
                                                                                                                Button16.BackColor = Color
                                                                                                                Button17.BackColor = Color
                                                                                                                Button18.BackColor = Color
                                                                                                                Button19.BackColor = Color
                                                                                                                Button20.BackColor = Color
                                                                                                                Button21.BackColor = Color
                                                                                                                Button22.BackColor = Color
                                                                                                                Button23.BackColor = Color
                                                                                                                Button24.BackColor = Color
                                                                                                                Button25.BackColor = Color
                                                                                                            Else
                                                                                                                If a = 26 Then
                                                                                                                    Button1.BackColor = Color
                                                                                                                    Button2.BackColor = Color
                                                                                                                    Button3.BackColor = Color
                                                                                                                    Button4.BackColor = Color
                                                                                                                    Button5.BackColor = Color
                                                                                                                    Button6.BackColor = Color
                                                                                                                    Button7.BackColor = Color
                                                                                                                    Button8.BackColor = Color
                                                                                                                    Button9.BackColor = Color
                                                                                                                    Button10.BackColor = Color
                                                                                                                    Button11.BackColor = Color
                                                                                                                    Button12.BackColor = Color
                                                                                                                    Button13.BackColor = Color
                                                                                                                    Button14.BackColor = Color
                                                                                                                    Button15.BackColor = Color
                                                                                                                    Button16.BackColor = Color
                                                                                                                    Button17.BackColor = Color
                                                                                                                    Button18.BackColor = Color
                                                                                                                    Button19.BackColor = Color
                                                                                                                    Button20.BackColor = Color
                                                                                                                    Button21.BackColor = Color
                                                                                                                    Button22.BackColor = Color
                                                                                                                    Button23.BackColor = Color
                                                                                                                    Button24.BackColor = Color
                                                                                                                    Button25.BackColor = Color
                                                                                                                    Button26.BackColor = Color
                                                                                                                Else
                                                                                                                    If a = 27 Then
                                                                                                                        Button1.BackColor = Color
                                                                                                                        Button2.BackColor = Color
                                                                                                                        Button3.BackColor = Color
                                                                                                                        Button4.BackColor = Color
                                                                                                                        Button5.BackColor = Color
                                                                                                                        Button6.BackColor = Color
                                                                                                                        Button7.BackColor = Color
                                                                                                                        Button8.BackColor = Color
                                                                                                                        Button9.BackColor = Color
                                                                                                                        Button10.BackColor = Color
                                                                                                                        Button11.BackColor = Color
                                                                                                                        Button12.BackColor = Color
                                                                                                                        Button13.BackColor = Color
                                                                                                                        Button14.BackColor = Color
                                                                                                                        Button15.BackColor = Color
                                                                                                                        Button16.BackColor = Color
                                                                                                                        Button17.BackColor = Color
                                                                                                                        Button18.BackColor = Color
                                                                                                                        Button19.BackColor = Color
                                                                                                                        Button20.BackColor = Color
                                                                                                                        Button21.BackColor = Color
                                                                                                                        Button22.BackColor = Color
                                                                                                                        Button23.BackColor = Color
                                                                                                                        Button24.BackColor = Color
                                                                                                                        Button25.BackColor = Color
                                                                                                                        Button26.BackColor = Color
                                                                                                                        Button27.BackColor = Color
                                                                                                                    End If
                                                                                                                End If
                                                                                                            End If
                                                                                                        End If
                                                                                                    End If
                                                                                                End If
                                                                                            End If
                                                                                        End If
                                                                                    End If
                                                                                End If
                                                                            End If
                                                                        End If
                                                                    End If
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub
    Protected Sub GvListaCopiaTickets_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GvListaCopiaSolicitudAtencion.SelectedIndexChanged
        Dim i As Integer
        cFun.FillDataGridView(sa.MuestraNumSolicitudAtencion(Trim(GvListaCopiaSolicitudAtencion.Rows(GvListaCopiaSolicitudAtencion.SelectedRow.RowIndex).Cells(18).Text), Trim(GvListaCopiaSolicitudAtencion.Rows(GvListaCopiaSolicitudAtencion.SelectedRow.RowIndex).Cells(10).Text), Trim(GvListaCopiaSolicitudAtencion.Rows(GvListaCopiaSolicitudAtencion.SelectedRow.RowIndex).Cells(8).Text), Trim(GvListaCopiaSolicitudAtencion.Rows(GvListaCopiaSolicitudAtencion.SelectedRow.RowIndex).Cells(4).Text)), GvNumSoliAten)
        LblNumCeldas.Text = GvNumSoliAten.Rows.Count
        'If GvListaCopiaSolicitudAtencion.Rows.Count - 1 >= 0 Then
        '    For i = 0 To GvListaCopiaSolicitudAtencion.Rows.Count - 1
        LblCodconsulta.Text = c.MuestraCodigoConsulta(Trim(GvListaCopiaSolicitudAtencion.Rows(GvListaCopiaSolicitudAtencion.SelectedRow.RowIndex).Cells(6).Text))
        '    Next
        'End If
        If Me.GvNumSoliAten.Rows.Count - 1 >= 0 Then
            If LblNumCeldas.Text = 1 Then
                Button1.Text = "Atencion N°" & GvNumSoliAten.Rows(0).Cells(0).Text
                Button1.BackColor = Drawing.Color.Red
            Else
                If LblNumCeldas.Text = 2 Then
                    Button1.Text = "Atencion N°" & GvNumSoliAten.Rows(0).Cells(0).Text
                    Button2.Text = "Atencion N°" & GvNumSoliAten.Rows(1).Cells(0).Text
                    Button2.BackColor = Drawing.Color.Red
                Else
                    If LblNumCeldas.Text = 3 Then
                        Button1.Text = "Atencion N°" & GvNumSoliAten.Rows(0).Cells(0).Text
                        Button2.Text = "Atencion N°" & GvNumSoliAten.Rows(1).Cells(0).Text
                        Button3.Text = "Atencion N°" & GvNumSoliAten.Rows(2).Cells(0).Text
                        Button3.BackColor = Drawing.Color.Red
                    Else
                        If LblNumCeldas.Text = 4 Then
                            Button1.Text = "Atencion N°" & GvNumSoliAten.Rows(0).Cells(0).Text
                            Button2.Text = "Atencion N°" & GvNumSoliAten.Rows(1).Cells(0).Text
                            Button3.Text = "Atencion N°" & GvNumSoliAten.Rows(2).Cells(0).Text
                            Button4.Text = "Atencion N°" & GvNumSoliAten.Rows(3).Cells(0).Text
                        Else
                            If LblNumCeldas.Text = 5 Then
                                Button1.Text = "Atencion N°" & GvNumSoliAten.Rows(0).Cells(0).Text
                                Button2.Text = "Atencion N°" & GvNumSoliAten.Rows(1).Cells(0).Text
                                Button3.Text = "Atencion N°" & GvNumSoliAten.Rows(2).Cells(0).Text
                                Button4.Text = "Atencion N°" & GvNumSoliAten.Rows(3).Cells(0).Text
                                Button5.Text = "Atencion N°" & GvNumSoliAten.Rows(4).Cells(0).Text
                            Else
                                If LblNumCeldas.Text = 6 Then
                                    Button1.Text = GvNumSoliAten.Rows(0).Cells(0).Text
                                    Button2.Text = GvNumSoliAten.Rows(1).Cells(0).Text
                                    Button3.Text = GvNumSoliAten.Rows(2).Cells(0).Text
                                    Button4.Text = GvNumSoliAten.Rows(3).Cells(0).Text
                                    Button5.Text = GvNumSoliAten.Rows(4).Cells(0).Text
                                    Button6.Text = GvNumSoliAten.Rows(5).Cells(0).Text
                                Else
                                    If LblNumCeldas.Text = 7 Then
                                        Button1.Text = GvNumSoliAten.Rows(0).Cells(0).Text
                                        Button2.Text = GvNumSoliAten.Rows(1).Cells(0).Text
                                        Button3.Text = GvNumSoliAten.Rows(2).Cells(0).Text
                                        Button4.Text = GvNumSoliAten.Rows(3).Cells(0).Text
                                        Button5.Text = GvNumSoliAten.Rows(4).Cells(0).Text
                                        Button6.Text = GvNumSoliAten.Rows(5).Cells(0).Text
                                        Button7.Text = GvNumSoliAten.Rows(6).Cells(0).Text
                                    Else
                                        If LblNumCeldas.Text = 8 Then
                                            Button1.Text = GvNumSoliAten.Rows(0).Cells(0).Text
                                            Button2.Text = GvNumSoliAten.Rows(1).Cells(0).Text
                                            Button3.Text = GvNumSoliAten.Rows(2).Cells(0).Text
                                            Button4.Text = GvNumSoliAten.Rows(3).Cells(0).Text
                                            Button5.Text = GvNumSoliAten.Rows(4).Cells(0).Text
                                            Button6.Text = GvNumSoliAten.Rows(5).Cells(0).Text
                                            Button7.Text = GvNumSoliAten.Rows(6).Cells(0).Text
                                            Button8.Text = GvNumSoliAten.Rows(7).Cells(0).Text
                                        Else
                                            If LblNumCeldas.Text = 9 Then
                                                Button1.Text = GvNumSoliAten.Rows(0).Cells(0).Text
                                                Button2.Text = GvNumSoliAten.Rows(1).Cells(0).Text
                                                Button3.Text = GvNumSoliAten.Rows(2).Cells(0).Text
                                                Button4.Text = GvNumSoliAten.Rows(3).Cells(0).Text
                                                Button5.Text = GvNumSoliAten.Rows(4).Cells(0).Text
                                                Button6.Text = GvNumSoliAten.Rows(5).Cells(0).Text
                                                Button7.Text = GvNumSoliAten.Rows(6).Cells(0).Text
                                                Button8.Text = GvNumSoliAten.Rows(7).Cells(0).Text
                                                Button9.Text = GvNumSoliAten.Rows(8).Cells(0).Text
                                            Else
                                                If LblNumCeldas.Text = 10 Then
                                                    Button1.Text = GvNumSoliAten.Rows(0).Cells(0).Text
                                                    Button2.Text = GvNumSoliAten.Rows(1).Cells(0).Text
                                                    Button3.Text = GvNumSoliAten.Rows(2).Cells(0).Text
                                                    Button4.Text = GvNumSoliAten.Rows(3).Cells(0).Text
                                                    Button5.Text = GvNumSoliAten.Rows(4).Cells(0).Text
                                                    Button6.Text = GvNumSoliAten.Rows(5).Cells(0).Text
                                                    Button7.Text = GvNumSoliAten.Rows(6).Cells(0).Text
                                                    Button8.Text = GvNumSoliAten.Rows(7).Cells(0).Text
                                                    Button9.Text = GvNumSoliAten.Rows(8).Cells(0).Text
                                                    Button10.Text = GvNumSoliAten.Rows(9).Cells(0).Text
                                                Else
                                                    If LblNumCeldas.Text = 11 Then
                                                        Button1.Text = GvNumSoliAten.Rows(0).Cells(0).Text
                                                        Button2.Text = GvNumSoliAten.Rows(1).Cells(0).Text
                                                        Button3.Text = GvNumSoliAten.Rows(2).Cells(0).Text
                                                        Button4.Text = GvNumSoliAten.Rows(3).Cells(0).Text
                                                        Button5.Text = GvNumSoliAten.Rows(4).Cells(0).Text
                                                        Button6.Text = GvNumSoliAten.Rows(5).Cells(0).Text
                                                        Button7.Text = GvNumSoliAten.Rows(6).Cells(0).Text
                                                        Button8.Text = GvNumSoliAten.Rows(7).Cells(0).Text
                                                        Button9.Text = GvNumSoliAten.Rows(8).Cells(0).Text
                                                        Button10.Text = GvNumSoliAten.Rows(9).Cells(0).Text
                                                        Button11.Text = GvNumSoliAten.Rows(10).Cells(0).Text
                                                    Else
                                                        If LblNumCeldas.Text = 12 Then
                                                            Button1.Text = GvNumSoliAten.Rows(0).Cells(0).Text
                                                            Button2.Text = GvNumSoliAten.Rows(1).Cells(0).Text
                                                            Button3.Text = GvNumSoliAten.Rows(2).Cells(0).Text
                                                            Button4.Text = GvNumSoliAten.Rows(3).Cells(0).Text
                                                            Button5.Text = GvNumSoliAten.Rows(4).Cells(0).Text
                                                            Button6.Text = GvNumSoliAten.Rows(5).Cells(0).Text
                                                            Button7.Text = GvNumSoliAten.Rows(6).Cells(0).Text
                                                            Button8.Text = GvNumSoliAten.Rows(7).Cells(0).Text
                                                            Button9.Text = GvNumSoliAten.Rows(8).Cells(0).Text
                                                            Button10.Text = GvNumSoliAten.Rows(9).Cells(0).Text
                                                            Button11.Text = GvNumSoliAten.Rows(10).Cells(0).Text
                                                            Button12.Text = GvNumSoliAten.Rows(11).Cells(0).Text
                                                        Else
                                                            If LblNumCeldas.Text = 13 Then
                                                                Button1.Text = GvNumSoliAten.Rows(0).Cells(0).Text
                                                                Button2.Text = GvNumSoliAten.Rows(1).Cells(0).Text
                                                                Button3.Text = GvNumSoliAten.Rows(2).Cells(0).Text
                                                                Button4.Text = GvNumSoliAten.Rows(3).Cells(0).Text
                                                                Button5.Text = GvNumSoliAten.Rows(4).Cells(0).Text
                                                                Button6.Text = GvNumSoliAten.Rows(5).Cells(0).Text
                                                                Button7.Text = GvNumSoliAten.Rows(6).Cells(0).Text
                                                                Button8.Text = GvNumSoliAten.Rows(7).Cells(0).Text
                                                                Button9.Text = GvNumSoliAten.Rows(8).Cells(0).Text
                                                                Button10.Text = GvNumSoliAten.Rows(9).Cells(0).Text
                                                                Button11.Text = GvNumSoliAten.Rows(10).Cells(0).Text
                                                                Button12.Text = GvNumSoliAten.Rows(11).Cells(0).Text
                                                                Button13.Text = GvNumSoliAten.Rows(12).Cells(0).Text
                                                            Else
                                                                If LblNumCeldas.Text = 14 Then
                                                                    Button1.Text = GvNumSoliAten.Rows(0).Cells(0).Text
                                                                    Button2.Text = GvNumSoliAten.Rows(1).Cells(0).Text
                                                                    Button3.Text = GvNumSoliAten.Rows(2).Cells(0).Text
                                                                    Button4.Text = GvNumSoliAten.Rows(3).Cells(0).Text
                                                                    Button5.Text = GvNumSoliAten.Rows(4).Cells(0).Text
                                                                    Button6.Text = GvNumSoliAten.Rows(5).Cells(0).Text
                                                                    Button7.Text = GvNumSoliAten.Rows(6).Cells(0).Text
                                                                    Button8.Text = GvNumSoliAten.Rows(7).Cells(0).Text
                                                                    Button9.Text = GvNumSoliAten.Rows(8).Cells(0).Text
                                                                    Button10.Text = GvNumSoliAten.Rows(9).Cells(0).Text
                                                                    Button11.Text = GvNumSoliAten.Rows(10).Cells(0).Text
                                                                    Button12.Text = GvNumSoliAten.Rows(11).Cells(0).Text
                                                                    Button13.Text = GvNumSoliAten.Rows(12).Cells(0).Text
                                                                    Button14.Text = GvNumSoliAten.Rows(13).Cells(0).Text
                                                                Else
                                                                    If LblNumCeldas.Text = 15 Then
                                                                        Button1.Text = GvNumSoliAten.Rows(0).Cells(0).Text
                                                                        Button2.Text = GvNumSoliAten.Rows(1).Cells(0).Text
                                                                        Button3.Text = GvNumSoliAten.Rows(2).Cells(0).Text
                                                                        Button4.Text = GvNumSoliAten.Rows(3).Cells(0).Text
                                                                        Button5.Text = GvNumSoliAten.Rows(4).Cells(0).Text
                                                                        Button6.Text = GvNumSoliAten.Rows(5).Cells(0).Text
                                                                        Button7.Text = GvNumSoliAten.Rows(6).Cells(0).Text
                                                                        Button8.Text = GvNumSoliAten.Rows(7).Cells(0).Text
                                                                        Button9.Text = GvNumSoliAten.Rows(8).Cells(0).Text
                                                                        Button10.Text = GvNumSoliAten.Rows(9).Cells(0).Text
                                                                        Button11.Text = GvNumSoliAten.Rows(10).Cells(0).Text
                                                                        Button12.Text = GvNumSoliAten.Rows(11).Cells(0).Text
                                                                        Button13.Text = GvNumSoliAten.Rows(12).Cells(0).Text
                                                                        Button14.Text = GvNumSoliAten.Rows(13).Cells(0).Text
                                                                        Button15.Text = GvNumSoliAten.Rows(14).Cells(0).Text
                                                                    Else
                                                                        If LblNumCeldas.Text = 16 Then
                                                                            Button1.Text = GvNumSoliAten.Rows(0).Cells(0).Text
                                                                            Button2.Text = GvNumSoliAten.Rows(1).Cells(0).Text
                                                                            Button3.Text = GvNumSoliAten.Rows(2).Cells(0).Text
                                                                            Button4.Text = GvNumSoliAten.Rows(3).Cells(0).Text
                                                                            Button5.Text = GvNumSoliAten.Rows(4).Cells(0).Text
                                                                            Button6.Text = GvNumSoliAten.Rows(5).Cells(0).Text
                                                                            Button7.Text = GvNumSoliAten.Rows(6).Cells(0).Text
                                                                            Button8.Text = GvNumSoliAten.Rows(7).Cells(0).Text
                                                                            Button9.Text = GvNumSoliAten.Rows(8).Cells(0).Text
                                                                            Button10.Text = GvNumSoliAten.Rows(9).Cells(0).Text
                                                                            Button11.Text = GvNumSoliAten.Rows(10).Cells(0).Text
                                                                            Button12.Text = GvNumSoliAten.Rows(11).Cells(0).Text
                                                                            Button13.Text = GvNumSoliAten.Rows(12).Cells(0).Text
                                                                            Button14.Text = GvNumSoliAten.Rows(13).Cells(0).Text
                                                                            Button15.Text = GvNumSoliAten.Rows(14).Cells(0).Text
                                                                            Button16.Text = GvNumSoliAten.Rows(15).Cells(0).Text
                                                                        Else
                                                                            If LblNumCeldas.Text = 17 Then
                                                                                Button1.Text = GvNumSoliAten.Rows(0).Cells(0).Text
                                                                                Button2.Text = GvNumSoliAten.Rows(1).Cells(0).Text
                                                                                Button3.Text = GvNumSoliAten.Rows(2).Cells(0).Text
                                                                                Button4.Text = GvNumSoliAten.Rows(3).Cells(0).Text
                                                                                Button5.Text = GvNumSoliAten.Rows(4).Cells(0).Text
                                                                                Button6.Text = GvNumSoliAten.Rows(5).Cells(0).Text
                                                                                Button7.Text = GvNumSoliAten.Rows(6).Cells(0).Text
                                                                                Button8.Text = GvNumSoliAten.Rows(7).Cells(0).Text
                                                                                Button9.Text = GvNumSoliAten.Rows(8).Cells(0).Text
                                                                                Button10.Text = GvNumSoliAten.Rows(9).Cells(0).Text
                                                                                Button11.Text = GvNumSoliAten.Rows(10).Cells(0).Text
                                                                                Button12.Text = GvNumSoliAten.Rows(11).Cells(0).Text
                                                                                Button13.Text = GvNumSoliAten.Rows(12).Cells(0).Text
                                                                                Button14.Text = GvNumSoliAten.Rows(13).Cells(0).Text
                                                                                Button15.Text = GvNumSoliAten.Rows(14).Cells(0).Text
                                                                                Button16.Text = GvNumSoliAten.Rows(15).Cells(0).Text
                                                                                Button17.Text = GvNumSoliAten.Rows(16).Cells(0).Text
                                                                            Else
                                                                                If LblNumCeldas.Text = 18 Then
                                                                                    Button1.Text = GvNumSoliAten.Rows(0).Cells(0).Text
                                                                                    Button2.Text = GvNumSoliAten.Rows(1).Cells(0).Text
                                                                                    Button3.Text = GvNumSoliAten.Rows(2).Cells(0).Text
                                                                                    Button4.Text = GvNumSoliAten.Rows(3).Cells(0).Text
                                                                                    Button5.Text = GvNumSoliAten.Rows(4).Cells(0).Text
                                                                                    Button6.Text = GvNumSoliAten.Rows(5).Cells(0).Text
                                                                                    Button7.Text = GvNumSoliAten.Rows(6).Cells(0).Text
                                                                                    Button8.Text = GvNumSoliAten.Rows(7).Cells(0).Text
                                                                                    Button9.Text = GvNumSoliAten.Rows(8).Cells(0).Text
                                                                                    Button10.Text = GvNumSoliAten.Rows(9).Cells(0).Text
                                                                                    Button11.Text = GvNumSoliAten.Rows(10).Cells(0).Text
                                                                                    Button12.Text = GvNumSoliAten.Rows(11).Cells(0).Text
                                                                                    Button13.Text = GvNumSoliAten.Rows(12).Cells(0).Text
                                                                                    Button14.Text = GvNumSoliAten.Rows(13).Cells(0).Text
                                                                                    Button15.Text = GvNumSoliAten.Rows(14).Cells(0).Text
                                                                                    Button16.Text = GvNumSoliAten.Rows(15).Cells(0).Text
                                                                                    Button17.Text = GvNumSoliAten.Rows(16).Cells(0).Text
                                                                                    Button18.Text = GvNumSoliAten.Rows(17).Cells(0).Text
                                                                                Else
                                                                                    If LblNumCeldas.Text = 19 Then
                                                                                        Button1.Text = GvNumSoliAten.Rows(0).Cells(0).Text
                                                                                        Button2.Text = GvNumSoliAten.Rows(1).Cells(0).Text
                                                                                        Button3.Text = GvNumSoliAten.Rows(2).Cells(0).Text
                                                                                        Button4.Text = GvNumSoliAten.Rows(3).Cells(0).Text
                                                                                        Button5.Text = GvNumSoliAten.Rows(4).Cells(0).Text
                                                                                        Button6.Text = GvNumSoliAten.Rows(5).Cells(0).Text
                                                                                        Button7.Text = GvNumSoliAten.Rows(6).Cells(0).Text
                                                                                        Button8.Text = GvNumSoliAten.Rows(7).Cells(0).Text
                                                                                        Button9.Text = GvNumSoliAten.Rows(8).Cells(0).Text
                                                                                        Button10.Text = GvNumSoliAten.Rows(9).Cells(0).Text
                                                                                        Button11.Text = GvNumSoliAten.Rows(10).Cells(0).Text
                                                                                        Button12.Text = GvNumSoliAten.Rows(11).Cells(0).Text
                                                                                        Button13.Text = GvNumSoliAten.Rows(12).Cells(0).Text
                                                                                        Button14.Text = GvNumSoliAten.Rows(13).Cells(0).Text
                                                                                        Button15.Text = GvNumSoliAten.Rows(14).Cells(0).Text
                                                                                        Button16.Text = GvNumSoliAten.Rows(15).Cells(0).Text
                                                                                        Button17.Text = GvNumSoliAten.Rows(16).Cells(0).Text
                                                                                        Button18.Text = GvNumSoliAten.Rows(17).Cells(0).Text
                                                                                        Button19.Text = GvNumSoliAten.Rows(18).Cells(0).Text
                                                                                    Else
                                                                                        If LblNumCeldas.Text = 20 Then
                                                                                            Button1.Text = GvNumSoliAten.Rows(0).Cells(0).Text
                                                                                            Button2.Text = GvNumSoliAten.Rows(1).Cells(0).Text
                                                                                            Button3.Text = GvNumSoliAten.Rows(2).Cells(0).Text
                                                                                            Button4.Text = GvNumSoliAten.Rows(3).Cells(0).Text
                                                                                            Button5.Text = GvNumSoliAten.Rows(4).Cells(0).Text
                                                                                            Button6.Text = GvNumSoliAten.Rows(5).Cells(0).Text
                                                                                            Button7.Text = GvNumSoliAten.Rows(6).Cells(0).Text
                                                                                            Button8.Text = GvNumSoliAten.Rows(7).Cells(0).Text
                                                                                            Button9.Text = GvNumSoliAten.Rows(8).Cells(0).Text
                                                                                            Button10.Text = GvNumSoliAten.Rows(9).Cells(0).Text
                                                                                            Button11.Text = GvNumSoliAten.Rows(10).Cells(0).Text
                                                                                            Button12.Text = GvNumSoliAten.Rows(11).Cells(0).Text
                                                                                            Button13.Text = GvNumSoliAten.Rows(12).Cells(0).Text
                                                                                            Button14.Text = GvNumSoliAten.Rows(13).Cells(0).Text
                                                                                            Button15.Text = GvNumSoliAten.Rows(14).Cells(0).Text
                                                                                            Button16.Text = GvNumSoliAten.Rows(15).Cells(0).Text
                                                                                            Button17.Text = GvNumSoliAten.Rows(16).Cells(0).Text
                                                                                            Button18.Text = GvNumSoliAten.Rows(17).Cells(0).Text
                                                                                            Button19.Text = GvNumSoliAten.Rows(18).Cells(0).Text
                                                                                            Button20.Text = GvNumSoliAten.Rows(19).Cells(0).Text
                                                                                        Else
                                                                                            If LblNumCeldas.Text = 21 Then
                                                                                                Button1.Text = GvNumSoliAten.Rows(0).Cells(0).Text
                                                                                                Button2.Text = GvNumSoliAten.Rows(1).Cells(0).Text
                                                                                                Button3.Text = GvNumSoliAten.Rows(2).Cells(0).Text
                                                                                                Button4.Text = GvNumSoliAten.Rows(3).Cells(0).Text
                                                                                                Button5.Text = GvNumSoliAten.Rows(4).Cells(0).Text
                                                                                                Button6.Text = GvNumSoliAten.Rows(5).Cells(0).Text
                                                                                                Button7.Text = GvNumSoliAten.Rows(6).Cells(0).Text
                                                                                                Button8.Text = GvNumSoliAten.Rows(7).Cells(0).Text
                                                                                                Button9.Text = GvNumSoliAten.Rows(8).Cells(0).Text
                                                                                                Button10.Text = GvNumSoliAten.Rows(9).Cells(0).Text
                                                                                                Button11.Text = GvNumSoliAten.Rows(10).Cells(0).Text
                                                                                                Button12.Text = GvNumSoliAten.Rows(11).Cells(0).Text
                                                                                                Button13.Text = GvNumSoliAten.Rows(12).Cells(0).Text
                                                                                                Button14.Text = GvNumSoliAten.Rows(13).Cells(0).Text
                                                                                                Button15.Text = GvNumSoliAten.Rows(14).Cells(0).Text
                                                                                                Button16.Text = GvNumSoliAten.Rows(15).Cells(0).Text
                                                                                                Button17.Text = GvNumSoliAten.Rows(16).Cells(0).Text
                                                                                                Button18.Text = GvNumSoliAten.Rows(17).Cells(0).Text
                                                                                                Button19.Text = GvNumSoliAten.Rows(18).Cells(0).Text
                                                                                                Button20.Text = GvNumSoliAten.Rows(19).Cells(0).Text
                                                                                                Button21.Text = GvNumSoliAten.Rows(20).Cells(0).Text
                                                                                            Else
                                                                                                If LblNumCeldas.Text = 22 Then
                                                                                                    Button1.Text = GvNumSoliAten.Rows(0).Cells(0).Text
                                                                                                    Button2.Text = GvNumSoliAten.Rows(1).Cells(0).Text
                                                                                                    Button3.Text = GvNumSoliAten.Rows(2).Cells(0).Text
                                                                                                    Button4.Text = GvNumSoliAten.Rows(3).Cells(0).Text
                                                                                                    Button5.Text = GvNumSoliAten.Rows(4).Cells(0).Text
                                                                                                    Button6.Text = GvNumSoliAten.Rows(5).Cells(0).Text
                                                                                                    Button7.Text = GvNumSoliAten.Rows(6).Cells(0).Text
                                                                                                    Button8.Text = GvNumSoliAten.Rows(7).Cells(0).Text
                                                                                                    Button9.Text = GvNumSoliAten.Rows(8).Cells(0).Text
                                                                                                    Button10.Text = GvNumSoliAten.Rows(9).Cells(0).Text
                                                                                                    Button11.Text = GvNumSoliAten.Rows(10).Cells(0).Text
                                                                                                    Button12.Text = GvNumSoliAten.Rows(11).Cells(0).Text
                                                                                                    Button13.Text = GvNumSoliAten.Rows(12).Cells(0).Text
                                                                                                    Button14.Text = GvNumSoliAten.Rows(13).Cells(0).Text
                                                                                                    Button15.Text = GvNumSoliAten.Rows(14).Cells(0).Text
                                                                                                    Button16.Text = GvNumSoliAten.Rows(15).Cells(0).Text
                                                                                                    Button17.Text = GvNumSoliAten.Rows(16).Cells(0).Text
                                                                                                    Button18.Text = GvNumSoliAten.Rows(17).Cells(0).Text
                                                                                                    Button19.Text = GvNumSoliAten.Rows(18).Cells(0).Text
                                                                                                    Button20.Text = GvNumSoliAten.Rows(19).Cells(0).Text
                                                                                                    Button21.Text = GvNumSoliAten.Rows(20).Cells(0).Text
                                                                                                    Button22.Text = GvNumSoliAten.Rows(21).Cells(0).Text
                                                                                                Else
                                                                                                    If LblNumCeldas.Text = 23 Then
                                                                                                        Button1.Text = GvNumSoliAten.Rows(0).Cells(0).Text
                                                                                                        Button2.Text = GvNumSoliAten.Rows(1).Cells(0).Text
                                                                                                        Button3.Text = GvNumSoliAten.Rows(2).Cells(0).Text
                                                                                                        Button4.Text = GvNumSoliAten.Rows(3).Cells(0).Text
                                                                                                        Button5.Text = GvNumSoliAten.Rows(4).Cells(0).Text
                                                                                                        Button6.Text = GvNumSoliAten.Rows(5).Cells(0).Text
                                                                                                        Button7.Text = GvNumSoliAten.Rows(6).Cells(0).Text
                                                                                                        Button8.Text = GvNumSoliAten.Rows(7).Cells(0).Text
                                                                                                        Button9.Text = GvNumSoliAten.Rows(8).Cells(0).Text
                                                                                                        Button10.Text = GvNumSoliAten.Rows(9).Cells(0).Text
                                                                                                        Button11.Text = GvNumSoliAten.Rows(10).Cells(0).Text
                                                                                                        Button12.Text = GvNumSoliAten.Rows(11).Cells(0).Text
                                                                                                        Button13.Text = GvNumSoliAten.Rows(12).Cells(0).Text
                                                                                                        Button14.Text = GvNumSoliAten.Rows(13).Cells(0).Text
                                                                                                        Button15.Text = GvNumSoliAten.Rows(14).Cells(0).Text
                                                                                                        Button16.Text = GvNumSoliAten.Rows(15).Cells(0).Text
                                                                                                        Button17.Text = GvNumSoliAten.Rows(16).Cells(0).Text
                                                                                                        Button18.Text = GvNumSoliAten.Rows(17).Cells(0).Text
                                                                                                        Button19.Text = GvNumSoliAten.Rows(18).Cells(0).Text
                                                                                                        Button20.Text = GvNumSoliAten.Rows(19).Cells(0).Text
                                                                                                        Button21.Text = GvNumSoliAten.Rows(20).Cells(0).Text
                                                                                                        Button22.Text = GvNumSoliAten.Rows(21).Cells(0).Text
                                                                                                        Button23.Text = GvNumSoliAten.Rows(22).Cells(0).Text
                                                                                                    Else
                                                                                                        If LblNumCeldas.Text = 24 Then
                                                                                                            Button1.Text = GvNumSoliAten.Rows(0).Cells(0).Text
                                                                                                            Button2.Text = GvNumSoliAten.Rows(1).Cells(0).Text
                                                                                                            Button3.Text = GvNumSoliAten.Rows(2).Cells(0).Text
                                                                                                            Button4.Text = GvNumSoliAten.Rows(3).Cells(0).Text
                                                                                                            Button5.Text = GvNumSoliAten.Rows(4).Cells(0).Text
                                                                                                            Button6.Text = GvNumSoliAten.Rows(5).Cells(0).Text
                                                                                                            Button7.Text = GvNumSoliAten.Rows(6).Cells(0).Text
                                                                                                            Button8.Text = GvNumSoliAten.Rows(7).Cells(0).Text
                                                                                                            Button9.Text = GvNumSoliAten.Rows(8).Cells(0).Text
                                                                                                            Button10.Text = GvNumSoliAten.Rows(9).Cells(0).Text
                                                                                                            Button11.Text = GvNumSoliAten.Rows(10).Cells(0).Text
                                                                                                            Button12.Text = GvNumSoliAten.Rows(11).Cells(0).Text
                                                                                                            Button13.Text = GvNumSoliAten.Rows(12).Cells(0).Text
                                                                                                            Button14.Text = GvNumSoliAten.Rows(13).Cells(0).Text
                                                                                                            Button15.Text = GvNumSoliAten.Rows(14).Cells(0).Text
                                                                                                            Button16.Text = GvNumSoliAten.Rows(15).Cells(0).Text
                                                                                                            Button17.Text = GvNumSoliAten.Rows(16).Cells(0).Text
                                                                                                            Button18.Text = GvNumSoliAten.Rows(17).Cells(0).Text
                                                                                                            Button19.Text = GvNumSoliAten.Rows(18).Cells(0).Text
                                                                                                            Button20.Text = GvNumSoliAten.Rows(19).Cells(0).Text
                                                                                                            Button21.Text = GvNumSoliAten.Rows(20).Cells(0).Text
                                                                                                            Button22.Text = GvNumSoliAten.Rows(21).Cells(0).Text
                                                                                                            Button23.Text = GvNumSoliAten.Rows(22).Cells(0).Text
                                                                                                            Button24.Text = GvNumSoliAten.Rows(23).Cells(0).Text
                                                                                                        Else
                                                                                                            If LblNumCeldas.Text = 25 Then
                                                                                                                Button1.Text = GvNumSoliAten.Rows(0).Cells(0).Text
                                                                                                                Button2.Text = GvNumSoliAten.Rows(1).Cells(0).Text
                                                                                                                Button3.Text = GvNumSoliAten.Rows(2).Cells(0).Text
                                                                                                                Button4.Text = GvNumSoliAten.Rows(3).Cells(0).Text
                                                                                                                Button5.Text = GvNumSoliAten.Rows(4).Cells(0).Text
                                                                                                                Button6.Text = GvNumSoliAten.Rows(5).Cells(0).Text
                                                                                                                Button7.Text = GvNumSoliAten.Rows(6).Cells(0).Text
                                                                                                                Button8.Text = GvNumSoliAten.Rows(7).Cells(0).Text
                                                                                                                Button9.Text = GvNumSoliAten.Rows(8).Cells(0).Text
                                                                                                                Button10.Text = GvNumSoliAten.Rows(9).Cells(0).Text
                                                                                                                Button11.Text = GvNumSoliAten.Rows(10).Cells(0).Text
                                                                                                                Button12.Text = GvNumSoliAten.Rows(11).Cells(0).Text
                                                                                                                Button13.Text = GvNumSoliAten.Rows(12).Cells(0).Text
                                                                                                                Button14.Text = GvNumSoliAten.Rows(13).Cells(0).Text
                                                                                                                Button15.Text = GvNumSoliAten.Rows(14).Cells(0).Text
                                                                                                                Button16.Text = GvNumSoliAten.Rows(15).Cells(0).Text
                                                                                                                Button17.Text = GvNumSoliAten.Rows(16).Cells(0).Text
                                                                                                                Button18.Text = GvNumSoliAten.Rows(17).Cells(0).Text
                                                                                                                Button19.Text = GvNumSoliAten.Rows(18).Cells(0).Text
                                                                                                                Button20.Text = GvNumSoliAten.Rows(19).Cells(0).Text
                                                                                                                Button21.Text = GvNumSoliAten.Rows(20).Cells(0).Text
                                                                                                                Button22.Text = GvNumSoliAten.Rows(21).Cells(0).Text
                                                                                                                Button23.Text = GvNumSoliAten.Rows(22).Cells(0).Text
                                                                                                                Button24.Text = GvNumSoliAten.Rows(23).Cells(0).Text
                                                                                                                Button25.Text = GvNumSoliAten.Rows(24).Cells(0).Text
                                                                                                            Else
                                                                                                                If LblNumCeldas.Text = 26 Then
                                                                                                                    Button1.Text = GvNumSoliAten.Rows(0).Cells(0).Text
                                                                                                                    Button2.Text = GvNumSoliAten.Rows(1).Cells(0).Text
                                                                                                                    Button3.Text = GvNumSoliAten.Rows(2).Cells(0).Text
                                                                                                                    Button4.Text = GvNumSoliAten.Rows(3).Cells(0).Text
                                                                                                                    Button5.Text = GvNumSoliAten.Rows(4).Cells(0).Text
                                                                                                                    Button6.Text = GvNumSoliAten.Rows(5).Cells(0).Text
                                                                                                                    Button7.Text = GvNumSoliAten.Rows(6).Cells(0).Text
                                                                                                                    Button8.Text = GvNumSoliAten.Rows(7).Cells(0).Text
                                                                                                                    Button9.Text = GvNumSoliAten.Rows(8).Cells(0).Text
                                                                                                                    Button10.Text = GvNumSoliAten.Rows(9).Cells(0).Text
                                                                                                                    Button11.Text = GvNumSoliAten.Rows(10).Cells(0).Text
                                                                                                                    Button12.Text = GvNumSoliAten.Rows(11).Cells(0).Text
                                                                                                                    Button13.Text = GvNumSoliAten.Rows(12).Cells(0).Text
                                                                                                                    Button14.Text = GvNumSoliAten.Rows(13).Cells(0).Text
                                                                                                                    Button15.Text = GvNumSoliAten.Rows(14).Cells(0).Text
                                                                                                                    Button16.Text = GvNumSoliAten.Rows(15).Cells(0).Text
                                                                                                                    Button17.Text = GvNumSoliAten.Rows(16).Cells(0).Text
                                                                                                                    Button18.Text = GvNumSoliAten.Rows(17).Cells(0).Text
                                                                                                                    Button19.Text = GvNumSoliAten.Rows(18).Cells(0).Text
                                                                                                                    Button20.Text = GvNumSoliAten.Rows(19).Cells(0).Text
                                                                                                                    Button21.Text = GvNumSoliAten.Rows(20).Cells(0).Text
                                                                                                                    Button22.Text = GvNumSoliAten.Rows(21).Cells(0).Text
                                                                                                                    Button23.Text = GvNumSoliAten.Rows(22).Cells(0).Text
                                                                                                                    Button24.Text = GvNumSoliAten.Rows(23).Cells(0).Text
                                                                                                                    Button25.Text = GvNumSoliAten.Rows(24).Cells(0).Text
                                                                                                                    Button26.Text = GvNumSoliAten.Rows(25).Cells(0).Text
                                                                                                                Else
                                                                                                                    If LblNumCeldas.Text = 27 Then
                                                                                                                        Button1.Text = GvNumSoliAten.Rows(0).Cells(0).Text
                                                                                                                        Button2.Text = GvNumSoliAten.Rows(1).Cells(0).Text
                                                                                                                        Button3.Text = GvNumSoliAten.Rows(2).Cells(0).Text
                                                                                                                        Button4.Text = GvNumSoliAten.Rows(3).Cells(0).Text
                                                                                                                        Button5.Text = GvNumSoliAten.Rows(4).Cells(0).Text
                                                                                                                        Button6.Text = GvNumSoliAten.Rows(5).Cells(0).Text
                                                                                                                        Button7.Text = GvNumSoliAten.Rows(6).Cells(0).Text
                                                                                                                        Button8.Text = GvNumSoliAten.Rows(7).Cells(0).Text
                                                                                                                        Button9.Text = GvNumSoliAten.Rows(8).Cells(0).Text
                                                                                                                        Button10.Text = GvNumSoliAten.Rows(9).Cells(0).Text
                                                                                                                        Button11.Text = GvNumSoliAten.Rows(10).Cells(0).Text
                                                                                                                        Button12.Text = GvNumSoliAten.Rows(11).Cells(0).Text
                                                                                                                        Button13.Text = GvNumSoliAten.Rows(12).Cells(0).Text
                                                                                                                        Button14.Text = GvNumSoliAten.Rows(13).Cells(0).Text
                                                                                                                        Button15.Text = GvNumSoliAten.Rows(14).Cells(0).Text
                                                                                                                        Button16.Text = GvNumSoliAten.Rows(15).Cells(0).Text
                                                                                                                        Button17.Text = GvNumSoliAten.Rows(16).Cells(0).Text
                                                                                                                        Button18.Text = GvNumSoliAten.Rows(17).Cells(0).Text
                                                                                                                        Button19.Text = GvNumSoliAten.Rows(18).Cells(0).Text
                                                                                                                        Button20.Text = GvNumSoliAten.Rows(19).Cells(0).Text
                                                                                                                        Button21.Text = GvNumSoliAten.Rows(20).Cells(0).Text
                                                                                                                        Button22.Text = GvNumSoliAten.Rows(21).Cells(0).Text
                                                                                                                        Button23.Text = GvNumSoliAten.Rows(22).Cells(0).Text
                                                                                                                        Button24.Text = GvNumSoliAten.Rows(23).Cells(0).Text
                                                                                                                        Button25.Text = GvNumSoliAten.Rows(24).Cells(0).Text
                                                                                                                        Button26.Text = GvNumSoliAten.Rows(25).Cells(0).Text
                                                                                                                        Button27.Text = GvNumSoliAten.Rows(26).Cells(0).Text
                                                                                                                    End If
                                                                                                                End If
                                                                                                            End If
                                                                                                        End If
                                                                                                    End If
                                                                                                End If
                                                                                            End If
                                                                                        End If
                                                                                    End If
                                                                                End If
                                                                            End If
                                                                        End If
                                                                    End If
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
            Dim a As String
            Dim sql As String
            a = Trim(GvListaCopiaSolicitudAtencion.Rows(GvListaCopiaSolicitudAtencion.SelectedRow.RowIndex).Cells(16).Text)
            sql = "Select CantidadPacientesAtender from DetalleProgramacionMedica where CodDetalleProgramacionMedica='" + a + "'"
            Lblcantidadconsultas.Text = cFun.ConsultaUnDato(sql, 0)
            ColorButton(Lblcantidadconsultas.Text, Drawing.Color.Yellow)
            ColorButton(LblNumCeldas.Text, Drawing.Color.Red)
        End If
    End Sub

    Sub Boton(ByVal a As Drawing.Color)
        Dim i As Integer
        If a = Drawing.Color.Red Then
            If GvListaCopiaSolicitudAtencion.Rows.Count - 1 >= 0 Then
                If LblCodconsulta.Text = "" Then
                    For i = 0 To GvListaCopiaSolicitudAtencion.Rows.Count - 1
                        If sa.ModificarAnulacion(Trim(GvListaCopiaSolicitudAtencion.Rows(GvListaCopiaSolicitudAtencion.SelectedRow.RowIndex).Cells(6).Text), Trim(GvListaCopiaSolicitudAtencion.Rows(GvListaCopiaSolicitudAtencion.SelectedRow.RowIndex).Cells(2).Text), LblFecha.Text, Trim(GvListaCopiaSolicitudAtencion.Rows(GvListaCopiaSolicitudAtencion.SelectedRow.RowIndex).Cells(12).Text), Trim(GvListaCopiaSolicitudAtencion.Rows(GvListaCopiaSolicitudAtencion.SelectedRow.RowIndex).Cells(16).Text)) = True Then
                            MessageBox.Show("La solicitud de atención se ha eliminado con éxito", "Sistema de Consultas e Historias Clinicas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                        Else
                        End If
                    Next
                Else
                    MessageBox.Show("No se puede eliminar esta solicitud de atención porque ya generó una atención", "Sistema de Consultas e Historias Clinicas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                    Server.Transfer("~/ModuloAdmision/ModuloAdmision.aspx?Valor1=" + LblUsu.Text)
                End If
            End If
        Else
            MessageBox.Show("Lo sentimos pero no puede eliminar esta solicitud de atención porque no ha sido entregada", "Sistema de Consultas e Historias Clinicas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
        End If
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Boton(Button1.BackColor)
    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        Boton(Button2.BackColor)
    End Sub

    Protected Sub Button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.Click
        Boton(Button3.BackColor)
    End Sub

    Protected Sub Button4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.Click
        Boton(Button4.BackColor)
    End Sub

    Protected Sub Button5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button5.Click
        Boton(Button5.BackColor)
    End Sub

    Protected Sub Button6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button6.Click
        Boton(Button6.BackColor)
    End Sub

    Protected Sub Button7_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button7.Click
        Boton(Button7.BackColor)
    End Sub

    Protected Sub Button8_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button8.Click
        Boton(Button8.BackColor)
    End Sub

    Protected Sub Button9_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button9.Click
        Boton(Button9.BackColor)
    End Sub

    Protected Sub Button10_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button10.Click
        Boton(Button10.BackColor)
    End Sub

    Protected Sub Button11_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button11.Click
        Boton(Button11.BackColor)
    End Sub

    Protected Sub Button12_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button12.Click
        Boton(Button12.BackColor)
    End Sub

    Protected Sub Button13_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button13.Click
        Boton(Button13.BackColor)
    End Sub

    Protected Sub Button14_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button14.Click
        Boton(Button14.BackColor)
    End Sub

    Protected Sub Button15_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button15.Click
        Boton(Button15.BackColor)
    End Sub

    Protected Sub Button16_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button16.Click
        Boton(Button16.BackColor)
    End Sub

    Protected Sub Button17_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button17.Click
        Boton(Button17.BackColor)
    End Sub

    Protected Sub Button18_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button18.Click
        Boton(Button18.BackColor)
    End Sub

    Protected Sub Button19_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button19.Click
        Boton(Button19.BackColor)
    End Sub

    Protected Sub Button20_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button20.Click
        Boton(Button20.BackColor)
    End Sub

    Protected Sub Button21_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button21.Click
        Boton(Button21.BackColor)
    End Sub

    Protected Sub Button22_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button22.Click
        Boton(Button22.BackColor)
    End Sub

    Protected Sub Button23_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button23.Click
        Boton(Button23.BackColor)
    End Sub

    Protected Sub Button24_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button24.Click
        Boton(Button24.BackColor)
    End Sub

    Protected Sub Button25_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button25.Click
        Boton(Button25.BackColor)
    End Sub

    Protected Sub Button26_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button26.Click
        Boton(Button26.BackColor)
    End Sub

    Protected Sub Button27_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button27.Click
        Boton(Button27.BackColor)
    End Sub

    Protected Sub BtnBuscar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles BtnBuscar.Click
        If TxtBuscar.Text = "" Or LblFechaPrueba.Text = "" Then
            MessageBox.Show("Disculpe pero no se puede realizar la búsqueda porque los datos están incompletos. Verifique que ha ingresado el apellido paterno del paciente y la fecha en la que saco el ticket", "Sistema de Consultas e Historias Clinicas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
        Else
            cFun.FillDataGridView(sa.ListarCopiaReprogramacionSolicitudAtencion(TxtBuscar.Text, CFecha.SelectedDate), GvListaCopiaSolicitudAtencion)
            GvListaCopiaSolicitudAtencion.Visible = True
        End If
    End Sub
End Class
