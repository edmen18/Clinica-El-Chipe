Imports datos
Imports Reportes
Imports System.Web.UI.WebControls
Imports System.Data.SqlClient
Public Class Epicrisis
    Dim fun As New cFuncionesDB
    Function llenarhospitalizaciones(ByRef grilla As GridView, ByVal paciente As String)
        Dim csql As String = "select hos.CodHospitalizacion,Nombres+' '+ApellidoPaterno+' '+ApellidoMaterno as paciente,sa.CodigoSolicitudAtencion as solicitud,MotivoHospitalización as motivo,convert(char(10),hos.fecha,103)as fecha from dbo.Paciente pac inner join dbo.HistoriaClinica hc on pac.CodPaciente=hc.CodPaciente inner join dbo.SolicitudAtencion sa on sa.NHC=hc.NHC inner join dbo.Hospitalizacion hos on hos.CodigoSolicitudAtencion=sa.CodigoSolicitudAtencion inner join  dbo.ConsentimientoInformado ci on ci.CodigoSolicitudAtencion=sa.CodigoSolicitudAtencion where hos.CodHospitalizacion not in (select CodHospitalizacion from dbo.epicrisis) and Nombres+' '+ApellidoPaterno+' '+ApellidoMaterno like '%" + paciente + "%'"
        fun.FillDataGridView(csql, grilla)
    End Function
    'evaluar si es perinatal
    Function perinatal(ByVal hos As String) As Boolean
        Dim csql As String = "select CodHospitalizacion from parto where CodHospitalizacion='" & hos & "' "
        If fun.ConsultaUnDato(csql, 0) = "" Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Function GuardarEpicrisis(ByVal CodEpicrisis As String, ByVal CodHospitalizacion As String, ByVal fecha As Date, ByVal hora As String, ByVal Complicaciones As String, ByVal FechaEgreso As Date, ByVal HoraEgreso As String, ByVal EstadiaTotal As String, ByVal mortalidad As Boolean, ByVal necropsia As Boolean, ByVal fechanacimiento As Date, ByVal FechaMuertePerinatal As Date) As Boolean
        Try
            Dim csql As String = "INSERT INTO dbo.Epicrisis (CodEpicrisis,CodHospitalizacion,Fecha,Hora,Complicaciones,FechaEgreso,HoraEgreso,EstadiaTotal,Mortalidad,Necropsia,FechaNacimiento,FechaMuertePerinatal) VALUES ('" & CodEpicrisis & "','" & CodHospitalizacion & "','" & fecha & "','" & hora & "','" & Complicaciones & "','" & FechaEgreso & "','" & HoraEgreso & "','" & EstadiaTotal & "','" & mortalidad & "','" & necropsia & "','" & fechanacimiento & "','" & FechaMuertePerinatal & "')"
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
    Function generar() As String
        Dim csql As String = "select count(*)+1 from epicrisis"
        Return fun.ConsultaUnDato(csql, 0)
    End Function
    Function parto(ByVal hosp As String)
        Dim csql As String = "select CodParto from dbo.Parto where CodHospitalizacion='" & hosp & "'"
        Return fun.ConsultaUnDato(csql, 0)
    End Function
End Class
