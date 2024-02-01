Imports System.Data.SqlClient
Imports datos
Public Class TipoDiagnostico
    Private cFunDB As cFuncionesDB
    Private s_CodTipoDiagnostico As String
    Private s_NomTipoDiagnostico As String
    Private s_Descripcion As String

    Public Property CodTipoDiagnostico() As String
        Get
            Return s_CodTipoDiagnostico
        End Get
        Set(ByVal value As String)
            s_CodTipoDiagnostico = value
        End Set
    End Property
    Public Property NomTipoDiagnostico() As String
        Get
            Return s_NomTipoDiagnostico
        End Get
        Set(ByVal value As String)
            s_NomTipoDiagnostico = value
        End Set
    End Property
    Public Property Descripcion() As String
        Get
            Return s_Descripcion
        End Get
        Set(ByVal value As String)
            s_Descripcion = value
        End Set
    End Property
    Function ListarTipoDiagnostico() As String
        Dim sql As String
        sql = "Select CodTipoDiagnostico,NomTipoDiagnostico from TipoDiagnostico"
        Return sql
    End Function
End Class

