Imports datos
Imports Reglas
Imports System.Windows.Forms

Partial Class Mantenimiento_Diagnostico
    Inherits System.Web.UI.Page
    Dim fun As New cFuncionesDB
    Dim enf As New Enfermedad
    Dim dia As New Diagnostico
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Page.IsPostBack = False Then
            llenar()
            Me.pnenfermedades.Visible = False
        End If
    End Sub
    Sub llenar()
        fun.FillDataGridView(dia.lista(), Me.gvmedicamentos)
    End Sub
    Protected Sub btnbuscarenf_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnbuscarenf.Click
        fun.FillDataGridView(enf.Buscar(Me.txtbenfermedad.Text), gvenfermedad)
        Me.pnenfermedades.Visible = True
    End Sub

    Protected Sub gvenfermedad_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvenfermedad.SelectedIndexChanged
        Me.lblcodenfermedad.Text = Trim(gvenfermedad.Rows(gvenfermedad.SelectedRow.RowIndex).Cells(1).Text)
        Me.lblenfermedad.Text = Trim(gvenfermedad.Rows(gvenfermedad.SelectedRow.RowIndex).Cells(2).Text)
        Me.lblcoddiag.Text = "A00." & fun.ConsultaUnDato(dia.generardiag(Me.lblcodenfermedad.Text), 0)
        Me.pnenfermedades.Visible = False
    End Sub

    Protected Sub Btnnuevo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Btnnuevo.Click
        cancelar()
        Me.lblcodigo.Text = fun.ConsultaUnDato(dia.generar, 0)
        Me.lblind.Text = "1"
    End Sub
    Sub cancelar()
        Me.lblcodenfermedad.Text = ""
        Me.lblenfermedad.Text = ""
        Me.lblcoddiag.Text = ""
        Me.lblcodigo.Text = ""
        Me.lblind.Text = ""
        Me.txtdiag.Text = ""
        Me.txtbenfermedad.Text = ""
        Me.txtbuscar.Text = ""
    End Sub

    Protected Sub gvmedicamentos_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvmedicamentos.SelectedIndexChanged
        Me.lblcodigo.Text = Trim(gvmedicamentos.Rows(gvmedicamentos.SelectedRow.RowIndex).Cells(1).Text)
        Me.lblcoddiag.Text = Trim(gvmedicamentos.Rows(gvmedicamentos.SelectedRow.RowIndex).Cells(2).Text)
        Me.txtdiag.Text = Trim(gvmedicamentos.Rows(gvmedicamentos.SelectedRow.RowIndex).Cells(3).Text)
        Me.lblcodenfermedad.Text = Trim(gvmedicamentos.Rows(gvmedicamentos.SelectedRow.RowIndex).Cells(4).Text)
        Me.lblenfermedad.Text = Trim(gvmedicamentos.Rows(gvmedicamentos.SelectedRow.RowIndex).Cells(5).Text)
        Me.lblind.Text = "2"
        llenar()
    End Sub

    Protected Sub Btngrabar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Btngrabar.Click
        If Me.lblind.Text = "1" Then
            If dia.AgregarDIAG(Me.lblcodigo.Text, Me.lblcoddiag.Text, Me.txtdiag.Text, Me.lblcodenfermedad.Text) = True Then
                MessageBox.Show("Datos guardados correctamente", "Sistema de Consultas e Historias Clinicas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
            Else
                Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('No es posible guardar los datos');</script>"))
            End If
        ElseIf Me.lblind.Text = "2" Then
            If dia.UpdateDIAG(Me.lblcodigo.Text, Me.lblcoddiag.Text, Me.txtdiag.Text, Me.lblcodenfermedad.Text) = True Then
                MessageBox.Show("Datos actualizados correctamente", "Sistema de Consultas e Historias Clinicas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
            Else
                Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('No es posible actualizar los datos');</script>"))
            End If
        End If
        llenar()
        cancelar()
    End Sub

    Protected Sub Btncancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Btncancel.Click
        cancelar()
        llenar()
    End Sub

    Protected Sub btnbuscar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnbuscar.Click
        fun.FillDataGridView(dia.buscar(Me.txtbuscar.Text), Me.gvmedicamentos)
    End Sub
End Class
