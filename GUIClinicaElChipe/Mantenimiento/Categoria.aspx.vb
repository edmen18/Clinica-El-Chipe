Imports Reglas
Imports datos
Imports System.Windows.Forms
Partial Class Mantenimiento_Categoria
    Inherits System.Web.UI.Page
    Dim fundb As New cFuncionesDB
    Dim tp As New Categoria
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Page.IsPostBack = False Then
            cargar()
        End If
    End Sub
    Sub cargar()
        fundb.FillDataGridView(tp.listar, Me.gvtp)
    End Sub
    Protected Sub btnnuevo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Btnnuevo.Click
        lblind.Text = "1"
        tp.generar(Me.lblcodcategoria)
    End Sub

    Protected Sub gvtp_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvtp.SelectedIndexChanged
        lblind.Text = "2"
        Me.lblcodcategoria.Text = Trim(gvtp.Rows(gvtp.SelectedRow.RowIndex).Cells(1).Text)
        Me.txtcategoria.Text = Trim(gvtp.Rows(gvtp.SelectedRow.RowIndex).Cells(2).Text)
        cargar()
    End Sub

    Protected Sub btngrabar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Btngrabar.Click
        If lblind.Text = "1" Then
            If tp.Agregarcategoria(lblcodcategoria.Text, Me.txtcategoria.Text) Then
                MessageBox.Show("Datos guardados correctamente", "Sistema de Consultas e Historias Clinicas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
            Else
                Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('No es posible guardar los datos');</script>"))
            End If
        ElseIf lblind.Text = "2" Then
            If tp.Updatecategoria(lblcodcategoria.Text, Me.txtcategoria.Text) Then
                MessageBox.Show("Datos actualizados correctamente", "Sistema de Consultas e Historias Clinicas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
            Else
                Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('No es posible guardar los datos');</script>"))
            End If
        End If
        cancelar()
    End Sub
    Sub cancelar()
        cargar()
        Me.lblind.Text = ""
        lblcodcategoria.Text = ""
        txtcategoria.Text = ""
        Txtdato.Text = ""
    End Sub
    Protected Sub btncancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Btncancelar.Click
        cancelar()
    End Sub

    Protected Sub Btnbuscar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Btnbuscar.Click
        fundb.FillDataGridView(tp.buscar(Txtdato.Text), gvtp)
    End Sub
End Class
