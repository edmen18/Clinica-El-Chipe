Imports Reglas
Imports datos
Partial Class Hospitalizacion_CamaSalaOperacion
    Inherits System.Web.UI.Page
    Dim cam As New Cama
    Dim sala As New SalaOperacion

    Protected Sub btnconsultar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnconsultar.Click
        If Me.rblista.SelectedIndex = 0 Then
            cam.consultarcama(Me.dtdel.SelectedDate, dtal.SelectedDate, Me.gvlista)
        ElseIf Me.rblista.SelectedIndex = 1 Then
            sala.consultasala(Me.dtdel.SelectedDate, dtal.SelectedDate, Me.gvlista)
        End If
    End Sub
End Class
