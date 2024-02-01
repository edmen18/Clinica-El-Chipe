Imports System.Data.SqlClient
Imports datos
Imports System.Windows.Forms

Public Class TipoUsuario
    Dim cFunDb As New cFuncionesDB
    Private s_CodTipoUsuario As String
    Private s_NomTipoUsuario As String
    Public Property CodTipoUsuario() As String
        Get
            Return s_CodTipoUsuario
        End Get
        Set(ByVal value As String)
            s_CodTipoUsuario = value
        End Set
    End Property
    Public Property NomTipoUsuario() As String
        Get
            Return s_NomTipoUsuario
        End Get
        Set(ByVal value As String)
            s_NomTipoUsuario = value
        End Set
    End Property
    Function listrar()
        Dim csql As String = "select codtipoUsuario,NomTipoUsuario from tipoUsuario"
        Return csql
    End Function
    Function buscar(ByVal dato As String)
        Dim csql As String = "select codtipoUsuario,NomTipoUsuario from tipoUsuario where NomTipoUsuario like '%" & dato & "%'"
        Return csql
    End Function
    Function generar(ByRef lab As System.Web.UI.WebControls.Label)
        Dim csql As String = "select count(*)+1 from tipoUsuario"
        lab.Text = "TU" & Format(CInt(cFunDb.ConsultaUnDato(csql, 0)) + 1, "00")
    End Function

    Public Function AgregarTipoUsuario(ByVal codtp As String, ByVal nomtp As String) As Boolean
        Try
            Dim csql As String = "Insert into TipoUsuario(CodTipoUsuario,NomTipoUsuario) values ('" + codtp + "','" + nomtp + "')"
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
            MessageBox.Show("Error" + ex.ToString, "Tipo Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Public Function UpdateTipoUsuario(ByRef codigo As String, ByRef nombre As String) As Boolean
        Try
            Dim csql As String = "Update TipoUsuario set NomTipoUsuario ='" + nombre + "' where codTipoUsuario='" + codigo + "'"
            Dim db As BaseDatos = New BaseDatos()
            'Dim pregunta As DialogResult
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            'pregunta = MessageBox.Show("Desea Actualizar este Material ", "Actualización de Material", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            'If pregunta = DialogResult.Yes Then
            db.ConfirmarTransaccion()
            Return True
            'Else
            db.CancelarTransaccion()
            Return False
            'End If
            db.Desconectar()
        Catch ex As Exception
            MessageBox.Show("Error" + ex.ToString, "Tipo Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
End Class
