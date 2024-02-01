Imports System.Data.SqlClient
Imports datos
Imports System.Web.UI.WebControls

Public Class TipoAtencion
    Dim cFun As New cFuncionesDB
    Private s_CodTipoAtencion As String
    Private s_NomTipoAtencion As String
    Private b_Estado As Boolean
    Public Property CodTipoAtencion() As String
        Get
            Return s_CodTipoAtencion
        End Get
        Set(ByVal value As String)
            s_CodTipoAtencion = value
        End Set
    End Property
    Public Property NomTipoAtencion() As String
        Get
            Return s_NomTipoAtencion
        End Get
        Set(ByVal value As String)
            s_NomTipoAtencion = value
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
    Public Sub CargarTipoAtencion(ByVal COMBO As DropDownList)
        Dim csql As String = "Select CodTipoAtencion, NomTipoAtencion from TipoAtencion Where estado='1' order by 2"
        cFun.FillListaOrCombo(csql, COMBO, "NomTipoAtencion", "CodTipoAtencion")
    End Sub
    Public Sub CargarTipoAtencionConsulta(ByVal COMBO As DropDownList)
        Dim csql As String = "Select CodTipoAtencion, NomTipoAtencion from TipoAtencion Where estado='1' and CodTipoAtencion='TA1'"
        cFun.FillListaOrCombo(csql, COMBO, "NomTipoAtencion", "CodTipoAtencion")
    End Sub
    Public Sub CargarTipoAtencionHTM(ByVal COMBO As DropDownList)
        Dim csql As String = "Select CodTipoAtencion, NomTipoAtencion from TipoAtencion Where estado='1' and CodTipoAtencion='TA2'"
        cFun.FillListaOrCombo(csql, COMBO, "NomTipoAtencion", "CodTipoAtencion")
    End Sub
    Public Sub CargarTipoAtencionHIQ(ByVal COMBO As DropDownList)
        Dim csql As String = "Select CodTipoAtencion, NomTipoAtencion from TipoAtencion Where estado='1' and CodTipoAtencion='TA3'"
        cFun.FillListaOrCombo(csql, COMBO, "NomTipoAtencion", "CodTipoAtencion")
    End Sub
End Class
