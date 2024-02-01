Imports System.Data.SqlClient
Imports datos
Public Class TipoComprobante
    Dim cFunDb As New cFuncionesDB
    Private s_CodTipoComprobante As String
    Private s_NomTipoComprobante As String
    Private s_Abreviatura As String
    Public Property CodTipoComprobante() As String
        Get
            Return s_CodTipoComprobante
        End Get
        Set(ByVal value As String)
            s_CodTipoComprobante = value
        End Set
    End Property
    Public Property NomTipoComprobante() As String
        Get
            Return s_NomTipoComprobante
        End Get
        Set(ByVal value As String)
            s_NomTipoComprobante = value
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
    Function ListaTipoComprobante() As String
        Dim sql As String
        sql = "Select CodTipoComprobante, NomTipoComprobante from TipoComprobante"
        Return sql
    End Function
End Class
