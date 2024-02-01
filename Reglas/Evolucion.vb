Imports datos
Imports Reportes
Imports System.Web.UI.WebControls
Imports System.Data.SqlClient
Public Class Evolucion
    Dim fun As New cFuncionesDB
    Public Function GuardarEvolucion(ByRef Codevolucion As String, ByRef CodHospitalizacion As String) As Boolean
        Try
            Dim csql As String = "Insert into Evolucion (Codevolucion,CodHospitalizacion) values('" & Codevolucion & "','" & CodHospitalizacion & "')"
            Dim db As BaseDatos = New BaseDatos()
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            db.ConfirmarTransaccion()
            db.Desconectar()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
