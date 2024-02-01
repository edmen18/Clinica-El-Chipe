Imports Reglas
Imports System.Data
Imports datos
Imports System.Windows.Forms

Partial Class Hospitalizacion_EvolucionMedica
    Inherits System.Web.UI.Page
    Dim cfun As New cFuncionesDB
    Dim hos As New Hospitalizacion
    Dim table As New DataTable("tabla")
    Dim TB As DataRow
    Dim i As Integer
    Dim diag As New Diagnostico

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        table.Columns.Add(New DataColumn("columna1"))
        table.Columns.Add(New DataColumn("columna2"))
        table.Columns.Add(New DataColumn("columna3"))
        table.Columns.Add(New DataColumn("columna4"))
        table.Columns.Add(New DataColumn("columna5"))
        table.Columns.Add(New DataColumn("columna6"))
        table.Columns.Add(New DataColumn("columna7"))
        table.Columns.Add(New DataColumn("columna8"))
        If Page.IsPostBack = False Then
            cancelar()
        End If
    End Sub
    Sub activar(ByVal valor As Boolean)
        Me.txtbuscar.Enabled = valor
        Me.txtao.Enabled = valor
        Me.txtas.Enabled = valor
        Me.txtenfermera.Enabled = valor
        Me.txthora.Enabled = valor
        Me.txtobs.Enabled = valor
        Me.txtre.Enabled = valor
        Me.txtvt.Enabled = valor
        Me.btnagregar.Enabled = valor
        Me.btnquitar.Enabled = valor
        Me.btnbuscar.Enabled = valor
        dddiagnostico.Enabled = valor
        ddtdiagnostico.Enabled = valor
    End Sub
    Protected Sub btnbuscar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnbuscar.Click
        hos.llenarhospitalizacionesEvol(gvhospitalizaciones, Me.txtbuscar.Text)
    End Sub

    Protected Sub gvhospitalizaciones_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvhospitalizaciones.SelectedIndexChanged
        Me.lblhospitalizacion.Text = (gvhospitalizaciones.Rows(gvhospitalizaciones.SelectedRow.RowIndex).Cells(1).Text)
    End Sub

    Protected Sub BtnGrabar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnGrabar.Click
        validarsiexisteevolucion()
    End Sub
    Sub generarevol()
        Dim csql As String = "select count(*)+1 from evolucion"
        Me.lblevolucion.Text = cfun.ConsultaUnDato(csql, 0)
    End Sub
    Sub generardevol()
        Dim csql As String = "select count(*)+1 from DetalleEvolucion"
        Me.lbldetalle.Text = cfun.ConsultaUnDato(csql, 0)
    End Sub

    Protected Sub btnNuevo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        'hos.servicios(Me.ddservicio)
        Me.lblevolucion.Text = ""
        lbldetalle.Text = ""
        activar(True)
        diag.listardiag(Me.dddiagnostico)
        diag.listartipodiag(ddtdiagnostico)
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
                TB("columna8") = Me.gvgvdetalle.Rows(i).Cells(8).Text
                table.Rows.Add(TB)
            Next
            TB = table.NewRow()
            TB("columna1") = Me.txtas.Text
            TB("columna2") = Me.txtao.Text
            TB("columna3") = Me.txtvt.Text
            TB("columna4") = Me.txtre.Text
            TB("columna5") = Me.txtobs.Text
            TB("columna6") = Me.Calendar1.SelectedDate
            TB("columna7") = Me.txthora.Text
            TB("columna8") = Me.txtenfermera.Text
            table.Rows.Add(TB)
            table.DefaultView.Sort = "columna1"
            gvgvdetalle.DataSource = table
            gvgvdetalle.DataBind()
        Else
            TB = table.NewRow()
            TB("columna1") = Me.txtas.Text
            TB("columna2") = Me.txtao.Text
            TB("columna3") = Me.txtvt.Text
            TB("columna4") = Me.txtre.Text
            TB("columna5") = Me.txtobs.Text
            TB("columna6") = Me.Calendar1.SelectedDate
            TB("columna7") = Me.txthora.Text
            TB("columna8") = Me.txtenfermera.Text
            table.Rows.Add(TB)
            'table.DefaultView.Sort = "columna2"
            gvgvdetalle.DataSource = table
            gvgvdetalle.DataBind()
        End If
    End Sub
    Sub validarsiexisteevolucion()
        Dim csql As String = "select CodEvolucion,CodHospitalizacion from evolucion where  CodHospitalizacion='" + Me.lblhospitalizacion.Text + "' "
        If cfun.ConsultaUnDato(csql, 0) = "" Then
            generarevol()
            If hos.GuardarEvolucion(Me.lblevolucion.Text, Me.lblhospitalizacion.Text) = True Then
                hos.GuardarDiagnostico(Me.lblhospitalizacion.Text, Me.dddiagnostico.SelectedValue, Me.ddtdiagnostico.SelectedValue, "Evolucion")
                For i = 0 To Me.gvgvdetalle.Rows.Count - 1
                    generardevol()
                    hos.GuardarDetalleEvolucion(Me.lbldetalle.Text, Me.lblevolucion.Text, Me.gvgvdetalle.Rows(i).Cells(1).Text, Me.gvgvdetalle.Rows(i).Cells(2).Text, Me.gvgvdetalle.Rows(i).Cells(3).Text, Me.gvgvdetalle.Rows(i).Cells(4).Text, Me.gvgvdetalle.Rows(i).Cells(5).Text, CDate(Me.gvgvdetalle.Rows(i).Cells(6).Text), Me.gvgvdetalle.Rows(i).Cells(7).Text, Me.gvgvdetalle.Rows(i).Cells(8).Text)
                Next
                cancelar()
            End If
        Else
            Me.lblevolucion.Text = cfun.ConsultaUnDato(csql, 0)
            For i = 0 To Me.gvgvdetalle.Rows.Count - 1
                generardevol()
                hos.GuardarDetalleEvolucion(Me.lbldetalle.Text, Me.lblevolucion.Text, Me.gvgvdetalle.Rows(i).Cells(1).Text, Me.gvgvdetalle.Rows(i).Cells(2).Text, Me.gvgvdetalle.Rows(i).Cells(3).Text, Me.gvgvdetalle.Rows(i).Cells(4).Text, Me.gvgvdetalle.Rows(i).Cells(5).Text, CDate(Me.gvgvdetalle.Rows(i).Cells(6).Text), Me.gvgvdetalle.Rows(i).Cells(7).Text, Me.gvgvdetalle.Rows(i).Cells(8).Text)
            Next
            cancelar()
        End If
        MessageBox.Show("Datos guardados correctamente", "Sistema de Consultas e Historias Clinicas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
        Server.Transfer("~/Hospitalizacion/Reportes/Reporte.aspx?ind=" & 2 & "&reporte=" & Me.lblevolucion.Text & "", True)
    End Sub

    Protected Sub btnquitar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnquitar.Click
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
                TB("columna8") = Me.gvgvdetalle.Rows(i).Cells(8).Text
                table.Rows.Add(TB)
            Next
            i = Me.gvgvdetalle.SelectedIndex
            table.Rows.RemoveAt(i)
            Me.gvgvdetalle.DataSource = table
            Me.gvgvdetalle.DataBind()
        End If
    End Sub

    Protected Sub btncancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        cancelar()
    End Sub
    Sub cancelar()
        Me.txtbuscar.Text = ""
        Me.txtao.Text = ""
        Me.txtas.Text = ""
        Me.txtenfermera.Text = ""
        Me.txthora.Text = ""
        Me.txtobs.Text = ""
        Me.txtre.Text = ""
        Me.txtvt.Text = ""
        activar(False)
    End Sub
End Class
