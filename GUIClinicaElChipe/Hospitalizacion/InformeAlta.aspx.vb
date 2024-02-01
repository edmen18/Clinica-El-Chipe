Imports Reglas
Imports System.Windows.Forms

Partial Class Hospitalizacion_InformeAlta
    Inherits System.Web.UI.Page
    Dim inf As New Cl_informeAlta
    Dim HOS As New Hospitalizacion
    Dim diag As New Diagnostico
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Page.IsPostBack = False Then
            activa(False)
        End If
    End Sub
    Sub activa(ByVal valor As Boolean)
        txtbuscar.Enabled = valor
        txtcondicion.Enabled = valor
        lblhospitalizacion.Enabled = valor
        lblinforme.Enabled = valor
        Me.btnbuscar.Enabled = valor
        Me.ddtdiagnostico.Enabled = valor
        Me.dddiagnostico.Enabled = valor
    End Sub

    Protected Sub btncancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        cancelar()
    End Sub
    Sub cancelar()
        txtbuscar.Text = ""
        txtcondicion.Text = ""
        lblhospitalizacion.Text = ""
    End Sub

    Protected Sub btnNuevo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        lblinforme.Text = ""
        Me.lblinforme.Text = inf.generar()
        diag.listardiag(Me.dddiagnostico)
        diag.listartipodiag(Me.ddtdiagnostico)
        activa(True)
    End Sub

    Protected Sub btngrabar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btngrabar.Click
        If Me.lblinforme.Text = "" Or Me.txtcondicion.Text = "" Or Me.lblhospitalizacion.Text = "" Then
            Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('Complete los datos antes de intentar grabarlos');</script>"))
        Else
            If inf.AgregarInforme(lblinforme.Text, Me.lblhospitalizacion.Text, txtcondicion.Text) = True Then
                HOS.GuardarDiagnostico(Me.lblhospitalizacion.Text, Me.dddiagnostico.SelectedValue, Me.ddtdiagnostico.SelectedValue, "Egreso")
                MessageBox.Show("Datos guardados correctamente", "Sistema de Consultas e Historias Clinicas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                Server.Transfer("~/Hospitalizacion/Reportes/Reporte.aspx?ind=" & 4 & "&reporte=" & Me.lblhospitalizacion.Text & "", True)
                cancelar()
                activa(False)
            Else
                Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('No es posible guardar los datos');</script>"))
            End If
        End If
    End Sub

    Protected Sub btnbuscar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnbuscar.Click
        inf.listarhos(gvhospitalizaciones, txtbuscar.Text)
    End Sub

    Protected Sub gvhospitalizaciones_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvhospitalizaciones.SelectedIndexChanged
        Me.lblhospitalizacion.Text = (gvhospitalizaciones.Rows(gvhospitalizaciones.SelectedRow.RowIndex).Cells(1).Text)
    End Sub
End Class
