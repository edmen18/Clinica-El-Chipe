Imports System.Web.UI.WebControls
Imports datos
Imports Reglas
Imports System.Windows.Forms

Partial Class Mantenimiento_Unidad
    Inherits System.Web.UI.Page
    Dim fun As New cFuncionesDB
    Dim cunidad As New Unidad
    Sub LlenarLista()
        Dim csql As String = "Select * from Unidad"
        fun.FillDataGridView(csql, Me.GridView1)
    End Sub
    Sub Buscar()
        Dim csql As String = "Select * from Unidad where Estado='1' and NomUnidad like '%" + Me.txtbuscar.Text + "%'"
        fun.FillDataGridView(csql, Me.GridView1)
    End Sub
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LlenarLista()
    End Sub
    Protected Sub GridView1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.SelectedIndexChanged
        Buscar()
        Me.LblCodigo.Text = Trim(GridView1.Rows(GridView1.SelectedRow.RowIndex).Cells(1).Text)
        Me.TxtNombre.Text = Trim(GridView1.Rows(GridView1.SelectedRow.RowIndex).Cells(2).Text)
        Me.TxtBuscar.Text = ""
        Me.TxtNombre.Enabled = True
        LlenarLista()
    End Sub
    Protected Sub BtnNuevo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        Me.LblCodigo.Text = "U" & Format(CInt(cunidad.GeneraCodigoUnidad()) + 1, "000")
        Me.TxtNombre.Enabled = True
        Me.BtnNuevo.Enabled = False
        Me.BtnGuardar.Enabled = True
    End Sub

    Protected Sub BtnGuardar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        If Me.TxtNombre.Text = "" Or Me.LblCodigo.Text = "" Then
            Me.ClientScript.RegisterStartupScript(Me.GetType(), "alert", ("<script>alert('Debe ingresar los datos correctos');</script>"))
        Else
            'If MsgBoxResult.Ok = Button1.Attributes.Add("onclick", "return confirm('esta seguro de grabar?');") Then

            'End If
            cunidad.CodUnidad = Me.LblCodigo.Text
            cunidad.NomUnidad = Me.TxtNombre.Text
            If cunidad.AgregarUnidad() = True Then
                MessageBox.Show("Datos guardados correctamente", "Sistema de Consultas e Historias Clinicas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
            Else
                Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('No es posible guardar los datos');</script>"))
            End If
        End If
        LlenarLista()
        Me.BtnGuardar.Enabled = False
        Me.BtnNuevo.Enabled = True
        Me.LblCodigo.Text = ""
        Me.TxtNombre.Text = ""
        Me.TxtNombre.Enabled = False
    End Sub

    Protected Sub BtnReporte_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnReporte.Click
        Me.BtnNuevo.Enabled = True
        Me.LblCodigo.Text = ""
        Me.TxtNombre.Text = ""
        Me.TxtBuscar.Text = ""
        Me.TxtNombre.Enabled = False

    End Sub

    Protected Sub BtnBuscar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        If Me.TxtBuscar.Text = "" Then
            Me.ClientScript.RegisterStartupScript(Me.GetType(), "alert", ("<script>alert('Debe ingresar algún dato a buscar');</script>"))
        Else
            Buscar()
        End If
    End Sub

    Protected Sub BtnEditar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnEditar.Click

    End Sub
End Class
