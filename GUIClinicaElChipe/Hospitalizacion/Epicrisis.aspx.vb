Imports datos
Imports Reglas
Imports System.Windows.Forms

Partial Class Hospitalizacion_Epicrisis
    Inherits System.Web.UI.Page
    Dim epi As New Epicrisis
    Dim cfun As New cFuncionesDB
    Dim diag As New Diagnostico
    Dim hos As New Hospitalizacion
    Protected Sub btnbuscar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnbuscar.Click
        epi.llenarhospitalizaciones(Me.gvhospitalizaciones, Me.txtbuscar.Text)
    End Sub

    Protected Sub gvhospitalizaciones_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvhospitalizaciones.SelectedIndexChanged
        Me.lblhospitalizacion.Text = (gvhospitalizaciones.Rows(gvhospitalizaciones.SelectedRow.RowIndex).Cells(1).Text)
        If epi.perinatal(Me.lblhospitalizacion.Text) = True Then
            lblperinatal.Visible = True
            Clperinatal.Visible = True
            Me.Label8.Visible = True
        Else
            lblperinatal.Visible = False
            Clperinatal.Visible = False
            Me.Label8.Visible = False
        End If
        lblparto.Text = epi.parto(lblhospitalizacion.Text)
        If lblparto.Text = "" Then
            clnacimiento.Visible = False
            Clperinatal.Visible = False
            Me.Label8.Visible = False
        End If
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Page.IsPostBack = False Then
            activa(False)
            lblperinatal.Visible = False
            Clperinatal.Visible = False
            clnacimiento.Visible = False
            Me.Label8.Visible = False
        End If
    End Sub

    Protected Sub btnguardar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnguardar.Click
        lblepicrisis.Text = epi.generar

        If CInt(Me.txtestadia.Text) >= 0 Then

            If lblparto.Text = "" Then
                If chkmortalidad.Checked = True And chknecropsia.Checked = True Then
                    If epi.GuardarEpicrisis(lblepicrisis.Text, Me.lblhospitalizacion.Text, Now.Date, Now.Hour & ":" & Now.Minute, Me.TXTCOMPLICACIONES.Text, CDate(clegreso.SelectedDate), txthoraegreso.Text, txtestadia.Text & " " & Me.lbldias.Text, "True", "True", CDate("01/01/1990"), CDate("01/01/1990")) = True Then
                        hos.GuardarDiagnostico(Me.lblhospitalizacion.Text, Me.dddiagnostico.SelectedValue, Me.ddtdiagnostico.SelectedValue, "Egreso")
                        MessageBox.Show("Datos guardados correctamente", "Sistema de Consultas e Historias Clinicas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                    Else
                        Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('No es posible guardar los datos');</script>"))
                    End If
                ElseIf chkmortalidad.Checked = False And chknecropsia.Checked = False Then
                    If epi.GuardarEpicrisis(lblepicrisis.Text, Me.lblhospitalizacion.Text, Now.Date, Now.Hour & ":" & Now.Minute, Me.TXTCOMPLICACIONES.Text, CDate(clegreso.SelectedDate), txthoraegreso.Text, txtestadia.Text & " " & Me.lbldias.Text, "False", "False", CDate("01/01/1990"), CDate("01/01/1990")) = True Then
                        MessageBox.Show("Datos guardados correctamente", "Sistema de Consultas e Historias Clinicas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                    Else
                        Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('No es posible guardar los datos');</script>"))
                    End If
                ElseIf chkmortalidad.Checked = True And chknecropsia.Checked = False Then
                    If epi.GuardarEpicrisis(lblepicrisis.Text, Me.lblhospitalizacion.Text, Now.Date, Now.Hour & ":" & Now.Minute, Me.TXTCOMPLICACIONES.Text, CDate(clegreso.SelectedDate), txthoraegreso.Text, txtestadia.Text & " " & Me.lbldias.Text, "True", "False", CDate("01/01/1990"), CDate("01/01/1990")) = True Then
                        MessageBox.Show("Datos guardados correctamente", "Sistema de Consultas e Historias Clinicas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                    Else
                        Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('No es posible guardar los datos');</script>"))
                    End If
                ElseIf chkmortalidad.Checked = False And chknecropsia.Checked = True Then
                    Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('No es posible guardar los datos. No coincide mortalidad con Necropsia');</script>"))
                End If
            Else
                If chkmortalidad.Checked = True And chknecropsia.Checked = True Then
                    If epi.GuardarEpicrisis(lblepicrisis.Text, Me.lblhospitalizacion.Text, Now.Date, Now.Hour & ":" & Now.Minute, Me.TXTCOMPLICACIONES.Text, CDate(clegreso.SelectedDate), txthoraegreso.Text, txtestadia.Text & " " & Me.lbldias.Text, "True", "True", CDate(clnacimiento.SelectedDate), CDate(Me.Clperinatal.SelectedDate)) = True Then
                        MessageBox.Show("Datos guardados correctamente", "Sistema de Consultas e Historias Clinicas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                    Else
                        Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('No es posible guardar los datos');</script>"))
                    End If
                ElseIf chkmortalidad.Checked = False And chknecropsia.Checked = False Then
                    If epi.GuardarEpicrisis(lblepicrisis.Text, Me.lblhospitalizacion.Text, Now.Date, Now.Hour & ":" & Now.Minute, Me.TXTCOMPLICACIONES.Text, CDate(clegreso.SelectedDate), txthoraegreso.Text, txtestadia.Text & " " & Me.lbldias.Text, "False", "False", CDate(clnacimiento.SelectedDate), CDate("01/01/1990")) = True Then
                        MessageBox.Show("Datos guardados correctamente", "Sistema de Consultas e Historias Clinicas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                    Else
                        Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('No es posible guardar los datos');</script>"))
                    End If
                ElseIf chkmortalidad.Checked = True And chknecropsia.Checked = False Then
                    If epi.GuardarEpicrisis(lblepicrisis.Text, Me.lblhospitalizacion.Text, Now.Date, Now.Hour & ":" & Now.Minute, Me.TXTCOMPLICACIONES.Text, CDate(clegreso.SelectedDate), txthoraegreso.Text, txtestadia.Text & " " & Me.lbldias.Text, "True", "False", CDate(clnacimiento.SelectedDate), CDate(Me.Clperinatal.SelectedDate)) = True Then
                        MessageBox.Show("Datos guardados correctamente", "Sistema de Consultas e Historias Clinicas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                    Else
                        Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('No es posible guardar los datos');</script>"))
                    End If
                ElseIf chkmortalidad.Checked = False And chknecropsia.Checked = True Then
                    Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('No es posible guardar los datos. No coincide mortalidad con Necropsia');</script>"))
                End If
            End If
            cancelar()
            activa(False)
        Else
            Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('No es posible que la estadia sea menor a cer(0) dias');</script>"))
        End If
        
    End Sub

    Protected Sub btnnuevo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnnuevo.Click
        Me.lblepicrisis.Text = ""
        lblepicrisis.Text = epi.generar
        diag.listartipodiag(ddtdiagnostico)
        diag.listardiag(dddiagnostico)
        activa(True)
    End Sub
    Sub activa(ByVal valor As Boolean)
        Me.clnacimiento.Enabled = valor
        Me.chkmortalidad.Enabled = valor
        Me.Label8.Enabled = valor
        Me.chknecropsia.Enabled = valor
        Me.lblhospitalizacion.Enabled = valor
        Me.TXTCOMPLICACIONES.Enabled = valor
        Me.txtestadia.Enabled = valor
        Me.txthoraegreso.Enabled = valor
        Me.txtbuscar.Enabled = valor
        Me.btnbuscar.Enabled = valor
        dddiagnostico.Enabled = valor
        ddtdiagnostico.Enabled = valor
    End Sub
    Sub cancelar()
        Me.lblparto.Text = ""
        Me.lblhospitalizacion.Text = ""
        Me.TXTCOMPLICACIONES.Text = ""
        Me.txtestadia.Text = ""
        Me.txthoraegreso.Text = ""
        chkmortalidad.Checked = False
        chknecropsia.Checked = False
    End Sub

    Protected Sub btncancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        activa(False)
        cancelar()
    End Sub

    Protected Sub clegreso_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles clegreso.SelectionChanged
        Me.txtestadia.Text = CDate(Me.clegreso.SelectedDate).DayOfYear - CDate(gvhospitalizaciones.Rows(gvhospitalizaciones.SelectedRow.RowIndex).Cells(5).Text).DayOfYear
    End Sub
End Class
