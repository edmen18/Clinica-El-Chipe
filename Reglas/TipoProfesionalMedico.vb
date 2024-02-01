Imports datos
Imports System.Data.SqlClient
Public Class TipoProfesionalMedico
    Dim cFunDb As New cFuncionesDB
    Private s_CodTipoProfesionalMedico As String
    Private s_NomTipoprofesionalMedico As String
    Public Property CodTipoProfesionalMedico() As String
        Get
            Return s_CodTipoProfesionalMedico
        End Get
        Set(ByVal value As String)
            s_CodTipoProfesionalMedico = value
        End Set
    End Property
    Public Property NomTipoprofesionalMedico() As String
        Get
            Return s_NomTipoprofesionalMedico
        End Get
        Set(ByVal value As String)
            s_NomTipoprofesionalMedico = value
        End Set
    End Property
    Function listar()
        Dim csql As String = "select codtipoprofesionalmedico,nomtipoprofesionalmedico from tipoprofesionalmedico"
        Return csql
    End Function
End Class
