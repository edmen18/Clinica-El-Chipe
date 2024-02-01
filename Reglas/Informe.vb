Imports System.Data.SqlClient
Imports datos
Public Class Informe
    Private cFunDB As cFuncionesDB
    Private s_CodInforme As String
    Private o_Consulta As Consulta
    Private o_Solicitud As Solicitud
    Private s_Resultado As String
    Private d_Fecha As Date

    Public Property CodInforme() As String
        Get
            Return s_CodInforme
        End Get
        Set(ByVal value As String)
            s_CodInforme = value
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
    Public Property Solicitud() As Solicitud
        Get
            Return o_Solicitud
        End Get
        Set(ByVal value As Solicitud)
            o_Solicitud = value
        End Set
    End Property
    Public Property Resultado() As String
        Get
            Return s_Resultado
        End Get
        Set(ByVal value As String)
            s_Resultado = value
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
    Public Function AgregarInforme(ByRef codinforme As String, ByRef codigoconsulta As String, ByRef codsolicitud As String, ByRef resultado As String, ByRef fecha As Date) As Boolean
        Try
            Dim csql As String = "Insert into Informe(CodInforme,CodigoConsulta,CodSolicitud,Resultado,Fecha)values('" & codinforme & "','" & codigoconsulta & "','" & codsolicitud & "','" & resultado & "','" & CDate(fecha) & "')"
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
End Class
