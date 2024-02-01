Imports Reglas
Imports datos
Imports System.Windows.Forms
Partial Class Mantenimiento_Pais
    Inherits System.Web.UI.Page
    Dim pa As New Pais
    Dim fun As New cFuncionesDB
    Protected Sub Btnnuevo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Btnnuevo.Click
        cancelar()
        pa.generar(Me.lblcodpais)
        lblflag.Text = 1
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Page.IsPostBack = False Then
            pa.ListarPais(Me.gvpais)
        End If
    End Sub

    Protected Sub gvpais_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvpais.SelectedIndexChanged
        Me.lblcodpais.Text = Trim(gvpais.Rows(gvpais.SelectedRow.RowIndex).Cells(1).Text)
        Me.txtnompais.Text = Trim(gvpais.Rows(gvpais.SelectedRow.RowIndex).Cells(2).Text)
        lblflag.Text = 2
    End Sub
    Sub cancelar()
        Me.lblcodpais.Text = ""
        Me.txtnompais.Text = ""
    End Sub

    Protected Sub Btngrabar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Btngrabar.Click
        If Me.txtnompais.Text = "" Or Me.lblcodpais.Text = "" Then
            Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('Error: Complete los datos antes de continuar');</script>"))
        Else
            If lblflag.Text = 1 Then
                'guardar
                pa.AgregarPais(Me.lblcodpais.Text, txtnompais.Text)
                MessageBox.Show("Datos guardados correctamente", "Sistema de Consultas e Historias Clinicas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
            ElseIf lblflag.Text = 2 Then
                'update
                pa.UpdatePais(Me.lblcodpais.Text, Me.txtnompais.Text)
                MessageBox.Show("Datos actalizados correctamente", "Sistema de Consultas e Historias Clinicas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
            End If
            pa.ListarPais(Me.gvpais)
            cancelar()
        End If

    End Sub
End Class
