Imports System.Data.SqlClient
Imports datos
Public Class SistemaPensiones
    Dim cFunDb As New cFuncionesDB
    Private s_CodSistemaPensiones As String
    Private s_NomSistemaPensiones As String
    Public Property CodSistemaPensiones() As String
        Get
            Return s_CodSistemaPensiones
        End Get
        Set(ByVal value As String)
            s_CodSistemaPensiones = value
        End Set
    End Property
    Public Property NomSistemaPensiones() As String
        Get
            Return s_NomSistemaPensiones
        End Get
        Set(ByVal value As String)
            s_NomSistemaPensiones = value
        End Set
    End Property
End Class
