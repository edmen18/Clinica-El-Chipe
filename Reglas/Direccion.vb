Imports datos
Imports System.Data.SqlClient
Public Class Direccion
    Dim cFun As New cFuncionesDB
    Private s_CodDireccion As String
    Private s_Dato1 As String
    Private s_NomDireccion As String
    Private s_Dato2 As String
    Private s_Numero As String
    Private s_Lote As String
    Private o_CentroPoblado As CentroPoblado
    Public Property CodDireccion() As String
        Get
            Return s_CodDireccion
        End Get
        Set(ByVal value As String)
            s_CodDireccion = value
        End Set
    End Property
    Public Property Dato1() As String
        Get
            Return s_Dato1
        End Get
        Set(ByVal value As String)
            s_Dato1 = value
        End Set
    End Property
    Public Property NomDireccion() As String
        Get
            Return s_NomDireccion
        End Get
        Set(ByVal value As String)
            s_NomDireccion = value
        End Set
    End Property
    Public Property Dato2() As String
        Get
            Return s_Dato2
        End Get
        Set(ByVal value As String)
            s_Dato2 = value
        End Set
    End Property
    Public Property Numero() As String
        Get
            Return s_Numero
        End Get
        Set(ByVal value As String)
            s_Numero = value
        End Set
    End Property
    Public Property Lote() As String
        Get
            Return s_Lote
        End Get
        Set(ByVal value As String)
            s_Lote = value
        End Set
    End Property
    Public Property CentroPoblado() As CentroPoblado
        Get
            Return o_CentroPoblado
        End Get
        Set(ByVal value As CentroPoblado)
            o_CentroPoblado = value
        End Set
    End Property
    Public Function AgregarDireccion(ByRef codigodireccion As String, ByRef dato1 As String, ByRef nomdireccion As String, ByRef dato2 As String, ByRef numero As String, ByRef lote As String, ByRef codigocentropoblado As String) As Boolean
        Try
            Dim csql As String = "Insert into Direccion(CodDireccion,Dato1,NomDireccion,Dato2,Numero,Lote,CodCentroPoblado) values ('" & codigodireccion & "','" & dato1 & "','" & nomdireccion & "','" & dato2 & "','" & numero & "','" & lote & "','" & codigocentropoblado & "')"
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
    Public Function ModificarDireccion(ByRef dato1 As String, ByRef nomdireccion As String, ByRef dato2 As String, ByRef numero As String, ByRef lote As String, ByRef codcentropoblado As String, ByRef codigodireccion As String) As Boolean
        Try
            Dim csql As String = "Update Direccion set Dato1='" + dato1 + "',NomDireccion='" + nomdireccion + "',Dato2='" + dato2 + "',Numero='" + numero + "',Lote='" + lote + "',CodCentroPoblado='" + codcentropoblado + "'" + _
            "where CodDireccion='" + codigodireccion + "'"
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
    Function GeneraCodigoDireccion() As String
        Dim sql As String
        sql = "Select Max(Convert(Int,right(CodDireccion,50))) from Direccion"
        Dim dato As String = cFun.ConsultaUnDato(sql, 0)
        Return dato
    End Function
End Class
