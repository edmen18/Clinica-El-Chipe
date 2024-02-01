Imports datos
Imports Reglas
Imports System.Windows.Forms

Partial Class ModuloConsultorio_BusquedaParaConsultorio
    Inherits System.Web.UI.Page
    Dim cFun As New cFuncionesDB
    Dim movi As New Movimiento
    Dim t As New Turno
    Dim u As New Usuario
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
        End If
    End Sub
    Public Texto As String
    Public Property _Texto1() As String
        Get
            Return Trim(GvListadoMovimientos.Rows(GvListadoMovimientos.SelectedRow.RowIndex).Cells(1).Text)
        End Get
        Set(ByVal value As String)
            Texto = value
        End Set
    End Property
    Public Property _Texto2() As String
        Get
            Return Trim(GvListadoMovimientos.Rows(GvListadoMovimientos.SelectedRow.RowIndex).Cells(2).Text)
        End Get
        Set(ByVal value As String)
            Texto = value
        End Set
    End Property
    Public Property _Texto3() As String
        Get
            Return Trim(GvListadoMovimientos.Rows(GvListadoMovimientos.SelectedRow.RowIndex).Cells(3).Text)
        End Get
        Set(ByVal value As String)
            Texto = value
        End Set
    End Property
    Public Property _Texto4() As String
        Get
            Return Trim(GvListadoMovimientos.Rows(GvListadoMovimientos.SelectedRow.RowIndex).Cells(4).Text)
        End Get
        Set(ByVal value As String)
            Texto = value
        End Set
    End Property
    Public Property _Texto5() As String
        Get
            Return Trim(GvListadoMovimientos.Rows(GvListadoMovimientos.SelectedRow.RowIndex).Cells(5).Text)
        End Get
        Set(ByVal value As String)
            Texto = value
        End Set
    End Property
    Public Property _Texto6() As String
        Get
            Return Trim(GvListadoMovimientos.Rows(GvListadoMovimientos.SelectedRow.RowIndex).Cells(7).Text)
        End Get
        Set(ByVal value As String)
            Texto = value
        End Set
    End Property
    Public Property _Texto7() As String
        Get
            Return Trim(GvListadoMovimientos.Rows(GvListadoMovimientos.SelectedRow.RowIndex).Cells(8).Text)
        End Get
        Set(ByVal value As String)
            Texto = value
        End Set
    End Property
    Public Property _Texto8() As String
        Get
            Return Trim(GvListadoMovimientos.Rows(GvListadoMovimientos.SelectedRow.RowIndex).Cells(11).Text)
        End Get
        Set(ByVal value As String)
            Texto = value
        End Set
    End Property
    Public Property _Texto9() As String
        Get
            Return Trim(GvListadoMovimientos.Rows(GvListadoMovimientos.SelectedRow.RowIndex).Cells(12).Text)
        End Get
        Set(ByVal value As String)
            Texto = value
        End Set
    End Property
    Public Property _Texto10() As String
        Get
            Return Trim(GvListadoMovimientos.Rows(GvListadoMovimientos.SelectedRow.RowIndex).Cells(13).Text)
        End Get
        Set(ByVal value As String)
            Texto = value
        End Set
    End Property
    Public Property _Texto11() As String
        Get
            Return Trim(GvListadoMovimientos.Rows(GvListadoMovimientos.SelectedRow.RowIndex).Cells(14).Text)
        End Get
        Set(ByVal value As String)
            Texto = value
        End Set
    End Property
    Public Property _Texto12() As String
        Get
            Return Trim(GvListadoMovimientos.Rows(GvListadoMovimientos.SelectedRow.RowIndex).Cells(15).Text)
        End Get
        Set(ByVal value As String)
            Texto = value
        End Set
    End Property
    Public Property _Texto13() As String
        Get
            Return Trim(GvListadoMovimientos.Rows(GvListadoMovimientos.SelectedRow.RowIndex).Cells(16).Text)
        End Get
        Set(ByVal value As String)
            Texto = value
        End Set
    End Property
    Public Property _Texto14() As String
        Get
            Return Trim(GvListadoMovimientos.Rows(GvListadoMovimientos.SelectedRow.RowIndex).Cells(17).Text)
        End Get
        Set(ByVal value As String)
            Texto = value
        End Set
    End Property
    Public Property _Texto15() As String
        Get
            Return Trim(GvListadoMovimientos.Rows(GvListadoMovimientos.SelectedRow.RowIndex).Cells(18).Text)
        End Get
        Set(ByVal value As String)
            Texto = value
        End Set
    End Property

    Protected Sub GvListadoMovimientos_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GvListadoMovimientos.SelectedIndexChanged
        Server.Transfer("~/ModuloConsultorio/Consulta.aspx?Valor1=" + LblUsu.Text)
    End Sub

    Protected Sub BtnBuscar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles BtnBuscar.Click
        If TxtBuscar.Text = "" Then
            MessageBox.Show("Disculpe pero no ha ingresado ningún dato para buscar", "Sistema de Consultas e Historias Clinicas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
        Else
            cFun.FillDataGridView(movi.ListarMovimientos(LblFecha.Text, TxtBuscar.Text), GvListadoMovimientos)
        End If
    End Sub
End Class
