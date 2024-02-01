Imports datos
Imports Reglas
Imports System.Windows.Forms
Partial Class ModuloAdmision_HistoriaClinica
    Inherits System.Web.UI.Page
    Dim cFun As New cFuncionesDB
    Dim ec As New EstadoCivil
    Dim tdi As New TipoDocIdentidad
    Dim p As New Pais
    Dim d As New Departamento
    Dim pro As New Provincia
    Dim dis As New Distrito
    Dim cp As New CentroPoblado
    Dim paci As New Paciente
    Dim hc As New HistoriaClinica
    Dim dire As New Direccion
    Dim u As New Usuario
    Dim t As New Turno
    Dim ValidChars As Integer
    Dim v As New Vali
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LblUsu.Text = Request.QueryString("Valor1")
        If Page.IsPostBack = False Then
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
            TxtApellidoPaterno.Text.ToUpper()
        End If
    End Sub

    Sub Nuevo()
        DdSeguro.Enabled = True
        DdAutogenerado.Enabled = True
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TxtFechaAfiliacion.Enabled = True
        TxtFechaVencimiento.Enabled = True
        TxtApellidoPaterno.Enabled = True
        TxtApellidoMaterno.Enabled = True
        TxtNombres.Enabled = True
        TxtFechaNacimiento.Enabled = True
        DdSexo.Enabled = True
        DdEstadoCivil.Enabled = True
        TxtOcupacion.Enabled = True
        DdTipoDocIdentidad.Enabled = True
        TxtTelefono.Enabled = True
        TxtCelular.Enabled = True
        TxtEmail.Enabled = True
        BtnBuscaPais.Enabled = True
        BtnBuscaDepa.Enabled = True
        BtnBuscaProvincia.Enabled = True
        BtnBuscaDistrito.Enabled = True
        BtnBuscaCentroPoblado.Enabled = True
        BtnBuscaLugarOrigen.Enabled = True
        DdPais.Enabled = True
        DdDepartamento.Enabled = True
        DdProvincia.Enabled = True
        DdDistrito.Enabled = True
        DdCentroPoblado.Enabled = True
        DdLugarOrigen.Enabled = True
        DdDato1.Enabled = True
        DdDato2.Enabled = True
        TxtDato1.Enabled = True
        TxtDato2.Enabled = True
        BtnNuevo.Enabled = False
        BtnRegistrar.Enabled = True
        DdAutogenerado.Items.Add("280")
        DdAutogenerado.Items.Add("310")
    End Sub
    Protected Sub DdAutogenerado_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DdAutogenerado.SelectedIndexChanged
        LblAutoge.Text = DdAutogenerado.SelectedValue.ToString
    End Sub
    Protected Sub DdDato2_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DdDato2.SelectedIndexChanged
        If DdDato2.SelectedItem.ToString = "Manzana" Then
            Label35.Visible = True
            TxtLote.Visible = True
        Else
            Label35.Visible = False
            TxtLote.Visible = False
        End If
    End Sub
    Protected Sub DdPais_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DdPais.SelectedIndexChanged
        DdProvincia.Items.Clear()
        DdDistrito.Items.Clear()
        DdCentroPoblado.Items.Clear()
        DdDepartamento.Items.Clear()
        cFun.FillListaOrCombo(d.ListaD(DdPais.Text), DdDepartamento, "NomDepartamento", "CodDepartamento")
        DdDepartamento.Items.Insert(0, "Seleccione un Departamento")
    End Sub
    Protected Sub DdDepartamento_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DdDepartamento.SelectedIndexChanged
        DdProvincia.Items.Clear()
        DdDistrito.Items.Clear()
        DdCentroPoblado.Items.Clear()
        cFun.FillListaOrCombo(pro.ListaP(DdDepartamento.Text), DdProvincia, "NomProvincia", "CodProvincia")
        DdProvincia.Items.Insert(0, "Seleccione una Provincia")
    End Sub
    Protected Sub DdProvincia_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DdProvincia.SelectedIndexChanged
        DdDistrito.Items.Clear()
        DdCentroPoblado.Items.Clear()
        cFun.FillListaOrCombo(dis.ListaD(DdProvincia.Text), DdDistrito, "NomDistrito", "CodDistrito")
        DdDistrito.Items.Insert(0, "Seleccione un Distrito")
    End Sub
    Protected Sub DdDistrito_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DdDistrito.SelectedIndexChanged
        DdCentroPoblado.Items.Clear()
        cFun.FillListaOrCombo(cp.ListaCP(DdDistrito.Text), DdCentroPoblado, "NomCentroPoblado", "CodCentroPoblado")
        DdCentroPoblado.Items.Insert(0, "Seleccione un Centro Poblado")
    End Sub

    Sub cancelar()
        DdSeguro.Items.Clear()
        DdAutogenerado.Items.Clear()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TxtFechaAfiliacion.Text = ""
        TxtFechaVencimiento.Text = ""
        TxtApellidoPaterno.Text = ""
        TxtApellidoMaterno.Text = ""
        TxtNombres.Text = ""
        TxtFechaNacimiento.Text = ""
        DdSexo.Items.Clear()
        DdEstadoCivil.Items.Clear()
        TxtOcupacion.Text = ""
        DdTipoDocIdentidad.Items.Clear()
        TxtNumero.Text = ""
        TxtTelefono.Text = ""
        TxtCelular.Text = ""
        TxtEmail.Text = ""
        DdPais.Items.Clear()
        DdDepartamento.Items.Clear()
        DdProvincia.Items.Clear()
        DdDistrito.Items.Clear()
        DdCentroPoblado.Items.Clear()
        DdLugarOrigen.Items.Clear()
        DdDato1.Items.Clear()
        DdDato2.Items.Clear()
        TxtDato1.Text = ""
        TxtDato2.Text = ""
        LblNHistoriaClinica.Text = ""
        LblFechaApertura.Text = ""
        LblCodDireccion.Text = ""
        LblCodRegistroSeguro.Text = ""
        LblCodPaciente.Text = ""
        LblCodUsuario.Text = ""
        LblClave.Text = ""
        LblAutoge.Text = ""
        LblNumAutogenerado.Text = ""
        LblAutogenerado.Text = ""
        LblCodEstadoCivil.Text = ""
        LblCodSeguro.Text = ""
        LblCodTipoDocIdentidad.Text = ""
        LblPaciente.Text = ""
        LblNumero.Text = ""

        DdSeguro.Enabled = False
        DdAutogenerado.Enabled = False
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TxtFechaAfiliacion.Enabled = False
        TxtFechaVencimiento.Enabled = False
        TxtApellidoPaterno.Enabled = False
        TxtApellidoMaterno.Enabled = False
        TxtNombres.Enabled = False
        TxtFechaNacimiento.Enabled = False
        DdSexo.Enabled = False
        DdEstadoCivil.Enabled = False
        TxtOcupacion.Enabled = False
        DdTipoDocIdentidad.Enabled = False
        TxtNumero.Enabled = False
        TxtTelefono.Enabled = False
        TxtCelular.Enabled = False
        TxtEmail.Enabled = False
        BtnBuscaPais.Enabled = False
        BtnBuscaDepa.Enabled = False
        BtnBuscaProvincia.Enabled = False
        BtnBuscaDistrito.Enabled = False
        BtnBuscaCentroPoblado.Enabled = False
        BtnBuscaLugarOrigen.Enabled = False
        DdPais.Enabled = False
        DdDepartamento.Enabled = False
        DdProvincia.Enabled = False
        DdDistrito.Enabled = False
        DdCentroPoblado.Enabled = False
        DdLugarOrigen.Enabled = False
        DdDato1.Enabled = False
        DdDato2.Enabled = False
        TxtDato1.Enabled = False
        TxtDato2.Enabled = False
        BtnNuevo.Enabled = True
        BtnRegistrar.Enabled = False
        LblUsuario.Text = ""
        BtnBuscar.Enabled = True
        BtnModificar.Enabled = False
        BtnImprimir.Enabled = False
        Label1.Visible = False
        Label11.Visible = False
        Label14.Visible = False
        DdAutogenerado.Visible = False
        TextBox1.Visible = False
        TextBox2.Visible = False
        LblNumAutogenerado.Visible = False
        TxtFechaAfiliacion.Visible = False
        TxtFechaVencimiento.Visible = False
    End Sub

    Protected Sub GvHCPaciente_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GvHCPaciente.SelectedIndexChanged
        LblNHistoriaClinica.Text = Trim(GvHCPaciente.Rows(GvHCPaciente.SelectedRow.RowIndex).Cells(1).Text)
        LblCodPaciente.Text = Trim(GvHCPaciente.Rows(GvHCPaciente.SelectedRow.RowIndex).Cells(2).Text)
        If Trim(GvHCPaciente.Rows(GvHCPaciente.SelectedRow.RowIndex).Cells(3).Text) = "&nbsp;" Then
            TxtApellidoPaterno.Text = ""
        Else
            TxtApellidoPaterno.Text = Trim(GvHCPaciente.Rows(GvHCPaciente.SelectedRow.RowIndex).Cells(3).Text)
        End If
        If Trim(GvHCPaciente.Rows(GvHCPaciente.SelectedRow.RowIndex).Cells(4).Text) = "&nbsp;" Then
            TxtApellidoMaterno.Text = ""
        Else
            TxtApellidoMaterno.Text = Trim(GvHCPaciente.Rows(GvHCPaciente.SelectedRow.RowIndex).Cells(4).Text)
        End If
        If Trim(GvHCPaciente.Rows(GvHCPaciente.SelectedRow.RowIndex).Cells(5).Text) = "&nbsp;" Then
            TxtNombres.Text = ""
        Else
            TxtNombres.Text = Trim(GvHCPaciente.Rows(GvHCPaciente.SelectedRow.RowIndex).Cells(5).Text)
        End If
        If Trim(GvHCPaciente.Rows(GvHCPaciente.SelectedRow.RowIndex).Cells(6).Text) = "&nbsp;" Then
            TxtFechaNacimiento.Text = ""
        Else
            TxtFechaNacimiento.Text = Trim(GvHCPaciente.Rows(GvHCPaciente.SelectedRow.RowIndex).Cells(6).Text)
        End If
        If Trim(GvHCPaciente.Rows(GvHCPaciente.SelectedRow.RowIndex).Cells(7).Text) = "&nbsp;" Then
            LblCodTipoDocIdentidad.Text = ""
        Else
            LblCodTipoDocIdentidad.Text = Trim(GvHCPaciente.Rows(GvHCPaciente.SelectedRow.RowIndex).Cells(7).Text)
        End If
        cFun.FillListaOrCombo(tdi.ListaTipoDocIdentidad(), DdTipoDocIdentidad, "NomTipoDoc", "CodTipoDocIdentidad")
        DdTipoDocIdentidad.Items.Insert(0, Trim(GvHCPaciente.Rows(GvHCPaciente.SelectedRow.RowIndex).Cells(8).Text))
        If Trim(GvHCPaciente.Rows(GvHCPaciente.SelectedRow.RowIndex).Cells(9).Text) = "&nbsp;" Then
            TxtNumero.Text = ""
        Else
            TxtNumero.Text = Trim(GvHCPaciente.Rows(GvHCPaciente.SelectedRow.RowIndex).Cells(9).Text)
        End If
        If Trim(GvHCPaciente.Rows(GvHCPaciente.SelectedRow.RowIndex).Cells(10).Text) = "&nbsp;" Then
            LblCodEstadoCivil.Text = ""
        Else
            LblCodEstadoCivil.Text = Trim(GvHCPaciente.Rows(GvHCPaciente.SelectedRow.RowIndex).Cells(10).Text)
        End If
        cFun.FillListaOrCombo(ec.ListaEstadoCivil(), DdEstadoCivil, "NomEstadoCivil", "CodEstadoCivil")
        DdEstadoCivil.Items.Insert(0, Trim(GvHCPaciente.Rows(GvHCPaciente.SelectedRow.RowIndex).Cells(11).Text))
        If Trim(GvHCPaciente.Rows(GvHCPaciente.SelectedRow.RowIndex).Cells(12).Text) = "" Then
            LblCodDireccion.Text = ""
        Else
            LblCodDireccion.Text = Trim(GvHCPaciente.Rows(GvHCPaciente.SelectedRow.RowIndex).Cells(12).Text)
        End If

        DdDato1.Items.Add("Niguno")
        DdDato1.Items.Add("Calle")
        DdDato1.Items.Add("Avenida")
        DdDato1.Items.Insert(0, Trim(GvHCPaciente.Rows(GvHCPaciente.SelectedRow.RowIndex).Cells(13).Text))

        If Trim(GvHCPaciente.Rows(GvHCPaciente.SelectedRow.RowIndex).Cells(14).Text) = "&nbsp;" Then
            TxtDato1.Text = ""
        Else
            TxtDato1.Text = Trim(GvHCPaciente.Rows(GvHCPaciente.SelectedRow.RowIndex).Cells(14).Text)
        End If
        DdDato2.Items.Add("Niguno")
        DdDato2.Items.Add("Numero")
        DdDato2.Items.Add("Manzana")
        DdDato2.Items.Insert(0, Trim(GvHCPaciente.Rows(GvHCPaciente.SelectedRow.RowIndex).Cells(15).Text))
        If Trim(GvHCPaciente.Rows(GvHCPaciente.SelectedRow.RowIndex).Cells(16).Text) = "&nbsp;" Then
            TxtDato2.Text = ""
        Else
            TxtDato2.Text = Trim(GvHCPaciente.Rows(GvHCPaciente.SelectedRow.RowIndex).Cells(16).Text)
        End If

        If Trim(GvHCPaciente.Rows(GvHCPaciente.SelectedRow.RowIndex).Cells(17).Text) = "&nbsp;" Then
            TxtLote.Text = ""
        Else
            TxtLote.Text = Trim(GvHCPaciente.Rows(GvHCPaciente.SelectedRow.RowIndex).Cells(17).Text)
        End If

        DdCentroPoblado.Items.Insert(0, Trim(GvHCPaciente.Rows(GvHCPaciente.SelectedRow.RowIndex).Cells(18).Text))
        DdDistrito.Items.Insert(0, Trim(GvHCPaciente.Rows(GvHCPaciente.SelectedRow.RowIndex).Cells(19).Text))

        DdProvincia.Items.Insert(0, Trim(GvHCPaciente.Rows(GvHCPaciente.SelectedRow.RowIndex).Cells(20).Text))
        cFun.FillListaOrCombo(d.ListaDepartamento(), DdDepartamento, "NomDepartamento", "CodDepartamento")
        DdDepartamento.Items.Insert(0, Trim(GvHCPaciente.Rows(GvHCPaciente.SelectedRow.RowIndex).Cells(21).Text))
        cFun.FillListaOrCombo(p.ListaPais(), DdPais, "NomPais", "CodPais")
        DdPais.Items.Insert(0, Trim(GvHCPaciente.Rows(GvHCPaciente.SelectedRow.RowIndex).Cells(22).Text))
        DdLugarOrigen.Items.Insert(0, Trim(GvHCPaciente.Rows(GvHCPaciente.SelectedRow.RowIndex).Cells(23).Text))

        If Trim(GvHCPaciente.Rows(GvHCPaciente.SelectedRow.RowIndex).Cells(24).Text) = "&nbsp;" Then
            LblCodRegistroSeguro.Text = ""
        Else
            LblCodRegistroSeguro.Text = Trim(GvHCPaciente.Rows(GvHCPaciente.SelectedRow.RowIndex).Cells(24).Text)
        End If

        If Trim(GvHCPaciente.Rows(GvHCPaciente.SelectedRow.RowIndex).Cells(25).Text) = "&nbsp;" Then
            LblCodSeguro.Text = ""
        Else
            LblCodSeguro.Text = Trim(GvHCPaciente.Rows(GvHCPaciente.SelectedRow.RowIndex).Cells(25).Text)
        End If
        If Trim(GvHCPaciente.Rows(GvHCPaciente.SelectedRow.RowIndex).Cells(27).Text) = "&nbsp;" Then
            LblNumAutogenerado.Text = ""
        Else
            Label1.Visible = True
            Label11.Visible = True
            Label14.Visible = True
            DdAutogenerado.Visible = True
            TextBox1.Visible = True
            TextBox2.Visible = True
            LblNumAutogenerado.Visible = True
            TxtFechaAfiliacion.Visible = True
            TxtFechaVencimiento.Visible = True
            LblNumAutogenerado.Text = Trim(GvHCPaciente.Rows(GvHCPaciente.SelectedRow.RowIndex).Cells(27).Text)
        End If
        If Trim(GvHCPaciente.Rows(GvHCPaciente.SelectedRow.RowIndex).Cells(28).Text) = "&nbsp;" Then
            TxtFechaAfiliacion.Text = ""
        Else
            TxtFechaAfiliacion.Text = Trim(GvHCPaciente.Rows(GvHCPaciente.SelectedRow.RowIndex).Cells(28).Text)
        End If
        If Trim(GvHCPaciente.Rows(GvHCPaciente.SelectedRow.RowIndex).Cells(29).Text) = "&nbsp;" Then
            TxtFechaVencimiento.Text = ""
        Else
            TxtFechaVencimiento.Text = Trim(GvHCPaciente.Rows(GvHCPaciente.SelectedRow.RowIndex).Cells(29).Text)
        End If
        If Trim(GvHCPaciente.Rows(GvHCPaciente.SelectedRow.RowIndex).Cells(30).Text) = "&nbsp;" Then
            LblFechaApertura.Text = ""
        Else
            LblFechaApertura.Text = Trim(GvHCPaciente.Rows(GvHCPaciente.SelectedRow.RowIndex).Cells(30).Text)
        End If
        DdSexo.Items.Add("M")
        DdSexo.Items.Add("F")
        DdSexo.Items.Insert(0, Trim(GvHCPaciente.Rows(GvHCPaciente.SelectedRow.RowIndex).Cells(31).Text))
        If Trim(GvHCPaciente.Rows(GvHCPaciente.SelectedRow.RowIndex).Cells(32).Text) = "&nbsp;" Then
            TxtOcupacion.Text = ""
        Else
            TxtOcupacion.Text = Trim(GvHCPaciente.Rows(GvHCPaciente.SelectedRow.RowIndex).Cells(32).Text)
        End If
        If Trim(GvHCPaciente.Rows(GvHCPaciente.SelectedRow.RowIndex).Cells(33).Text) = "&nbsp;" Then
            TxtCelular.Text = ""
        Else
            TxtCelular.Text = Trim(GvHCPaciente.Rows(GvHCPaciente.SelectedRow.RowIndex).Cells(33).Text)
        End If
        If Trim(GvHCPaciente.Rows(GvHCPaciente.SelectedRow.RowIndex).Cells(34).Text).ToString = "&nbsp;" Then
            TxtTelefono.Text = ""
        Else
            TxtTelefono.Text = Trim(GvHCPaciente.Rows(GvHCPaciente.SelectedRow.RowIndex).Cells(34).Text)
        End If
        If Trim(GvHCPaciente.Rows(GvHCPaciente.SelectedRow.RowIndex).Cells(35).Text) = "&nbsp;" Then
            TxtEmail.Text = ""
        Else
            TxtEmail.Text = Trim(GvHCPaciente.Rows(GvHCPaciente.SelectedRow.RowIndex).Cells(35).Text)
        End If
        BtnModificar.Enabled = True
        Nuevo()
        LblAutoge.Text = "280"
        Panel8.Visible = False
        BtnImprimir.Enabled = True
    End Sub

    Protected Sub DdSeguro_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DdSeguro.SelectedIndexChanged
        If DdSeguro.SelectedItem.Text = "SIS" Then
            Label1.Visible = True
            Label11.Visible = True
            Label14.Visible = True
            DdAutogenerado.Visible = True
            TextBox1.Visible = True
            TextBox2.Visible = True
            LblNumAutogenerado.Visible = True
            TxtFechaAfiliacion.Visible = True
            TxtFechaVencimiento.Visible = True
        Else
            DdAutogenerado.Visible = True
            TextBox1.Text = ""
            TextBox2.Text = ""
            LblNumAutogenerado.Text = ""
            TxtFechaAfiliacion.Text = ""
            TxtFechaVencimiento.Text = ""
            Label1.Visible = False
            Label11.Visible = False
            Label14.Visible = False
            DdAutogenerado.Visible = False
            TextBox1.Visible = False
            TextBox2.Visible = False
            LblNumAutogenerado.Visible = False
            TxtFechaAfiliacion.Visible = False
            TxtFechaVencimiento.Visible = False
        End If
    End Sub

    Protected Sub LinkButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkButton1.Click
        Server.Transfer("~/ModuloAdmision/ModuloAdmision.aspx?Valor1=" + LblUsu.Text)
    End Sub

    Protected Sub BtnRegistrar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles BtnRegistrar.Click
        Dim a As Date
        a = "01/01/1900"
        LblAutogenerado.Text = LblAutoge.Text + TextBox1.Text + TextBox2.Text

        If dire.GeneraCodigoDireccion() = "" Then
            LblCodDireccion.Text = 1
        Else
            LblCodDireccion.Text = CStr(CInt(dire.GeneraCodigoDireccion()) + 1)
        End If
        If paci.GeneraCodigoPaciente() = "" Then
            LblCodPaciente.Text = 1
        Else
            LblCodPaciente.Text = CStr(CInt(paci.GeneraCodigoPaciente()) + 1)
        End If
        If u.GeneraCodigoUsuario() = "" Then
            LblCodUsuario.Text = 1
        Else
            LblCodUsuario.Text = CStr(CInt(u.GeneraCodigoUsuario()) + 1)
        End If
        If hc.GeneraCodigoHistoriaClinica() = "" Then
            LblNHistoriaClinica.Text = 1
        Else
            LblNHistoriaClinica.Text = CStr(CInt(hc.GeneraCodigoHistoriaClinica()) + 1)
        End If

        If LblCodDireccion.Text = "" Or TxtDato1.Text = "" Or TxtDato1.Text = "" Or TxtDato2.Text = "" Or DdCentroPoblado.Text = "" Then
            Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('No es posible guardar el registro porque los datos están incompletos');</script>"))
        Else
            If dire.AgregarDireccion(LblCodDireccion.Text, DdDato1.SelectedItem.ToString, TxtDato1.Text, DdDato2.SelectedItem.ToString, TxtDato2.Text, TxtLote.Text, DdCentroPoblado.Text) = True Then
            Else
                Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('No es posible guardar los datos');</script>"))
            End If
        End If

        LblUsuario.Text = "P" + LblNHistoriaClinica.Text + LblCodPaciente.Text + TxtApellidoPaterno.Text
        LblClave.Text = "123456"

        If LblCodUsuario.Text = "" Or LblUsuario.Text = "" Or LblClave.Text = "" Then
            Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('No es posible guardar el registro porque los datos están incompletos');</script>"))
        Else
            If u.AgregarUsuario(LblCodUsuario.Text, LblUsuario.Text, LblClave.Text, "True", "TU02") = True Then
            Else
                Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('No es posible guardar los datos');</script>"))
            End If
        End If

        If LblCodPaciente.Text = "" Or TxtNombres.Text = "" Or TxtApellidoPaterno.Text = "" Or TxtApellidoMaterno.Text = "" Or TxtFechaNacimiento.Text = "" Or TxtOcupacion.Text = "" Or TxtNumero.Text = "" Or LblCodDireccion.Text = "" Or LblCodRegistroSeguro.Text = "" Or LblCodUsuario.Text = "" Then
            Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('No es posible guardar el registro porque los datos están incompletos');</script>"))
        Else
            If paci.AgregarPaciente(LblCodPaciente.Text, TxtNombres.Text, TxtApellidoPaterno.Text, TxtApellidoMaterno.Text, DdTipoDocIdentidad.Text, TxtFechaNacimiento.Text, LblCodDireccion.Text, DdSexo.SelectedItem.ToString, DdEstadoCivil.Text, TxtOcupacion.Text, TxtCelular.Text, TxtTelefono.Text, TxtEmail.Text, LblCodRegistroSeguro.Text, LblCodUsuario.Text, TxtNumero.Text, DdLugarOrigen.SelectedItem.ToString) = True Then
            Else
                Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('No es posible guardar los datos');</script>"))
            End If
        End If

        If LblNHistoriaClinica.Text = "" Or LblFechaApertura.Text = "" Or LblCodPaciente.Text = "" Then
            Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('No es posible guardar el registro porque los datos están incompletos');</script>"))
        Else
            If hc.AgregarHistoriaClinica(LblNHistoriaClinica.Text, LblFechaApertura.Text, LblCodPaciente.Text, "aaaaa") = True Then
                MessageBox.Show("Datos guardados correctamente", "Sistema de Consultas e Historias Clinicas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                MessageBox.Show("IMPORTANTE. Comunicarle al paciente que su Usuario es " + LblUsuario.Text + " y su clave por defecto es " + LblClave.Text + ". Esta clave tiene que cambiarla inmediatamente", "Sistema de Consultas e Historias Clinicas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                cancelar()
            Else
                Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('No es posible guardar los datos');</script>"))
            End If
        End If
        BtnNuevo.Enabled = True
        BtnRegistrar.Enabled = False
    End Sub

    Protected Sub BtnNuevo_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles BtnNuevo.Click
        DdSexo.Items.Add("M")
        DdSexo.Items.Add("F")
        cFun.FillListaOrCombo(tdi.ListaTipoDocIdentidad(), DdTipoDocIdentidad, "NomTipoDoc", "CodTipoDocIdentidad")
        DdTipoDocIdentidad.Items.Insert(0, "Seleccione un tipo de Doc.")
        cFun.FillListaOrCombo(ec.ListaEstadoCivil(), DdEstadoCivil, "NomEstadoCivil", "CodEstadoCivil")
        DdEstadoCivil.Items.Insert(0, "Seleccione estado civil")
        LblAutoge.Text = "280"
        LblFechaApertura.Text = LblFecha.Text
        If dire.GeneraCodigoDireccion() = "" Then
            LblCodDireccion.Text = 1
        Else
            LblCodDireccion.Text = CStr(CInt(dire.GeneraCodigoDireccion()) + 1)
        End If
        If paci.GeneraCodigoPaciente() = "" Then
            LblCodPaciente.Text = 1
        Else
            LblCodPaciente.Text = CStr(CInt(paci.GeneraCodigoPaciente()) + 1)
        End If
        If u.GeneraCodigoUsuario() = "" Then
            LblCodUsuario.Text = 1
        Else
            LblCodUsuario.Text = CStr(CInt(u.GeneraCodigoUsuario()) + 1)
        End If
        If hc.GeneraCodigoHistoriaClinica() = "" Then
            LblNHistoriaClinica.Text = 1
        Else
            LblNHistoriaClinica.Text = CStr(CInt(hc.GeneraCodigoHistoriaClinica()) + 1)
        End If
        cFun.FillListaOrCombo(p.ListaPais(), DdPais, "NomPais", "CodPais")
        cFun.FillListaOrCombo(d.ListaDepartamento(), DdDepartamento, "NomDepartamento", "CodDepartamento")
        DdDepartamento.Items.Insert(0, "Seleccione un Departamento")
        cFun.FillListaOrCombo(p.ListaPais, DdLugarOrigen, "NomPais", "CodPais")
        DdDato1.Items.Add("Niguno")
        DdDato1.Items.Add("Calle")
        DdDato1.Items.Add("Avenida")
        DdDato2.Items.Add("Niguno")
        DdDato2.Items.Add("Numero")
        DdDato2.Items.Add("Manzana")
        BtnImprimir.Enabled = True
        Nuevo()
    End Sub

    Protected Sub BtnBuscar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles BtnBuscar.Click
        Panel8.Visible = True
        BtnBuscar.Enabled = False
    End Sub

    Protected Sub BtnModificar_Click1(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles BtnModificar.Click
        LblAutogenerado.Text = LblAutoge.Text + TextBox1.Text + TextBox2.Text
        If LblCodDireccion.Text = "" Then
            Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('No es posible editar el registro porque los datos están incompletos');</script>"))
        Else
            If dire.ModificarDireccion(DdDato1.SelectedItem.ToString, TxtDato1.Text, DdDato2.SelectedItem.ToString, TxtDato2.Text, TxtLote.Text, DdCentroPoblado.Text, LblCodDireccion.Text) = True Then
            Else
                Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('No es posible editar los datos');</script>"))
            End If
        End If
        If LblCodPaciente.Text = "" Then
            Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('No es posible editar el registro porque los datos están incompletos');</script>"))
        Else
            If paci.ModificarPaciente(TxtNombres.Text, TxtApellidoPaterno.Text, TxtApellidoMaterno.Text, LblCodTipoDocIdentidad.Text, TxtFechaNacimiento.Text, DdSexo.SelectedItem.ToString, LblCodEstadoCivil.Text, TxtOcupacion.Text, TxtCelular.Text, TxtTelefono.Text, TxtEmail.Text, TxtNumero.Text, DdLugarOrigen.SelectedItem.ToString, LblCodPaciente.Text) = True Then
                MessageBox.Show("Datos modificados correctamente", "Sistema de Consultas e Historias Clinicas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                cancelar()
            Else
                Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('No es posible editar los datos');</script>"))
            End If
        End If
    End Sub

    Protected Sub BtnCancelar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles BtnCancelar.Click
        cancelar()
    End Sub

    Protected Sub DdDato1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DdDato1.SelectedIndexChanged
        LblPaciente.Text = cFun.ConsultaUnDato(paci.ComprobarPaciente(TxtNumero.Text, TxtNombres.Text, TxtApellidoPaterno.Text, TxtApellidoMaterno.Text), 0)
        LblNumero.Text = cFun.ConsultaUnDato(paci.ComprobarPaciente(TxtNumero.Text, TxtNombres.Text, TxtApellidoPaterno.Text, TxtApellidoMaterno.Text), 1)
        If LblPaciente.Text = "" Or LblNumero.Text = "" Then

        Else
            MessageBox.Show("El paciente " + LblPaciente.Text + " con el Doc. de Identidad N°" + LblNumero.Text + " ya está registrado", "Sistema de Consultas e Historias Clinicas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
            cancelar()
        End If
    End Sub

    Protected Sub DdTipoDocIdentidad_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DdTipoDocIdentidad.SelectedIndexChanged
        If DdTipoDocIdentidad.SelectedItem.Text = "Sin Documento" Then
            TxtNumero.MaxLength = 0
        Else
            If DdTipoDocIdentidad.SelectedItem.Text = "Documento Nacional de Identidad" Then
                TxtNumero.MaxLength = 8
            Else
                If DdTipoDocIdentidad.SelectedItem.Text = "Carnet de extranjería" Then
                    TxtNumero.MaxLength = 15
                Else
                    If DdTipoDocIdentidad.SelectedItem.Text = "Pasaporte" Then
                        TxtNumero.MaxLength = 15
                    Else
                        If DdTipoDocIdentidad.SelectedItem.Text = "Documento de Identidad Extranjero" Then
                            TxtNumero.MaxLength = 15
                        Else
                            If DdTipoDocIdentidad.SelectedItem.Text = "RUC" Then
                                TxtNumero.MaxLength = 11
                            End If
                        End If
                    End If
                End If
            End If
        End If
        TxtNumero.Enabled = True
    End Sub

    Protected Sub TxtNumero_TextChanged(ByVal Keyascii As Short)
        Dim solonumeros As Integer
        If ((Keyascii >= 48 And Keyascii <= 57) Or (Keyascii = 8)) Then
            solonumeros = Keyascii
        Else
            solonumeros = 0
        End If
    End Sub

    Function SoloNumeros(ByVal Keyascii As Short) As Short
        If ((Keyascii >= 48 And Keyascii <= 57) Or (Keyascii = 8)) Then
            SoloNumeros = Keyascii
        Else
            SoloNumeros = 0
        End If
    End Function

    Protected Sub BtnBuscarPaciente_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles BtnBuscarPaciente.Click
        If TxtBuscar.Text = "" Then
            MessageBox.Show("Debe ingresar el Apellido Paterno del Paciente a Buscar", "Sistema de Consultas e Historias Clinicas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
        Else
            cFun.FillDataGridView(paci.ListaHistoriaClinicaPaciente(TxtBuscar.Text), Me.GvHCPaciente)
        End If
    End Sub

    Protected Sub BtnCancelarPaciente_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles BtnCancelarPaciente.Click
        TxtBuscar.Text = ""
        Panel8.Visible = False
        BtnBuscar.Enabled = True
    End Sub

    Protected Sub BtnHuella_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles BtnHuella.Click
        Dim path As String
        path = "D:\RegistroHuella\RegistraHuella\RegistraHuella\bin\Debug\RegistraHuella.exe"
        System.Diagnostics.Process.Start(path, "")
    End Sub
End Class
