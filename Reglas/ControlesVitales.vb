Imports System.Data.SqlClient
Imports datos
Imports Reportes
Public Class ControlesVitales
    Dim fun As New cFuncionesDB
    Public Function diaHospitalizado(ByVal fecha As Date, ByVal hosp As String)
        Dim csql As String = "select convert(int,datediff(dd,Fecha,'" + fecha + "')) from dbo.Hospitalizacion where CodHospitalizacion='" + hosp + "'"
        Return fun.ConsultaUnDato(csql, 0)
    End Function
    Public Function diaoperado(ByVal fecha As Date, ByVal hosp As String)
        Dim csql As String = "select convert(int,datediff(dd,Fecha,'" + fecha + "')) from dbo.ReporteOperatorio where CodHospitalizacion='" + hosp + "' union select convert(int,datediff(dd,n.Fecha,getdate())) from dbo.Nacimiento n inner join parto p on p.codparto=n.codparto inner join hospitalizacion h on h.CodHospitalizacion= p.CodHospitalizacion where h.CodHospitalizacion='" + hosp + "'"
        Return fun.ConsultaUnDato(csql, 0)
    End Function
    Public Function verificarControl(ByVal hosp As String)
        Dim csql As String = "select CodControlesVitales from controlesvitales where codhospitalizacion='" + hosp + "'"
        Return fun.ConsultaUnDato(csql, 0)
    End Function
    Public Function generar()
        Dim csql As String = "select count(*)+1 from controlesvitales"
        Return fun.ConsultaUnDato(csql, 0)
    End Function
    Public Function generardetalle()
        Dim csql As String = "select count(*)+1 from detallecontrolesvitales"
        Return fun.ConsultaUnDato(csql, 0)
    End Function
    Public Function AgregarControl(ByVal hos As String, ByVal control As String) As Boolean
        Try
            Dim csql As String = "Insert into ControlesVitales(CodControlesVitales,CodHospitalizacion) values ('" + control + "','" + hos + "')"
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
    Public Function AgregarDetalle(ByVal CodDetalleControlesVitales As String, ByVal CodControlesVitales As String, ByVal Fecha As Date, ByVal DiaHospitalizado As String, ByVal DiasOperado As String, ByVal PresionArterial As String, ByVal Pulso As String, ByVal Temperatura As String, ByVal Hora As String, ByVal Peso As String, ByVal NDeposiciones As String, ByVal Orina As String, ByVal NBalHidricos As String, ByVal Mestruacion As String, ByVal Drenaje As String, ByVal Transfusiones As String, ByVal Loquios As String) As Boolean
        Try
            Dim csql As String = "insert into dbo.DetalleControlesVitales (CodDetalleControlesVitales,CodControlesVitales,Fecha,DiaHospitalizado,DiasOperado,PresionArterial,Pulso,Temperatura,Hora,Peso,NDeposiciones,Orina,NBalHidricos,Mestruacion,Drenaje,Transfusiones,Loquios ) values ('" & CodDetalleControlesVitales & "','" & CodControlesVitales & "','" & Fecha & "','" & DiaHospitalizado & "','" & DiasOperado & "','" & PresionArterial & "','" & Pulso & "','" & Temperatura & "','" & Hora & "','" & Peso & "','" & NDeposiciones & "','" & Orina & "','" & NBalHidricos & "','" & Mestruacion & "','" & Drenaje & "','" & Transfusiones & "','" & Loquios & "' )"
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
    Public Function ImprimePerinatal(ByVal parto As String) As DataSet
        Dim db As BaseDatos = New BaseDatos()
        db.Conectar()
        Dim ds As New Ds_Parto
        Dim adaptador As New SqlDataAdapter("SELECT Nombres+' '+ApellidoPaterno+' '+ ApellidoMaterno AS PACIENTE,CodParto,TipoParto,Anestesia,CordonUmbilical,LiquidoAmniotico,Placenta,Reanimacion,DrogasUsadas FROM dbo.Parto P INNER JOIN dbo.Hospitalizacion H ON P.CodHospitalizacion=H.CodHospitalizacion INNER JOIN dbo.SolicitudAtencion SA ON SA.CodigoSolicitudAtencion=H.CodigoSolicitudAtencion INNER JOIN dbo.HistoriaClinica HC ON HC.NHC=SA.NHC INNER JOIN PACIENTE PAC ON PAC.CodPaciente=HC.CodPaciente  WHERE CODPARTO='" & parto & "'", db._Conexion)
        Dim adaptador1 As New SqlDataAdapter("SELECT CODPARTO,CodNacimiento,NombreRN,Sexo,Semanas,Fecha,Hora,Talla,Peso,PC,PTX,PABD,FC,ER,TM,REF,COL,Temperatura,Observaciones,ExamenFisico,Diagnostico FROM dbo.Nacimiento WHERE CODPARTO='" & parto & "'", db._Conexion)
        Dim adaptador2 As New SqlDataAdapter("SELECT CODPARTO, Gestacion,Paridad,Termino,Prematuros,Abortos,Obito,FactoresMedicoRiesgo,TiempoGestacion,PatologiaEmbarazo,FechaParto,Hora,IndicioLaborParto,RPMCaracteristicas,DrogasLaborParto FROM dbo.AntecedentesMaternos WHERE CODPARTO='" & parto & "'", db._Conexion)
        adaptador.Fill(ds.Tables("Dt_parto"))
        adaptador1.Fill(ds.Tables("dt_nacimiento"))
        adaptador2.Fill(ds.Tables("dt_antecedentes"))
        Return ds
    End Function
End Class
