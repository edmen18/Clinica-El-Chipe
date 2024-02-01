Imports datos
Imports Reglas
Imports System.Windows.Forms
Partial Class ModuloCaja_VentaConsulta
    Inherits System.Web.UI.Page
    Dim cFun As New cFuncionesDB
    Dim ser As New Servicio
    Dim c As New Comprobante
    Dim tc As New TipoComprobante
    Dim v As New Venta
    Dim detallev As New DetalleVenta
    Dim t As New Turno
    Dim u As New Usuario
    Dim i As New IGV
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not PreviousPage Is Nothing Then
            LblNHC.Text = PreviousPage._Texto1
            LblPaciente.Text = PreviousPage._Texto2
            LblNumTicket.Text = PreviousPage._Texto3
            LblCodPaciente.Text = PreviousPage._Texto4
            LblCodVenta.Text = PreviousPage._Texto5
            LblEspecialidad.Text = PreviousPage._Texto6
            LblCodEspecialidad.Text = PreviousPage._Texto7
        End If
        LblUsu.Text = Request.QueryString("Valor1")
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
    End Sub
    Sub listar()
        Dim sql As String
        sql = "Select CodServicio,NomServicio,Precio from servicio where NomServicio like '%" + Me.TxtBuscar.Text + "%'"
        cFun.FillDataGridView(sql, GvListadoServicio)
    End Sub
    Protected Sub GvListadoServicio_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GvListadoServicio.SelectedIndexChanged
        LblCodServicio.Text = Trim(GvListadoServicio.Rows(GvListadoServicio.SelectedRow.RowIndex).Cells(1).Text)
        LblPrecio.Text = Trim(GvListadoServicio.Rows(GvListadoServicio.SelectedRow.RowIndex).Cells(3).Text)
        LblTotal.Text = Val(LblPrecio.Text) * Val(TxtCantidad.Text)
        If c.GeneraCodigoComprobante() = "" Then
            LblCodCom.Text = 1
        Else
            LblCodCom.Text = Format(CInt(c.GeneraCodigoComprobante()) + 1)
        End If
    End Sub

    Protected Sub LinkButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkButton1.Click
        Server.Transfer("~/ModuloCaja/ModuloCaja.aspx?Valor1=" + LblUsu.Text)
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
            LblCodIGV.Text = cFun.ConsultaUnDato(i.MuestraIGV(), 0)
            LblIGV.Text = cFun.ConsultaUnDato(i.MuestraIGV(), 1)
            LblTotalIGV.Text = Val(LblTotal.Text) + (Val(LblTotal.Text) * Val(LblIGV.Text))
        End If
    End Sub

    Protected Sub BtnRegistrar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles BtnRegistrar.Click
        Dim hora As String
        Dim a As String = "0"
        hora = LblHora.Text & " " & LblHoraampm.Text
        If LblCodVenta.Text = "" Or LblCodPaciente.Text = "" Or LblTotal.Text = "" Then
            Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('No es posible guardar el registro porque los datos están incompletos');</script>"))
        Else
            If v.AgregarVenta2(LblCodVenta.Text, "A00002", LblCT.Text, LblCodU.Text, LblCodPaciente.Text, Val(LblTotal.Text), "V", LblFecha.Text, hora, "False", LblCodIGV.Text, LblTotalIGV.Text) = True Then
            Else
                Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('No es posible guardar los datos');</script>"))
            End If
        End If
        If LblCodVenta.Text = "" Or LblCodServicio.Text = "" Or LblPrecio.Text = "" Or LblTotal.Text = "" Then
            Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('No es posible guardar el registro porque los datos están incompletos');</script>"))
        Else
            If detallev.AgregarDetalleVenta(LblCodVenta.Text, LblCodServicio.Text, "", TxtCantidad.Text, Val(LblPrecio.Text), Val(LblTotal.Text)) = True Then
            Else
                Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('No es posible guardar los datos');</script>"))
            End If
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

    Protected Sub BtnBuscar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles BtnBuscar.Click
        cFun.FillDataGridView(ser.ListarServicio(TxtBuscar.Text), GvListadoServicio)
        GvListadoServicio.Visible = True
    End Sub
End Class
