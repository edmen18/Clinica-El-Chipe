Imports Reglas
Imports Reportes
Imports System.Windows.Forms

Partial Class ModuloProgramacionMedica_Reportes_PMDiaria
    Inherits System.Web.UI.Page
    Dim pm As New ProgramacionMedica
    Dim cr As New CrPMDiario

    Protected Sub BtnMostrar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles BtnMostrar.Click
        If LblFecha2.Text = "" Then
            MessageBox.Show("Disculpe pero debe ingresar la fecha a buscar", "Sistema de Consultas e Historias Clinicas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
        Else
            cr.DataDefinition.FormulaFields.Item("Fecha2").Text = "'" + LblFecha2.Text + "'"
            'cr.DataDefinition.FormulaFields.Item("FechaAl").Text = "'" + LblFechaAl.Text + "'"
            cr.SetDataSource(pm.ReporteProgramacionMedica(LblFecha2.Text).Tables("ProgramacionMedicaDiaria"))
            Me.CrystalReportViewer1.ReportSource = cr
        End If
    End Sub

    Protected Sub Calendar1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Calendar1.SelectionChanged
        LblFecha2.Text = Calendar1.SelectedDate
    End Sub
End Class
