Imports Reglas
Imports datos
Imports System.Windows.Forms

Partial Class ModuloCaja_Consultas_ConsultaVenta
    Inherits System.Web.UI.Page
    Dim p As New Paciente
    Dim cfun As New cFuncionesDB
    Dim v As New Venta
    Dim anu As New Anulacion
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LblUsu.Text = Request.QueryString("Valor1")
        If Page.IsPostBack = False Then
            Me.Panel3.Visible = False
            Me.Panel8.Visible = False
        End If
    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        If TxtBuscar.Text = "" Then
            MessageBox.Show("Debe ingresar el dato a buscar", "Sistema de Consultas e Historias Clinicas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
        Else
            cfun.FillDataGridView(p.BuscarPaciente(Me.TxtBuscar.Text), Gvpaciente)
        End If
    End Sub

    Protected Sub imbuscar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles imbuscar.Click
        'If Me.rblista.SelectedIndex = 0 Then
        '    v.consultaventa(Gvpaciente.Rows(Gvpaciente.SelectedRow.RowIndex).Cells(9).Text, Now.Date, 1, Me.gvventas)
        'ElseIf Me.rblista.SelectedIndex = 1 Then
        '    v.consultaventa("", Me.Calendar1.SelectedDate, 2, Me.gvventas)
        'ElseIf Me.rblista.SelectedIndex = 2 Then
        '    v.consultaventa(Gvpaciente.Rows(Gvpaciente.SelectedRow.RowIndex).Cells(9).Text, Me.Calendar1.SelectedDate, 1, Me.gvventas)
        'End If

    End Sub

    Protected Sub rblista_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rblista.SelectedIndexChanged
        Me.Panel3.Visible = False
        Me.Panel8.Visible = False
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Me.rblista.SelectedIndex = 0 Then
            Me.Panel3.Visible = True
            Me.Panel8.Visible = False
        ElseIf Me.rblista.SelectedIndex = 1 Then
            Me.Panel3.Visible = False
            Me.Panel8.Visible = True
        ElseIf Me.rblista.SelectedIndex = 2 Then
            Me.Panel3.Visible = True
            Me.Panel8.Visible = True
        End If
    End Sub

    Protected Sub imanular_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles imanular.Click
        If v.ventaatencion(gvventas.Rows(gvventas.SelectedRow.RowIndex).Cells(1).Text) = "TA1" Then
            If v.AnularVenta(gvventas.Rows(gvventas.SelectedRow.RowIndex).Cells(1).Text) = True Then
                MessageBox.Show("Datos guardados correctamente", "Sistema de Consultas e Historias Clinicas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                anu.generaranul()
                anu.RegistrarAnulacion("8", Me.TextBox1.Text, gvventas.Rows(gvventas.SelectedRow.RowIndex).Cells(1).Text)
            Else
                MessageBox.Show("No es posible eliminar los datos", "Sistema de Consultas e Historias Clinicas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
            End If
        Else
            Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('No es posible anular el registro ya que no se trata de una consulta');</script>"))
        End If

       
    End Sub
End Class
