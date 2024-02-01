Imports System.Data.SqlClient
Imports datos
Imports System.Web.UI.WebControls
Imports Reportes
Public Class ProgramacionMedica
    Dim cFun As New cFuncionesDB
    Dim db As New BaseDatos
    Private s_CodProgramacionMedica As String
    Private o_MedicoEspecialidad As MedicoEspecialidad
    Private d_FechaProMedica As Date
    Private o_Usuario As Usuario
    Public Property CodProgramacionMedica() As String
        Get
            Return s_CodProgramacionMedica
        End Get
        Set(ByVal value As String)
            s_CodProgramacionMedica = value
        End Set
    End Property
    Public Property MedicoEspecialidad() As MedicoEspecialidad
        Get
            Return o_MedicoEspecialidad
        End Get
        Set(ByVal value As MedicoEspecialidad)
            o_MedicoEspecialidad = value
        End Set
    End Property
    Public Property FechaProMedica() As Date
        Get
            Return d_FechaProMedica
        End Get
        Set(ByVal value As Date)
            d_FechaProMedica = value
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
    Function GeneraCodigoProgramacionMedica()
        Dim sql As String
        sql = "Select count(*)+1 from ProgramacionMedica"
        Dim dato As String = cFun.ConsultaUnDato(sql, 0)
        Return dato
    End Function
    Public Function AgregarProgramacionMedica(ByRef codigoprogramacionmedica As String, ByRef codigomedicoespecialidad As String, ByRef fechaprogramacionmedica As Date, ByRef codusuario As String) As Boolean
        Try
            Dim csql As String = "Insert into ProgramacionMedica(CodProgramacionMedica,CodMedicoEspecialidad,FechaProMedica,CodUsuario) values ('" & codigoprogramacionmedica & "','" & codigomedicoespecialidad & "','" & CDate(fechaprogramacionmedica) & "','" & codusuario & "')"
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
    Public Function ReporteProgramacionMedica(ByVal fecha As Date) As DataSet
        db.Conectar()
        Dim adaptador As New SqlDataAdapter("Select e.NomEspecialidad as Especialidad,p.Nombres+' '+p.ApellidoPaterno+' '+p.ApellidoMaterno as Medico,t.NomTurno as Turno,convert(char(10),dpm.Fecha,103) as Fecha,dpm.CantidadConsultasAtender as Tickets,dpm.TipoAtencion as TipoAtencion from Personal p inner join Medico m on p.codpersonal=m.codpersonal inner join MedicoEspecialidad me on me.CodMedico=m.CodMedico inner join Especialidad e on e.CodEspecialidad=me.CodEspecialidad inner join ProgramacionMedica pm on pm.CodMedicoEspecialidad=me.CodMedicoEspecialidad inner join DetalleProgramacionMedica dpm on dpm.CodProgramacionMedica=pm.CodProgramacionMedica inner join Turno t on t.CodTurno=dpm.codturno where dpm.Fecha='" & fecha & "'", db._Conexion)
        Dim ds As New DsPMDiaria
        adaptador.Fill(ds.Tables("ProgramacionMedicaDiaria"))
        Return ds
    End Function

    'Public Function consulta(ByVal fech As Date) As DataSet
    '    db.Conectar()
    '    Dim adaptador As New SqlDataAdapter("select Nombres+' '+ApellidoPaterno+' '+ApellidoMaterno as nombre,NomEspecialidad,NomTurno ,convert(char(10),Fecha,103) as Fecha,CantidadConsultasAtender,atencion from dbo.Personal p inner join dbo.Medico m on p.codpersonal=m.codpersonal inner join dbo.MedicoEspecialidad me on me.CodMedico=m.CodMedico inner join dbo.Especialidad e on e.CodEspecialidad=me.CodEspecialidad inner join dbo.ProgramacionMedica pm on pm.CodMedicoEspecialidad=me.CodMedicoEspecialidad inner join dbo.DetalleProgramacionMedica dpm on dpm.CodProgramacionMedica=pm.CodProgramacionMedica inner join dbo.Turno t on t.CodTurno=dpm.codturno and Fecha='" + fech + "'and CodDetalleProgramacionMedica='" + Me.CodDetalle + "'", db._Conexion)
    '    'Dim ds As New DsProgramacion
    '    adaptador.Fill(ds.Tables("Dtprogramacion"))
    '    Return ds
    'End Function
End Class
