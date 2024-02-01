Imports System.Data.SqlClient
Imports datos
Imports System.Web.UI.WebControls
Public Class DiagnosticoHospitalizacion
    Dim cFun As New cFuncionesDB
    Public Function GuardarDiagnostico(ByRef CodDiagHosp As String, ByRef CodHospitalizacion As String, ByRef Coddiagnostico As String, ByRef tipodiag As String, ByRef tipodiaghosp As String, ByRef fecha As Date) As Boolean
        Try
            Dim csql As String = "Insert into DiagnosticoHospitalizacion(CodDiagnosticoHospitalizacion,Codhospitalizacion,CodDiagnostico,CodTipoDiagnostico,TipoDiagnosticoHospitalizacion,Fecha) values ('" & CodDiagHosp & "','" & CodHospitalizacion & "','" & Coddiagnostico & "','" & tipodiag & "','" & tipodiaghosp & "','" & CDate(fecha) & "')"
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
