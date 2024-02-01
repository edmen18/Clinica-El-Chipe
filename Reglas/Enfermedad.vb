Imports System.Data.SqlClient
Imports datos
Public Class Enfermedad
    Private cFunDB As cFuncionesDB
    Private s_CodEnfermedad As String
    Private s_Codigo As String
    Private s_NomEnfermedad As String

    Public Property CodEnfermedad() As String
        Get
            Return s_CodEnfermedad
        End Get
        Set(ByVal value As String)
            s_CodEnfermedad = value
        End Set
    End Property
    Public Property Codigo() As String
        Get
            Return s_Codigo
        End Get
        Set(ByVal value As String)
            s_Codigo = value
        End Set
    End Property
    Public Property NomEnfermedad() As String
        Get
            Return s_NomEnfermedad
        End Get
        Set(ByVal value As String)
            s_NomEnfermedad = value
        End Set
    End Property
    Function Buscar(ByVal text As String)
        Dim csql As String = "select codenfermedad, nomenfermedad from enfermedad where nomenfermedad like '%" + text + "%'"
        Return csql
    End Function
End Class
