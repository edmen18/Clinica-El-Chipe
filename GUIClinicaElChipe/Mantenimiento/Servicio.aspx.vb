Imports datos
Imports Reglas
Imports System.Windows.Forms
Partial Class Mantenimiento_Servicio
    Inherits System.Web.UI.Page
    Dim fundb As New cFuncionesDB
    Dim tp As New Servicio
    Dim h As New Categoria
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Page.IsPostBack = False Then
            Me.PNHABIT.Visible = False
        End If
    End Sub
    Protected Sub Btnbuscar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Btnbuscar.Click
        Me.PNHABIT.Visible = True
        fundb.FillDataGridView(h.buscar(Me.Txtcategoria.Text), GVHABITACION)
    End Sub
    Sub cargar()
        fundb.FillDataGridView(tp.listrar, Me.gvtp)
    End Sub
    Protected Sub btnnuevo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnnuevo.Click
        lblind.Text = "1"
        tp.generar(lblcodigo)
    End Sub

    Protected Sub gvtp_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvtp.SelectedIndexChanged
        lblind.Text = "2"
        Me.lblcodigo.Text = Trim(gvtp.Rows(gvtp.SelectedRow.RowIndex).Cells(1).Text)
        Me.txtdescripcion.Text = Trim(gvtp.Rows(gvtp.SelectedRow.RowIndex).Cells(2).Text)
        Me.lblcategoria.Text = Trim(gvtp.Rows(gvtp.SelectedRow.RowIndex).Cells(4).Text)
        Me.Txtcategoria.Text = Trim(gvtp.Rows(gvtp.SelectedRow.RowIndex).Cells(5).Text)
        Me.txtprecio.Text = Trim(gvtp.Rows(gvtp.SelectedRow.RowIndex).Cells(3).Text)
        cargar()
    End Sub

    Protected Sub btngrabar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btngrabar.Click
        If Me.txtprecio.Text = "" Or Me.txtdescripcion.Text = "" Or Me.lblind.Text = "" Or Me.lblcodigo.Text = "" Then
            Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('Complete los datos nates de continuar');</script>"))
        Else
            If lblind.Text = "1" Then
                If tp.Agregarservicio(lblcodigo.Text, Me.txtdescripcion.Text, Me.lblcategoria.Text, CDbl(Me.txtprecio.Text)) Then
                    MessageBox.Show("Datos guardados correctamente", "Sistema de Consultas e Historias Clinicas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                Else
                    Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('No es posible guardar los datos');</script>"))
                End If
            ElseIf lblind.Text = "2" Then
                If tp.Updateservicio(lblcodigo.Text, Me.txtdescripcion.Text, Me.lblcategoria.Text, CDbl(Me.txtprecio.Text)) Then
                    MessageBox.Show("Datos actualizados correctamente", "Sistema de Consultas e Historias Clinicas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                Else
                    Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('No es posible guardar los datos');</script>"))
                End If
            End If
            cancelar()
        End If

    End Sub
    Sub cancelar()
        cargar()
        Me.txtprecio.Text = ""
        Me.lblind.Text = ""
        lblcodigo.Text = ""
        txtdescripcion.Text = ""
        Ttxtdato.Text = ""
        Me.lblcategoria.Text = ""
        Me.Txtcategoria.Text = ""
        PNHABIT.Visible = False
        Me.txtdescripcion.Enabled = True
    End Sub

    Protected Sub btnver_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnver.Click
        fundb.FillDataGridView(tp.buscar(Ttxtdato.Text), gvtp)
    End Sub

    Protected Sub btncancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        cancelar()
    End Sub

    Protected Sub GVHABITACION_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GVHABITACION.SelectedIndexChanged
        Me.lblcategoria.Text = Trim(GVHABITACION.Rows(GVHABITACION.SelectedRow.RowIndex).Cells(1).Text)
        Me.Txtcategoria.Text = Trim(GVHABITACION.Rows(GVHABITACION.SelectedRow.RowIndex).Cells(2).Text)
        Me.PNHABIT.Visible = False
    End Sub

    Protected Sub btneliminar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btneliminar.Click
        If lblind.Text = "2" Then
            If tp.deleteservicio(lblcodigo.Text) Then
                MessageBox.Show("Datos eliminados correctamente", "Sistema de Consultas e Historias Clinicas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
            Else
                Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('No es posible Eliminar los datos');</script>"))
            End If
        Else
            Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('Selecciona un elemento de la lista inferior');</script>"))
        End If
        cancelar()
    End Sub
End Class
