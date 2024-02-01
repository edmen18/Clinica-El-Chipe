Imports System.Data.SqlClient
Imports datos
Public Class TipoSolicitud
    Private cFunDB As cFuncionesDB
    Private s_CodTipoSolicitud As String
    Private s_NomTipoSolicitud As String

    Public Property CodTipoSolicitud() As String
        Get
            Return s_CodTipoSolicitud
        End Get
        Set(ByVal value As String)
            s_CodTipoSolicitud = value
        End Set
    End Property
    Public Property NomTipoSolicitud() As String
        Get
            Return s_NomTipoSolicitud
        End Get
        Set(ByVal value As String)
            s_NomTipoSolicitud = value
        End Set
    End Property
    Function ListaTipoSolicitud() As String
        Dim sql As String
        sql = "Select CodTipoSolicitud, NomTipoSolicitud from TipoSolicitud"
        Return sql
    End Function
End Class
