Imports System.Data.SqlClient
Imports datos
Imports System.Web.UI.WebControls

Public Class DetalleProgramacionMedica
    Dim cFun As New cFuncionesDB
    Private s_CodDetalleProgramacionMedica As String
    Private o_ProgramacionMedica As ProgramacionMedica
    Private o_Turno As Turno
    Private d_FechaAtencion As Date
    Private d_FechaRegistro As Date
    Private c_Atencion As Char
    Private i_CantidadPacientesAtender As Integer
    Private o_TipoAtencion As TipoAtencion
    Private b_Estado As Boolean
    Private o_SalaOperacion As SalaOperacion
    Private c_HoraOperacion As Char
    Private s_DuracionAproxOperacion As String
    Private o_Cama As Cama
    Public Property CodDetalleProgramacionMedica() As String
        Get
            Return s_CodDetalleProgramacionMedica
        End Get
        Set(ByVal value As String)
            s_CodDetalleProgramacionMedica = value
        End Set
    End Property
    Public Property ProgramacionMedica() As ProgramacionMedica
        Get
            Return o_ProgramacionMedica
        End Get
        Set(ByVal value As ProgramacionMedica)
            o_ProgramacionMedica = value
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
    Public Property FechaAtencion() As Date
        Get
            Return d_FechaAtencion
        End Get
        Set(ByVal value As Date)
            d_FechaAtencion = value
        End Set
    End Property
    Public Property FechaRegistro() As Date
        Get
            Return d_FechaRegistro
        End Get
        Set(ByVal value As Date)
            d_FechaRegistro = value
        End Set
    End Property
    Public Property Atencion() As Char
        Get
            Return c_Atencion
        End Get
        Set(ByVal value As Char)
            c_Atencion = value
        End Set
    End Property
    Public Property CantidadPacientesAtender() As Integer
        Get
            Return i_CantidadPacientesAtender
        End Get
        Set(ByVal value As Integer)
            i_CantidadPacientesAtender = value
        End Set
    End Property
    Public Property TipoAtencion() As TipoAtencion
        Get
            Return o_TipoAtencion
        End Get
        Set(ByVal value As TipoAtencion)
            o_TipoAtencion = value
        End Set
    End Property
    Public Property Estado() As Boolean
        Get
            Return b_Estado
        End Get
        Set(ByVal value As Boolean)
            b_Estado = value
        End Set
    End Property
    Public Property SalaOperacion() As SalaOperacion
        Get
            Return o_SalaOperacion
        End Get
        Set(ByVal value As SalaOperacion)
            o_SalaOperacion = value
        End Set
    End Property
    Public Property HoraOperacion() As Char
        Get
            Return c_HoraOperacion
        End Get
        Set(ByVal value As Char)
            c_HoraOperacion = value
        End Set
    End Property
    Public Property DuracionAproxOperacion() As String
        Get
            Return s_DuracionAproxOperacion
        End Get
        Set(ByVal value As String)
            s_DuracionAproxOperacion = value
        End Set
    End Property
    Public Property Cama() As Cama
        Get
            Return o_Cama
        End Get
        Set(ByVal value As Cama)
            o_Cama = value
        End Set
    End Property
    Public Function AgregarDetalleProgramacion(ByRef codigodetalleprogramacionmedica As String, ByRef codigoprogramacionmedica As String, ByRef codigoturno As String, ByRef fechaatencion As Date, ByRef fecharegistro As Date, ByRef atencion As CheckBox, ByRef cantidadpacientesatender As TextBox, ByRef codtipoatencion As String, ByRef estado As Boolean, ByRef codigosalaoperacion As String, ByRef horaoperacion As String, ByRef duracionoperacion As String, ByRef codigocama As String) As Boolean
        Try
            Dim aten As String
            If (atencion.Checked) Then
                aten = "1"
            Else
                aten = "0"
            End If
            Dim csql As String = "Insert into DetalleProgramacionMedica(CodDetalleProgramacionMedica,CodProgramacionMedica,CodTurno,FechaAtencion,FechaRegistro,Atencion,CantidadPacientesAtender,CodTipoAtencion,Estado,CodSalaOperacion,HoraOperacion,DuracionAproxOperacion,CodCama) values ('" & codigodetalleprogramacionmedica & "','" & codigoprogramacionmedica & "','" & codigoturno & "','" & CDate(fechaatencion) & "','" & CDate(fecharegistro) & "','" & aten & "'," & cantidadpacientesatender.Text & ",'" & codtipoatencion & "','" & estado & "','" & codigosalaoperacion & "','" & horaoperacion & "','" & duracionoperacion & "','" & codigocama & "')"
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
    Public Function ModificarDetalleProgramacion(ByRef atencion As String, ByRef cantidadpacientes As Integer, ByRef codigodetalleprogramacionmedicas As String) As Boolean
        Try
            Dim csql As String = "Update DetalleProgramacionMedica  set atencion='" + atencion + "',CantidadPacientesAtender='" + cantidadpacientes.ToString + "' where CodDetalleProgramacionMedica='" + codigodetalleprogramacionmedicas + "'"
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
    Public Function EliminarDetalleProgramacion() As Boolean
        Try
            Dim csql As String = "Update DetalleProgramacionMedica set estado='False' where CodDetalleProgramacionMedica='" + CodDetalleProgramacionMedica + "'"
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
    '****** Para el web form de eliminacion de tickets
    Function CantidadCon(ByRef c As String)
        Dim sql As String
        sql = "Select CantidadPacientesAtender from DetalleProgramacionMedica where CodDetalleProgramacionMedica='" + c + ""
        Return sql
    End Function
    Function GeneraCodigoDetalleProgramacionMedica()
        Dim sql As String
        sql = "Select count(*)+1 from DetalleProgramacionMedica"
        Dim dato As String = cFun.ConsultaUnDato(sql, 0)
        Return dato
    End Function
    Function CantidadPacientes(ByRef fecha As Date, ByRef codigoespecialidad As String, ByRef codigoturno As String, ByRef codigomedico As String) As String
        Dim sql As String
        sql = "Select a.CantidadPacientesAtender from DetalleProgramacionMedica a " + _
        "inner join Turno b on a.CodTurno=b.CodTurno " + _
        "inner join ProgramacionMedica c on c.CodProgramacionMedica=a.CodProgramacionMedica " + _
        "inner join MedicoEspecialidad d on d.CodMedicoEspecialidad=c.CodMedicoEspecialidad " + _
        "inner join Especialidad e on e.CodEspecialidad=d.CodEspecialidad " + _
        "inner join Medico f on f.CodMedico=d.CodMedico " + _
        "where a.FechaAtencion='" + CDate(fecha) + "' and e.CodEspecialidad='" + codigoespecialidad + "' and b.CodTurno='" + codigoturno + "' and f.CodMedico='" + codigomedico + "'"
        Return sql
    End Function
    Function ListaCodDetalleProgramacionMedica(ByRef codigoturno As String, ByRef fecha As Date, ByRef cantidad As Integer, ByRef codigoespecialidad As String, ByRef codigomedico As String) As String
        Dim sql As String
        sql = "Select a.CodDetalleProgramacionMedica from DetalleProgramacionMedica a " + _
        "inner join Turno b on a.CodTurno=b.CodTurno " + _
        "inner join ProgramacionMedica c on c.CodProgramacionMedica=a.CodProgramacionMedica " + _
        "inner join MedicoEspecialidad d on d.CodMedicoEspecialidad=c.CodMedicoEspecialidad " + _
        "inner join Especialidad e on e.CodEspecialidad=d.CodEspecialidad " + _
        "inner join Medico g on g.CodMedico=d.CodMedico where " + _
        "b.CodTurno='" + codigoturno + "' and a.FechaAtencion='" + CDate(fecha) + "' and '" + cantidad.ToString + "'>0 and e.CodEspecialidad='" + codigoespecialidad + "' and g.CodMedico='" + codigomedico + "' and a.Atencion='1' and a.Estado='True'"
        Return sql
    End Function
End Class