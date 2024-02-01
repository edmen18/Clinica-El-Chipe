Imports Reportes
Imports Reglas
Imports CrystalDecisions.Shared

Partial Class ModuloCaja_Reportes_Reportes
    Inherits System.Web.UI.Page
    Dim V As New Venta
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Label1.Text = Request.QueryString("ind")
        If Page.IsPostBack = False Then
            If Me.Label1.Text = "1" Then
                Dim cr As New Cr_detalle
                cr.SetDataSource(V.Imprimedetalle(Request.QueryString("dato")))
                Me.CrystalReportViewer1.ReportSource = cr
            ElseIf Me.Label1.Text = "2" Then
                Dim cr As New Cr_ventas
                cr.SetDataSource(V.reportes(Request.QueryString("dato"), CDate(Request.QueryString("fdel")), CDate(Request.QueryString("fal")), 1))
                Me.CrystalReportViewer1.ReportSource = cr
            ElseIf Me.Label1.Text = "3" Then
                Dim cr As New Cr_VentasXComprobante
                cr.SetDataSource(V.reportes(Request.QueryString("dato"), CDate(Request.QueryString("fdel")), CDate(Request.QueryString("fal")), 2))
                Me.CrystalReportViewer1.ReportSource = cr
            ElseIf Me.Label1.Text = "4" Then
                Dim cr As New Cr_VentasxFecha
                cr.DataDefinition.FormulaFields.Item("fdel").Text = "'" + Request.QueryString("fdel") + "'"
                cr.DataDefinition.FormulaFields.Item("fal").Text = "'" + Request.QueryString("fal") + "'"
                cr.SetDataSource(V.reportes(Request.QueryString("dato"), CDate(Request.QueryString("fdel")), CDate(Request.QueryString("fal")), 3))
                Me.CrystalReportViewer1.ReportSource = cr
            End If
        End If
    End Sub

    Protected Sub imprimi_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles imprimi.Click
        If Me.Label1.Text = "1" Then
            Dim cr As New Cr_detalle
            cr.SetDataSource(V.Imprimedetalle(Request.QueryString("dato")))
            Me.CrystalReportViewer1.ReportSource = cr
            cr.PrintToPrinter(1, False, 0, 0)
        ElseIf Me.Label1.Text = "2" Then
            Dim cr As New Cr_ventas
            cr.SetDataSource(V.reportes(Request.QueryString("dato"), CDate(Request.QueryString("fdel")), CDate(Request.QueryString("fal")), 1))
            Me.CrystalReportViewer1.ReportSource = cr
            cr.PrintToPrinter(1, False, 0, 0)
        ElseIf Me.Label1.Text = "3" Then
            Dim cr As New Cr_VentasXComprobante
            cr.SetDataSource(V.reportes(Request.QueryString("dato"), CDate(Request.QueryString("fdel")), CDate(Request.QueryString("fal")), 2))
            Me.CrystalReportViewer1.ReportSource = cr
            cr.PrintToPrinter(1, False, 0, 0)
        ElseIf Me.Label1.Text = "4" Then
            Dim cr As New Cr_VentasxFecha
            cr.DataDefinition.FormulaFields.Item("fdel").Text = "'" + Request.QueryString("fdel") + "'"
            cr.DataDefinition.FormulaFields.Item("fal").Text = "'" + Request.QueryString("fal") + "'"
            cr.SetDataSource(V.reportes(Request.QueryString("dato"), CDate(Request.QueryString("fdel")), CDate(Request.QueryString("fal")), 3))
            Me.CrystalReportViewer1.ReportSource = cr
            cr.PrintToPrinter(1, False, 0, 0)
        End If
    End Sub


    Protected Sub btnpdf_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnpdf.Click
        If Me.Label1.Text = "1" Then
            Dim cr As New Cr_detalle
            cr.SetDataSource(V.Imprimedetalle(Request.QueryString("dato")))
            Me.CrystalReportViewer1.ReportSource = cr
            cr.ExportToHttpResponse(ExportFormatType.PortableDocFormat, Response, True, "NombreArchivo")
        ElseIf Me.Label1.Text = "2" Then
            Dim cr As New Cr_ventas
            cr.SetDataSource(V.reportes(Request.QueryString("dato"), CDate(Request.QueryString("fdel")), CDate(Request.QueryString("fal")), 1))
            Me.CrystalReportViewer1.ReportSource = cr
            cr.ExportToHttpResponse(ExportFormatType.PortableDocFormat, Response, True, "NombreArchivo")
        ElseIf Me.Label1.Text = "3" Then
            Dim cr As New Cr_VentasXComprobante
            cr.SetDataSource(V.reportes(Request.QueryString("dato"), CDate(Request.QueryString("fdel")), CDate(Request.QueryString("fal")), 2))
            Me.CrystalReportViewer1.ReportSource = cr
            cr.ExportToHttpResponse(ExportFormatType.PortableDocFormat, Response, True, "NombreArchivo")
        ElseIf Me.Label1.Text = "4" Then
            Dim cr As New Cr_VentasxFecha
            cr.DataDefinition.FormulaFields.Item("fdel").Text = "'" + Request.QueryString("fdel") + "'"
            cr.DataDefinition.FormulaFields.Item("fal").Text = "'" + Request.QueryString("fal") + "'"
            cr.SetDataSource(V.reportes(Request.QueryString("dato"), CDate(Request.QueryString("fdel")), CDate(Request.QueryString("fal")), 3))
            Me.CrystalReportViewer1.ReportSource = cr
            cr.ExportToHttpResponse(ExportFormatType.PortableDocFormat, Response, True, "NombreArchivo")
        End If
    End Sub

    Protected Sub btnexcel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnexcel.Click
        If Me.Label1.Text = "1" Then
            Dim cr As New Cr_detalle
            cr.SetDataSource(V.Imprimedetalle(Request.QueryString("dato")))
            Me.CrystalReportViewer1.ReportSource = cr
            cr.ExportToHttpResponse(ExportFormatType.Excel, Response, True, "NombreArchivo")
        ElseIf Me.Label1.Text = "2" Then
            Dim cr As New Cr_ventas
            cr.SetDataSource(V.reportes(Request.QueryString("dato"), CDate(Request.QueryString("fdel")), CDate(Request.QueryString("fal")), 1))
            Me.CrystalReportViewer1.ReportSource = cr
            cr.ExportToHttpResponse(ExportFormatType.Excel, Response, True, "NombreArchivo")
        ElseIf Me.Label1.Text = "3" Then
            Dim cr As New Cr_VentasXComprobante
            cr.SetDataSource(V.reportes(Request.QueryString("dato"), CDate(Request.QueryString("fdel")), CDate(Request.QueryString("fal")), 2))
            Me.CrystalReportViewer1.ReportSource = cr
            cr.ExportToHttpResponse(ExportFormatType.Excel, Response, True, "NombreArchivo")
        ElseIf Me.Label1.Text = "4" Then
            Dim cr As New Cr_VentasxFecha
            cr.DataDefinition.FormulaFields.Item("fdel").Text = "'" + Request.QueryString("fdel") + "'"
            cr.DataDefinition.FormulaFields.Item("fal").Text = "'" + Request.QueryString("fal") + "'"
            cr.SetDataSource(V.reportes(Request.QueryString("dato"), CDate(Request.QueryString("fdel")), CDate(Request.QueryString("fal")), 3))
            Me.CrystalReportViewer1.ReportSource = cr
            cr.ExportToHttpResponse(ExportFormatType.Excel, Response, True, "NombreArchivo")
        End If
    End Sub
End Class
