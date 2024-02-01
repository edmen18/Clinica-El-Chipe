Imports System.Data.SqlClient
Imports datos
Imports System.Web.UI.WebControls
Public Class CondicionPersonal
    Dim cFunDb As New cFuncionesDB
    Function listar()
        Dim csql As String = "select CodCondicionPersonal,NomCondicionPersonal from CondicionPersonal"
        Return csql
    End Function
End Class
