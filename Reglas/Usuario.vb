Imports System.Data.SqlClient
Imports datos
Public Class Usuario
    Dim cFun As New cFuncionesDB
    Private s_CodUsuario As String
    Private s_Usuario As String
    Private s_Clave As String
    Private b_Estado As Boolean
    Private o_TipoUsuario As TipoUsuario
    Public Property CodUsuario() As String
        Get
            Return s_CodUsuario
        End Get
        Set(ByVal value As String)
            s_CodUsuario = value
        End Set
    End Property
    Public Property Usuario() As String
        Get
            Return s_Usuario
        End Get
        Set(ByVal value As String)
            s_Usuario = value
        End Set
    End Property
    Public Property Clave() As String
        Get
            Return s_Clave
        End Get
        Set(ByVal value As String)
            s_Clave = value
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
    Public Property TipoUsuario() As TipoUsuario
        Get
            Return o_TipoUsuario
        End Get
        Set(ByVal value As TipoUsuario)
            o_TipoUsuario = value
        End Set
    End Property
    Public Function AgregarUsuario(ByRef codigousuario As String, ByRef usuario As String, ByRef clave As String, ByRef estado As Boolean, ByRef codigotipousuario As String) As Boolean
        Try
            Dim csql As String = "Insert into Usuario(CodUsuario,Usuario,Clave,Estado,CodTipoUsuario)values('" & codigousuario & "','" & usuario & "','" & clave & "','" & estado & "','" & codigotipousuario & "')"
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
    Function InicioSesion(ByRef usuario As String, ByRef clave As String) As String
        Dim sql As String
        sql = "Select u.codusuario,u.usuario,u.clave,tu.CodTipoUsuario,p.Estado,u.Estado from Usuario u inner join TipoUsuario tu on u.CodTipoUsuario=tu.CodTipoUsuario inner join Personal p on p.CodUsuario=u.CodUsuario where u.usuario='" + usuario + "'and u.clave='" + clave + "'"
        Return sql
    End Function
    Function MostrarUsuario(ByRef usu As String) As String
        Dim sql As String
        sql = "Select a.Nombres+' '+a.ApellidoPaterno+' '+a.ApellidoMaterno as Personal,b.Usuario,b.CodUsuario from Personal a " + _
        "inner join Usuario b on a.CodUsuario=b.CodUsuario where b.Usuario='" + usu + "'"
        Return sql
    End Function
    Function GeneraCodigoUsuario() As String
        Dim sql As String
        sql = "Select Max(Convert(Int,right(CodUsuario,50))) from Usuario"
        Dim dato As String = cFun.ConsultaUnDato(sql, 0)
        Return dato
    End Function
End Class
