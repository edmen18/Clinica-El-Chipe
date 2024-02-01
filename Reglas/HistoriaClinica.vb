Imports System.Data.SqlClient
Imports datos
Imports System.Web.UI.WebControls
Imports Reportes
Public Class HistoriaClinica
    Dim cFun As New cFuncionesDB
    Dim db As New BaseDatos
    Private s_NHC As String
    Private d_FechaApertura As Date
    Private o_Paciente As Paciente
    Private s_Antecedentes As String
    Public Property NHC() As String
        Get
            Return s_NHC
        End Get
        Set(ByVal value As String)
            s_NHC = value
        End Set
    End Property
    Public Property FechaApertura() As Date
        Get
            Return d_FechaApertura
        End Get
        Set(ByVal value As Date)
            d_FechaApertura = value
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
    Public Property Antecedentes() As String
        Get
            Return s_Antecedentes
        End Get
        Set(ByVal value As String)
            s_Antecedentes = value
        End Set
    End Property
    Public Function AgregarHistoriaClinica(ByRef nhc As String, ByRef fechaapertura As Date, ByRef codigopaciente As String, ByRef antecedentes As String) As Boolean
        Try
            Dim csql As String = "Insert into HistoriaClinica(NHC,FechaApertura,CodPaciente,Antecedentes) values ('" & nhc & "','" & CDate(fechaapertura) & "','" & codigopaciente & "','" & antecedentes & "')"
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
    Function GeneraCodigoHistoriaClinica() As String
        Dim sql As String
        sql = "Select Max(Convert(Int,right(NHC,50))) from HistoriaClinica"
        Dim dato As String = cFun.ConsultaUnDato(sql, 0)
        Return dato
    End Function
    Public Function ReporteAperturaHC(ByVal fechadel As Date, ByVal fechaal As Date) As DataSet
        db.Conectar()
        Dim adaptador As New SqlDataAdapter("Select a.NHC,b.Nombres+' '+b.ApellidoPaterno+' '+b.ApellidoMaterno as Paciente,a.FechaApertura from HistoriaClinica a inner join Paciente b on a.CodPaciente=b.CodPaciente where a.FechaApertura>='" + CDate(fechadel) + "' and a.FechaApertura<='" + CDate(fechaal) + "'", db._Conexion)
        Dim ds As New DsAperturaHC
        adaptador.Fill(ds.Tables("DtAperturaHC"))
        Return ds
    End Function
End Class
