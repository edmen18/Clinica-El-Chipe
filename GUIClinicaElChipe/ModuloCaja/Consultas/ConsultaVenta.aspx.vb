Imports Reglas
Imports datos
Partial Class ModuloCaja_Consultas_ConsultaVenta
    Inherits System.Web.UI.Page
    Dim v As New Venta
    Dim tc As New TipoComprobante
    Dim fun As New cFuncionesDB
    Protected Sub btnconsultar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnconsultar.Click
        If Page.IsPostBack = True Then
            If Me.rblista.SelectedIndex = 0 Then
                If Me.ddestado.Text = "Efectivas" Then
                    v.consultaventa("False", Me.clfechadel.SelectedDate, Me.clfechaal.SelectedDate, 1, Me.GridView1)
                End If
                If Me.ddestado.Text = "Anuladas" Then
                    v.consultaventa("True", Me.clfechadel.SelectedDate, Me.clfechaal.SelectedDate, 1, Me.GridView1)
                End If
                If Me.ddestado.Text = "Seleccione" Then
                    Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('Debe seleccionar una opción');</script>"))
                End If
            End If

            If Me.rblista.SelectedIndex = 1 Then
                v.consultaventa(DropDownList1.SelectedValue.ToString, Me.clfechadel.SelectedDate, Me.clfechaal.SelectedDate, 2, Me.GridView1)
            End If

            If Me.rblista.SelectedIndex = 2 Then
                v.consultaventa("", Me.clfechadel.SelectedDate, Me.clfechaal.SelectedDate, 3, Me.GridView1)
            End If
        End If


    End Sub
    Private _compro As String
    Public Property Compro() As String
        Get
            Return (GridView1.Rows(Me.GridView1.SelectedRow.RowIndex).Cells(1).Text)
        End Get
        Set(ByVal value As String)
            _compro = value
        End Set
    End Property

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Page.IsPostBack = False Then
            fun.FillListaOrCombo(tc.ListaTipoComprobante(), DropDownList1, "nomtipocomprobante", "codtipocomprobante")
        End If
    End Sub

    Protected Sub btnDetalle_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDetalle.Click
        Server.Transfer("~/ModuloCaja/Reportes/Reportes.aspx?ind=" & 1 & "&dato=" & Me.Compro.ToString & "", True)
    End Sub

    Protected Sub btnreporte_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnreporte.Click
        If Me.rblista.SelectedIndex = 0 Then
            If Me.ddestado.Text = "Efectivas" Then
                Server.Transfer("~/ModuloCaja/Reportes/Reportes.aspx?ind=" & 2 & "&dato=" & 0 & " &fdel=" & Me.clfechadel.SelectedDate & "&fal=" & Me.clfechaal.SelectedDate & "", True)
            End If
            If Me.ddestado.Text = "Anuladas" Then
                Server.Transfer("~/ModuloCaja/Reportes/Reportes.aspx?ind=" & 2 & "&dato=" & 1 & " &fdel=" & Me.clfechadel.SelectedDate & "&fal=" & Me.clfechaal.SelectedDate & "", True)
            End If
        ElseIf Me.rblista.SelectedIndex = 1 Then
            Server.Transfer("~/ModuloCaja/Reportes/Reportes.aspx?ind=" & 3 & "&dato=" & Me.DropDownList1.SelectedValue & " &fdel=" & Me.clfechadel.SelectedDate & "&fal=" & Me.clfechaal.SelectedDate & "", True)
        ElseIf Me.rblista.SelectedIndex = 2 Then
            Server.Transfer("~/ModuloCaja/Reportes/Reportes.aspx?ind=" & 4 & "&dato="" &fdel=" & Me.clfechadel.SelectedDate & "&fal=" & Me.clfechaal.SelectedDate & "", True)
        End If

    End Sub
End Class
