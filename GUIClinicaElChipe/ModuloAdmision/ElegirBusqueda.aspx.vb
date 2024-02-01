
Partial Class ModuloAdmision_ElegirBusqueda
    Inherits System.Web.UI.Page

    Protected Sub btnbuscar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnbuscar.Click
        If Me.RadioButtonList1.SelectedIndex = 0 Then
            Server.Transfer("~/ModuloAdmision/BusquedaParaSolicitudAtencion.aspx")
        End If
        If Me.RadioButtonList1.SelectedIndex = 1 Then
            Dim path As String
            path = "D:\VerificarHuella\VerifHuella\VerifHuella\bin\Debug\VerifHuella.exe"
            System.Diagnostics.Process.Start(path, "")
        End If
    End Sub
End Class
