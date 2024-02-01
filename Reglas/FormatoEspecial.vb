Imports System.Data.SqlClient
Imports datos
Public Class FormatoEspecial
    Dim cFunDB As cFuncionesDB
    Private s_CodFormatoEspecial As String
    Private o_Consulta As Consulta
    Private d_Fecha As Date
    Public Property CodFormatoEspecial() As String
        Get
            Return s_CodFormatoEspecial
        End Get
        Set(ByVal value As String)
            s_CodFormatoEspecial = value
        End Set
    End Property
    Public Property Consulta() As Consulta
        Get
            Return o_Consulta
        End Get
        Set(ByVal value As Consulta)
            o_Consulta = value
        End Set
    End Property
    Public Property Fecha() As Date
        Get
            Return d_Fecha
        End Get
        Set(ByVal value As Date)
            d_Fecha = value
        End Set
    End Property
End Class
