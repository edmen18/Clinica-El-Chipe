Imports System.Data.SqlClient
Imports datos
Imports System.Windows.Forms

Public Class Medicamento
    Private cFunDB As cFuncionesDB
    Private s_CodMedicamento As String
    Private s_NomMedicamento As String
    Private d_PrecioUnitario As Double
    Private s_Utilidad As String

    Public Property CodMedicamento() As String
        Get
            Return s_CodMedicamento
        End Get
        Set(ByVal value As String)
            s_CodMedicamento = value
        End Set
    End Property
    Public Property NomMedicamento() As String
        Get
            Return s_NomMedicamento
        End Get
        Set(ByVal value As String)
            s_NomMedicamento = value
        End Set
    End Property
    Public Property PrecioUnitario() As Double
        Get
            Return d_PrecioUnitario
        End Get
        Set(ByVal value As Double)
            d_PrecioUnitario = value
        End Set
    End Property
    Public Property Utilidad() As String
        Get
            Return s_Utilidad
        End Get
        Set(ByVal value As String)
            s_Utilidad = value
        End Set
    End Property
    Function ListarMedicamento() As String
        Dim sql As String
        sql = "Select CodMedicamento,NomMedicamento,Utilidad,preciounitario from Medicamento"
        Return sql
    End Function
    Function BuscarMedicamento(ByRef nombre As String) As String
        Dim sql As String
        sql = "Select CodMedicamento,NomMedicamento,Utilidad,preciounitario from Medicamento where NomMedicamento like '%" + nombre + "%'"
        Return sql
    End Function

    'operaciones bd
    Public Function AgregarMedicamento(ByVal codigo As String, ByVal medicamento As String, ByVal precio As Double, ByRef utilidad As String) As Boolean
        Try
            Dim csql As String = "insert into medicamento (Codmedicamento,nommedicamento,utilidad,preciounitario) values ('" & codigo & "','" & medicamento & "','" & utilidad & "','" & precio & "')"
            Dim db As BaseDatos = New BaseDatos()
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            db.ConfirmarTransaccion()
            db.Desconectar()
            Return True
        Catch ex As Exception
            MessageBox.Show("Error" + ex.ToString, "Medicamento", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Public Function UpdateMedicamento(ByVal codigo As String, ByVal medicamento As String, ByVal precio As Double, ByRef utilidad As String) As Boolean
        Try
            Dim csql As String = "update medicamento set nommedicamento='" & medicamento & "',utilidad='" & utilidad & "',preciounitario='" & precio & "' where Codmedicamento='" & codigo & "'"
            Dim db As BaseDatos = New BaseDatos()
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            db.ConfirmarTransaccion()
            db.Desconectar()
            Return True
        Catch ex As Exception
            MessageBox.Show("Error" + ex.ToString, "Medicamento", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Function generar()
        Dim csql As String = "select count(*)+1 from medicamento"
        Return csql
    End Function
End Class
