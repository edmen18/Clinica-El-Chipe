Imports System.Data.SqlClient
Imports datos
Public Class EstadoCivil
    Dim cFunDb As New cFuncionesDB
    Private s_CodEstadoCivil As String
    Private s_NomEstadoCivil As String
    Public Property CodEstadoCivil() As String
        Get
            Return s_CodEstadoCivil
        End Get
        Set(ByVal value As String)
            s_CodEstadoCivil = value
        End Set
    End Property
    Public Property NomEstadoCivil() As String
        Get
            Return s_NomEstadoCivil
        End Get
        Set(ByVal value As String)
            s_NomEstadoCivil = value
        End Set
    End Property
    Function ListaEstadoCivil() As String
        Dim sql As String
        sql = "Select CodEstadoCivil, NomEstadoCivil from EstadoCivil"
        Return sql
    End Function
End Class
