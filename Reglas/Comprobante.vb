Imports System.Data.SqlClient
Imports datos
Public Class Comprobante
    Dim cFunDb As New cFuncionesDB
    Private s_CodComprobante As String
    Private o_TipoComprobante As TipoComprobante
    Private d_Fecha As Date
    Private s_Hora As String
    Private i_NumSerie As Integer
    Private i_CorrelativoInicio As Integer
    Private i_CorrelativoFin As Integer
    Private i_CorrelativoIn As Integer
    Private o_Venta As Venta
    Private b_Anulacion As Boolean

    Public Property CodComprobante() As String
        Get
            Return s_CodComprobante
        End Get
        Set(ByVal value As String)
            s_CodComprobante = value
        End Set
    End Property
    Public Property TipoComprobante() As TipoComprobante
        Get
            Return o_TipoComprobante
        End Get
        Set(ByVal value As TipoComprobante)
            o_TipoComprobante = value
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
    Public Property Hora() As String
        Get
            Return s_Hora
        End Get
        Set(ByVal value As String)
            s_Hora = value
        End Set
    End Property
    Public Property NumSerie() As Integer
        Get
            Return i_NumSerie
        End Get
        Set(ByVal value As Integer)
            i_NumSerie = value
        End Set
    End Property
    Public Property CorrelativoInicio() As Integer
        Get
            Return i_CorrelativoInicio
        End Get
        Set(ByVal value As Integer)
            i_CorrelativoInicio = value
        End Set
    End Property
    Public Property CorrelativoFin() As Integer
        Get
            Return i_CorrelativoFin
        End Get
        Set(ByVal value As Integer)
            i_CorrelativoFin = value
        End Set
    End Property
    Public Property CorrelativoIn() As Integer
        Get
            Return i_CorrelativoIn
        End Get
        Set(ByVal value As Integer)
            i_CorrelativoIn = value
        End Set
    End Property
    Public Property Venta() As Venta
        Get
            Return o_Venta
        End Get
        Set(ByVal value As Venta)
            o_Venta = value
        End Set
    End Property
    Public Property Anulacion() As Boolean
        Get
            Return b_Anulacion
        End Get
        Set(ByVal value As Boolean)
            b_Anulacion = value
        End Set
    End Property
  
    Public Function AgregarComprobante(ByRef codigocomprobante As String, ByRef codigotipocomprobante As String, ByRef fecha As Date, ByRef hora As String, ByRef numeroserie As Integer, ByRef correlativoinicio As Integer, ByRef correlativofin As Integer, ByRef correlativoin As Integer, ByRef codigoventa As String, ByRef anulacion As Boolean) As Boolean
        Try
            Dim csql As String = "Insert into Comprobante(CodComprobante,CodTipoComprobante,Fecha,Hora,NumeroSerie,CorrelativoInicio,CorrelativoFin,CorrelativoIn,CodVenta,Anulacion) values ('" & codigocomprobante & "','" & codigotipocomprobante & "','" & fecha & "','" & hora & "','" & numeroserie & "','" & correlativoinicio & "','" & correlativofin & "','" & correlativoin & "','" & codigoventa & "','" & anulacion & "')"
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
    Public Function ModificarComprobante(ByRef codigoventa As String) As Boolean
        Try
            Dim csql As String = "Update Comprobante set Anulacion='True' where CodVenta='" + codigoventa + "'"
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
    Function GeneraCodigoComprobante() As String
        Dim strsql As String
        strsql = "Select Max(Convert(Int,right(CodComprobante,200))) from Comprobante"
        Dim dato As String = cFunDb.ConsultaUnDato(strsql, 0)
        Return dato
    End Function
End Class
