Imports datos
Imports System.Data.SqlClient
Public Class Provincia
    Dim cFunDb As New cFuncionesDB
    Private s_CodProvincia As String
    Private s_NomProvincia As String
    Private o_Departamento As Departamento
    Public Property CodProvincia() As String
        Get
            Return s_CodProvincia
        End Get
        Set(ByVal value As String)
            s_CodProvincia = value
        End Set
    End Property
    Public Property NomProvincia() As String
        Get
            Return s_NomProvincia
        End Get
        Set(ByVal value As String)
            s_NomProvincia = value
        End Set
    End Property
    Public Property Departamento() As Departamento
        Get
            Return o_Departamento
        End Get
        Set(ByVal value As Departamento)
            o_Departamento = value
        End Set
    End Property
    Function ListaP(ByRef codigodepartamento As String) As String
        Dim sql As String
        sql = "Select a.CodProvincia,a.NomProvincia from Provincia a " + _
        "inner join Departamento b on a.CodDepartamento=b.CodDepartamento where b.CodDepartamento='" + codigodepartamento + "'"
        Return sql
    End Function
End Class
