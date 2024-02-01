Imports Reglas
Imports datos
Imports System.Windows.Forms

Partial Class Mantenimiento_Medico
    Inherits System.Web.UI.Page
    Dim fundb As New cFuncionesDB
    Dim esp As New Especialidad
    Dim tp As New TipoProfesionalMedico
    Dim med As New Medico
    Protected Sub BTNVER_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTNVER.Click
        fundb.FillDataGridView(med.buscar(Me.txtdato.Text), Me.GridView1)
        Panel1.Visible = True
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Page.IsPostBack = False Then
            Panel2.Visible = False
            Panel1.Visible = False
        End If
    End Sub

    Protected Sub GridView1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.SelectedIndexChanged
        Me.lblcodpersonal.Text = Trim(GridView1.Rows(GridView1.SelectedRow.RowIndex).Cells(1).Text)
        Me.lblnombre.Text = Trim(GridView1.Rows(GridView1.SelectedRow.RowIndex).Cells(2).Text)
        Me.lblapellido.Text = Trim(GridView1.Rows(GridView1.SelectedRow.RowIndex).Cells(3).Text)
        verificar_codmedico_especialidades()
        Me.Panel1.Visible = False
        tipomedico()
    End Sub
    Sub verificar_codmedico_especialidades()
        Me.lblcodigomedico.Text = fundb.ConsultaUnDato(med.codmedicoobtener(Me.lblcodpersonal.Text), 0)
    End Sub
    Sub tipomedico()
        Me.lblcodprofesional.Text = fundb.ConsultaUnDato(med.obtenerTipoProfesionalMedico(Me.lblcodigomedico.Text), 0)
        Me.lblprofesional.Text = fundb.ConsultaUnDato(med.obtenerTipoProfesionalMedico(Me.lblcodigomedico.Text), 1)
    End Sub

    Protected Sub btngrabar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btngrabar.Click
        If Me.lblcodigomedico.Text = "" Then
            Me.lblcodigomedico.Text = "M" & fundb.ConsultaUnDato(med.generarMedico(), 0)
            If med.AgregarMedico(Me.lblcodigomedico.Text, Me.lblcodpersonal.Text, Me.lblcodprofesional.Text) = True Then
                MessageBox.Show("Datos guardados correctamente", "Sistema de Consultas e Historias Clinicas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
            Else
                Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('No es posible guardar los datos');</script>"))
            End If
        Else
            If med.ModificarMedico(Me.lblcodprofesional.Text, Me.lblcodigomedico.Text) = True Then
                MessageBox.Show("Datos Actualizados correctamente", "Sistema de Consultas e Historias Clinicas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
            Else
                Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('No es posible guardar los datos');</script>"))
            End If
        End If
        cancelar()
    End Sub

    Protected Sub btneliminar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btneliminar.Click
        If Me.lblcodigomedico.Text <> "" Then
            If med.EliminarMedico(Me.lblcodigomedico.Text) = True Then
                MessageBox.Show("Datos eliminados correctamente", "Sistema de Consultas e Historias Clinicas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
            Else
                Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('No es posible guardar los datos');</script>"))
            End If
        End If
        cancelar()
    End Sub

    Protected Sub btnespecialidades_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnespecialidades.Click
        If lblcodigomedico.Text <> "" Then
            Server.Transfer("~/Mantenimiento/Medicoespecialidad.aspx?codmedico=" & Me.lblcodigomedico.Text & "&medico=" & Me.lblnombre.Text & " " & Me.lblapellido.Text & "", True)
        End If
    End Sub

    Protected Sub btneditar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btneditar.Click
        Panel2.Visible = True
        fundb.FillDataGridView(tp.listar, gvtp)
    End Sub

    Protected Sub btncancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        cancelar()
    End Sub
    Sub cancelar()
        Me.lblapellido.Text = ""
        Me.lblcodigomedico.Text = ""
        Me.lblcodpersonal.Text = ""
        Me.lblcodprofesional.Text = ""
        Me.lblnombre.Text = ""
        Me.lblprofesional.Text = ""
        Me.Panel2.Visible = False
        Me.Panel1.Visible = False

    End Sub

    Protected Sub gvtp_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvtp.SelectedIndexChanged
        Me.lblcodprofesional.Text = gvtp.Rows(gvtp.SelectedRow.RowIndex).Cells(1).Text
        Me.lblprofesional.Text = gvtp.Rows(gvtp.SelectedRow.RowIndex).Cells(2).Text
        Panel2.Visible = False
    End Sub
End Class
