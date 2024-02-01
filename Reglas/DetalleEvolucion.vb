Imports datos
Imports Reportes
Imports System.Web.UI.WebControls
Imports System.Data.SqlClient
Public Class DetalleEvolucion
    Dim fun As New cFuncionesDB
    Public Function GuardarDetalleEvolucion(ByRef CodDetalleEvolucion As String, ByRef Codevolucion As String, ByRef ApreciacionSubjetiva As String, ByRef ApreciacionObjetiva As String, ByRef VerificacionTratamiento As String, ByRef ResultadoExamen As String, ByRef Observaciones As String, ByRef Fecha As Date, ByRef hora As String, ByRef NotaEnfermeria As String) As Boolean
        Try
            Dim csql As String = "Insert into dbo.DetalleEvolucion (CodDetalleEvolucion,CodEvolucion,ApreciacionSubjetiva,ApreciacionObjetiva,VerificacionTratamiento,ResultadoExamen,Observaciones,Fecha,Hora,NotaEnfermeria)values ('" & CodDetalleEvolucion & "','" & Codevolucion & "','" & ApreciacionSubjetiva & "','" & ApreciacionObjetiva & "','" & VerificacionTratamiento & "','" & ResultadoExamen & "','" & Observaciones & "','" & Fecha & "','" & hora & "','" & NotaEnfermeria & "')"
            Dim db As BaseDatos = New BaseDatos()
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            db.ConfirmarTransaccion()
            db.Desconectar()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Return False
        End Try
    End Function
End Class
