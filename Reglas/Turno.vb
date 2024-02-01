Imports System.Data.SqlClient
Imports datos
Imports System.Web.UI.WebControls

Public Class Turno
    Dim cFun As New cFuncionesDB
    Private s_CodTurno As String
    Private s_NomTurno As String
    Private c_HoraInicio As Char
    Private c_HoraFin As Char
    Private b_Estado As Boolean
    Public Property CodTurno() As String
        Get
            Return s_CodTurno
        End Get
        Set(ByVal value As String)
            s_CodTurno = value
        End Set
    End Property
    Public Property NomTurno() As String
        Get
            Return s_NomTurno
        End Get
        Set(ByVal value As String)
            s_NomTurno = value
        End Set
    End Property
    Public Property HoraInicio() As Char
        Get
            Return c_HoraInicio
        End Get
        Set(ByVal value As Char)
            c_HoraInicio = value
        End Set
    End Property
    Public Property HoraFin() As Char
        Get
            Return c_HoraFin
        End Get
        Set(ByVal value As Char)
            c_HoraFin = value
        End Set
    End Property
    Public Property Estado() As Boolean
        Get
            Return b_Estado
        End Get
        Set(ByVal value As Boolean)
            b_Estado = value
        End Set
    End Property
    Public Function horaturno(ByRef turno As String) As Boolean
        Dim horaf As Date
        Dim csql As String = "Select horafin from Turno where codturno='" + turno + "'"
        horaf = cFun.ConsultaUnDato(csql, 0)
        If horaf.Hour > Now.Hour Then
            Return True
        Else
            Return False
        End If
    End Function
    Function ListaTurno() As String
        Dim sql As String
        sql = "Select CodTurno,NomTurno from turno where NomTurno='Mañana' or NomTurno='Tarde' or NomTurno='Noche'"
        Return sql
    End Function
    Public Sub CargarTurnos(ByVal COMBO As DropDownList)
        Dim csql As String = "Select CodTurno, NomTurno from TURNO Where estado='1' order by 2"
        cFun.FillListaOrCombo(csql, COMBO, "NOMTURNO", "CODTURNO")
    End Sub
    Function ListaCodTurno() As String
        Dim sql As String
        sql = "Select CodTurno from Turno where NomTurno='" + NomTurno + "'"
        Return sql
    End Function
End Class
