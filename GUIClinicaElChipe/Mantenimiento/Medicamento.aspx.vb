Imports datos
Imports Reglas
Imports System.Windows.Forms

Partial Class Mantenimiento_Medicamento
    Inherits System.Web.UI.Page
    Dim fun As New cFuncionesDB
    Dim med As New Medicamento
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Page.IsPostBack = False Then
            llenar()
        End If
    End Sub
    Sub llenar()
        fun.FillDataGridView(med.ListarMedicamento, Me.gvmedicamentos)
    End Sub
    Protected Sub Btnnuevo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Btnnuevo.Click
        Me.lblcodigo.Text = fun.ConsultaUnDato(med.generar, 0)
        Me.lblind.Text = "1"
    End Sub

    Protected Sub gvmedicamentos_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvmedicamentos.SelectedIndexChanged
        Me.lblind.Text = "2"
        Me.lblcodigo.Text = Trim(gvmedicamentos.Rows(gvmedicamentos.SelectedRow.RowIndex).Cells(1).Text)
        Me.txtmedicamento.Text = Trim(gvmedicamentos.Rows(gvmedicamentos.SelectedRow.RowIndex).Cells(2).Text)
        Me.txtpunit.Text = Trim(gvmedicamentos.Rows(gvmedicamentos.SelectedRow.RowIndex).Cells(3).Text)
        Me.txtutilidad.Text = Trim(gvmedicamentos.Rows(gvmedicamentos.SelectedRow.RowIndex).Cells(4).Text)
    End Sub

    Protected Sub Btngrabar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Btngrabar.Click

        If Me.txtmedicamento.Text = "" Or Me.txtpunit.Text = "" Or Me.txtutilidad.Text = "" Or Me.lblcodigo.Text = "" Then
            Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('Complete los datos antes de continuar');</script>"))
        Else
            If Me.lblind.Text = "1" Then
                If med.AgregarMedicamento(Me.lblcodigo.Text, Me.txtmedicamento.Text, CDbl(Me.txtpunit.Text), Me.txtutilidad.Text) = True Then
                    MessageBox.Show("Datos guardados correctamente", "Sistema de Consultas e Historias Clinicas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                Else
                    Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('No es posible guardar los datos');</script>"))
                End If
            ElseIf Me.lblind.Text = "2" Then
                If med.UpdateMedicamento(Me.lblcodigo.Text, Me.txtmedicamento.Text, CDbl(Me.txtpunit.Text), Me.txtutilidad.Text) = True Then
                    MessageBox.Show("Datos actualizados correctamente", "Sistema de Consultas e Historias Clinicas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                Else
                    Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('No es posible actualizar los datos');</script>"))
                End If
            End If
            cancelar()
        End If
    End Sub

    Protected Sub Btncancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Btncancelar.Click
        cancelar()
    End Sub
    Sub cancelar()
        Me.lblcodigo.Text = ""
        Me.txtmedicamento.Text = ""
        Me.txtpunit.Text = ""
        Me.txtutilidad.Text = ""
        Me.lblind.Text = ""
        llenar()
        Me.txtbuscar.Text = ""
    End Sub

    Protected Sub Btncancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Btncancel.Click
        Me.txtbuscar.Text = ""
        llenar()
    End Sub

    Protected Sub btnbuscar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnbuscar.Click
        fun.FillDataGridView(med.BuscarMedicamento(Me.txtbuscar.Text), Me.gvmedicamentos)
    End Sub
End Class
