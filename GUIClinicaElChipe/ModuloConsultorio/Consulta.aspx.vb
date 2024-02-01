Imports datos
Imports Reglas
Imports System.Data
Imports System.Windows.Forms
Partial Class ModuloConsultorio_Consulta
    Inherits System.Web.UI.Page
    Dim cFun As New cFuncionesDB
    Dim table As New DataTable("tabla")
    Dim TB As DataRow
    Dim i As Integer
    Dim con As New Consulta
    Dim d As New Diagnostico
    Dim u As New Usuario
    Dim t As New Turno
    Dim medi As New Medicamento
    Dim td As New TipoDiagnostico
    Dim rece As New Receta
    Dim trata As New Tratamiento
    Dim diagconsul As New DiagnosticoConsulta
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LblUsu.Text = Request.QueryString("Valor1")
        If Not PreviousPage Is Nothing Then
            LblNHC.Text = PreviousPage._Texto1
            LblCodigoSolicitudAtencion.Text = PreviousPage._Texto2
            LblNumSolicitudAtencion.Text = PreviousPage._Texto3
            LblCodVenta.Text = PreviousPage._Texto4
            LblPaciente.Text = PreviousPage._Texto5
            LblEspecialidad.Text = PreviousPage._Texto6
            LblCodEspecialidad.Text = PreviousPage._Texto7
            LblAntecedentes.Text = PreviousPage._Texto8
            LblCodTriaje.Text = PreviousPage._Texto9
            LblTemperatura.Text = PreviousPage._Texto10
            LblFR.Text = PreviousPage._Texto11
            LblPA.Text = PreviousPage._Texto12
            LblPeso.Text = PreviousPage._Texto13
            LblTalla.Text = PreviousPage._Texto14
            LblFechaTriaje.Text = PreviousPage._Texto15
        End If
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
            cFun.FillListaOrCombo(td.ListarTipoDiagnostico(), DdTipoDiagnostico, "NomTipoDiagnostico", "CodTipoDiagnostico")
            DdTipoDiagnostico.Items.Insert(0, "--Seleccione--")
            cFun.FillListaOrCombo(td.ListarTipoDiagnostico(), DdTipoDiag, "NomTipoDiagnostico", "CodTipoDiagnostico")
            DdTipoDiag.Items.Insert(0, "--Seleccione--")
            cFun.FillDataGridView(d.ListarDiagnostico, GvListaDiagnostico)
            cFun.FillDataGridView(medi.ListarMedicamento, GvListaMedicamento)
            'MessageBox.Show("Bienvenido al Sistema " + LblPersonal.Text + ",que tenga una buena " + LblTurno.Text + "", "Sistema de Consultas e Historias Clinicas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
            TxtProximaCita.Text = "01/01/1990"
        End If
        table.Columns.Add(New DataColumn("Columna1"))
        table.Columns.Add(New DataColumn("Columna2"))
        table.Columns.Add(New DataColumn("Columna3"))
        table.Columns.Add(New DataColumn("Columna4"))
        table.Columns.Add(New DataColumn("Columna5"))
    End Sub
    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        LblCodD1.Text = Trim(GvListaDiagnostico.Rows(GvListaDiagnostico.SelectedRow.RowIndex).Cells(1).Text)
        LblDiag1.Text = Trim(GvListaDiagnostico.Rows(GvListaDiagnostico.SelectedRow.RowIndex).Cells(3).Text)
        LblCodE1.Text = Trim(GvListaDiagnostico.Rows(GvListaDiagnostico.SelectedRow.RowIndex).Cells(4).Text)
        LblE1.Text = Trim(GvListaDiagnostico.Rows(GvListaDiagnostico.SelectedRow.RowIndex).Cells(5).Text)
    End Sub

    Protected Sub Button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.Click
        LblCodD2.Text = Trim(GvListaDiagnostico.Rows(GvListaDiagnostico.SelectedRow.RowIndex).Cells(1).Text)
        LblDiag2.Text = Trim(GvListaDiagnostico.Rows(GvListaDiagnostico.SelectedRow.RowIndex).Cells(3).Text)
        LblCodE2.Text = Trim(GvListaDiagnostico.Rows(GvListaDiagnostico.SelectedRow.RowIndex).Cells(4).Text)
        LblE2.Text = Trim(GvListaDiagnostico.Rows(GvListaDiagnostico.SelectedRow.RowIndex).Cells(5).Text)
    End Sub

    Protected Sub GvListaMedicamento_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GvListaMedicamento.SelectedIndexChanged
        If rece.GeneraCodigoReceta() = "" Then
            LblCodReceta.Text = 1
        Else
            LblCodReceta.Text = CStr(CInt(rece.GeneraCodigoReceta()) + 1)
        End If
        LblCodM.Text = Trim(GvListaMedicamento.Rows(GvListaMedicamento.SelectedRow.RowIndex).Cells(1).Text)
        LblM.Text = Trim(GvListaMedicamento.Rows(GvListaMedicamento.SelectedRow.RowIndex).Cells(2).Text)
        LblUtilidad.Text = Trim(GvListaMedicamento.Rows(GvListaMedicamento.SelectedRow.RowIndex).Cells(3).Text)
    End Sub
    Protected Sub BtnNuevo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        LblCodM.Text = ""
        LblM.Text = ""
        LblUtilidad.Text = ""
        TxtTratamiento.Text = ""
    End Sub
    Sub CrearGridview()
        If GvTratamiento.Rows.Count - 1 >= 0 Then
            For i = 0 To Me.GvTratamiento.Rows.Count - 1
                TB = table.NewRow()
                TB("Columna1") = GvTratamiento.Rows(i).Cells(1).Text
                TB("Columna2") = GvTratamiento.Rows(i).Cells(2).Text
                TB("Columna3") = GvTratamiento.Rows(i).Cells(3).Text
                TB("Columna4") = GvTratamiento.Rows(i).Cells(4).Text
                TB("Columna5") = GvTratamiento.Rows(i).Cells(5).Text
                table.Rows.Add(TB)
            Next
        End If
        TB = table.NewRow()
        TB("Columna1") = LblCodReceta.Text
        TB("Columna2") = LblCodM.Text
        TB("Columna3") = LblM.Text
        TB("Columna4") = TxtCantidad.Text
        TB("Columna5") = TxtTratamiento.Text
        table.Rows.Add(TB)
        GvTratamiento.DataSource = table
        GvTratamiento.DataBind()
    End Sub
    Protected Sub Button4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.Click
        If LblCodReceta.Text = "" Or LblCodM.Text = "" Or LblM.Text = "" Or TxtCantidad.Text = "" Or TxtTratamiento.Text = "" Then
            Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('No es posible guardar el registro porque los datos están incompletos');</script>"))
        Else
            CrearGridview()
        End If
    End Sub
    Protected Sub BtnGuardar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        Dim hora As String
        hora = LblHora.Text & " " & LblHoraampm.Text
        If con.GeneraCodigoConsulta() = "" Then
            LblCodigoConsulta.Text = 1
        Else
            LblCodigoConsulta.Text = CStr(CInt(con.GeneraCodigoConsulta()) + 1)
        End If
        If con.GeneraCodConsulta(LblFecha.Text) = "" Then
            LblCodConsulta.Text = 1
        Else
            LblCodConsulta.Text = CStr(CInt(con.GeneraCodConsulta(LblFecha.Text)) + 1)
        End If
        If con.GeneraNumConsulta(LblFecha.Text, LblCodEspecialidad.Text) = "" Then
            LblNumConsulta.Text = 1
        Else
            LblNumConsulta.Text = CStr(CInt(con.GeneraNumConsulta(LblFecha.Text, LblCodEspecialidad.Text)) + 1)
        End If
        If rece.GeneraCodigoReceta() = "" Then
            LblCodReceta.Text = 1
        Else
            LblCodReceta.Text = CStr(CInt(rece.GeneraCodigoReceta()) + 1)
        End If
        If LblCodigoConsulta.Text = "" Or LblCodConsulta.Text = "" Or LblNumConsulta.Text = "" Or TxtRelatoEnfermedad.Text = "" Or TxtExamenFisico.Text = "" Or LblCodTriaje.Text = "" Or LblCodigoSolicitudAtencion.Text = "" Then
            Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('No es posible guardar el registro porque los datos están incompletos');</script>"))
        Else
            If con.AgregarConsulta(LblCodigoConsulta.Text, LblCodConsulta.Text, LblNumConsulta.Text, LblFecha.Text, hora, TxtRelatoEnfermedad.Text, TxtExamenFisico.Text, LblCodTriaje.Text, LblCodigoSolicitudAtencion.Text, TxtProximaCita.Text, TxtDescripcion.Text, TxtResultadoExamenes.Text) = True Then

            Else
                Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('No es posible guardar los datos');</script>"))
            End If
        End If
        If LblCodReceta.Text = "" Or TxtNumReceta.Text = "" Or LblCodigoConsulta.Text = "" Or LblCodConsulta.Text = "" Or LblNumConsulta.Text = "" Then
            Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('No es posible guardar el registro porque los datos están incompletos');</script>"))
        Else
            If rece.AgregarReceta(LblCodReceta.Text, TxtNumReceta.Text, LblFecha.Text, LblCodigoConsulta.Text) = True Then
      
            Else
                Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('No es posible guardar los datos');</script>"))
            End If
        End If
        If LblCodReceta.Text = "" Or LblCodM.Text = "" Or TxtCantidad.Text = "" Or TxtTratamiento.Text = "" Then
            Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('No es posible guardar el registro porque los datos están incompletos');</script>"))
        Else
            If GvTratamiento.Rows.Count - 1 >= 0 Then
                For i = 0 To Me.GvTratamiento.Rows.Count - 1
                    trata.AgregarTratamiento(GvTratamiento.Rows(i).Cells(1).Text, GvTratamiento.Rows(i).Cells(2).Text, Val(GvTratamiento.Rows(i).Cells(4).Text), GvTratamiento.Rows(i).Cells(5).Text)
                Next
            Else
                Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('No es posible guardar los datos');</script>"))
            End If
        End If
        If LblCodD2.Text <> "" Then
            diagconsul.AgregarDiagnosticoConsulta(LblCodigoConsulta.Text, LblCodD2.Text, DdTipoDiag.Text, LblFecha.Text)
        End If

        If LblCodigoConsulta.Text = "" Or LblCodD1.Text = "" Or DdTipoDiagnostico.Text = "" Then
            Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('No es posible guardar el registro porque los datos están incompletos');</script>"))
        Else
            If diagconsul.AgregarDiagnosticoConsulta(LblCodigoConsulta.Text, LblCodD1.Text, DdTipoDiagnostico.Text, LblFecha.Text) = True Then
                MessageBox.Show("Datos guardados correctamente", "Sistema de Consultas e Historias Clinicas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
            Else
                Me.ClientScript.RegisterStartupScript(Me.GetType(), "Alert", ("<script>alert('No es posible guardar los datos');</script>"))
            End If
        End If
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        cFun.FillDataGridView(d.BuscarDiagnostico(TxtBuscarDiagnostico.Text), GvListaDiagnostico)
    End Sub

    Protected Sub BtnBuscar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        cFun.FillDataGridView(medi.BuscarMedicamento(TxtBuscarMedicamento.Text), GvListaMedicamento)
    End Sub
    Public Texto As String

    Public Property _Texto1() As String
        Get
            Return LblCodigoConsulta.Text
        End Get
        Set(ByVal value As String)
            Texto = value
        End Set
    End Property
    Public Property _Texto2() As String
        Get
            Return LblPaciente.Text
        End Get
        Set(ByVal value As String)
            Texto = value
        End Set
    End Property
    Public Property _Texto3() As String
        Get
            Return LblNHC.Text
        End Get
        Set(ByVal value As String)
            Texto = value
        End Set
    End Property
    Public Property _Texto4() As String
        Get
            Return TxtRelatoEnfermedad.Text
        End Get
        Set(ByVal value As String)
            Texto = value
        End Set
    End Property
End Class
