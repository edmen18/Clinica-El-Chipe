Imports datos
Imports System.Data.SqlClient
Public Class IGV
    Dim cFun As New cFuncionesDB
    Private s_CodIGV As String
    Private d_Valor As Double
    Private b_Estado As Boolean
    Public Property CodIGV() As String
        Get
            Return s_CodIGV
        End Get
        Set(ByVal value As String)
            s_CodIGV = value
        End Set
    End Property
    Public Property Valor() As Double
        Get
            Return d_Valor
        End Get
        Set(ByVal value As Double)
            d_Valor = value
        End Set
    End Property
    Public Property Estado() As Boolean
        Get
            Return b_Estado
        End Get
        Set(ByVal value As Boolean)
            b_Estado = value
        End Set
    End Property
    Function MuestraIGV()
        Dim sql As String
        sql = "Select CodIGV,Valor from IGV where Estado='True'"
        Return sql
    End Function
End Class
