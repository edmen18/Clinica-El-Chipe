Imports Reglas
Imports System.Data
Imports datos
Imports System.Windows.Forms

Partial Class Hospitalizacion_PrescripcionOrden
    Inherits System.Web.UI.Page
    Dim table As New DataTable("tabla")
    Dim TB As DataRow
    Dim i As Integer
    Dim hos As New Hospitalizacion
    Dim fun As New cFuncionesDB
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        table.Columns.Add(New DataColumn("columna1"))
        table.Columns.Add(New DataColumn("columna2"))
        table.Columns.Add(New DataColumn("columna3"))
        table.Columns.Add(New DataColumn("columna4"))
        table.Columns.Add(New DataColumn("columna5"))
        table.Columns.Add(New DataColumn("columna6"))
        table.Columns.Add(New DataColumn("columna7"))
        If Page.IsPostBack = False Then
            hos.medicamentos(Me.ddmedicamento)
            activar(False)
        End If
    End Sub
    Sub activar(ByVal valor As Boolean)
        Me.txtbuscar.Enabled = valor
        Me.txtdieta.Enabled = valor
        Me.txtdosis.Enabled = valor
        Me.txthora.Enabled = valor
        Me.txttrata.Enabled = valor
        Me.txtva.Enabled = valor
        Me.btnbuscar.Enabled = valor
        Me.btnagregar.Enabled = valor
        Me.Button1.Enabled = valor
    End Sub

    Protected Sub btnagregar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnagregar.Click
        If Me.gvgvdetalle.Rows.Count - 1 >= 0 Then
            For i = 0 To Me.gvgvdetalle.Rows.Count - 1
                TB = table.NewRow()
                TB("columna1") = Me.gvgvdetalle.Rows(i).Cells(1).Text
                TB("columna2") = Me.gvgvdetalle.Rows(i).Cells(2).Text
                TB("columna3") = Me.gvgvdetalle.Rows(i).Cells(3).Text
                TB("columna4") = Me.gvgvdetalle.Rows(i).Cells(4).Text
                TB("columna5") = Me.gvgvdetalle.Rows(i).Cells(5).Text
                TB("columna6") = Me.gvgvdetalle.Rows(i).Cells(6).Text
                TB("columna7") = Me.gvgvdetalle.Rows(i).Cells(7).Text
                table.Rows.Add(TB)
            Next
            TB = table.NewRow()
            TB("columna1") = Me.ddmedicamento.SelectedValue
            TB("columna2") = Me.ddmedicamento.Text
            TB("columna3") = Me.txtdosis.Text
            TB("columna4") = Me.txttrata.Text
            TB("columna5") = Me.txtva.Text
            TB("columna6") = Me.Calendar1.SelectedDate
            TB("columna7") = Me.txthora.Text
            table.Rows.Add(TB)
            table.DefaultView.Sort = "columna1"
            gvgvdetalle.DataSource = table
            gvgvdetalle.DataBind()
        Else
            TB = table.NewRow()
            TB("columna1") = Me.ddmedicamento.SelectedValue
            TB("columna2") = Me.ddmedicamento.Text
            TB("columna3") = Me.txtdosis.Text
            TB("columna4") = Me.txttrata.Text
            TB("columna5") = Me.txtva.Text
            TB("columna6") = Me.Calendar1.SelectedDate
            TB("columna7") = Me.txthora.Text
            table.Rows.Add(TB)
            table.DefaultView.Sort = "columna2"
            gvgvdetalle.DataSource = table
            gvgvdetalle.DataBind()
        End If
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        i = Me.gvgvdetalle.SelectedIndex
        If Me.gvgvdetalle.Rows.Count - 1 >= 0 Then
            For i = 0 To Me.gvgvdetalle.Rows.Count - 1
                TB = table.NewRow()
                TB("columna1") = Me.gvgvdetalle.Rows(i).Cells(1).Text
                TB("columna2") = Me.gvgvdetalle.Rows(i).Cells(2).Text
                TB("columna3") = Me.gvgvdetalle.Rows(i).Cells(3).Text
                TB("columna4") = Me.gvgvdetalle.Rows(i).Cells(4).Text
                TB("columna5") = Me.gvgvdetalle.Rows(i).Cells(5).Text
                TB("columna6") = Me.gvgvdetalle.Rows(i).Cells(6).Text
                TB("columna7") = Me.gvgvdetalle.Rows(i).Cells(7).Text
                table.Rows.Add(TB)
            Next
            i = Me.gvgvdetalle.SelectedIndex
            table.Rows.RemoveAt(i)
            Me.gvgvdetalle.DataSource = table
            Me.gvgvdetalle.DataBind()
        End If
    End Sub

    Protected Sub btnbuscar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnbuscar.Click
        hos.llenarhospitalizacionesPres(Me.gvhospitalizaciones, Me.txtbuscar.Text)
    End Sub

    Protected Sub btnnuevo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnnuevo.Click
        activar(True)
        Me.lblprescripcion.Text = ""
        generar()
    End Sub
    Sub generar()
        Dim csql As String = "select count(*)+1 from PrescripcionMedica"
        Me.lblprescripcion.Text = fun.ConsultaUnDato(csql, 0)
    End Sub

    Protected Sub btnguardar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnguardar.Click
        If hos.Guardarprescripcion(Me.lblprescripcion.Text, Me.lblhospitalizacion.Text, txtdieta.Text) = True Then
            Try
                For i = 0 To Me.gvgvdetalle.Rows.Count - 1
                    hos.GuardarprescripcionDetalle(Me.lblprescripcion.Text, Me.gvgvdetalle.Rows(i).Cells(1).Text, Me.gvgvdetalle.Rows(i).Cells(3).Text, Me.gvgvdetalle.Rows(i).Cells(4).Text, Me.gvgvdetalle.Rows(i).Cells(5).Text, CDate(Me.gvgvdetalle.Rows(i).Cells(6).Text), Me.gvgvdetalle.Rows(i).Cells(7).Text)
                Next
                MessageBox.Show("Datos guardados correctamente", "Sistema de Consultas e Historias Clinicas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                Server.Transfer("~/Hospitalizacion/Reportes/Reporte.aspx?ind=" & 3 & "&reporte=" & Me.lblprescripcion.Text & "", True)
                cancelar()
            Catch ex As Exception
                Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('No es posible guardar los datos');</script>"))
            End Try
        End If
    End Sub

    Protected Sub gvhospitalizaciones_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvhospitalizaciones.SelectedIndexChanged
        Me.lblhospitalizacion.Text = (gvhospitalizaciones.Rows(gvhospitalizaciones.SelectedRow.RowIndex).Cells(1).Text)
    End Sub

    Protected Sub btncancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        cancelar()
    End Sub
    Sub cancelar()
        Me.txtbuscar.Text = ""
        Me.txtdieta.Text = ""
        Me.txtdosis.Text = ""
        Me.txthora.Text = ""
        Me.txttrata.Text = ""
        Me.txtva.Text = ""
        ' Me.lblprescripcion.Text = ""
        Me.lblhospitalizacion.Text = ""
        activar(False)
    End Sub
End Class