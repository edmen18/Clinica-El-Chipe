Imports datos
Imports Reglas
Imports System.Data
Imports System.Windows.Forms
Partial Class ModuloCaja_VentaServicio
    Inherits System.Web.UI.Page
    Dim cFun As New cFuncionesDB
    Dim ser As New Servicio
    Dim p As New Paciente
    Dim c As New Comprobante
    Dim tc As New TipoComprobante
    Dim v As New Venta
    Dim detallev As New DetalleVenta
    Dim t As New Turno
    Dim u As New Usuario
    Dim igv As New IGV
    Dim table As New DataTable("tabla")
    Dim TB As DataRow
    Dim i As Integer
    Dim j As Integer
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LblUsu.Text = Request.QueryString("Valor1")

        If Page.IsPostBack = False Then
            LblCodVenta.Text = "V" & cFun.ConsultaUnDato(v.GeneraCodigoVenta, 0)
            TxtCantidad.Text = 1
            cFun.FillListaOrCombo(tc.ListaTipoComprobante(), DdTipoComprobante, "NomTipoComprobante", "CodTipoComprobante")
            DdTipoComprobante.Items.Insert(0, "--Seleccione--")
        End If

        If Page.IsPostBack = False Then
            TxtCantidad.Text = 1
            cFun.FillListaOrCombo(tc.ListaTipoComprobante(), DdTipoComprobante, "NomTipoComprobante", "CodTipoComprobante")
            DdTipoComprobante.Items.Insert(0, "--Seleccione--")
            LblPersonal.Text = cFun.ConsultaUnDato(u.MostrarUsuario(LblUsu.Text), 0)
            LblCodU.Text = cFun.ConsultaUnDato(u.MostrarUsuario(LblUsu.Text), 2)
            LblFecha.Text = Date.Today
            LblHora.Text = TimeOfDay
            If LblHora.Text >= "00:00:00".ToString And LblHora.Text <= "06:59:59".ToString Then
                LblTurno.Text = "Madrugada"
                LblHoraampm.Text = "a.m"
            Else
                If LblHora.Text >= "07:00:00".ToString And LblHora.Text <= "12:59:59".ToString Then
                    LblTurno.Text = "Mañana"
                    LblHoraampm.Text = "a.m"
                Else
                    If LblHora.Text >= "13:00:00".ToString And LblHora.Text <= "18:59:59".ToString Then
                        LblTurno.Text = "Tarde"
                        LblHoraampm.Text = "p.m"
                    Else
                        LblTurno.Text = "Noche"
                        LblHoraampm.Text = "p.m"
                    End If
                End If
            End If
            t.NomTurno = LblTurno.Text
            LblCT.Text = cFun.ConsultaUnDato(t.ListaCodTurno(), 0)
        End If

        'PARA LAS COLUMNAS DEL DATATABLE QUE LLENARA LA GRILLA DE DETALLE
        table.Columns.Add(New DataColumn("codservicio"))
        table.Columns.Add(New DataColumn("servicio"))
        table.Columns.Add(New DataColumn("cantidad"))
        table.Columns.Add(New DataColumn("precio"))
        table.Columns.Add(New DataColumn("subtotal"))
        table.Columns.Add(New DataColumn("Impuesto"))
        table.Columns.Add(New DataColumn("redondeo"))
        table.Columns.Add(New DataColumn("total"))
        table.Columns.Add(New DataColumn("descuento"))
    End Sub
    Sub llenar()
        If CDbl(Me.LblPrecio.Text) > 0 Or Me.LblCodServicio.Text <> "" Then
            If GvListadoServicioF.Rows.Count - 1 >= 0 Then
                For i = 0 To GvListadoServicioF.Rows.Count - 1
                    TB = table.NewRow()
                    TB("codservicio") = GvListadoServicioF.Rows(i).Cells(1).Text
                    TB("servicio") = GvListadoServicioF.Rows(i).Cells(2).Text
                    TB("cantidad") = GvListadoServicioF.Rows(i).Cells(3).Text
                    TB("precio") = GvListadoServicioF.Rows(i).Cells(4).Text
                    TB("subtotal") = GvListadoServicioF.Rows(i).Cells(5).Text
                    table.Rows.Add(TB)
                Next
            End If
            TB = table.NewRow()
            TB("codservicio") = Me.LblCodServicio.Text
            TB("servicio") = Me.lblservicio.Text
            TB("cantidad") = Me.TxtCantidad.Text
            TB("precio") = Me.LblPrecio.Text
            TB("subtotal") = (CDbl(Me.LblPrecio.Text) * CDbl(Me.TxtCantidad.Text))
            table.Rows.Add(TB)
            GvListadoServicioF.DataSource = table
            GvListadoServicioF.DataBind()
        End If
    End Sub
    Sub listar()
        Dim sql As String
        sql = "Select CodServicio,NomServicio,Precio from servicio where NomServicio like '%" + Me.TxtBuscar.Text + "%'"
        cFun.FillDataGridView(sql, GvListadoServicio)
    End Sub

    Protected Sub GvListadoServicio_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GvListadoServicio.SelectedIndexChanged
        LblCodServicio.Text = Trim(GvListadoServicio.Rows(GvListadoServicio.SelectedRow.RowIndex).Cells(1).Text)
        lblservicio.Text = Trim(GvListadoServicio.Rows(GvListadoServicio.SelectedRow.RowIndex).Cells(2).Text)
        LblPrecio.Text = Trim(GvListadoServicio.Rows(GvListadoServicio.SelectedRow.RowIndex).Cells(3).Text)
    End Sub

    Protected Sub Gvpacientes_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Gvpacientes.SelectedIndexChanged
        LblCodPaciente.Text = Trim(Gvpacientes.Rows(Gvpacientes.SelectedRow.RowIndex).Cells(1).Text)
        txtpaciente.Text = Trim(Gvpacientes.Rows(Gvpacientes.SelectedRow.RowIndex).Cells(2).Text)
        LblNHC.Text = Trim(Gvpacientes.Rows(Gvpacientes.SelectedRow.RowIndex).Cells(3).Text)
    End Sub
    Sub calcular()
        Me.LblTotal.Text = "0.00"
        For i = 0 To GvListadoServicioF.Rows.Count - 1
            Me.LblTotal.Text = CDbl(Me.LblTotal.Text) + CDbl(GvListadoServicioF.Rows(i).Cells(5).Text)
        Next
        LblCodCom.Text = Format(CInt(c.GeneraCodigoComprobante()) + 1)
    End Sub
    Sub ELIMINARFILA()
        i = GvListadoServicioF.SelectedIndex
        If GvListadoServicioF.Rows.Count - 1 >= 0 Then
            For i = 0 To GvListadoServicioF.Rows.Count - 1
                TB = table.NewRow()
                TB("codservicio") = GvListadoServicioF.Rows(i).Cells(1).Text
                TB("servicio") = GvListadoServicioF.Rows(i).Cells(2).Text
                TB("cantidad") = GvListadoServicioF.Rows(i).Cells(3).Text
                TB("precio") = GvListadoServicioF.Rows(i).Cells(4).Text
                TB("subtotal") = GvListadoServicioF.Rows(i).Cells(5).Text
                table.Rows.Add(TB)
            Next
            i = Me.GvListadoServicioF.SelectedIndex
            table.Rows.RemoveAt(i)
            Me.GvListadoServicioF.DataSource = table
            Me.GvListadoServicioF.DataBind()
        End If
    End Sub
    Protected Sub GvListadoServicioF_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GvListadoServicioF.SelectedIndexChanged
        ELIMINARFILA()
        calcular()
    End Sub

    Protected Sub LinkButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkButton1.Click
        Server.Transfer("~/ModuloCaja/ModuloCaja.aspx?Valor1=" + LblUsu.Text)
    End Sub

    Protected Sub btnbuscarpaciente_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles BtnBuscarPaciente.Click
        p.BusquedaPaciente(txtpaciente.Text, Gvpacientes)
    End Sub

    Protected Sub BtnBuscar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles BtnBuscar.Click
        cFun.FillDataGridView(ser.ListarServicio2(TxtBuscar.Text), GvListadoServicio)
        GvListadoServicio.Visible = True
    End Sub

    Protected Sub btnagregar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles BtnAgregar.Click
        llenar()
    End Sub

    Protected Sub btncalcular_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles BtnCalcular.Click
        calcular()
    End Sub

    Protected Sub DdTipoComprobante_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DdTipoComprobante.SelectedIndexChanged
        If DdTipoComprobante.SelectedItem.Text = "Boleta" Then
            Label29.Visible = True
            TxtNumSerie.Visible = True
            Label30.Visible = True
            TxtCorreInicio.Visible = True
            Label36.Visible = True
            TxtCorreFin.Visible = True
            Label37.Visible = True
            TxtCorreIntermedio.Visible = True
            Label40.Visible = False
            Label41.Visible = False
            LblTotalIGV.Visible = False
            LblCodIGV.Text = ""
            LblIGV.Text = ""
            LblIGV.Visible = False
            LblTotalIGV.Text = ""
        Else
            Label29.Visible = False
            TxtNumSerie.Visible = False
            Label30.Visible = False
            TxtCorreInicio.Visible = False
            Label36.Visible = False
            TxtCorreFin.Visible = False
            Label37.Visible = False
            TxtCorreIntermedio.Visible = False
            Label40.Visible = True
            LblIGV.Visible = True
            Label41.Visible = True
            LblTotalIGV.Visible = True
            LblCodIGV.Text = cFun.ConsultaUnDato(igv.MuestraIGV(), 0)
            LblIGV.Text = cFun.ConsultaUnDato(igv.MuestraIGV(), 1)
            LblTotalIGV.Text = Val(LblTotal.Text) + (Val(LblTotal.Text) * Val(LblIGV.Text))
        End If
    End Sub

    Protected Sub BtnGuardar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles BtnGuardar.Click
        Dim hora As String
        Dim a As String = "0"
        hora = LblHora.Text & " " & LblHoraampm.Text
        If LblCodVenta.Text = "" Or LblCodPaciente.Text = "" Or LblTotal.Text = "" Then
            Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('No es posible guardar el registro porque los datos están incompletos');</script>"))
        Else
            If v.AgregarVenta(LblCodVenta.Text, "A00002", LblCT.Text, LblCodU.Text, LblCodPaciente.Text, CDbl(LblTotal.Text), "V", LblFecha.Text, hora, "False", LblCodIGV.Text, LblTotalIGV.Text) = True Then
            Else
                Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('No es posible guardar los datos');</script>"))
            End If
        End If

        If LblCodVenta.Text = "" Or LblCodServicio.Text = "" Or LblPrecio.Text = "" Or LblTotal.Text = "" Then
            Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('No es posible guardar el registro porque los datos están incompletos');</script>"))
        Else

            For i = 0 To Me.GvListadoServicioF.Rows.Count - 1
                If detallev.AgregarDetalleVenta(LblCodVenta.Text, GvListadoServicioF.Rows(i).Cells(1).Text, "", GvListadoServicioF.Rows(i).Cells(3).Text, GvListadoServicioF.Rows(i).Cells(4).Text, GvListadoServicioF.Rows(i).Cells(5).Text) = True Then
                Else
                    Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('No es posible guardar los datos');</script>"))
                End If
            Next
        End If

        If LblCodCom.Text = "" Or DdTipoComprobante.Text = "" Or LblCodVenta.Text = "" Then
            Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('No es posible guardar el registro porque los datos están incompletos');</script>"))
        Else
            If DdTipoComprobante.SelectedItem.Text = "Boleta" Then
                If c.AgregarComprobante(LblCodCom.Text, DdTipoComprobante.Text, LblFecha.Text, hora, TxtNumSerie.Text, TxtCorreInicio.Text, TxtCorreFin.Text, TxtCorreIntermedio.Text, LblCodVenta.Text, "False") = True Then
                    MessageBox.Show("Datos guardados correctamente", "Sistema de Consultas e Historias Clinicas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                    Server.Transfer("~/ModuloCaja/ModuloCaja.aspx?Valor1=" + LblUsu.Text)
                Else
                    Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('No es posible guardar los datos');</script>"))
                End If
            Else
                If c.AgregarComprobante(LblCodCom.Text, DdTipoComprobante.Text, LblFecha.Text, hora, a, a, a, a, LblCodVenta.Text, "False") = True Then
                    MessageBox.Show("Datos guardados correctamente", "Sistema de Consultas e Historias Clinicas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                    Server.Transfer("~/ModuloCaja/ModuloCaja.aspx?Valor1=" + LblUsu.Text)
                Else
                    Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('No es posible guardar los datos');</script>"))
                End If
            End If
        End If
    End Sub
End Class
