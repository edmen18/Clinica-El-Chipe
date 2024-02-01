Imports Reglas
Imports System.Data
Imports datos
Imports System.Windows.Forms

Partial Class Hospitalizacion_ReporteOperatorio
    Inherits System.Web.UI.Page
    Dim hos As New Hospitalizacion
    Dim table As New DataTable("tabla")
    Dim TB As DataRow
    Dim i As Integer
    Dim fun As New cFuncionesDB
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        table.Columns.Add(New DataColumn("columna1"))
        table.Columns.Add(New DataColumn("columna2"))
        table.Columns.Add(New DataColumn("columna3"))
        If Page.IsPostBack = False Then
            activar(False)
        End If
    End Sub

    Protected Sub btnbuscar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnbuscar.Click
        hos.llenarhospitalizaciones(gvhospitalizaciones, Me.txtbuscar.Text)
    End Sub
    Sub activar(ByVal valor As Boolean)
        Me.txtbuscar.Enabled = valor
        Me.txtduracion.Enabled = valor
        Me.txthallazgos.Enabled = valor
        Me.txthora.Enabled = valor
        gvprogramacion.DataSource = Nothing
        btnagregar.Enabled = valor
        btnquitar.Enabled = valor
        btnbuscar.Enabled = valor
    End Sub
    Protected Sub btnnuevo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnnuevo.Click
        activar(True)
        Me.lblreporte.Text = ""
        lblhospitalizacion.Text = ""
        generar()
        hos.diagnosticos(Me.dddiagn)
        hos.diagnosticos(Me.ddiag)
        hos.cargarmedicos(Me.ddmedico)
    End Sub
    Protected Sub btnagregar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnagregar.Click
        If Me.gvprogramacion.Rows.Count - 1 >= 0 Then
            For i = 0 To Me.gvprogramacion.Rows.Count - 1
                TB = table.NewRow()
                TB("columna1") = Me.gvprogramacion.Rows(i).Cells(1).Text
                TB("columna2") = Me.gvprogramacion.Rows(i).Cells(2).Text
                TB("columna3") = Me.gvprogramacion.Rows(i).Cells(3).Text
                table.Rows.Add(TB)
            Next
            TB = table.NewRow()
            TB("columna1") = Me.ddmedico.SelectedValue
            TB("columna2") = Me.ddmedico.Text
            TB("columna3") = Me.ddcargo.Text
            table.Rows.Add(TB)
            table.DefaultView.Sort = "columna1"
            gvprogramacion.DataSource = table
            gvprogramacion.DataBind()
        Else
            TB = table.NewRow()
            TB("columna1") = Me.ddmedico.SelectedValue
            TB("columna2") = Me.ddmedico.Text
            TB("columna3") = Me.ddcargo.Text
            table.Rows.Add(TB)
            table.DefaultView.Sort = "columna2"
            gvprogramacion.DataSource = table
            gvprogramacion.DataBind()
        End If
    End Sub

    Protected Sub btnquitar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnquitar.Click
        i = Me.gvprogramacion.SelectedIndex
        If Me.gvprogramacion.Rows.Count - 1 >= 0 Then
            For i = 0 To Me.gvprogramacion.Rows.Count - 1
                TB = table.NewRow()
                TB("columna1") = Me.gvprogramacion.Rows(i).Cells(1).Text
                TB("columna2") = Me.gvprogramacion.Rows(i).Cells(2).Text
                TB("columna3") = Me.gvprogramacion.Rows(i).Cells(3).Text
                table.Rows.Add(TB)
            Next
            i = Me.gvprogramacion.SelectedIndex
            table.Rows.RemoveAt(i)
            Me.gvprogramacion.DataSource = table
            Me.gvprogramacion.DataBind()
        End If
    End Sub

    Protected Sub gvhospitalizaciones_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvhospitalizaciones.SelectedIndexChanged
        Me.lblhospitalizacion.Text = (gvhospitalizaciones.Rows(gvhospitalizaciones.SelectedRow.RowIndex).Cells(1).Text)
    End Sub
    Sub generar()
        Dim csql As String = "select count(*)+1 from ReporteOperatorio"
        Me.lblreporte.Text = fun.ConsultaUnDato(csql, 0)
    End Sub

    Protected Sub btngrabar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btngrabar.Click
        If Me.lblreporte.Text = "" Or Me.lblhospitalizacion.Text = "" Or Me.txtduracion.Text = "" Or Me.cfecha.SelectedDate = Nothing Or Me.txthallazgos.Text = "" Or Me.txthora.Text = "" Or Me.gvprogramacion.Rows.Count - 1 <= 0 Then
            Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('No es posible guardar los datos ya que están incompletos');</script>"))
        Else
            If hos.GuardarReporteOperatorio(Me.lblreporte.Text, Me.lblhospitalizacion.Text, Me.cfecha.SelectedDate, Me.txtduracion.Text, Me.txthora.Text, Me.txthallazgos.Text) = True Then
                'DIAGNOSTICOS
                hos.Guardardiagnosticospre(Me.lblreporte.Text, Me.ddiag.SelectedIndex)
                hos.Guardardiagnosticospos(Me.lblreporte.Text, Me.ddiag.SelectedIndex)
                'GUARDAR DICTORES
                For i = 0 To Me.gvprogramacion.Rows.Count - 1
                    hos.GuardarDoctores(Me.lblreporte.Text, Me.gvprogramacion.Rows(i).Cells(1).Text, Me.gvprogramacion.Rows(i).Cells(3).Text)
                Next
            End If
            MessageBox.Show("Datos guardados correctamente", "Sistema de Consultas e Historias Clinicas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
            Server.Transfer("~/Hospitalizacion/Reportes/Reporte.aspx?ind=" & 1 & "&reporte=" & Me.lblreporte.Text & "", True)
            cancelar()
        End If
    End Sub

    Protected Sub btncancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        'Server.Transfer("~/Hospitalizacion/Reportes/Reporte.aspx?ind=" & 1 & "&reporte=" & Me.lblreporte.Text & "", True)
        cancelar()
    End Sub
    Sub cancelar()
        Me.txtbuscar.Text = ""
        Me.txtduracion.Text = ""
        Me.txthallazgos.Text = ""
        Me.txthora.Text = ""
        activar(False)
    End Sub
End Class
