Imports datos
Imports Reglas
Imports System.Windows.Forms

Partial Class Hospitalizacion_Hospitalizacion
    Inherits System.Web.UI.Page
    Dim hosp As New Hospitalizacion
    Dim fun As New cFuncionesDB
    Dim diag As New Diagnostico
    Protected Sub btnnuevo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnnuevo.Click
        activa(True)
        generar()
        diag.listardiag(dddiagnostico)
        diag.listartipodiag(ddtdiagnostico)
    End Sub
    Sub activa(ByVal valor As Boolean)
        Me.txtbuscar.Enabled = valor
        Me.txtAnamnesis.Enabled = valor
        Me.txtcligeneral.Enabled = valor
        Me.txtcliregional.Enabled = valor
        Me.lblhospitalizacion.Enabled = valor
        Me.lblpaciente.Enabled = valor
        Me.lblsolicitud.Enabled = valor
        Me.dddiagnostico.Enabled = valor
        ddtdiagnostico.Enabled = valor
    End Sub
    Protected Sub btnGrabar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGrabar.Click
        If Me.txtbuscar.Text = "" Or Me.lblhospitalizacion.Text = "" Or Me.lblpaciente.Text = "" Or Me.lblsolicitud.Text = "" Or Me.txtcligeneral.Text = "" Or Me.txtcliregional.Text = "" Or Me.txtAnamnesis.Text = "" Then
            Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('No es posible guardar los datos ya que están incompletos');</script>"))
        Else
            If hosp.AgregarHospitalizacion(Me.lblhospitalizacion.Text, Me.lblsolicitud.Text, Now.Date, CStr(Now.Hour), Me.txtcligeneral.Text, Me.txtcliregional.Text, Me.txtAnamnesis.Text) = True Then
                If hosp.GuardarDiagnostico(Me.lblhospitalizacion.Text, Me.dddiagnostico.SelectedValue, ddtdiagnostico.SelectedValue, "Ingreso") = True Then
                    MessageBox.Show("Datos guardados correctamente", "Sistema de Consultas e Historias Clinicas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                    cancelar()
                End If
            Else
                Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('No es posible guardar los datos');</script>"))
            End If
        End If
    End Sub
    Sub generar()
        Dim csql As String = "select count(*)+1 from hospitalizacion"
        Me.lblhospitalizacion.Text = fun.ConsultaUnDato(csql, 0)
    End Sub

    Protected Sub btnbuscar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnbuscar.Click
        hosp.listarSolicitudespendientes(gvsolicitudes, Me.txtbuscar.Text)
    End Sub

    Protected Sub gvsolicitudes_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvsolicitudes.SelectedIndexChanged
        Me.lblpaciente.Text = Trim(gvsolicitudes.Rows(gvsolicitudes.SelectedRow.RowIndex).Cells(1).Text)
        Me.lblsolicitud.Text = Trim(gvsolicitudes.Rows(gvsolicitudes.SelectedRow.RowIndex).Cells(2).Text)
    End Sub
    Sub cancelar()
        Me.txtbuscar.Text = ""
        Me.lblhospitalizacion.Text = ""
        Me.lblpaciente.Text = ""
        Me.lblsolicitud.Text = ""
        Me.txtcligeneral.Text = ""
        Me.txtcliregional.Text = ""
        Me.txtAnamnesis.Text = ""
        activa(False)
    End Sub

    Protected Sub btncancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        cancelar()
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Page.IsPostBack = False Then
            activa(False)
        End If
    End Sub
End Class
