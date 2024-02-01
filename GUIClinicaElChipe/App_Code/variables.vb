Imports Microsoft.VisualBasic

Public Class variables
    Private _codpaciente As String
    Public Property CodPac() As String
        Get
            Return _codpaciente
        End Get
        Set(ByVal value As String)
            _codpaciente = value
        End Set
    End Property
    Private _historia As String
    Public Property historia() As String
        Get
            Return _historia
        End Get
        Set(ByVal value As String)
            _historia = value
        End Set
    End Property
    Private _PACIENTE As String
    Public Property Paciente() As String
        Get
            Return _PACIENTE
        End Get
        Set(ByVal value As String)
            _PACIENTE = value
        End Set
    End Property
End Class
