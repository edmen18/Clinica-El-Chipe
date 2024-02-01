Imports datos
Imports System.Data.SqlClient
Public Class Distrito
    Dim cFunDb As New cFuncionesDB
    Private s_CodDistrito As String
    Private s_NomDistrito As String
    Private o_Provincia As Provincia
    Public Property CodDistrito() As String
        Get
            Return s_CodDistrito
        End Get
        Set(ByVal value As String)
            s_CodDistrito = value
        End Set
    End Property
    Public Property NomDistrito() As String
        Get
            Return s_NomDistrito
        End Get
        Set(ByVal value As String)
            s_NomDistrito = value
        End Set
    End Property
    Public Property Provincia() As Provincia
        Get
            Return o_Provincia
        End Get
        Set(ByVal value As Provincia)
            o_Provincia = value
        End Set
    End Property
    Function ListaD(ByRef codigoprovincia As String) As String
        Dim sql As String
        sql = "Select a.CodDistrito,a.NomDistrito from Distrito a " + _
        "inner join Provincia b on a.CodProvincia=b.CodProvincia where b.CodProvincia='" + codigoprovincia + "'"
        Return sql
    End Function
End Class
