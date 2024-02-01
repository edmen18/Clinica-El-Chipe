Imports System.Data.SqlClient
Imports datos
Public Class Receta
    Private cFunDB As New cFuncionesDB
    Private s_CodReceta As String
    Private s_NumReceta As String
    Private d_Fecha As Date
    Private o_Consulta As Consulta

    Public Property CodReceta() As String
        Get
            Return s_CodReceta
        End Get
        Set(ByVal value As String)
            s_CodReceta = value
        End Set
    End Property
    Public Property NumReceta() As String
        Get
            Return s_NumReceta
        End Get
        Set(ByVal value As String)
            s_NumReceta = value
        End Set
    End Property
    Public Property Fecha() As Date
        Get
            Return d_Fecha
        End Get
        Set(ByVal value As Date)
            d_Fecha = value
        End Set
    End Property
    Public Property Consulta() As Consulta
        Get
            Return o_Consulta
        End Get
        Set(ByVal value As Consulta)
            o_Consulta = value
        End Set
    End Property
    Public Function AgregarReceta(ByRef codigoreceta As String, ByRef numreceta As String, ByRef fecha As Date, ByRef codigoconsulta As String) As Boolean
        Try
            Dim csql As String = "Insert into Receta(CodReceta,NumReceta,Fecha,CodigoConsulta)values('" & codigoreceta & "','" & numreceta & "','" & CDate(fecha) & "','" & codigoconsulta & "')"
            Dim db As BaseDatos = New BaseDatos()
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            db.ConfirmarTransaccion()
            db.Desconectar()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Function GeneraCodigoReceta() As String
        Dim sql As String
        sql = "Select Max(Convert(Int,right(CodReceta,100))) from Receta"
        Dim d As String = cFunDB.ConsultaUnDato(sql, 0)
        Return d
    End Function
End Class
