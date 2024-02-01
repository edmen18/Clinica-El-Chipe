Imports datos
Imports Reportes
Imports System.Web.UI.WebControls
Imports System.Data.SqlClient

Public Class Hospitalizacion
    Dim fun As New cFuncionesDB
    Public Function AgregarHospitalizacion(ByRef codigo As String, ByRef solicitud As String, ByRef fechA As Date, ByRef hora As String, ByRef general As String, ByRef regional As String, ByRef ana As String) As Boolean
        Try
            Dim csql As String = "insert into dbo.Hospitalizacion (CodHospitalizacion,CodigoSolicitudAtencion,Fecha,Hora,ExamenClinicoGeneral,ExamenClinicoRegional,Anamnesis) values ('" & codigo & "','" & solicitud & "','" & fechA & "','" & hora & "','" & general & "','" & regional & "','" & ana & "')"
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
    Function listarSolicitudespendientes(ByRef grilla As GridView, ByVal paciente As String)
        Dim csql As String = "select Nombres+' '+ApellidoPaterno+' '+ApellidoMaterno as paciente,sa.CodigoSolicitudAtencion as solicitud,MotivoHospitalización as motivo,fecha from dbo.Paciente pac inner join dbo.HistoriaClinica hc on pac.CodPaciente=hc.CodPaciente inner join dbo.SolicitudAtencion sa on sa.NHC=hc.NHC inner join dbo.ConsentimientoInformado ci on ci.CodigoSolicitudAtencion=sa.CodigoSolicitudAtencion where (sa.CodigoSolicitudAtencion not in (select CodigoSolicitudAtencion from hospitalizacion)) and Nombres+' '+ApellidoPaterno+' '+ApellidoMaterno like '%" + paciente + "%'"
        fun.FillDataGridView(csql, grilla)
    End Function

    'para reporte operatorio
    Function llenarhospitalizaciones(ByRef grilla As GridView, ByVal paciente As String)
        Dim csql As String = "select hos.CodHospitalizacion,Nombres+' '+ApellidoPaterno+' '+ApellidoMaterno as paciente,sa.CodigoSolicitudAtencion as solicitud,MotivoHospitalización as motivo,convert(char(10),hos.fecha,103)as fecha from dbo.Paciente pac inner join dbo.HistoriaClinica hc on pac.CodPaciente=hc.CodPaciente inner join dbo.SolicitudAtencion sa on sa.NHC=hc.NHC inner join dbo.Hospitalizacion hos on hos.CodigoSolicitudAtencion=sa.CodigoSolicitudAtencion inner join dbo.ConsentimientoInformado ci on ci.CodigoSolicitudAtencion=sa.CodigoSolicitudAtencion where ( hos.CodHospitalizacion not in (select CodHospitalizacion from ReporteOperatorio)) and Nombres+' '+ApellidoPaterno+' '+ApellidoMaterno like '%" + paciente + "%' "
        fun.FillDataGridView(csql, grilla)
    End Function
    Sub diagnosticos(ByRef combo As DropDownList)
        Dim csql As String = "select coddiagnostico,diagnostico from diagnostico"
        fun.FillListaOrCombo(csql, combo, "diagnostico", "coddiagnostico")
    End Sub
    Sub servicios(ByRef combo As DropDownList)
        Dim csql As String = "select codservicio,nomservicio from servicio"
        fun.FillListaOrCombo(csql, combo, "nomservicio", "codservicio")
    End Sub
    Sub cargarmedicos(ByRef combo As DropDownList)
        Dim csql As String = "SELECT m.CodMedico,Nombres+' '+ApellidoPaterno+' '+ApellidoMaterno AS NOMBRE FROM dbo.Personal P INNER JOIN dbo.Medico M ON M.CodPersonal=P.CodPersonal inner join medicoespecialidad me on me.codmedico=m.codmedico WHERE m.Estado='1'"
        fun.FillListaOrCombo(csql, combo, "NOMBRE", "CODmedico")
    End Sub
    Public Function Guardardiagnosticospre(ByRef CodReporteOperatorio As String, ByRef Coddiagnostico As String) As Boolean
        Try
            Dim csql As String = "insert into dbo.DiagnosticoReporteO (CodReporteOperatorio,CodDiagnostico,CodServicio,DiagnosticoPreOperatorio,DiagnosticoPostOperatorio)values ('" & CodReporteOperatorio & "','" & Coddiagnostico & "','true','false')"
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
    Public Function Guardardiagnosticospos(ByRef CodReporteOperatorio As String, ByRef Coddiagnostico As String) As Boolean
        Try
            Dim csql As String = "insert into dbo.DiagnosticoReporteO (CodReporteOperatorio,CodDiagnostico,CodServicio,DiagnosticoPreOperatorio,DiagnosticoPostOperatorio)values ('" & CodReporteOperatorio & "','" & Coddiagnostico & "','false','true')"
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
    Public Function GuardarDoctores(ByRef CodReporteOperatorio As String, ByRef Codmedico As String, ByRef FuncionOperacion As String) As Boolean
        Try
            Dim csql As String = "insert into dbo.MedicoReporteOperatorio (CodReporteOperatorio,CodMedico,FuncionOperacion) values('" & CodReporteOperatorio & "','" & Codmedico & "','" & FuncionOperacion & "')"
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
    Public Function GuardarReporteOperatorio(ByRef CodReporteOperatorio As String, ByRef CodHospitalizacion As String, ByRef Fecha As Date, ByRef Duracion As String, ByRef Hora As String, ByRef HallazgosOperatorios As String) As Boolean
        Try
            Dim csql As String = "insert into dbo.ReporteOperatorio (CodReporteOperatorio,CodHospitalizacion,Duracion,Fecha,Hora,HallazgosOperatorios) values('" & CodReporteOperatorio & "','" & CodHospitalizacion & "','" & Duracion & "','" & Fecha & "','" & Hora & "','" & HallazgosOperatorios & "')"
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
    Public Function ImprimeReporteOperatorio(ByVal reporte As String) As DataSet
        Dim db As BaseDatos = New BaseDatos()
        db.Conectar()
        Dim ds As New Ds_ReporteOperatorio
        Dim adaptador As New SqlDataAdapter("select CodReporteOperatorio,Duracion,HallazgosOperatorios from dbo.ReporteOperatorio where CodReporteOperatorio='" & reporte & "'", db._Conexion)
        Dim adaptador1 As New SqlDataAdapter("select Diagnostico,DiagnosticoPreOperatorio, DiagnosticoPostOperatorio from dbo.DiagnosticoReporteO a inner join dbo.ReporteOperatorio b on b.CodReporteOperatorio=a.CodReporteOperatorio inner join dbo.Diagnostico c on c.CodDiagnostico=a.CodDiagnostico where b.CodReporteOperatorio='" & reporte & "'", db._Conexion)
        Dim adaptador2 As New SqlDataAdapter("select CodReporteOperatorio,Nombres+''+ApellidoPaterno+''+ApellidoMaterno as Doctor, FuncionOperacion as funcion from dbo.Personal p inner join dbo.Medico m on m.Codpersonal=p.Codpersonal inner join dbo.MedicoReporteOperatorio mr on mr.CodMedico=m.CodMedico where CodReporteOperatorio='" & reporte & "'", db._Conexion)
        adaptador.Fill(ds.Tables("Cabecera"))
        adaptador1.Fill(ds.Tables("Diagnostico"))
        adaptador2.Fill(ds.Tables("Doctor"))
        Return ds
    End Function
    ' fin reporte operatorio
    ' para Evolución Medica
    Function llenarhospitalizacionesEvol(ByRef grilla As GridView, ByVal paciente As String)
        Dim csql As String = "select hos.CodHospitalizacion,Nombres+' '+ApellidoPaterno+' '+ApellidoMaterno as paciente,sa.CodigoSolicitudAtencion as solicitud,MotivoHospitalización as motivo,convert(char(10),hos.fecha,103)as fecha from dbo.Paciente pac inner join dbo.HistoriaClinica hc on pac.CodPaciente=hc.CodPaciente inner join dbo.SolicitudAtencion sa on sa.NHC=hc.NHC inner join dbo.Hospitalizacion hos on hos.CodigoSolicitudAtencion=sa.CodigoSolicitudAtencion inner join dbo.ConsentimientoInformado ci on ci.CodigoSolicitudAtencion=sa.CodigoSolicitudAtencion inner join dbo.TipoAtencion ta on ta.CodTipoAtencion=ci.CodTipoAtencion where ( hos.CodHospitalizacion not in (select CodHospitalizacion from InformeAlta)) and Nombres+' '+ApellidoPaterno+' '+ApellidoMaterno like '%" + paciente + "%'"
        fun.FillDataGridView(csql, grilla)
    End Function
    Public Function GuardarEvolucion(ByRef Codevolucion As String, ByRef CodHospitalizacion As String) As Boolean
        Try
            Dim csql As String = "insert into Evolucion (Codevolucion,CodHospitalizacion) values('" & Codevolucion & "','" & CodHospitalizacion & "')"
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
    Public Function GuardarDetalleEvolucion(ByRef CodDetalleEvolucion As String, ByRef Codevolucion As String, ByRef ApreciacionSubjetiva As String, ByRef ApreciacionObjetiva As String, ByRef VerificacionTratamiento As String, ByRef ResultadoExamen As String, ByRef Observaciones As String, ByRef Fecha As Date, ByRef hora As String, ByRef NotaEnfermeria As String) As Boolean
        Try
            Dim csql As String = "insert into dbo.DetalleEvolucion (CodDetalleEvolucion,CodEvolucion,ApreciacionSubjetiva,ApreciacionObjetiva,VerificacionTratamiento,ResultadoExamen,Observaciones,Fecha,Hora,NotaEnfermeria)values ('" & CodDetalleEvolucion & "','" & Codevolucion & "','" & ApreciacionSubjetiva & "','" & ApreciacionObjetiva & "','" & VerificacionTratamiento & "','" & ResultadoExamen & "','" & Observaciones & "','" & Fecha & "','" & hora & "','" & NotaEnfermeria & "')"
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
    Public Function ImprimeEVOLMEDICA(ByVal evol As String) As DataSet
        Dim db As BaseDatos = New BaseDatos()
        db.Conectar()
        Dim ds As New Ds_evolucion
        Dim adaptador As New SqlDataAdapter("select de.Fecha,de.Hora,Nombres,ApellidoPaterno,ApellidoMaterno,hc.nhc,ApreciacionSubjetiva,ApreciacionObjetiva,VerificacionTratamiento,ResultadoExamen,NotaEnfermeria,Observaciones,e.codevolucion from dbo.DetalleEvolucion de inner join dbo.Evolucion e on de.CodEvolucion=e.CodEvolucion inner join dbo.Hospitalizacion h on e.CodHospitalizacion=h.CodHospitalizacion inner join dbo.SolicitudAtencion sa on sa.CodigoSolicitudAtencion=h.CodigoSolicitudAtencion inner join dbo.HistoriaClinica hc on hc.nhc=sa.nhc inner join dbo.Paciente p on p.CodPaciente=hc.codpaciente where e.codevolucion='" + evol + "'", db._Conexion)
        Dim adaptador1 As New SqlDataAdapter("SELECT e.codevolucion,ha.NumHabitacion,c.NumCama FROM dbo.Evolucion E INNER JOIN dbo.Hospitalizacion H ON E.CodHospitalizacion=H.CodHospitalizacion INNER JOIN dbo.SolicitudAtencion SA ON SA.CodIGOSolicitudAtencion=H.CodIGOSolicitudAtencion INNER JOIN dbo.DetalleProgramacionMedica DP ON DP.CodDetalleProgramacionMedica=SA.CodDetalleProgramacionMedica INNER JOIN CAMA C ON C.CODCAMA=DP.CODCAMA INNER JOIN HABITACION HA ON HA.CODHABITACION=C.CODHABITACION where e.codevolucion='" + evol + "'", db._Conexion)
        Dim adaptador2 As New SqlDataAdapter("select e.codevolucion,NomServicio from dbo.Evolucion E INNER JOIN dbo.Hospitalizacion H ON E.CodHospitalizacion=H.CodHospitalizacion INNER JOIN dbo.SolicitudAtencion SA ON SA.CodIGOSolicitudAtencion=H.CodIGOSolicitudAtencion inner join venta v on v.codventa=sa.codventa inner join detalleventa dv on dv.codventa=v.codventa inner join servicio s on s.codservicio=dv.codservicio where e.codevolucion='" + evol + "'", db._Conexion)
        adaptador.Fill(ds.Tables("Dt_"))
        adaptador1.Fill(ds.Tables("dt_1"))
        adaptador2.Fill(ds.Tables("Dt_2"))
        Return ds
    End Function
    'fin evolucion medica

    'para prescripcion Ordenes
    Function llenarhospitalizacionesPres(ByRef grilla As GridView, ByVal paciente As String)
        Dim csql As String = "select hos.CodHospitalizacion,Nombres+' '+ApellidoPaterno+' '+ApellidoMaterno as paciente,sa.CodigoSolicitudAtencion as solicitud,MotivoHospitalización as motivo,convert(char(10),hos.fecha,103)as fecha from dbo.Paciente pac inner join dbo.HistoriaClinica hc on pac.CodPaciente=hc.CodPaciente inner join dbo.SolicitudAtencion sa on sa.NHC=hc.NHC inner join dbo.Hospitalizacion hos on hos.CodigoSolicitudAtencion=sa.CodigoSolicitudAtencion inner join dbo.ConsentimientoInformado ci on ci.CodigoSolicitudAtencion=sa.CodigoSolicitudAtencion where ( hos.CodHospitalizacion not in (select CodHospitalizacion from InformeAlta)) and Nombres+' '+ApellidoPaterno+' '+ApellidoMaterno like '%" + paciente + "%'"
        fun.FillDataGridView(csql, grilla)
    End Function
    Function medicamentos(ByRef combo As DropDownList)
        Dim csql As String = "select codmedicamento, nommedicamento from medicamento"
        fun.FillListaOrCombo(csql, combo, "nommedicamento", "Codmedicamento")
    End Function

    Public Function Guardarprescripcion(ByRef CodPrescripcion As String, ByRef CodHospitalizacion As String, ByVal dieta As String) As Boolean
        Try
            Dim csql As String = "insert into PrescripcionMedica (CodPrescripcion,CodHospitalizacion,dieta,estado) values('" & CodPrescripcion & "','" & CodHospitalizacion & "','" & dieta & "','True')"
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

    Public Function GuardarprescripcionDetalle(ByRef CodPrescripcion As String, ByRef CodMedicamento As String, ByRef dosis As String, ByRef tratamiento As String, ByRef ViaAdministracion As String, ByRef fecha As Date, ByRef hora As String) As Boolean
        Try
            Dim csql As String = "insert into dbo.TratamientoPrescripciones (CodPrescripcion,CodMedicamento,Dosis,Tratamiento,ViaAdministracion,Fecha,Hora) values ('" & CodPrescripcion & "','" & CodMedicamento & "','" & dosis & "','" & tratamiento & "','" & ViaAdministracion & "','" & fecha & "','" & hora & "')"
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

    Public Function ImprimePrescripcionMedica(ByVal pres As String) As DataSet
        Dim db As BaseDatos = New BaseDatos()
        db.Conectar()
        Dim ds As New Ds_prescripcion
        Dim adaptador As New SqlDataAdapter("select t.Fecha,t.Hora,Dosis,NomMedicamento,Tratamiento,ViaAdministracion,Nombres,ApellidoPaterno,ApellidoMaterno,hc.nhc from dbo.TratamientoPrescripciones t inner join dbo.Medicamento m on m.CodMedicamento=t.CodMedicamento inner join dbo.PrescripcionMedica pm on t.CodPrescripcion= pm.CodPrescripcion inner join dbo.Hospitalizacion h on pm.CodHospitalizacion=h.CodHospitalizacion inner join dbo.SolicitudAtencion sa on sa.CodigoSolicitudAtencion=h.CodigoSolicitudAtencion inner join dbo.HistoriaClinica hc on hc.nhc=sa.nhc inner join dbo.Paciente p on p.CodPaciente=hc.codpaciente where pm.CodPrescripcion='" + pres + "'", db._Conexion)
        Dim adaptador1 As New SqlDataAdapter("SELECT e.CodPrescripcion,ha.NumHabitacion,c.NumCama FROM PrescripcionMedica E INNER JOIN dbo.Hospitalizacion H ON E.CodHospitalizacion=H.CodHospitalizacion INNER JOIN dbo.SolicitudAtencion SA ON SA.CodIGOSolicitudAtencion=H.CodIGOSolicitudAtencion INNER JOIN dbo.DetalleProgramacionMedica DP ON DP.CodDetalleProgramacionMedica=SA.CodDetalleProgramacionMedica INNER JOIN CAMA C ON C.CODCAMA=DP.CODCAMA INNER JOIN HABITACION HA ON HA.CODHABITACION=C.CODHABITACION where e.CodPrescripcion='" + pres + "'", db._Conexion)
        Dim adaptador2 As New SqlDataAdapter("select e.CodPrescripcion,NomServicio from dbo.PrescripcionMedica E INNER JOIN dbo.Hospitalizacion H ON E.CodHospitalizacion=H.CodHospitalizacion INNER JOIN dbo.SolicitudAtencion SA ON SA.CodIGOSolicitudAtencion=H.CodIGOSolicitudAtencion inner join venta v on v.codventa=sa.codventa inner join detalleventa dv on dv.codventa=v.codventa inner join servicio s on s.codservicio=dv.codservicio where e.CodPrescripcion='" + pres + "'", db._Conexion)
        adaptador.Fill(ds.Tables("Dt_pres"))
        adaptador1.Fill(ds.Tables("dt_ch"))
        adaptador2.Fill(ds.Tables("dt_serv"))
        Return ds
    End Function
    ' fin prescripcion Orden

    'guardar diagnóstico hospitalizacion para todos los procesos
    Public Function GuardarDiagnostico(ByRef CodHospitalizacion As String, ByRef Coddiagnostico As String, ByRef tipodiag As String, ByRef tipodiaghosp As String) As Boolean
        Try
            Dim csql As String = "insert into dbo.DiagnosticoHospitalizacion (Codhospitalizacion,CodDiagnostico,CodTipoDiagnostico,TipoDiagnosticoHospitalizacion,Fecha) values ('" & CodHospitalizacion & "','" & Coddiagnostico & "','" & tipodiag & "','" & tipodiaghosp & "','" & Now.Date() & "')"
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