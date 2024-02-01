Imports System.Data.SqlClient
Imports datos
Imports System.Windows.Forms

Public Class TipoPersonal
    Dim cFunDb As New cFuncionesDB
    Private s_CodTipoPersonal As String
    Private s_NomTipoPersonal As String
    Public Property CodTipoPersonal() As String
        Get
            Return s_CodTipoPersonal
        End Get
        Set(ByVal value As String)
            s_CodTipoPersonal = value
        End Set
    End Property
    Public Property NomTipoPersonal() As String
        Get
            Return s_NomTipoPersonal
        End Get
        Set(ByVal value As String)
            s_NomTipoPersonal = value
        End Set
    End Property
    Function listrar()
        Dim csql As String = "select codtipopersonal,NomTipoPersonal from tipopersonal"
        Return csql
    End Function
    Function buscar(ByVal dato As String)
        Dim csql As String = "select codtipopersonal,NomTipoPersonal from tipopersonal where NomTipoPersonal like '%" & dato & "%'"
        Return csql
    End Function
    Function generar(ByRef lab As System.Web.UI.WebControls.Label)
        Dim csql As String = "select count(*)+1 from tipopersonal"
        lab.Text = "TP" & Format(CInt(cFunDb.ConsultaUnDato(csql, 0)) + 1, "000")
    End Function


    Public Function AgregarTipoPersonal(ByVal codtp As String, ByVal nomtp As String) As Boolean
        Try
            Dim csql As String = "Insert into TipoPersonal(CodTipoPersonal,NomTipoPersonal) values ('" + codtp + "','" + nomtp + "')"
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
            MessageBox.Show("Error" + ex.ToString, "TipoPersonal", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Public Function UpdateTipoPersonal(ByRef codigo As String, ByRef nombre As String) As Boolean
        Try
            Dim csql As String = "Update TipoPersonal set NomTipoPersonal ='" + nombre + "' where codTipoPersonal='" + codigo + "'"
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
            MessageBox.Show("Error" + ex.ToString, "TipoPersonal", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

End Class
