Imports datos
Imports Reglas
Imports Reportes
Imports CrystalDecisions.Shared
Partial Class Hospitalizacion_Reportes_Reporte
    Inherits System.Web.UI.Page
    Dim hos As New Hospitalizacion
    Dim ia As New Cl_informeAlta
    Dim cv As New ControlesVitales
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Label1.Text = Request.QueryString("ind")
        If Page.IsPostBack = False Then
            If Me.Label1.Text = "1" Then
                hpregresar.NavigateUrl = "~/Hospitalizacion/ReporteOperatorio.aspx"
                Dim cr As New Cr_ReporteOperatorio
                cr.SetDataSource(hos.ImprimeReporteOperatorio(Request.QueryString("reporte")))
                Me.CrystalReportViewer1.ReportSource = cr
            End If
            If Me.Label1.Text = "2" Then
                hpregresar.NavigateUrl = "~/Hospitalizacion/EvolucionMedica.aspx"
                Dim cr As New Cr_EvolMedica
                cr.SetDataSource(hos.ImprimeEVOLMEDICA(Request.QueryString("reporte")))
                CrystalReportViewer1.ReportSource = cr
            End If
            If Me.Label1.Text = "3" Then
                hpregresar.NavigateUrl = "~/Hospitalizacion/PrescripcionOrden.aspx"
                Dim cr As New Cr_prescripcion
                cr.SetDataSource(hos.ImprimePrescripcionMedica(Request.QueryString("reporte")))
                CrystalReportViewer1.ReportSource = cr
            End If
            If Me.Label1.Text = "4" Then
                hpregresar.NavigateUrl = "~/Hospitalizacion/InformeAlta.aspx"
                Dim cr As New Cr_InformeMedico
                cr.SetDataSource(ia.ImprimeInformeAlta(Request.QueryString("reporte")))
                CrystalReportViewer1.ReportSource = cr
            End If
            If Me.Label1.Text = "5" Then
                hpregresar.NavigateUrl = "~/Hospitalizacion/BusquedaParaControlesVitales.aspx"
                Dim cr As New Cr_perinatal
                cr.SetDataSource(cv.ImprimePerinatal(Request.QueryString("reporte")))
                CrystalReportViewer1.ReportSource = cr
            End If
        End If
    End Sub
End Class
