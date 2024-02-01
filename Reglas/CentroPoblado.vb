Imports System.Data.SqlClient
Imports datos
Public Class CentroPoblado
    Dim cFunDb As New cFuncionesDB
    Private s_CodCentroPoblado As String
    Private s_NomCentroPoblado As String
    Private o_Distrito As Distrito
    Public Property CodCentroPoblado() As String
        Get
            Return s_CodCentroPoblado
        End Get
        Set(ByVal value As String)
            s_CodCentroPoblado = value
        End Set
    End Property
    Public Property NomCentroPoblado() As String
        Get
            Return s_NomCentroPoblado
        End Get
        Set(ByVal value As String)
            s_NomCentroPoblado = value
        End Set
    End Property
    Public Property Distrito() As Distrito
        Get
            Return o_Distrito
        End Get
        Set(ByVal value As Distrito)
            o_Distrito = value
        End Set
    End Property
    Function ListaCP(ByRef codigodistrito As String) As String
        Dim sql As String
        sql = "Select a.CodCentroPoblado,a.NomCentroPoblado from CentroPoblado a " + _
        "inner join Distrito b on a.CodDistrito=b.CodDistrito where b.CodDistrito='" + codigodistrito + "'"
        Return sql
    End Function
End Class
