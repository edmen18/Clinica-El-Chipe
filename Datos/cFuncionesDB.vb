Imports System.Web.UI.WebControls
Imports System.Windows.Forms
Public Class cFuncionesDB
    Private _dt As DataTable
    Public Property dt() As DataTable
        Get
            Return _dt
        End Get
        Set(ByVal value As DataTable)
            _dt = value
        End Set
    End Property
    Overloads Sub FillListaOrCombo(ByVal csql As String, ByVal oCombo As DropDownList, ByVal displayMember As String, ByVal valueMember As String)
        Dim dt As New Data.DataTable
        Dim db As BaseDatos = New BaseDatos()
        db.Conectar()
        db.CrearComando(csql)
        Try
            dt.Load(db.EjecutarConsulta())
            oCombo.DataSource = dt
            oCombo.DataValueField = valueMember
            oCombo.DataTextField = displayMember
            oCombo.DataBind()
        Catch ex As Exception
            MsgBox("Error al operar con la base de datos!", MsgBoxStyle.Critical, "Error!")
        End Try
        db.Desconectar()
    End Sub
    'Buscar un Dato especifico
    Public Function ConsultaUnDato(ByVal csql As String, ByVal col As Integer) As String
        Dim dt As New DataTable
        Dim cad As String = ""
        Dim db As BaseDatos = New BaseDatos()
        db.Conectar()
        db.CrearComando(csql)
        Try
            dt.Load(db.EjecutarConsulta())
            If dt.Rows.Count > 0 Then
                cad = dt.Rows(0).Item(col).ToString
                db.Desconectar()
            End If
        Catch ex As Exception
            MsgBox("Error al operar con la base de datos!", MsgBoxStyle.Critical, "Error!")
        End Try
        Return cad
    End Function
    'Llena un DatagridView

    Overloads Sub FillDataGridView(ByVal csql As String, ByVal oDgv As GridView)
        Dim dt As New DataTable
        Dim db As BaseDatos = New BaseDatos()
        db.Conectar()
        db.CrearComando(csql)
        Try
            dt.Load(db.EjecutarConsulta())
            oDgv.DataSource = dt
            oDgv.DataBind()
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Public Function ConsultaX(ByVal csql As String) As DataTable
        Dim dt As New DataTable
        Dim db As BaseDatos = New BaseDatos()
        db.Conectar()
        db.CrearComando(csql)
        Try
            dt.Load(db.EjecutarConsulta())
            db.Desconectar()
        Catch ex As Exception
            MsgBox("Error al operar con la base de datos!", MsgBoxStyle.Critical, "Error!")
        End Try
        Return dt
    End Function
    'Llena Combo
    Overloads Sub FillComboUltra(ByVal csql As String, ByRef oCombo As Object, ByVal displayMember As String, ByVal valueMember As String)
        Dim dt As New Data.DataTable
        Dim db As BaseDatos = New BaseDatos()
        db.Conectar()
        db.CrearComando(csql)
        Try
            dt.Load(db.EjecutarConsulta())
            oCombo.DataSource = dt
            oCombo.ValueMember = valueMember
            oCombo.DisplayMember = displayMember
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error!")
        End Try
        db.Desconectar()
    End Sub
    'LLena un Listview desde un datatable
    'Public Sub FillListview(ByVal csql As String, ByVal oLisview As ListView)
    '    Dim dt As New DataTable
    '    Dim db As BaseDatos = New BaseDatos()
    '    db.Conectar()
    '    db.CrearComando(csql)
    '    Try
    '        dt.Load(db.EjecutarConsulta())
    '        If dt.Rows.Count > 0 Then
    '            oLisview.Items.Clear()
    '            For f As Integer = 0 To dt.Rows.Count - 1
    '                Dim dato As New ListViewItem(dt.Rows(f).Item(0).ToString)
    '                ' recorrer las columnas
    '                For c As Integer = 1 To dt.Columns.Count - 1
    '                    dato.SubItems.Add(dt.Rows(f).Item(c).ToString())
    '                Next
    '                oLisview.Items.Add(dato)
    '            Next
    '            db.Desconectar()
    '        End If
    '    Catch ex As Exception
    '        MsgBox("Error al operar con la base de datos!", MsgBoxStyle.Critical, "Error!")
    '    End Try
    'End Sub


End Class

