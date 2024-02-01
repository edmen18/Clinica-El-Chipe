Imports System.Data.SqlClient
Imports datos
Public Class SolicitudAtencion
    Dim cFunDb As New cFuncionesDB
    Private s_CodigoSolicitudAtencion As String
    Private s_CodSolicitudAtencion As String
    Private s_NumSolicitudAtencion As String
    Private o_DetalleProgramacionMedica As DetalleProgramacionMedica
    Private o_HistoriaClinica As HistoriaClinica
    Private d_FechaAtencion As Date
    Private d_Fecha As Date
    Private s_HoraRegistro As String
    Private o_Usuario As Usuario
    Private d_FechaReprogramacion As Date
    Private o_Venta As Venta
    Private b_Reprogramado As Boolean
    Private b_Anulado As Boolean
    Private d_FechaAnulacion As Date
    Private s_MotivoHospitalizacion As String
    Public Property CodigoSolicitudAtencion() As String
        Get
            Return s_CodigoSolicitudAtencion
        End Get
        Set(ByVal value As String)
            s_CodigoSolicitudAtencion = value
        End Set
    End Property
    Public Property CodSlicitudAtencion() As String
        Get
            Return s_CodSolicitudAtencion
        End Get
        Set(ByVal value As String)
            s_CodSolicitudAtencion = value
        End Set
    End Property
    Public Property NumSolicitudAtencion() As String
        Get
            Return s_NumSolicitudAtencion
        End Get
        Set(ByVal value As String)
            s_NumSolicitudAtencion = value
        End Set
    End Property
    Public Property DetalleProgramacionMedica() As DetalleProgramacionMedica
        Get
            Return o_DetalleProgramacionMedica
        End Get
        Set(ByVal value As DetalleProgramacionMedica)
            o_DetalleProgramacionMedica = value
        End Set
    End Property
    Public Property HistoriaClinica() As HistoriaClinica
        Get
            Return o_HistoriaClinica
        End Get
        Set(ByVal value As HistoriaClinica)
            o_HistoriaClinica = value
        End Set
    End Property
    Public Property FechaAtencion() As Date
        Get
            Return d_FechaAtencion
        End Get
        Set(ByVal value As Date)
            d_FechaAtencion = value
        End Set
    End Property
    Public Property Fecha() As Date
        Get
            Return d_Fecha
        End Get
        Set(ByVal value As Date)
            d_Fecha = value
        End Set
    End Property
    Public Property HoraRegistro() As String
        Get
            Return s_HoraRegistro
        End Get
        Set(ByVal value As String)
            s_HoraRegistro = value
        End Set
    End Property
    Public Property Usuario() As Usuario
        Get
            Return o_Usuario
        End Get
        Set(ByVal value As Usuario)
            o_Usuario = value
        End Set
    End Property
    Public Property FechaReprogramacion() As Date
        Get
            Return d_FechaReprogramacion
        End Get
        Set(ByVal value As Date)
            d_FechaReprogramacion = value
        End Set
    End Property
    Public Property Venta() As Venta
        Get
            Return o_Venta
        End Get
        Set(ByVal value As Venta)
            o_Venta = value
        End Set
    End Property
    Public Property Reprogramado() As Boolean
        Get
            Return b_Reprogramado
        End Get
        Set(ByVal value As Boolean)
            b_Reprogramado = value
        End Set
    End Property
    Public Property Anulado() As Boolean
        Get
            Return b_Anulado
        End Get
        Set(ByVal value As Boolean)
            b_Anulado = value
        End Set
    End Property
    Public Property FechaAnulacion() As Date
        Get
            Return d_FechaAnulacion
        End Get
        Set(ByVal value As Date)
            d_FechaAnulacion = value
        End Set
    End Property
    Public Property MotivoHospitalizacion() As String
        Get
            Return s_MotivoHospitalizacion
        End Get
        Set(ByVal value As String)
            s_MotivoHospitalizacion = value
        End Set
    End Property
    Public Function AgregarSolicitudAtencion(ByRef codigosolicitudatencion As String, ByRef codsolicitudatencion As String, ByRef numsolicitudatencion As String, ByRef codigodetalleprogramacionmedica As String, ByRef nhc As String, ByRef fechaatencion As Date, ByRef fecha As Date, ByRef Hora As String, ByRef codigousuario As String, ByRef fechareprogramacion As Date, ByRef codigoventa As String, ByRef reprogramado As Boolean, ByRef anulado As Boolean, ByRef fechaanulado As Date, ByRef motivo As String) As Boolean
        Try
            Dim csql As String = "Insert into SolicitudAtencion(CodigoSolicitudAtencion,CodSolicitudAtencion,NumSolicitudAtencion,CodDetalleProgramacionMedica,NHC,FechaAtencion,Fecha,HoraRegistro,CodUsuario,FechaReprogramacion,CodVenta,Reprogramado,Anulado,FechaAnulacion,MotivoHospitalizacion)values('" & codigosolicitudatencion & "','" & codsolicitudatencion & "','" & numsolicitudatencion & "','" & codigodetalleprogramacionmedica & "','" & nhc & "','" & CDate(fechaatencion) & "','" & CDate(fecha) & "','" & Hora & "','" & codigousuario & "','" & fechareprogramacion & "','" & codigoventa & "','" & reprogramado & "','" & anulado & "','" & fechaanulado & "','" & motivo & "')"
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
    Public Function ModificarReprogramacion(ByRef codigosolicitudatencion As String, ByRef numsolicitudatencion As String, ByRef fecha As Date) As Boolean
        Try
            Dim csql As String = "Update SolicitudAtencion set Reprogramado='True',FechaReprogramacion='" & CDate(fecha) & "' where CodigoSolicitudAtencion='" & codigosolicitudatencion & "' and NumSolicitudAtencion='" & numsolicitudatencion & "'"
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
    Public Function ModificarAnulacion(ByRef codigosolicitudatencion As String, ByRef numsolicitudatencion As String, ByRef fechaanulacion As Date, ByRef fechaatencion As Date, ByRef codigodetallepm As String) As Boolean
        Try
            Dim csql As String = "Update SolicitudAtencion set Anulado='True' and FechaAnulacion='" & CDate(fechaanulacion) & "' where CodigoSolicitudAtencion='" & codigosolicitudatencion & "' and NumSolicitudAtencion='" & numsolicitudatencion & "' and FechaAtencion='" & CDate(fechaatencion) & "' and CodDetalleProgramacionMedica='" & codigodetallepm & "'"
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
    Function ListarSolicitudAtencion1(ByRef fecha As Date, ByRef apellido As String) As String
        '***Para la búsqueda por apellido de la solicitud de atención en el web form de busquedaparacaja
        Dim sql As String
        sql = "Select b.NHC,c.NumSolicitudAtencion,d.ApellidoPaterno+' '+d.ApellidoMaterno+' , '+d.Nombres as Paciente,a.CodVenta,d.CodPaciente," + _
        "c.FechaAtencion,f.NomEspecialidad,f.CodEspecialidad from Venta a " + _
        "inner join SolicitudAtencion c on c.CodVenta=a.CodVenta " + _
        "inner join HistoriaClinica b on b.NHC=C.NHC " + _
        "inner join Paciente d on d.CodPaciente=b.CodPaciente " + _
        "inner join DetalleProgramacionMedica g on g.CodDetalleProgramacionMedica=c.CodDetalleProgramacionMedica " + _
        "inner join ProgramacionMedica i on i.CodProgramacionMedica=g.CodProgramacionMedica " + _
        "inner join MedicoEspecialidad h on h.CodMedicoEspecialidad=i.CodMedicoEspecialidad " + _
        "inner join Especialidad f on f.CodEspecialidad=h.CodEspecialidad where c.FechaAtencion='" + CDate(fecha) + "' and d.ApellidoPaterno like '%" + apellido + "%' and c.Reprogramado='False' and c.Anulado='False'"
        Return sql
    End Function
    Function ListarSolicitudAtencion2(ByRef fecha As Date, ByRef apellido As String) As String
        '***Para el web form busquedaparaarchivo
        Dim sql As String
        sql = "Select a.NHC,b.NumSolicitudAtencion,d.CodVenta,f.NomEspecialidad,c.ApellidoPaterno+' '+c.ApellidoMaterno+' , '+c.Nombres as Paciente," + _
        "b.FechaAtencion as FechaSolicitud,d.Fecha as FechaVenta,f.CodEspecialidad,j.NomTipoAtencion from HistoriaClinica a " + _
        "inner join SolicitudAtencion b on a.NHC=b.NHC " + _
        "inner join Paciente c on c.CodPaciente=a.CodPaciente " + _
        "inner join Venta d on d.CodVenta=b.CodVenta " + _
        "inner join DetalleProgramacionMedica i on i.CodDetalleProgramacionMedica=b.CodDetalleProgramacionMedica " + _
        "inner join ProgramacionMedica g on g.CodProgramacionMedica=i.CodProgramacionMedica " + _
        "inner join MedicoEspecialidad h on h.CodMedicoEspecialidad=g.CodMedicoEspecialidad " + _
        "inner join TipoAtencion j on j.CodTipoAtencion=i.CodTipoAtencion " + _
        "inner join Especialidad f on f.CodEspecialidad=h.CodEspecialidad where b.FechaAtencion='" + CDate(fecha) + "' and c.ApellidoPaterno like '%" + apellido + "%' and b.Reprogramado='False' and b.Anulado='False' and d.Estado='V'"
        Return sql
    End Function
    Function CalcularSolicitudAtencionPaciente(ByRef codigopaciente As String, ByRef nhc As String, ByRef fecha As Date, ByRef turno As String)
        '*** Para Entrega de tickets. Para controlar que un paciente no saque un ticket mas de una ves en un mismo turno
        Dim sql As String
        sql = "Select c.CodigoSolicitudAtencion,c.NumSolicitudAtencion,h.NomEspecialidad,j.ApellidoPaterno+' '+j.ApellidoMaterno+' , '+j.Nombres as MEDICO from Paciente a " + _
        "inner join HistoriaClinica b on a.CodPaciente=b.CodPaciente " + _
        "inner join SolicitudAtencion c on c.NHC=b.NHC " + _
        "inner join DetalleProgramacionMedica d on d.CodDetalleProgramacionMedica=c.CodDetalleProgramacionMedica " + _
        "inner join Turno e on e.CodTurno=d.CodTurno " + _
        "inner join ProgramacionMedica f on f.CodProgramacionMedica=d.CodProgramacionMedica " + _
        "inner join MedicoEspecialidad g on g.CodMedicoEspecialidad=f.CodMedicoEspecialidad " + _
        "inner join Especialidad h on h.CodEspecialidad=g.CodEspecialidad " + _
        "inner join Medico i on i.CodMedico=g.CodMedico " + _
        "inner join Personal j on j.CodPersonal=i.CodPersonal " + _
        "where a.CodPaciente='" + codigopaciente + "' and b.NHC='" + nhc + "' and c.FechaAtencion='" + CDate(fecha) + "' and e.CodTurno='" + turno + "'  and c.Reprogramado='False'"
        Return sql
    End Function
    Function ListarCopiaReprogramacionSolicitudAtencion(ByRef dato As String, ByRef fecha As Date)
        '*** Para la búsqueda del web form eliminar solicitud de atención.
        Dim sql As String
        sql = "Select b.NHC,d.ApellidoPaterno+' '+d.ApellidoMaterno+' , '+d.Nombres as Paciente,d.CodPaciente,a.CodigoSolicitudAtencion,a.NumSolicitudAtencion,c.NomEspecialidad,c.CodEspecialidad, " + _
        "i.ApellidoPaterno+' '+i.ApellidoMaterno+' , '+i.Nombres as Medico, " + _
        "e.CodMedico,f.NomTurno,a.FechaAtencion,h.CodVenta, " + _
        "p.ApellidoPaterno+' '+p.ApellidoMaterno+' , '+p.Nombres as Usuario,m.CodUsuario,a.Fecha,j.CodDetalleProgramacionMedica,a.FechaReprogramacion,f.CodTurno,h.Estado,a.CodSolicitudAtencion,a.Reprogramado,a.HoraRegistro,a.Anulado,a.FechaAnulacion from SolicitudAtencion a " + _
        "inner join HistoriaClinica b on b.NHC=a.NHC " + _
        "inner join Paciente d on d.CodPaciente=b.CodPaciente " + _
        "inner join DetalleProgramacionMedica j on j.CodDetalleProgramacionMedica=a.CodDetalleProgramacionMedica " + _
        "inner join ProgramacionMedica k on k.CodProgramacionMedica=j.CodProgramacionMedica " + _
        "inner join MedicoEspecialidad l on l.CodMedicoEspecialidad=k.CodMedicoEspecialidad " + _
        "inner join Especialidad c on c.CodEspecialidad=l.CodEspecialidad " + _
        "inner join Medico e on e.CodMedico=l.CodMedico " + _
        "inner join Turno f on f.CodTurno=j.CodTurno " + _
        "inner join Venta h on h.CodVenta=a.CodVenta " + _
        "inner join Personal i on i.CodPersonal=e.Codpersonal " + _
        "inner join Usuario m on m.CodUsuario=a.CodUsuario " + _
        "inner join TipoAtencion q on q.CodTipoAtencion=j.CodTipoAtencion " + _
        "inner join Personal p on p.CodUsuario=m.CodUsuario where q.CodTipoAtencion='TA1' and d.ApellidoPaterno like '%" + dato + "%' and a.FechaAtencion>='" + CDate(fecha) + "' and a.Reprogramado='False' and a.Anulado='False'"
        Return sql
    End Function
    Function ListarCodigoTicket(ByRef Codigo As String, ByRef codigoVenta As String)
        '****** Para la eliminación del Ticket se obtiene en codigo del ticket
        Dim sql As String
        sql = "Select a.CodigoSolicitudAtencion from SolicitudAtencion c inner join Consulta a " + _
        "on a.CodigoSolicitudAtencion=c.CodigoSolicitudAtencion inner join Venta b " + _
        "on b.CodVenta=c.CodVenta where a.CodigoSolicitudAtencion='" + Codigo + "' and b.CodVenta='" + codigoVenta + "'"
        Return sql
    End Function
    Function CodVenta(ByRef Codigo As String, ByRef codigoVenta As String)
        '****** Para la eliminación del Ticket se obtiene en codigo del ticket
        Dim sql As String
        sql = "Select b.CodVenta from SolicitudAtencion c inner join Consulta a " + _
        "on a.CodigoSolicitudAtencion=c.CodigoSolicitudAtencion inner join Venta b " + _
        "on b.CodVenta=c.CodVenta where a.CodigoSolicitudAtencion='" + Codigo + "' and b.CodVenta='" + codigoVenta + "'"
        Return sql
    End Function
    Function MuestraNumSolicitudAtencion(ByRef codigoturno As String, ByRef codigomedico As String, ByRef codigoespecialidad As String, ByRef fecha As Date)
        '*** Para el web form eliminar ticket
        Dim sql As String
        sql = "Select a.NumSolicitudAtencion from SolicitudAtencion a " + _
        "inner join DetalleProgramacionMedica b on a.CodDetalleProgramacionMedica=b.CodDetalleProgramacionMedica " + _
        "inner join Turno c on c.CodTurno=b.CodTurno " + _
        "inner join ProgramacionMedica d on d.CodProgramacionMedica=b.CodProgramacionMedica " + _
        "inner join MedicoEspecialidad e on e.CodMedicoEspecialidad=d.CodMedicoEspecialidad " + _
        "inner join Especialidad f on f.CodEspecialidad=e.CodEspecialidad " + _
        "inner join Medico g on g.CodMedico=e.CodMedico " + _
        "where c.CodTurno='" + codigoturno + "' and g.CodMedico='" + codigomedico + "' and f.CodEspecialidad='" + codigoespecialidad + "' and a.Fecha='" + CDate(fecha) + "'"
        Return sql
    End Function
    Function GeneraCodigoSolicitudAtencion() As String
        Dim sql As String
        sql = "Select Convert(int,max(right(CodigoSolicitudAtencion,100))) from SolicitudAtencion"
        Dim dato As String = cFunDb.ConsultaUnDato(sql, 0)
        Return dato
    End Function
    Function GeneraCodSolicitudAtencion(ByRef fecha As Date) As String
        Dim strsql As String
        strsql = "Select Convert(int,max(right(CodSolicitudAtencion,50))) from SolicitudAtencion where FechaAtencion='" + CDate(fecha) + "'"
        Dim dato As String = cFunDb.ConsultaUnDato(strsql, 0)
        Return dato
    End Function
    Function GeneraNumSolicitudAtencion(ByRef fecha As Date, ByRef codesp As String, ByRef turno As String, ByRef medico As String) As String
        Dim strsql As String
        strsql = "Select Convert(int,max(right(f.NumSolicitudAtencion,50))) from DetalleProgramacionMedica a " + _
        "inner join Turno b on a.CodTurno=b.CodTurno " + _
        "inner join ProgramacionMedica c on c.CodProgramacionMedica=a.CodProgramacionMedica " + _
        "inner join MedicoEspecialidad d on d.CodMedicoEspecialidad=c.CodMedicoEspecialidad " + _
        "inner join Especialidad e on e.CodEspecialidad=d.CodEspecialidad " + _
        "inner join SolicitudAtencion f on f.CodDetalleProgramacionMedica=a.CodDetalleProgramacionMedica " + _
        "inner join Medico g on g.CodMedico=d.CodMedico " + _
        "where f.FechaAtencion='" + CDate(fecha) + "' and e.CodEspecialidad='" + codesp + "' and b.CodTurno='" + turno + "' and g.CodMedico='" + medico + "'"
        Dim dato As String = cFunDb.ConsultaUnDato(strsql, 0)
        Return dato
    End Function
    Function ContarNumSolicitudAtencion(ByRef fecha As Date, ByRef codesp As String, ByRef turno As String, ByRef medico As String) As String
        Dim strsql As String 'para el web form de reprogramacion solicitud de atencion en el módulo de admision
        strsql = "Select Count(f.NumSolicitudAtencion) from DetalleProgramacionMedica a " + _
        "inner join Turno b on a.CodTurno=b.CodTurno " + _
        "inner join ProgramacionMedica c on c.CodProgramacionMedica=a.CodProgramacionMedica " + _
        "inner join MedicoEspecialidad d on d.CodMedicoEspecialidad=c.CodMedicoEspecialidad " + _
        "inner join Especialidad e on e.CodEspecialidad=d.CodEspecialidad " + _
        "inner join SolicitudAtencion f on f.CodDetalleProgramacionMedica=a.CodDetalleProgramacionMedica " + _
        "inner join Medico g on g.CodMedico=d.CodMedico " + _
        "where f.FechaAtencion='" + CDate(fecha) + "' and e.CodEspecialidad='" + codesp + "' and b.CodTurno='" + turno + "' and g.CodMedico='" + medico + "' and Anulado='False'"
        Dim dato As String = cFunDb.ConsultaUnDato(strsql, 0)
        Return dato
    End Function
    Function MuestraCodigoSolicitudAtencion(ByRef codigosoliaten As String) As String
        '***** Para el formulario de modificacion de programacion medica
        Dim sql As String
        sql = "Select CodigoSolicitudAtencion from SolicitudAtencion where CodDetalleProgramacionMedica='" & codigosoliaten & "'"
        Dim dato As String = cFunDb.ConsultaUnDato(sql, 0)
        Return dato
    End Function
End Class
