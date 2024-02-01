Imports Reglas
Imports Reportes
Imports System.Windows.Forms

Partial Class ModuloProgramacionMedica_Reportes_ProgramacionMedica
    Inherits System.Web.UI.Page
    Dim pm As New ProgramacionMedica
    'Dim cr As New CrProgramacionMedica

    Protected Sub BtnMostrar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles BtnMostrar.Click
        If LblFechaDel.Text = "" Or LblFechaAl.Text = "" Then
            MessageBox.Show("Disculpe pero debe ingresar las fechas a buscar", "Sistema de Consultas e Historias Clinicas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
        Else
            'cr.DataDefinition.FormulaFields.Item("FechaDel").Text = "'" + LblFechaDel.Text + "'"
            'cr.DataDefinition.FormulaFields.Item("FechaAl").Text = "'" + LblFechaAl.Text + "'"
            'cr.SetDataSource(pm.ReporteProgramacionMedica(LblFechaDel.Text, LblFechaAl.Text).Tables("DtProgramacionMedica"))
            'Me.CrystalReportViewer1.ReportSource = cr
        End If
    End Sub

    Protected Sub Calendar1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Calendar1.SelectionChanged
        LblFechaDel.Text = Calendar1.SelectedDate
    End Sub

    Protected Sub Calendar2_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Calendar2.SelectionChanged
        LblFechaAl.Text = Calendar2.SelectedDate
    End Sub
End Class
