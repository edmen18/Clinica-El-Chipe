Imports System.Data.SqlClient
Imports datos
Public Class DiagnosticoConsulta
    Dim cFunDB As cFuncionesDB
    Private o_Consulta As Consulta
    Private o_Diagnostico As Diagnostico
    Private o_TipoDiagnostico As TipoDiagnostico
    Private d_Fecha As Date
    Public Property Consulta() As Consulta
        Get
            Return o_Consulta
        End Get
        Set(ByVal value As Consulta)
            o_Consulta = value
        End Set
    End Property
    Public Property Diagnostico() As Diagnostico
        Get
            Return o_Diagnostico
        End Get
        Set(ByVal value As Diagnostico)
            o_Diagnostico = value
        End Set
    End Property
    Public Property TipoDiagnostico() As TipoDiagnostico
        Get
            Return o_TipoDiagnostico
        End Get
        Set(ByVal value As TipoDiagnostico)
            o_TipoDiagnostico = value
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
    Public Function AgregarDiagnosticoConsulta(ByRef codigoconsulta As String, ByRef codigodiagnostico As String, ByRef codigotipodiagnostico As String, ByRef fecha As Date) As Boolean
        Try
            Dim csql As String = "Insert into DiagnosticoConsulta(CodigoConsulta,CodDiagnostico,CodTipoDiagnostico,Fecha)values('" & codigoconsulta & "','" & codigodiagnostico & "','" & codigotipodiagnostico & "','" & CDate(fecha) & "')"
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
    Function ListaDiagnosticoConsulta(ByRef codigoconsulta As String, ByRef fecha As Date)
        Dim sql As String
        sql = "Select d.CodEnfermedad,d.NomEnfermedad,b.CodDiagnostico,b.Diagnostico,c.NomTipoDiagnostico,a.CodigoConsulta from DiagnosticoConsulta a " + _
        "inner join Diagnostico b on a.CodDiagnostico=b.CodDiagnostico " + _
        "inner join TipoDiagnostico c on c.CodTipoDiagnostico=a.CodTipoDiagnostico " + _
        "inner join Enfermedad d on d.CodEnfermedad=b.CodEnfermedad where a.CodigoConsulta='" + codigoconsulta + "' and a.Fecha>='" + CDate(fecha) + "'"
        Return sql
    End Function
End Class
