Imports System.Data.SqlClient
Imports datos
Public Class Tratamiento
    Private cFunDB As cFuncionesDB
    Private o_Receta As Receta
    Private o_Medicamento As Medicamento
    Private d_Cantidad As Double
    Private s_Tratamiento As String

    Public Property Receta() As Receta
        Get
            Return o_Receta
        End Get
        Set(ByVal value As Receta)
            o_Receta = value
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
    Public Property Cantidad() As Double
        Get
            Return d_Cantidad
        End Get
        Set(ByVal value As Double)
            d_Cantidad = value
        End Set
    End Property
    Public Property Tratamiento() As String
        Get
            Return s_Tratamiento
        End Get
        Set(ByVal value As String)
            s_Tratamiento = value
        End Set
    End Property
    Public Function AgregarTratamiento(ByRef codigoreceta As String, ByRef codigomedicamento As String, ByRef cantidad As Double, ByRef tratamiento As String) As Boolean
        Try
            Dim csql As String = "Insert into Tratamiento(CodReceta,CodMedicamento,Cantidad,Tratamiento)values('" & codigoreceta & "','" & codigomedicamento & "','" & cantidad & "','" & tratamiento & "')"
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
