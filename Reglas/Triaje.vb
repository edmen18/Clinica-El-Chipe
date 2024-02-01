Imports System.Data.SqlClient
Imports datos
Public Class Triaje
    Private cFunDB As cFuncionesDB
    Private s_CodTriaje As String
    Private d_Temperatura As Double
    Private d_FR As Double
    Private d_PA As Double
    Private d_Peso As Double
    Private d_Talla As Double
    Private d_Fecha As Date
    Public Property CodTriaje() As String
        Get
            Return s_CodTriaje
        End Get
        Set(ByVal value As String)
            s_CodTriaje = value
        End Set
    End Property
    Public Property Temperatura() As Double
        Get
            Return d_Temperatura
        End Get
        Set(ByVal value As Double)
            d_Temperatura = value
        End Set
    End Property
    Public Property FR() As Double
        Get
            Return d_FR
        End Get
        Set(ByVal value As Double)
            d_FR = value
        End Set
    End Property
    Public Property PA() As Double
        Get
            Return d_PA
        End Get
        Set(ByVal value As Double)
            d_PA = value
        End Set
    End Property
    Public Property Peso() As Double
        Get
            Return d_Peso
        End Get
        Set(ByVal value As Double)
            d_Peso = value
        End Set
    End Property
    Public Property Talla() As Double
        Get
            Return d_Talla
        End Get
        Set(ByVal value As Double)
            d_Talla = value
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
    Function ListarTriaje(ByRef fecha As Date) As String
        Dim sql As String
        sql = "Select a.NHC,b.NumTicket,c.ApellidoPaterno+' '+c.ApellidoMaterno+' , '+c.Nombres as Paciente," + _
        "d.CodTriaje,d.Temperatura,d.FR,d.PA,d.Peso,d.Talla,d.Fecha,c.CodPaciente from Movimiento a " + _
        "inner join HistoriaClinica e on e.NHC=a.NHC " + _
        "inner join Ticket b on b.NHC=e.NHC " + _
        "inner join Paciente c on c.CodPaciente=e.CodPaciente " + _
        "inner join Triaje d on d.CodPaciente=c.CodPaciente where b.FechaAtencion>='" + CDate(fecha) + "' and a.Fecha>='" + CDate(fecha) + "' and d.Fecha>='" + CDate(fecha) + "'"
        Return sql
    End Function
End Class
