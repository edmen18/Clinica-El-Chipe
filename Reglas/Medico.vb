Imports datos
Imports System.Data.SqlClient
Imports System.Web.UI.WebControls

Public Class Medico
    Dim cFun As New cFuncionesDB
    Private s_CodMedico As String
    Private o_Personal As Personal
    Private o_TipoProfesionalMedico As TipoProfesionalMedico
    Public Property CodMedico() As String
        Get
            Return s_CodMedico
        End Get
        Set(ByVal value As String)
            s_CodMedico = value
        End Set
    End Property
    Public Property Personal() As Personal
        Get
            Return o_Personal
        End Get
        Set(ByVal value As Personal)
            o_Personal = value
        End Set
    End Property
    Public Property TipoProfesionalMedico() As TipoProfesionalMedico
        Get
            Return o_TipoProfesionalMedico
        End Get
        Set(ByVal value As TipoProfesionalMedico)
            o_TipoProfesionalMedico = value
        End Set
    End Property
    Public Function AgregarMedico(ByRef codigomedio As String, ByRef codigopersonal As String, ByRef codigotipoprofesional As String) As Boolean
        Try
            Dim csql As String = "Insert into Medico(CodMedico,CodPersonal,CodTipoProfesionalMedico,estado) values ('" + codigomedio + "','" + codigopersonal + "','" + codigotipoprofesional + "','1')"
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
    Public Function EliminarMedico(ByRef codigomedico As String) As Boolean
        Try
            Dim csql As String = "Update Medico set estado ='0' where CodMedico='" + codigomedico + "'"
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
    Public Function ModificarMedico(ByRef codigotipoprofesionalmedico As String, ByRef codigomedico As String) As Boolean
        Try
            Dim csql As String = "Update medico set CodTipoProfesionalMedico ='" + codigotipoprofesionalmedico + "' where CodMedico='" + codigomedico + "'"
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
    Function generarMedico()
        Dim csql As String = "select count(*)+1 from medico"
        Return csql
    End Function
    Public Sub CargarMedicos(ByVal COMBO As DropDownList, ByVal codigoespecialidad As String)
        Dim csql As String = "Select m.CodMedico,Nombres+' '+ApellidoPaterno+' '+ApellidoMaterno as NOMBRE from Personal p inner join Medico m on m.CodPersonal=p.CodPersonal inner join medicoespecialidad me on me.codmedico=m.codmedico where m.Estado='1' and me.codespecialidad='" + codigoespecialidad + "'"
        cFun.FillListaOrCombo(csql, COMBO, "NOMBRE", "CODMEDICO")
    End Sub
    Function ListaMedicos(ByRef turno As String, ByRef fecha As Date, ByRef codigoespe As String)
        Dim sql As String
        sql = "Select g.CodMedico,h.ApellidoPaterno+' '+h.ApellidoMaterno+' , '+h.Nombres as MEDICO,a.CodDetalleProgramacionMedica from DetalleProgramacionMedica a " + _
        "inner join Turno b on a.CodTurno=b.CodTurno " + _
        "inner join ProgramacionMedica c on c.CodProgramacionMedica=a.CodProgramacionMedica " + _
        "inner join MedicoEspecialidad d on d.CodMedicoEspecialidad=c.CodMedicoEspecialidad " + _
        "inner join Especialidad e on e.CodEspecialidad=d.CodEspecialidad " + _
        "inner join Medico g on g.CodMedico=d.CodMedico " + _
        "inner join Personal h on h.CodPersonal=g.CodPersonal where " + _
        "b.CodTurno='" + turno + "' and a.FechaAtencion='" + CDate(fecha) + "' and e.CodEspecialidad='" + codigoespe + "' and a.Atencion='1' and a.Estado='True'"
        Return sql
    End Function
    Function buscar(ByVal dato As String)
        Dim csql As String = "select CodPersonal as codigo,nombres as nombre,ApellidoPaterno+' '+ ApellidoMaterno as apellidos,NomTipoDoc +': '+NumeroDocIdentidad as identidad from dbo.Personal p inner join dbo.TipoDocIdentidad td on p.CodTipoDocIdentidad=td.CodTipoDocIdentidad where (p.CodTipoPersonal='TP006' or p.CodTipoPersonal='TP007')and( ApellidoPaterno+' '+ ApellidoMaterno+' '+nombres like '%" + dato + "%' or NumeroDocIdentidad like '%" + dato + "%'or nombres+' '+ApellidoPaterno+' '+ ApellidoMaterno like '%" + dato + "%')"
        Return csql
    End Function
    Function codmedicoobtener(ByVal personal As String)
        Dim csql As String = "select codmedico from medico where codpersonal='" + personal + "'"
        Return csql
    End Function
    Function obtenerespecialidades(ByVal medico As String)
        Dim csql As String = "select CodMedicoEspecialidad as codmesp,e.codespecialidad as codigo,nomespecialidad as especialidad from especialidad e inner join medicoespecialidad me on me.codespecialidad=e.codespecialidad where me.codmedico='" + medico + "' and me.estado='1'"
        Return csql
    End Function
    Function obtenerTipoProfesionalMedico(ByVal medico As String)
        Dim csql As String = "select pm.codtipoprofesionalmedico,nomtipoprofesionalmedico from tipoprofesionalmedico pm inner join medico m on m.codtipoprofesionalmedico=pm.codtipoprofesionalmedico where m.codmedico='" + medico + "'"
        Return csql
    End Function
End Class
