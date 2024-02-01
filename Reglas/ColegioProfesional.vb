Imports System.Data.Sql
Imports datos
Public Class ColegioProfesional
    Dim cFunDb As New cFuncionesDB
    Private s_CodColegioProfesional As String
    Private s_NomColegioProfesional As String
    Public Property CodColegioProfesional() As String
        Get
            Return s_CodColegioProfesional
        End Get
        Set(ByVal value As String)
            s_CodColegioProfesional = value
        End Set
    End Property
    Public Property NomColegioProfesional() As String
        Get
            Return s_NomColegioProfesional
        End Get
        Set(ByVal value As String)
            s_NomColegioProfesional = value
        End Set
    End Property
    Function listar()
        Dim csql As String = "select codcolegioprofesional,nomcolegioprofesional from colegioprofesional"
        Return csql
    End Function
End Class
