Imports datos
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Public Class Departamento
    Dim cFunDb As New cFuncionesDB
    Private s_CodDepartamento As String
    Private s_NomDepartamento As String
    Private o_Pais As Pais
    Public Property CodDepartamento() As String
        Get
            Return s_CodDepartamento
        End Get
        Set(ByVal value As String)
            s_CodDepartamento = value
        End Set
    End Property
    Public Property NomDepartamento() As String
        Get
            Return s_NomDepartamento
        End Get
        Set(ByVal value As String)
            s_NomDepartamento = value
        End Set
    End Property
    Public Property Pais() As Pais
        Get
            Return o_Pais
        End Get
        Set(ByVal value As Pais)
            o_Pais = value
        End Set
    End Property
    Function ListaD(ByRef codigopais As String) As String
        Dim sql As String
        sql = "Select a.CodDepartamento,a.NomDepartamento from Departamento a " + _
        "inner join Pais b on a.CodPais=b.CodPais where b.CodPais='" + codigopais + "'"
        Return sql
    End Function
    Function ListaDepartamento() As String
        Dim sql As String
        sql = "Select CodDepartamento,NomDepartamento from Departamento"
        Return sql
    End Function
End Class
