Imports System.Data.SqlClient
Imports datos
Imports System.Web.UI.WebControls
Imports System.Windows.Forms

Public Class Personal
    Dim cFunDb As New cFuncionesDB
    Private s_CodPersonal As String
    Private s_Nombres As String
    Private s_ApellidoPaterno As String
    Private s_ApellidoMaterno As String
    Private o_TipoDocIdentidad As TipoDocIdentidad
    Private d_FechaNacimiento As Date
    Private c_Sexo As Char
    Private s_Celular As String
    Private s_Telefono As String
    Private o_Direccion As Direccion
    Private o_TipoPersonal As TipoPersonal
    Private o_EstadoCivil As EstadoCivil
    Private s_Email As String
    Private o_SistemaPensiones As SistemaPensiones
    Private o_ColegioProfesional As ColegioProfesional
    Private s_NumColegiatura As String
    Private o_Area As Area
    Private s_TelefonoAnexo As String
    Private b_Estado As Boolean
    Private o_Usuario As Usuario
    Private s_NumeroDocIdentidad As String
    Private s_Foto As String

    Public Property CodPersonal() As String
        Get
            Return s_CodPersonal
        End Get
        Set(ByVal value As String)
            s_CodPersonal = value
        End Set
    End Property
    Public Property Nombres() As String
        Get
            Return s_Nombres
        End Get
        Set(ByVal value As String)
            s_Nombres = value
        End Set
    End Property
    Public Property ApellidoPaterno() As String
        Get
            Return s_ApellidoPaterno
        End Get
        Set(ByVal value As String)
            s_ApellidoPaterno = value
        End Set
    End Property
    Public Property ApellidoMaterno() As String
        Get
            Return s_ApellidoMaterno
        End Get
        Set(ByVal value As String)
            s_ApellidoMaterno = value
        End Set
    End Property
    Public Property TipoDocIdentidad() As TipoDocIdentidad
        Get
            Return o_TipoDocIdentidad
        End Get
        Set(ByVal value As TipoDocIdentidad)
            o_TipoDocIdentidad = value
        End Set
    End Property
    Public Property FechaNacimiento() As Date
        Get
            Return d_FechaNacimiento
        End Get
        Set(ByVal value As Date)
            d_FechaNacimiento = value
        End Set
    End Property
    Public Property Sexo() As Char
        Get
            Return c_Sexo
        End Get
        Set(ByVal value As Char)
            c_Sexo = value
        End Set
    End Property
    Public Property Celular() As String
        Get
            Return s_Celular
        End Get
        Set(ByVal value As String)
            s_Celular = value
        End Set
    End Property
    Public Property Telefono() As String
        Get
            Return s_Telefono
        End Get
        Set(ByVal value As String)
            s_Telefono = value
        End Set
    End Property
    Public Property Direccion() As Direccion
        Get
            Return o_Direccion
        End Get
        Set(ByVal value As Direccion)
            o_Direccion = value
        End Set
    End Property
    Public Property TipoPersonal() As TipoPersonal
        Get
            Return o_TipoPersonal
        End Get
        Set(ByVal value As TipoPersonal)
            o_TipoPersonal = value
        End Set
    End Property
    Public Property EstadoCivil() As EstadoCivil
        Get
            Return o_EstadoCivil
        End Get
        Set(ByVal value As EstadoCivil)
            o_EstadoCivil = value
        End Set
    End Property
    Public Property Email() As String
        Get
            Return s_Email
        End Get
        Set(ByVal value As String)
            s_Email = value
        End Set
    End Property
    Public Property SistemaPensiones() As SistemaPensiones
        Get
            Return o_SistemaPensiones
        End Get
        Set(ByVal value As SistemaPensiones)
            o_SistemaPensiones = value
        End Set
    End Property
    Public Property Colegioprofesional() As ColegioProfesional
        Get
            Return o_ColegioProfesional
        End Get
        Set(ByVal value As ColegioProfesional)
            o_ColegioProfesional = value
        End Set
    End Property
    Public Property NumColegiatura() As String
        Get
            Return s_NumColegiatura
        End Get
        Set(ByVal value As String)
            s_NumColegiatura = value
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
    Public Property TelefonoAnexo() As String
        Get
            Return s_TelefonoAnexo
        End Get
        Set(ByVal value As String)
            s_TelefonoAnexo = value
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
    Public Property Usuario() As Usuario
        Get
            Return o_Usuario
        End Get
        Set(ByVal value As Usuario)
            o_Usuario = value
        End Set
    End Property
    Public Property NumeroDocIdentidad() As String
        Get
            Return s_NumeroDocIdentidad
        End Get
        Set(ByVal value As String)
            s_NumeroDocIdentidad = value
        End Set
    End Property
    Public Property Foto() As String
        Get
            Return s_Foto
        End Get
        Set(ByVal value As String)
            s_Foto = value
        End Set
    End Property
    Function generarpersonal(ByRef lbl As System.Web.UI.WebControls.Label)
        Dim csql As String = "select count(*)+1 from personal"
        lbl.Text = "P" & cFunDb.ConsultaUnDato(csql, 0)
    End Function
    Public Function AgregarPersona(ByVal CodPersonal As String, ByVal Nombres As String, ByVal ApellidoPaterno As String, ByVal ApellidoMaterno As String, ByVal CodTipoDocIdentidad As String, ByVal NumeroDocIdentidad As String, ByVal Celular As String, ByVal Telefono As String, ByVal Email As String, ByVal CodTipoPersonal As String, ByVal CodArea As String, ByVal Sexo As String, ByVal CodEstadoCivil As String, ByVal FechaNacimiento As Date, ByVal TelefonoAnexo As String, ByVal CodColegioProfesional As String, ByVal NumColegiatura As String, ByVal CodDireccion As String, ByVal CodCondicionPersonal As String, ByVal estado As String, ByVal CodUsuario As String, ByVal foto As String) As Boolean
        Try
            Dim csql As String = "insert into personal (CodPersonal,Nombres,ApellidoPaterno,ApellidoMaterno,CodTipoDocIdentidad,NumeroDocIdentidad,Celular,Telefono,Email,CodTipoPersonal,CodArea,Sexo,CodEstadoCivil,FechaNacimiento,TelefonoAnexo,CodColegioProfesional,NumColegiatura,CodDireccion,CodCondicionPersonal,Estado,CodUsuario,Foto) values ('" & CodPersonal & "','" & Nombres & "','" & ApellidoPaterno & "','" & ApellidoMaterno & "','" & CodTipoDocIdentidad & "','" & NumeroDocIdentidad & "','" & Celular & "','" & Telefono & "','" & Email & "','" & CodTipoPersonal & "','" & CodArea & "','" & Sexo & "','" & CodEstadoCivil & "','" & FechaNacimiento & "','" & TelefonoAnexo & "','" & CodColegioProfesional & "','" & NumColegiatura & "','" & CodDireccion & "','" & CodCondicionPersonal & "','" & estado & "','" & CodUsuario & "','" & foto & "')"
            Dim db As BaseDatos = New BaseDatos()
            ' Dim pregunta As DialogResult
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            'pregunta = MessageBox.Show("Desea dar de Alta este Convenio", "Insercion de Convenio", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            'If pregunta = DialogResult.Yes Then
            db.ConfirmarTransaccion()
            '    MessageBox.Show("Los datos se almacenaron satisfactoriamente", "SAB", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Else
            '    db.CancelarTransaccion()
            'End If
            db.Desconectar()
            Return True
        Catch ex As Exception
            MessageBox.Show("Error Alta Convenio" + ex.ToString, "Convenio", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
End Class
