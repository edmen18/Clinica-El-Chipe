Imports System.Data.SqlClient
Imports datos
Public Class Consulta
    Dim cFunDb As New cFuncionesDB
    Private s_CodigoConsulta As String
    Private s_CodConsulta As String
    Private s_NumConsulta As String
    Private d_Fecha As Date
    Private s_Hora As String
    Private s_RelatoEnfermedad As String
    Private s_ExamenFisico As String
    Private o_Triaje As Triaje
    Private o_SolicitudAtencion As SolicitudAtencion
    Private d_FechaProximaCita As Date
    Private s_Descripcion As String
    Private s_ResultadoExamen As String

    Public Property CodigoConsulta() As String
        Get
            Return s_CodigoConsulta
        End Get
        Set(ByVal value As String)
            s_CodigoConsulta = value
        End Set
    End Property
    Public Property CodConsulta() As String
        Get
            Return s_CodConsulta
        End Get
        Set(ByVal value As String)
            s_CodConsulta = value
        End Set
    End Property
    Public Property NumConsulta() As String
        Get
            Return s_NumConsulta
        End Get
        Set(ByVal value As String)
            s_NumConsulta = value
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
    Public Property Hora() As String
        Get
            Return s_Hora
        End Get
        Set(ByVal value As String)
            s_Hora = value
        End Set
    End Property
    Public Property RelatoEnfermedad() As String
        Get
            Return s_RelatoEnfermedad
        End Get
        Set(ByVal value As String)
            s_RelatoEnfermedad = value
        End Set
    End Property
    Public Property ExamenFisico() As String
        Get
            Return s_ExamenFisico
        End Get
        Set(ByVal value As String)
            s_ExamenFisico = value
        End Set
    End Property
    Public Property Triaje() As Triaje
        Get
            Return o_Triaje
        End Get
        Set(ByVal value As Triaje)
            o_Triaje = value
        End Set
    End Property
    Public Property SolicitudAtencion() As SolicitudAtencion
        Get
            Return o_SolicitudAtencion
        End Get
        Set(ByVal value As SolicitudAtencion)
            o_SolicitudAtencion = value
        End Set
    End Property
    Public Property FechaProximaCita() As Date
        Get
            Return d_FechaProximaCita
        End Get
        Set(ByVal value As Date)
            d_FechaProximaCita = value
        End Set
    End Property
    Public Property Descripcion() As String
        Get
            Return s_Descripcion
        End Get
        Set(ByVal value As String)
            s_Descripcion = value
        End Set
    End Property
    Public Property ResultadoExamen() As String
        Get
            Return s_ResultadoExamen
        End Get
        Set(ByVal value As String)
            s_ResultadoExamen = value
        End Set
    End Property
    Public Function AgregarConsulta(ByRef codigoconsulta As String, ByRef codconsulta As String, ByRef numconsulta As String, ByRef fecha As Date, ByRef hora As String, ByRef relatoenfermedad As String, ByRef examenfisico As String, ByRef codigotriaje As String, ByRef codigosolicitudatencion As String, ByRef fechaproximacita As Date, ByRef descripcion As String, ByRef resultadoexam As String) As Boolean
        Try
            Dim csql As String = "Insert into Consulta(CodigoConsulta,CodConsulta,NumConsulta,Fecha,Hora,RelatoEnfermedad,ExamenFisico,CodTriaje,CodigoSolicitudAtencion,FechaProximaCita,Descripcion,ResultadoExamen)values('" & codigoconsulta & "','" & codconsulta & "','" & numconsulta & "','" & CDate(fecha) & "','" & hora & "','" & relatoenfermedad & "','" & examenfisico & "','" & codigotriaje & "','" & codigosolicitudatencion & "','" & CDate(fechaproximacita) & "','" & descripcion & "','" & resultadoexam & "')"
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
    Function GeneraCodigoConsulta() As String
        Dim sql As String
        sql = "Select Max(Convert(Int,right(CodigoConsulta,100))) from Consulta"
        Dim dato As String = cFunDb.ConsultaUnDato(sql, 0)
        Return dato
    End Function
    Function GeneraCodConsulta(ByRef fecha As Date) As String
        Dim sql As String
        sql = "Select Max(Convert(Int,right(CodConsulta,100))) from Consulta where Fecha>='" & CDate(fecha) & "'"
        Dim dato As String = cFunDb.ConsultaUnDato(sql, 0)
        Return dato
    End Function
    Function GeneraNumConsulta(ByRef fecha As Date, ByRef codesp As String) As String
        Dim sql As String
        sql = "Select Max(Convert(Int,right(g.NumConsulta,50))) from DetalleProgramacionMedica a " + _
        "inner join Turno b on a.CodTurno=b.CodTurno inner join ProgramacionMedica c on c.CodProgramacionMedica=a.CodProgramacionMedica " + _
        "inner join MedicoEspecialidad d on d.CodMedicoEspecialidad=c.CodMedicoEspecialidad " + _
        "inner join Especialidad e on e.CodEspecialidad=d.CodEspecialidad " + _
        "inner join SolicitudAtencion f on f.CodDetalleProgramacionMedica=a.CodDetalleProgramacionMedica " + _
        "inner join Consulta g on g.CodigoSolicitudAtencion=f.CodigoSolicitudAtencion " + _
        "inner join HistoriaClinica h on h.NHC=f.NHC " + _
        "inner join Movimiento i on i.NHC=h.NHC where f.FechaAtencion>='" & CDate(fecha) & "' and e.CodEspecialidad='" & codesp & "'" + _
        "and i.Fecha>='" & CDate(fecha) & "'"
        Dim dato As String = cFunDb.ConsultaUnDato(sql, 0)
        Return dato
    End Function
    Function MuestraCodigoConsulta(ByRef codigosoliaten As String) As String
        '***** Para el formulario eliminar solicitud de consulta ***********
        Dim sql As String
        sql = "Select b.CodigoConsulta from SolicitudAtencion a " + _
        "inner join Consulta b on a.CodigoSolicitudAtencion=b.CodigoSolicitudAtencion " + _
        "where a.CodigoSolicitudAtencion='" & codigosoliaten & "'"
        Dim dato As String = cFunDb.ConsultaUnDato(sql, 0)
        Return dato
    End Function
End Class
