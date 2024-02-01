Imports System.Data.SqlClient
Imports datos
Public Class TipoDocIdentidad
    Dim cFunDb As New cFuncionesDB
    Private s_CodTipoDocIdentidad As String
    Private s_NomTipoDoc As String
    Private s_Abreviatura As String
    Public Property CodTipoDocIdentidad() As String
        Get
            Return s_CodTipoDocIdentidad
        End Get
        Set(ByVal value As String)
            s_CodTipoDocIdentidad = value
        End Set
    End Property
    Public Property NomTipoDoc() As String
        Get
            Return s_NomTipoDoc
        End Get
        Set(ByVal value As String)
            s_NomTipoDoc = value
        End Set
    End Property
    Public Property Abreviatura() As String
        Get
            Return s_Abreviatura
        End Get
        Set(ByVal value As String)
            s_Abreviatura = value
        End Set
    End Property
    Function ListaTipoDocIdentidad() As String
        Dim sql As String
        sql = "Select CodTipoDocIdentidad,NomTipoDoc from TipoDocIdentidad"
        Return sql
    End Function
End Class
