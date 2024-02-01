Imports System.Data.SqlClient
Imports datos
Public Class TipoConsulta
    Private cFunDB As cFuncionesDB
    Private s_CodTipoConsulta As String
    Private s_NomTipoConsulta As String

    Public Property CodTipoConsulta() As String
        Get
            Return s_CodTipoConsulta
        End Get
        Set(ByVal value As String)
            s_CodTipoConsulta = value
        End Set
    End Property
    Public Property NomTipoConsulta() As String
        Get
            Return s_NomTipoConsulta
        End Get
        Set(ByVal value As String)
            s_NomTipoConsulta = value
        End Set
    End Property
    Function ListarTipoConsulta() As String
        Dim sql As String
        sql = "Select CodTipoConsulta, NomTipoConsulta from TipoConsulta"
        Return sql
    End Function
End Class
