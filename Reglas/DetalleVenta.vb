Imports System.Data.SqlClient
Imports datos
Public Class DetalleVenta
    Dim cFunDb As New cFuncionesDB
    Private o_Venta As Venta
    Private o_Servicio As Servicio
    Private o_Medicamento As Medicamento
    Private i_Cantidad As Integer
    Private d_Precio As Double
    Private d_Total As Double
    Public Property Venta() As Venta
        Get
            Return o_Venta
        End Get
        Set(ByVal value As Venta)
            o_Venta = value
        End Set
    End Property
    Public Property Servicio() As Servicio
        Get
            Return o_Servicio
        End Get
        Set(ByVal value As Servicio)
            o_Servicio = value
        End Set
    End Property
    Public Property Medicamento() As Medicamento
        Get
            Return o_Medicamento
        End Get
        Set(ByVal value As Medicamento)
            o_Medicamento = value
        End Set
    End Property
    Public Property Cantidad() As Integer
        Get
            Return i_Cantidad
        End Get
        Set(ByVal value As Integer)
            i_Cantidad = value
        End Set
    End Property
    Public Property Precio() As Double
        Get
            Return d_Precio
        End Get
        Set(ByVal value As Double)
            d_Precio = value
        End Set
    End Property
    Public Property Total() As Double
        Get
            Return d_Total
        End Get
        Set(ByVal value As Double)
            d_Total = value
        End Set
    End Property
    Public Function AgregarDetalleVenta(ByRef codigoventa As String, ByRef codigoservicio As String, ByRef codigomedicamento As String, ByRef cantidad As Integer, ByRef Precio As Double, ByRef Total As Double) As Boolean
        Try
            Dim csql As String = "Insert into DetalleVenta(CodVenta,CodServicio,CodMedicamento,Cantidad,Precio,Total) values ('" & codigoventa & "','" & codigoservicio & "','" & codigomedicamento & "','" & cantidad & "','" & Precio & "','" & Total & "')"
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
