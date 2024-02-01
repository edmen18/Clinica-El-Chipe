Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Imports datos
Imports System.Web.UI.WebControls
Public Class Nacimiento
    Dim cFun As New cFuncionesDB
    Public Function generar(ByRef nac As Label)
        Dim csql As String = "select count(*)+1 from nacimiento"
        nac.Text = cFun.ConsultaUnDato(csql, 0)
    End Function
    Public Function Registrar(ByVal CodNacimiento As String, ByVal CodParto As String, ByVal NombreRN As String, ByVal Sexo As String, ByVal Semanas As String, ByVal Fecha As String, ByVal Hora As String, ByVal Talla As String, ByVal Peso As String, ByVal PC As String, ByVal PTX As String, ByVal PABD As String, ByVal FC As String, ByVal ER As String, ByVal TM As String, ByVal REF As String, ByVal COL As String, ByVal Temperatura As String, ByVal Observaciones As String, ByVal ExamenFisico As String, ByVal Diagnostico As String) As Boolean
        Try
            Dim csql As String = "insert into dbo.Nacimiento (CodNacimiento,CodParto,NombreRN,Sexo,Semanas,Fecha ,Hora,Talla,Peso,PC,PTX,PABD ,FC ,ER ,TM,REF,COL,Temperatura,Observaciones,ExamenFisico,Diagnostico)values ('" & CodNacimiento & "','" & CodParto & "','" & NombreRN & "','" & Sexo & "','" & Semanas & "','" & Fecha & "','" & Hora & "','" & Talla & "','" & Peso & "','" & PC & "','" & PTX & "','" & PABD & "' ,'" & FC & "' ,'" & ER & "' ,'" & TM & "','" & REF & "','" & COL & "','" & Temperatura & "','" & Observaciones & "','" & ExamenFisico & "','" & Diagnostico & "')"
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
