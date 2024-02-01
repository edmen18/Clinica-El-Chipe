Imports datos
Imports Reportes
Imports System.Web.UI.WebControls
Imports System.Data.SqlClient
Public Class PrescripcionMedica
    Dim fun As New cFuncionesDB
    'para prescripcion Ordenes
    Function llenarhospitalizacionesPres(ByRef grilla As GridView, ByVal paciente As String)
        Dim csql As String = "select hos.CodHospitalizacion,Nombres+' '+ApellidoPaterno+' '+ApellidoMaterno as paciente,sa.CodigoSolicitudAtencion as solicitud,MotivoHospitalización as motivo,convert(char(10),hos.fecha,103)as fecha from dbo.Paciente pac inner join dbo.HistoriaClinica hc on pac.CodPaciente=hc.CodPaciente inner join dbo.SolicitudAtencion sa on sa.NHC=hc.NHC inner join dbo.Hospitalizacion hos on hos.CodigoSolicitudAtencion=sa.CodigoSolicitudAtencion where ( hos.CodHospitalizacion not in (select CodHospitalizacion from InformeAlta)) and Nombres+' '+ApellidoPaterno+' '+ApellidoMaterno like '%" + paciente + "%'"
        fun.FillDataGridView(csql, grilla)
    End Function
    Function MostrarPrescripcionMedica(ByRef grilla As GridView, ByVal paciente As String)
        Dim csql As String = "Select hos.CodHospitalizacion,Nombres+' '+ApellidoPaterno+' '+ApellidoMaterno as paciente, " + _
        "sa.CodigoSolicitudAtencion as solicitud,MotivoHospitalización as motivo,convert(char(10),hos.fecha,103)as fecha,pm.CodPrescripcion,pm.Dieta,pm.OrdenMedica,pm.FechaOrdenMedica " + _
        "from dbo.Paciente pac inner join dbo.HistoriaClinica hc on pac.CodPaciente=hc.CodPaciente inner join dbo.SolicitudAtencion sa " + _
        "on sa.NHC=hc.NHC inner join dbo.Hospitalizacion hos on hos.CodigoSolicitudAtencion=sa.CodigoSolicitudAtencion " + _
        "inner join PrescripcionMedica pm on hos.CodHospitalizacion=pm.CodHospitalizacion " + _
        "where (hos.CodHospitalizacion not in (select CodHospitalizacion from InformeAlta)) " + _
        "and Nombres+' '+ApellidoPaterno+' '+ApellidoMaterno like '%" & paciente & "%' and pm.Estado='True'"
        fun.FillDataGridView(csql, grilla)
    End Function
    Public Function RegistrarPrescripcionMedica(ByRef CodPrescripcion As String, ByRef CodHospitalizacion As String, ByVal dieta As String, ByVal ordenmedica As String, ByVal fechaorden As Date) As Boolean
        Try
            Dim csql As String = "insert into PrescripcionMedica(CodPrescripcion,CodHospitalizacion,dieta,estado,OrdenMedica,FechaOrdenMedica) values('" & CodPrescripcion & "','" & CodHospitalizacion & "','" & dieta & "','True','" & ordenmedica & "','" & CDate(fechaorden) & "')"
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
