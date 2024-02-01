Imports System.Data.SqlClient
Imports datos
Public Class Solicitud
    Dim cFunDb As New cFuncionesDB
    Private s_CodSolicitud As String
    Private o_Servicio As Servicio
    Private s_NumSolicitud As String
    Private o_Consulta As Consulta
    Private s_EnfermedadActual As String
    Private s_Solicitud As String
    Private s_Motivo As String
    Private d_Fecha As Date
    Private s_Descripcion As String
    Private o_TipoSolicitud As TipoSolicitud

    Public Property CodSolicitud() As String
        Get
            Return s_CodSolicitud
        End Get
        Set(ByVal value As String)
            s_CodSolicitud = value
        End Set
    End Property
    Public Property NumSolicitud() As String
        Get
            Return s_NumSolicitud
        End Get
        Set(ByVal value As String)
            s_NumSolicitud = value
        End Set
    End Property
    Public Property Consulta() As Consulta
        Get
            Return o_Consulta
        End Get
        Set(ByVal value As Consulta)
            o_Consulta = value
        End Set
    End Property
    Public Property EnfermedadActual() As String
        Get
            Return s_EnfermedadActual
        End Get
        Set(ByVal value As String)
            s_EnfermedadActual = value
        End Set
    End Property
    Public Property Solicitud() As String
        Get
            Return s_Solicitud
        End Get
        Set(ByVal value As String)
            s_Solicitud = value
        End Set
    End Property
    Public Property Motivo() As String
        Get
            Return s_Motivo
        End Get
        Set(ByVal value As String)
            s_Motivo = value
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
    Public Property Descripcion() As String
        Get
            Return s_Descripcion
        End Get
        Set(ByVal value As String)
            s_Descripcion = value
        End Set
    End Property
    Public Property TipoSolicitud() As TipoSolicitud
        Get
            Return o_TipoSolicitud
        End Get
        Set(ByVal value As TipoSolicitud)
            o_TipoSolicitud = value
        End Set
    End Property
    Function GeneraCodigoServicio() As String
        Dim sql As String
        sql = "Select Max(Convert(Int,right(CodSolicitud,50))) from Solicitud"
        Dim dato As String = cFunDb.ConsultaUnDato(sql, 0)
        Return dato
    End Function
    Public Function AgregarSolicitud(ByRef codsolicitud As String, ByRef codservicio As String, ByRef codigoconsulta As String, ByRef enfermedadactual As String, ByRef solicitud As String, ByRef motivo As String, ByRef fecha As Date, ByRef descripcion As String, ByRef codtiposolicitud As String) As Boolean
        Try
            Dim csql As String = "Insert into Solicitud(CodSolicitud,CodServicio,CodigoConsulta,EnfermedadActual,Solicitud,Motivo,Fecha,Descripcion,CodTipoSolicitud)values('" & codsolicitud & "','" & codservicio & "','" & codigoconsulta & "','" & enfermedadactual & "','" & solicitud & "','" & motivo & "','" & CDate(fecha) & "','" & descripcion & "','" & codtiposolicitud & "')"
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
    Function ListaSolicitud(ByRef dato As String)
        Dim sql As String
        sql = "Select a.CodSolicitud,b.NomServicio,b.CodServicio,f.ApellidoPaterno+' '+f.ApellidoMaterno+' , '+f.Nombres as Paciente,a.Fecha from Solicitud a " + _
        "inner join Servicio b on a.CodServicio=b.CodServicio " + _
        "inner join Consulta c on c.CodigoConsulta=a.CodigoConsulta " + _
        "inner join Ticket d on d.CodigoTicket=c.CodigoTicket " + _
        "inner join HistoriaClinica e on e.NHC=d.NHC " + _
        "inner join Paciente f on f.CodPaciente=e.CodPaciente where f.Nombres like '%" + dato + "%' or f.ApellidoPaterno like '%" + dato + "%'" + _
        "or f.ApellidoMaterno like '%" + dato + "%'"
        Return sql
    End Function
End Class
