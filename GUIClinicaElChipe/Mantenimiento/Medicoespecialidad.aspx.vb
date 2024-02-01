Imports Reglas
Imports datos
Imports System.Windows.Forms
Partial Class Mantenimiento_Medicoespecialidad
    Inherits System.Web.UI.Page
    Dim fundb As New cFuncionesDB
    Dim esp As New Especialidad
    Dim tp As New TipoProfesionalMedico
    Dim med As New Medico
    Dim mes As New MedicoEspecialidad
    Dim bandera As Integer = 0
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.lblcodigo.Text = Request("codmedico")
        Me.lblmedico.Text = Request("medico")
        If Page.IsPostBack = False Then
            fundb.FillListaOrCombo(esp.ListarEspecialidad(), ddespecialidad, "nomespecialidad", "codespecialidad")
            fundb.FillDataGridView(med.obtenerespecialidades(Me.lblcodigo.Text), Me.gvespecialidades)
        End If
    End Sub
    Protected Sub btneliminar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btneliminar.Click
        If Me.lblcodigo.Text <> "" Then
            If mes.EliminarMedicoESP(gvespecialidades.Rows(gvespecialidades.SelectedRow.RowIndex).Cells(1).Text) = True Then
                MessageBox.Show("Datos eliminados correctamente", "Sistema de Consultas e Historias Clinicas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
            Else
                Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('No es posible guardar los datos');</script>"))
            End If
        End If
        fundb.FillDataGridView(med.obtenerespecialidades(Me.lblcodigo.Text), Me.gvespecialidades)
        cancelar()
    End Sub

    Protected Sub btnagregar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnagregar.Click
        For i = 0 To Me.gvespecialidades.Rows.Count - 1
            If gvespecialidades.Rows(i).Cells(2).Text = Me.ddespecialidad.SelectedValue Then
                bandera = bandera + 1
            End If
        Next
        If bandera > 0 Then
            Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('Los datos ya existen');</script>"))
        Else
            If Me.lblcodigo.Text <> "" Then
                Me.lblcodmes.Text = "ME" & mes.GeneraCodigoMedicoEspecialidad()
                If mes.AgregarMedicoESP(Me.lblcodmes.Text, Me.lblcodigo.Text, Me.ddespecialidad.SelectedValue) = True Then
                    MessageBox.Show("Datos guardados correctamente", "Sistema de Consultas e Historias Clinicas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                Else
                    Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('No es posible guardar los datos');</script>"))
                End If
            End If
        End If
        fundb.FillDataGridView(med.obtenerespecialidades(Me.lblcodigo.Text), Me.gvespecialidades)
        cancelar()
    End Sub
    Sub cancelar()
        Me.lblcodmes.Text = ""
        bandera = 0
    End Sub
End Class
