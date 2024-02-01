Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Imports datos
Imports System.Web.UI.WebControls
Public Class Antecedentesmaternos
    Dim cFun As New cFuncionesDB
    Public Function generar(ByRef am As Label)
        Dim csql As String = "select count(*)+1 from antecedentesmaternos"
        am.Text = cFun.ConsultaUnDato(csql, 0)
    End Function
    Public Function registrar(ByVal CodAntecedentes As String, ByVal CodParto As String, ByVal Gestacion As String, ByVal Paridad As String, ByVal Termino As String, ByVal Prematuros As String, ByVal Abortos As String, ByVal Obito As String, ByVal FactoresMedicoRiesgo As String, ByVal TiempoGestacion As String, ByVal PatologiaEmbarazo As String, ByVal FechaParto As String, ByVal Hora As String, ByVal IndicioLaborParto As String, ByVal RPMCaracteristicas As String, ByVal DrogasLaborParto As String) As Boolean
        Try
            Dim csql As String = "insert into dbo.AntecedentesMaternos (CodAntecedentes,CodParto,Gestacion,Paridad,Termino,Prematuros,Abortos,Obito,FactoresMedicoRiesgo,TiempoGestacion,PatologiaEmbarazo,FechaParto,Hora,IndicioLaborParto,RPMCaracteristicas,DrogasLaborParto ) values ('" & CodAntecedentes & "','" & CodParto & "','" & Gestacion & "' ,'" & Paridad & "','" & Termino & "','" & Prematuros & "','" & Abortos & "', '" & Obito & "','" & FactoresMedicoRiesgo & "','" & TiempoGestacion & "','" & PatologiaEmbarazo & "','" & FechaParto & "','" & Hora & "','" & IndicioLaborParto & "','" & RPMCaracteristicas & "','" & DrogasLaborParto & "' )"
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
