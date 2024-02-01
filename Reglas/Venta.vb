Imports System.Data.SqlClient
Imports datos
Imports System.Web.UI.WebControls
Imports Reportes

Public Class Venta
    Dim cFunDb As New cFuncionesDB
    Private s_CodVenta As String
    Private o_Area As Area
    Private o_Turno As Turno
    Private o_Usuario As Usuario
    Private o_Paciente As Paciente
    Private d_Total As Double
    Private s_Estado As String
    Private d_Fecha As Date
    Private s_Hora As String
    Private b_Anulacion As Boolean
    Private d_IGV As Double
    Private d_TotalIGV As Double

    Public Property CodVenta() As String
        Get
            Return s_CodVenta
        End Get
        Set(ByVal value As String)
            s_CodVenta = value
        End Set
    End Property
    Public Property Area() As Area
        Get
            Return o_Area
        End Get
        Set(ByVal value As Area)
            o_Area = value
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
    Public Property Usuario() As Usuario
        Get
            Return o_Usuario
        End Get
        Set(ByVal value As Usuario)
            o_Usuario = value
        End Set
    End Property
    Public Property Paciente() As Paciente
        Get
            Return o_Paciente
        End Get
        Set(ByVal value As Paciente)
            o_Paciente = value
        End Set
    End Property
    Public Property Total() As Double
        Get
            Return d_Total
        End Get
        Set(ByVal value As Double)
            d_Total = value
        End Set
    End Property

    Public Property Estado() As String
        Get
            Return s_Estado
        End Get
        Set(ByVal value As String)
            s_Estado = value
        End Set
    End Property

    Public Property Fecha() As String
        Get
            Return d_Fecha
        End Get
        Set(ByVal value As String)
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

    Public Property Anulacion() As Boolean
        Get
            Return b_Anulacion
        End Get
        Set(ByVal value As Boolean)
            b_Anulacion = value
        End Set
    End Property
    Public Property IGV() As Double
        Get
            Return d_IGV
        End Get
        Set(ByVal value As Double)
            d_IGV = value
        End Set
    End Property
    Public Property TotalIGV() As Double
        Get
            Return d_TotalIGV
        End Get
        Set(ByVal value As Double)
            d_TotalIGV = value
        End Set
    End Property
    Public Function AgregarVenta(ByRef codigo As String, ByRef codigoarea As String, ByRef codigoturno As String, ByRef codigousuario As String, ByRef codigopaciente As String, ByRef total As Double, ByRef estado As String, ByRef fecha As Date, ByRef hora As String, ByRef anulacion As Boolean, ByRef IGV As String, ByRef Monto As Double) As Boolean
        Try
            Dim csql As String = "Insert into Venta(CodVenta,CodArea,CodTurno,CodUsuario,CodPaciente,Total,Estado,Fecha,Hora,Anulacion,CodIGV,TotalIGV) values ('" & codigo & "','" & codigoarea & "','" & codigoturno & "','" & codigousuario & "','" & codigopaciente & "','" & total & "','" & estado & "','" & CDate(fecha) & "','" & hora & "','" & anulacion & "','" & IGV & "','" & Monto & "')"
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

    Public Function AnularVenta(ByVal codigo As String) As Boolean
        Try
            Dim csql As String = "update Venta set Anulacion='True' where  CodVenta='" + codigo + "' "
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

    Public Function AgregarVenta2(ByRef codigo As String, ByRef codigoarea As String, ByRef codigoturno As String, ByRef codigousuario As String, ByRef codigopaciente As String, ByRef total As Double, ByRef estado As String, ByRef fecha As Date, ByRef hora As String, ByRef anulacion As Boolean, ByRef IGV As String, ByRef Monto As Double) As Boolean
        Try
            Dim csql As String = "Update Venta set CodArea='" & codigoarea & "',CodTurno='" & codigoturno & "',CodUsuario='" & codigousuario & "',Total='" & total.ToString & "',Estado='" & estado & "',Fecha='" & fecha & "',Hora='" + hora + "',CodIGV='" & IGV.ToString & "',TotalIGV='" & Monto.ToString & "' where CodVenta='" & codigo & "' and CodPaciente='" & codigopaciente & "'"
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
    Public Function ModificarVenta(ByRef codigoventa As String, ByRef estado As String) As Boolean
        Try
            Dim csql As String = "Update Venta set Anulacion='True' where CodVenta='" + codigoventa + "' and Estado='" + estado + "'"
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
    Function GeneraCodigoVenta()
        Dim sql As String
        sql = "Select count(*)+1 from Venta"
        Return sql
    End Function

    Function consultaventa(ByVal dato As String, ByVal fechadel As Date, ByVal fechaal As Date, ByVal ind As Integer, ByRef grid As GridView)
        Dim csql As String
        Try
            If ind = 1 Then ' por estado anulada o efectiva
                csql = "select NomTipoComprobante as comprobante,numero,nomturno,p.Nombres+' '+p.ApellidoPaterno+' '+p.ApellidoMaterno as paciente, convert(char(10),v.Fecha,103)as fecha,Total,TotalIGV,pe.Nombres+' '+pe.ApellidoPaterno+' '+pe.ApellidoMaterno as usuario,v.anulacion as anula,tc.CodTipoComprobante as codtc,v.codventa from dbo.Comprobante c inner join dbo.TipoComprobante tc on c.CodTipoComprobante=tc.CodTipoComprobante inner join dbo.Venta v on v.CodVenta=c.CodVenta inner join dbo.Turno t on t.CodTurno=v.CodTurno inner join dbo.Paciente p on p.CodPaciente=v.CodPaciente inner join dbo.Usuario u on u.CodUsuario=v.CodUsuario inner join dbo.Personal pe on pe.CodUsuario=u.CodUsuario where v.anulacion='" & CBool(dato) & "' and v.fecha>='" & fechadel & "' and v.fecha<='" & fechaal & "'"
            End If
            If ind = 2 Then ' por comprobante
                csql = "select NomTipoComprobante as comprobante,numero,nomturno,p.Nombres+' '+p.ApellidoPaterno+' '+p.ApellidoMaterno as paciente, convert(char(10),v.Fecha,103)as fecha,Total,TotalIGV,pe.Nombres+' '+pe.ApellidoPaterno+' '+pe.ApellidoMaterno as usuario,v.anulacion as anula,tc.CodTipoComprobante as codtc,v.codventa from dbo.Comprobante c inner join dbo.TipoComprobante tc on c.CodTipoComprobante=tc.CodTipoComprobante inner join dbo.Venta v on v.CodVenta=c.CodVenta inner join dbo.Turno t on t.CodTurno=v.CodTurno inner join dbo.Paciente p on p.CodPaciente=v.CodPaciente inner join dbo.Usuario u on u.CodUsuario=v.CodUsuario inner join dbo.Personal pe on pe.CodUsuario=u.CodUsuario where tc.codtipocomprobante='" & dato & "' and v.fecha>='" & fechadel & "' and v.fecha<='" & fechaal & "'"
            End If
            If ind = 3 Then ' por fecha
                csql = "select NomTipoComprobante as comprobante,numero,nomturno,p.Nombres+' '+p.ApellidoPaterno+' '+p.ApellidoMaterno as paciente, convert(char(10),v.Fecha,103)as fecha,Total,TotalIGV,pe.Nombres+' '+pe.ApellidoPaterno+' '+pe.ApellidoMaterno as usuario,v.anulacion as anula,tc.CodTipoComprobante as codtc,v.codventa from dbo.Comprobante c inner join dbo.TipoComprobante tc on c.CodTipoComprobante=tc.CodTipoComprobante inner join dbo.Venta v on v.CodVenta=c.CodVenta inner join dbo.Turno t on t.CodTurno=v.CodTurno inner join dbo.Paciente p on p.CodPaciente=v.CodPaciente inner join dbo.Usuario u on u.CodUsuario=v.CodUsuario inner join dbo.Personal pe on pe.CodUsuario=u.CodUsuario where v.fecha>='" & fechadel & "' and v.fecha<='" & fechaal & "'"
            End If
            cFunDb.FillDataGridView(csql, grid)
        Catch ex As Exception
            MsgBox("Error al operar con la base de datos!", MsgBoxStyle.Critical, "Error!")
        End Try
        
    End Function

    Function ventaatencion(ByVal codven As String)
        Dim csql As String = "select ta.CodTipoAtencion from dbo.TipoAtencion ta inner join dbo.DetalleProgramacionMedica dpm on ta.CodTipoAtencion=dpm.CodTipoAtencion inner join dbo.SolicitudAtencion sa on sa.CodDetalleProgramacionMedica=dpm.CodDetalleProgramacionMedica inner join dbo.Venta v on v.codventa=sa.codventa where v.codventa='" + codven + "'"
        Return cFunDb.ConsultaUnDato(csql, 0)
    End Function

    Public Function Imprimedetalle(ByVal dato As String) As DataSet
        Dim db As BaseDatos = New BaseDatos()
        db.Conectar()
        Dim ds As New Ds_cabecera
        Dim adaptador As New SqlDataAdapter("select NomTipoComprobante as comprobante,numero,nomturno,p.Nombres+' '+p.ApellidoPaterno+' '+p.ApellidoMaterno as paciente, convert(char(10),v.Fecha,103)as fecha,Total,TotalIGV,pe.Nombres+' '+pe.ApellidoPaterno+' '+pe.ApellidoMaterno as usuario,v.anulacion as anula,tc.CodTipoComprobante as codtc,v.codventa from dbo.Comprobante c inner join dbo.TipoComprobante tc on c.CodTipoComprobante=tc.CodTipoComprobante inner join dbo.Venta v on v.CodVenta=c.CodVenta inner join dbo.Turno t on t.CodTurno=v.CodTurno inner join dbo.Paciente p on p.CodPaciente=v.CodPaciente inner join dbo.Usuario u on u.CodUsuario=v.CodUsuario inner join dbo.Personal pe on pe.CodUsuario=u.CodUsuario where v.codventa='" & dato & "'", db._Conexion)
        Dim adaptador1 As New SqlDataAdapter("select v.codventa,NomServicio as ServMed,cantidad,dv.precio,dv.total from  dbo.DetalleVenta dv inner join venta v on dv.CodVenta=v.CodVenta inner join dbo.Servicio s on s.CodServicio=dv.CodServicio where v.codventa='" & dato & "'", db._Conexion)
        Dim adaptador2 As New SqlDataAdapter("select v1.codventa as ven,NomMedicamento as medecina,cantidad as cant ,dv1.precio as prec ,dv1.total as tot from  dbo.DetalleVenta dv1 inner join venta v1 on dv1.CodVenta=v1.CodVenta inner join dbo.Medicamento m on m.CodMedicamento=dv1.CodMedicamento where v1.codventa='" & dato & "'", db._Conexion)
        adaptador.Fill(ds.Tables("cabecera"))
        adaptador1.Fill(ds.Tables("detalleser"))
        'adaptador2.Fill(ds.Tables("detallemed"))
        Return ds
    End Function

    Public Function reportes(ByVal dato As String, ByVal fechadel As Date, ByVal fechaal As Date, ByVal ind As Integer) As DataSet
        Try
            Dim db As BaseDatos = New BaseDatos()
            db.Conectar()
            Dim ds As New Ds_ReportesVentas
            If ind = 1 Then ' por estado anulada o efectiva
                Dim csql As New SqlDataAdapter("select NomTipoComprobante as comprobante,numero,nomturno,p.Nombres+' '+p.ApellidoPaterno+' '+p.ApellidoMaterno as paciente, convert(char(10),v.Fecha,103)as fecha,Total,TotalIGV,pe.Nombres+' '+pe.ApellidoPaterno+' '+pe.ApellidoMaterno as usuario,v.anulacion as anula,tc.CodTipoComprobante as codtc,v.codventa from dbo.Comprobante c inner join dbo.TipoComprobante tc on c.CodTipoComprobante=tc.CodTipoComprobante inner join dbo.Venta v on v.CodVenta=c.CodVenta inner join dbo.Turno t on t.CodTurno=v.CodTurno inner join dbo.Paciente p on p.CodPaciente=v.CodPaciente inner join dbo.Usuario u on u.CodUsuario=v.CodUsuario inner join dbo.Personal pe on pe.CodUsuario=u.CodUsuario where v.anulacion='" & CBool(dato) & "' and v.fecha>='" & fechadel & "' and v.fecha<='" & fechaal & "'", db._Conexion)
                csql.Fill(ds.Tables("dt_ventas"))
                Return ds
            End If
            If ind = 2 Then ' por comprobante
                Dim csql As New SqlDataAdapter("select NomTipoComprobante as comprobante,numero,nomturno,p.Nombres+' '+p.ApellidoPaterno+' '+p.ApellidoMaterno as paciente, convert(char(10),v.Fecha,103)as fecha,Total,TotalIGV,pe.Nombres+' '+pe.ApellidoPaterno+' '+pe.ApellidoMaterno as usuario,v.anulacion as anula,tc.CodTipoComprobante as codtc,v.codventa from dbo.Comprobante c inner join dbo.TipoComprobante tc on c.CodTipoComprobante=tc.CodTipoComprobante inner join dbo.Venta v on v.CodVenta=c.CodVenta inner join dbo.Turno t on t.CodTurno=v.CodTurno inner join dbo.Paciente p on p.CodPaciente=v.CodPaciente inner join dbo.Usuario u on u.CodUsuario=v.CodUsuario inner join dbo.Personal pe on pe.CodUsuario=u.CodUsuario where tc.codtipocomprobante='" & dato & "' and v.fecha>='" & fechadel & "' and v.fecha<='" & fechaal & "'", db._Conexion)
                csql.Fill(ds.Tables("dt_ventas"))
                Return ds
            End If
            If ind = 3 Then ' por fecha
                Dim csql As New SqlDataAdapter("select NomTipoComprobante as comprobante,numero,nomturno,p.Nombres+' '+p.ApellidoPaterno+' '+p.ApellidoMaterno as paciente, convert(char(10),v.Fecha,103)as fecha,Total,TotalIGV,pe.Nombres+' '+pe.ApellidoPaterno+' '+pe.ApellidoMaterno as usuario,v.anulacion as anula,tc.CodTipoComprobante as codtc,v.codventa from dbo.Comprobante c inner join dbo.TipoComprobante tc on c.CodTipoComprobante=tc.CodTipoComprobante inner join dbo.Venta v on v.CodVenta=c.CodVenta inner join dbo.Turno t on t.CodTurno=v.CodTurno inner join dbo.Paciente p on p.CodPaciente=v.CodPaciente inner join dbo.Usuario u on u.CodUsuario=v.CodUsuario inner join dbo.Personal pe on pe.CodUsuario=u.CodUsuario where v.fecha>='" & fechadel & "' and v.fecha<='" & fechaal & "'", db._Conexion)
                csql.Fill(ds.Tables("dt_ventas"))
                Return ds
            End If
        Catch ex As Exception
            MsgBox("Error al operar con la base de datos!" + ex.Message, MsgBoxStyle.Critical, "Error!")
        End Try
        
    End Function

End Class
