Imports Reglas
Imports datos
Imports System.Windows.Forms

Partial Class Mantenimiento_Area
    Inherits System.Web.UI.Page
    Dim ar As New Area
    Dim fun As New cFuncionesDB

    Protected Sub btnver_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnver.Click
        ar.ListarUnidades(Me.gvunidades, Me.txtunidad.Text)
        Me.Panel2.Visible = True
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Page.IsPostBack = False Then
            fun.FillDataGridView(ar.ListarArea(), Me.gvareas)
        End If
    End Sub

    Protected Sub gvunidades_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvunidades.SelectedIndexChanged
        Me.lblunidad.Text = Trim(gvunidades.Rows(gvunidades.SelectedRow.RowIndex).Cells(1).Text)
        Me.txtunidad.Text = Trim(gvunidades.Rows(gvunidades.SelectedRow.RowIndex).Cells(2).Text)
        Me.Panel2.Visible = False
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        cancelar()
        ar.generar(Me.lblcodarea)
        lblflag.Text = 1
    End Sub
    Sub cancelar()
        Me.lblcodarea.Text = ""
        Me.txtarea.Text = ""
        Me.lblunidad.Text = ""
        Me.lblflag.Text = ""
        Me.txtunidad.Text = ""
        Me.Panel2.Visible = False
    End Sub

    Protected Sub gvareas_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvareas.SelectedIndexChanged
        lblflag.Text = 2
        Me.lblcodarea.Text = Trim(gvareas.Rows(gvareas.SelectedRow.RowIndex).Cells(1).Text)
        Me.txtarea.Text = Trim(gvareas.Rows(gvareas.SelectedRow.RowIndex).Cells(2).Text)
        Me.lblunidad.Text = Trim(gvareas.Rows(gvareas.SelectedRow.RowIndex).Cells(3).Text)
        Me.txtunidad.Text = Trim(gvareas.Rows(gvareas.SelectedRow.RowIndex).Cells(4).Text)

    End Sub

    Protected Sub btngrabar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btngrabar.Click
        If Me.txtarea.Text = "" Or Me.txtunidad.Text = "" Or Me.lblcodarea.Text = "" Or Me.lblunidad.Text = "" Or Me.lblflag.Text = "" Then
            Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('Error: Complete los datos antes de continuar');</script>"))
        Else
            If lblflag.Text = 1 Then
                'guardar
                ar.Agregararea(Me.lblcodarea.Text, txtarea.Text, Me.lblunidad.Text)
                MessageBox.Show("Datos guardados correctamente", "Sistema de Consultas e Historias Clinicas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
            ElseIf lblflag.Text = 2 Then
                'update
                ar.Updatearea(Me.lblcodarea.Text, Me.txtarea.Text, Me.lblunidad.Text)
                MessageBox.Show("Datos actalizados correctamente", "Sistema de Consultas e Historias Clinicas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
            End If
            fun.FillDataGridView(ar.ListarArea(), Me.gvareas)
            cancelar()
        End If

    End Sub

    Protected Sub btncancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        cancelar()
    End Sub

    Protected Sub btneliminar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btneliminar.Click
        If Me.txtarea.Text = "" Or Me.txtunidad.Text = "" Or Me.lblcodarea.Text = "" Or Me.lblunidad.Text = "" Or Me.lblflag.Text = "" Then
            Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('Error: Complete los datos antes de continuar');</script>"))
        Else
            If lblflag.Text = 2 Then
                'Delete
                ar.DeleteArea(Me.lblcodarea.Text)
                MessageBox.Show("Datos eliminados correctamente", "Sistema de Consultas e Historias Clinicas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
            End If
            fun.FillDataGridView(ar.ListarArea(), Me.gvareas)
            cancelar()
        End If
    End Sub
End Class
