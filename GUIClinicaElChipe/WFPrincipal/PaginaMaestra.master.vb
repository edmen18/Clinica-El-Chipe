Imports datos
Imports Reglas
Partial Class WFServicios_PaginaMaestra
    Inherits System.Web.UI.MasterPage
    Dim cFun As New cFuncionesDB
    Dim u As New Usuario
    Dim t As New Turno
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LblFecha.Text = retornardia() & ", " & Now.Day & " de " & retornarmes() & " del " & Now.Year
    End Sub
    Function retornardia() As String
        Dim dia As String = ""
        Select Case Now.DayOfWeek
            Case 1
                dia = "Lunes"
            Case 2
                dia = "Martes"
            Case 3
                dia = "Miércoles"
            Case 4
                dia = "Jueves"
            Case 5
                dia = "Viernes"
            Case 6
                dia = "Sábado"
            Case 0
                dia = "Domingo"
        End Select
        Return dia
    End Function
    Function retornarmes() As String
        Dim mes As String = ""
        Select Case Now.Month
            Case 1
                mes = "Enero"
            Case 2
                mes = "Febrero"
            Case 3
                mes = "Marzo"
            Case 4
                mes = "Abril"
            Case 5
                mes = "Mayo"
            Case 6
                mes = "Junio"
            Case 7
                mes = "Julio"
            Case 8
                mes = "Agosto"
            Case 9
                mes = "Setiembre"
            Case 10
                mes = "Octubre"
            Case 11
                mes = "Noviembre"
            Case 12
                mes = "Diciembre"
        End Select
        Return mes
    End Function
End Class

