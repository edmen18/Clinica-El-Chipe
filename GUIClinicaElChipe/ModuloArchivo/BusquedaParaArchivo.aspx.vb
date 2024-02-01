Imports datos
Imports Reglas
Imports System.Windows.Forms

Partial Class ModuloArchivo_BusquedaParaArchivo
    Inherits System.Web.UI.Page
    Dim cFun As New cFuncionesDB
    Dim sa As New SolicitudAtencion
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
            Return Trim(GvListaArchivo.Rows(GvListaArchivo.SelectedRow.RowIndex).Cells(1).Text)
        End Get
        Set(ByVal value As String)
            Texto = value
        End Set
    End Property
    Public Property _Texto2() As String
        Get
            Return Trim(GvListaArchivo.Rows(GvListaArchivo.SelectedRow.RowIndex).Cells(2).Text)
        End Get
        Set(ByVal value As String)
            Texto = value
        End Set
    End Property
    Public Property _Texto3() As String
        Get
            Return Trim(GvListaArchivo.Rows(GvListaArchivo.SelectedRow.RowIndex).Cells(4).Text)
        End Get
        Set(ByVal value As String)
            Texto = value
        End Set
    End Property
    Public Property _Texto4() As String
        Get
            Return Trim(GvListaArchivo.Rows(GvListaArchivo.SelectedRow.RowIndex).Cells(5).Text)
        End Get
        Set(ByVal value As String)
            Texto = value
        End Set
    End Property
    Public Property _Texto5() As String
        Get
            Return Trim(GvListaArchivo.Rows(GvListaArchivo.SelectedRow.RowIndex).Cells(8).Text)
        End Get
        Set(ByVal value As String)
            Texto = value
        End Set
    End Property

    Protected Sub GvListaArchivo_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GvListaArchivo.SelectedIndexChanged
        Server.Transfer("~/ModuloArchivo/MovimientosHC.aspx?Valor1=" + LblUsu.Text)
    End Sub

    Protected Sub LinkButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkButton1.Click
        Server.Transfer("~/ModuloArchivo/ModuloArchivo.aspx?Valor1=" + LblUsu.Text)
    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        If TxtBuscar.Text = "" Then
            MessageBox.Show("Debe ingresar el dato a buscar", "Sistema de Consultas e Historias Clinicas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
        Else
            cFun.FillDataGridView(sa.ListarSolicitudAtencion2(LblFecha.Text, TxtBuscar.Text), GvListaArchivo)
        End If
    End Sub
End Class
