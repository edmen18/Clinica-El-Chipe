Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Imports datos
Imports System.Web.UI.WebControls
Public Class Parto
    Dim cFun As New cFuncionesDB
    Public Function generar(ByRef part As Label)
        Dim csql As String = "select count(*)+1 from parto"
        part.Text = cFun.ConsultaUnDato(csql, 0)
    End Function
    Public Function AgregarPaciente(ByVal CodParto As String, ByVal CodHospitalizacion As String, ByVal TipoParto As String, ByVal Anestesia As String, ByVal CordonUmbilical As String, ByVal LiquidoAmniotico As String, ByVal Placenta As String, ByVal Reanimacion As String, ByVal DrogasUsadas As String) As Boolean
        Try
            Dim csql As String = "insert into dbo.Parto (CodParto,CodHospitalizacion,TipoParto ,Anestesia ,CordonUmbilical,LiquidoAmniotico,Placenta,Reanimacion ,DrogasUsadas )values ('" & CodParto & "','" & CodHospitalizacion & "','" & TipoParto & "' ,'" & Anestesia & "' ,'" & CordonUmbilical & "','" & LiquidoAmniotico & "','" & Placenta & "','" & Reanimacion & "' ,'" & DrogasUsadas & "')"
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
