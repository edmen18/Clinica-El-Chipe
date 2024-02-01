Imports System.Data.SqlClient
Imports datos
Public Class Movimiento
    Private cFunDB As cFuncionesDB
    Private o_Area As Area
    Private o_HistoriaClinica As HistoriaClinica
    Private s_De As String
    Private s_A As String
    Private d_Fecha As Date
    Private s_Hora As String
    Private o_Usuario As Usuario
    Private o_Turno As Turno
    Private o_Especialidad As Especialidad
    Public Property Area() As Area
        Get
            Return o_Area
        End Get
        Set(ByVal value As Area)
            o_Area = value
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
    Public Property De() As String
        Get
            Return s_De
        End Get
        Set(ByVal value As String)
            s_De = value
        End Set
    End Property
    Public Property A() As String
        Get
            Return s_A
        End Get
        Set(ByVal value As String)
            s_A = value
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
    Public Property Usuario() As Usuario
        Get
            Return o_Usuario
        End Get
        Set(ByVal value As Usuario)
            o_Usuario = value
        End Set
    End Property
    Public Property Turno() As Turno
        Get
            Return o_Turno
        End Get
        Set(ByVal value As Turno)
            o_Turno = value
        End Set
    End Property
    Public Property Especialidad() As Especialidad
        Get
            Return o_Especialidad
        End Get
        Set(ByVal value As Especialidad)
            o_Especialidad = value
        End Set
    End Property
    Public Function AgregarMovimiento(ByRef codigoarea As String, ByRef nhc As String, ByRef de As String, ByRef a As String, ByRef Fecha As Date, ByRef hora As String, ByRef codigousuario As String, ByRef codigoturno As String, ByRef codigoespecialidad As String) As Boolean
        Try
            Dim csql As String = "Insert into Movimiento(CodArea,NHC,De,A,Fecha,Hora,CodUsuario,CodTurno,CodEspecialidad) values ('" & codigoarea & "','" & nhc & "','" & de & "','" & a & "','" & CDate(Fecha) & "','" & hora & "','" & codigousuario & "','" & codigoturno & "','" & codigoespecialidad & "')"
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
    Function ListarMovimientos(ByRef fecha As Date, ByRef paciente As String) As String
        Dim sql As String
        sql = "Select a.NHC,b.CodigoSolicitudAtencion,b.NumSolicitudAtencion,c.CodVenta, d.ApellidoPaterno+' '+d.ApellidoMaterno+' , '+d.Nombres as Paciente," + _
        "a.A as Area, e.NomEspecialidad, e.CodEspecialidad, f.CodMedico,j.ApellidoPaterno+' '+j.ApellidoMaterno+' , '+j.Nombres as Medico," + _
        "g.Antecedentes,k.CodTriaje,k.Temperatura,k.FR,k.PA,k.Peso,k.Talla,k.Fecha as FechaTriaje from Movimiento a " + _
        "inner join Historiaclinica g on a.NHC=g.NHC " + _
        "inner join SolicitudAtencion b on b.NHC=g.NHC " + _
        "inner join Venta c on c.CodVenta=b.CodVenta " + _
        "inner join Paciente d on d.CodPaciente=g.CodPaciente " + _
        "inner join DetalleProgramacionMedica h on h.CodDetalleProgramacionMedica=b.CodDetalleProgramacionMedica " + _
        "inner join ProgramacionMedica l on l.CodProgramacionMedica=h.CodProgramacionMedica " + _
        "inner join MedicoEspecialidad i on i.CodMedicoEspecialidad=l.CodMedicoEspecialidad " + _
        "inner join Especialidad e on e.CodEspecialidad=i.CodEspecialidad " + _
        "inner join Medico f on f.CodMedico=i.CodMedico " + _
        "inner join Personal j on j.CodPersonal=f.CodPersonal " + _
        "inner join Triaje k on k.CodPaciente=d.CodPaciente where b.FechaAtencion>='" + CDate(fecha) + "' and a.Fecha>='" + CDate(fecha) + "' and k.Fecha>='" + CDate(fecha) + "' and d.ApellidoPaterno like '%" + paciente + "%'"
        Return sql
    End Function
End Class
