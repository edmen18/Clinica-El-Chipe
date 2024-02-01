Imports Reglas
Imports datos
Imports System.Windows.Forms

Partial Class Mantenimiento_Especialidad
    Inherits System.Web.UI.Page
    Dim fundb As New cFuncionesDB
    Dim esp As New Especialidad
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cargar()
    End Sub
    Sub cargar()
        fundb.FillDataGridView(esp.ListarEspecialidad, Me.gvespecialidades)
    End Sub

    Protected Sub Btngrabar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Btngrabar.Click
        If lblcodespecialidad.Text = "" Or Me.txtespecialidad.Text = "" Then
            Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('Error: Complete los datos antes de continuar');</script>"))
        Else
            If Me.lblflag.Text = "1" Then
                If esp.AgregarEspecialidad(Me.lblcodespecialidad.Text, Me.txtespecialidad.Text) = True Then
                    MessageBox.Show("Datos guardados correctamente", "Sistema de Consultas e Historias Clinicas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                Else
                    Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('Error: No es posible grabar los datos');</script>"))
                End If
            ElseIf lblflag.Text = "2" Then
                If esp.ModificarEspecialidad(Me.txtespecialidad.Text, Me.lblcodespecialidad.Text) = True Then
                    MessageBox.Show("Datos Actualizados correctamente", "Sistema de Consultas e Historias Clinicas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                Else
                    Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('Error: No es posible grabar los datos');</script>"))
                End If
            End If
        End If
        cargar()
        cancelar()
    End Sub

    Protected Sub Btncancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Btncancelar.Click
        cancelar()
    End Sub

    Protected Sub Btnnuevo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Btnnuevo.Click
        Me.lblcodespecialidad.Text = "E" & esp.generar()
        Me.lblflag.Text = "1"
    End Sub
    Sub cancelar()
        Me.txtespecialidad.Text = ""
        Me.lblcodespecialidad.Text = ""
        Me.lblflag.Text = "2"
    End Sub

    Protected Sub gvespecialidades_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvespecialidades.SelectedIndexChanged
        Me.lblcodespecialidad.Text = Trim(gvespecialidades.Rows(gvespecialidades.SelectedRow.RowIndex).Cells(1).Text)
        Me.txtespecialidad.Text = Trim(gvespecialidades.Rows(gvespecialidades.SelectedRow.RowIndex).Cells(2).Text)
        lblflag.Text = 2

    End Sub
End Class
