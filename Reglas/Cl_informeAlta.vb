Imports datos
Imports Reportes
Imports System.Web.UI.WebControls
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class Cl_informeAlta
    Dim fun As New cFuncionesDB

    Function listarhos(ByRef grilla As GridView, ByVal paciente As String)
        Dim csql As String = "select hos.CodHospitalizacion,Nombres+' '+ApellidoPaterno+' '+ApellidoMaterno as paciente,sa.CodigoSolicitudAtencion as solicitud,MotivoHospitalización as motivo,convert(char(10),hos.fecha,103)as fecha from dbo.Paciente pac inner join dbo.HistoriaClinica hc on pac.CodPaciente=hc.CodPaciente inner join dbo.SolicitudAtencion sa on sa.NHC=hc.NHC inner join dbo.Hospitalizacion hos on hos.CodigoSolicitudAtencion=sa.CodigoSolicitudAtencion inner join dbo.ConsentimientoInformado ci on ci.CodigoSolicitudAtencion=sa.CodigoSolicitudAtencion where ( hos.CodHospitalizacion not in (select CodHospitalizacion from informealta))and  ( hos.CodHospitalizacion in (select CodHospitalizacion from epicrisis)) and Nombres+' '+ApellidoPaterno+' '+ApellidoMaterno like '%" + paciente + "%'"
        fun.FillDataGridView(csql, grilla)
    End Function

    Public Function AgregarInforme(ByVal informe As String, ByVal hospital As String, ByVal condicion As String) As Boolean
        Try
            Dim csql As String = "insert into dbo.InformeAlta (codinformealta,CodHospitalizacion,Fecha,Hora,CondicionAlta) values ('" & informe & "','" & hospital & "','" & Now.Date & "','" & Now.Hour & ":" & Now.Minute & "','" & condicion & "')"
            Dim db As BaseDatos = New BaseDatos()
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            db.ConfirmarTransaccion()
            db.Desconectar()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Sistema de Consultas e Historias Clinicas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
            Return False
        End Try
    End Function
    Function generar()
        Dim csql As String = "select count(*)+1 from informealta"
        Return fun.ConsultaUnDato(csql, 0)
    End Function

    Public Function ImprimeInformeAlta(ByVal hosp As String) As DataSet
        Dim db As BaseDatos = New BaseDatos()
        db.Conectar()
        Dim ds As New Ds_InformeAlta
        Dim adaptador1 As New SqlDataAdapter("select h.codhospitalizacion,nomservicio,CONVERT (CHAR(10),FechaEgreso,103) as fechaalta,CONVERT (CHAR(10),h.Fecha,103) as Fechaingreso  from dbo.Servicio s inner join detalleventa dv on dv.CodServicio=s.codservicio inner join venta v on v.codventa=dv.codventa inner join dbo.SolicitudAtencion sa on sa.codventa=v.codventa inner join hospitalizacion h on h.CodigoSolicitudAtencion=sa.CodigoSolicitudAtencion inner join epicrisis e on e.codhospitalizacion=h.codhospitalizacion where h.codhospitalizacion='" + hosp + "'", db._Conexion)
        Dim adaptador2 As New SqlDataAdapter("select hos.codhospitalizacion,Nombres +' '+ ApellidoPaterno +' '+ ApellidoMaterno as Nombre, Sexo,hc.nhc,MotivoHospitalizacion from dbo.Paciente p inner join dbo.HistoriaClinica hc on hc.CodPaciente=p.CodPaciente inner join dbo.SolicitudAtencion sa on sa.NHC=hc.NHC inner join dbo.Hospitalizacion hos on hos.CodigoSolicitudAtencion=sa.CodigoSolicitudAtencion where hos.codhospitalizacion='" + hosp + "'", db._Conexion)
        Dim adaptador3 As New SqlDataAdapter("select h.codhospitalizacion, NomMedicamento from medicamento m inner join tratamientoprescripciones tp on tp.CodMedicamento =m.codmedicamento inner join dbo.PrescripcionMedica pm on pm.CodPrescripcion=tp.CodPrescripcion inner join hospitalizacion h on h.CodHospitalizacion=pm.CodHospitalizacion where h.CodHospitalizacion='1' and pm.estado='" + hosp + "'", db._Conexion)
        Dim adaptador4 As New SqlDataAdapter("select h.codhospitalizacion,ApreciacionSubjetiva,ApreciacionObjetiva,VerificacionTratamiento,ResultadoExamen,Observaciones,NotaEnfermeria,CONVERT (CHAR(10),i.Fecha,103) as fechaInforme,CondicionAlta from dbo.DetalleEvolucion de inner join dbo.Evolucion e on e.CodEvolucion=de.CodEvolucion inner join dbo.Hospitalizacion h on h.CodHospitalizacion=e.CodHospitalizacion inner join informealta i on i.CodHospitalizacion=h.CodHospitalizacion where h.CodHospitalizacion='" + hosp + "'", db._Conexion)
        Dim adaptador5 As New SqlDataAdapter("SELECT codhospitalizacion,Diagnostico FROM dbo.Diagnostico D inner join dbo.DiagnosticoHospitalizacion do on do.CodDiagnostico= d.CodDiagnostico where CodHospitalizacion='" + hosp + "'  and TipoDiagnosticoHospitalizacion='Egreso'", db._Conexion)
        adaptador1.Fill(ds.Tables("servicios"))
        adaptador2.Fill(ds.Tables("Cliente"))
        adaptador3.Fill(ds.Tables("Medicamento"))
        adaptador4.Fill(ds.Tables("Informe"))
        adaptador5.Fill(ds.Tables("Diagnostico"))
        Return ds
    End Function
End Class
