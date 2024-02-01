Imports System.Data.SqlClient
Imports datos
Imports System.Web.UI.WebControls
Imports System.Windows.Forms

Public Class Habitacion
    Dim cFun As New cFuncionesDB
    Private s_CodHabitacion As String
    Private i_NumHabitacion As Integer
    Public Property CodHabitacion() As String
        Get
            Return s_CodHabitacion
        End Get
        Set(ByVal value As String)
            s_CodHabitacion = value
        End Set
    End Property
    Public Property NumHabitacion() As String
        Get
            Return i_NumHabitacion
        End Get
        Set(ByVal value As String)
            i_NumHabitacion = value
        End Set
    End Property
    Function listrar()
        Dim csql As String = "select codHabitacion,NumHabitacion from Habitacion"
        Return csql
    End Function
    Function buscar(ByVal dato As String)
        Dim csql As String = "select codHabitacion,NumHabitacion from Habitacion where NumHabitacion like '%" & dato & "%'"
        Return csql
    End Function
    Function generar(ByRef lab As System.Web.UI.WebControls.Label)
        Dim csql As String = "select count(*)+1 from Habitacion"
        lab.Text = "H" & cFun.ConsultaUnDato(csql, 0)
    End Function

    Public Function AgregarHabitacion(ByVal codtp As String, ByVal nomtp As String) As Boolean
        Try
            Dim csql As String = "Insert into Habitacion(CodHabitacion,NumHabitacion) values ('" + codtp + "','" + nomtp + "')"
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
            MessageBox.Show("Error" + ex.ToString, "Habitacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Public Function UpdateHabitacion(ByRef codigo As String, ByRef nombre As String) As Boolean
        Try
            Dim csql As String = "Update Habitacion set NumHabitacion ='" + nombre + "' where codHabitacion='" + codigo + "'"
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
            MessageBox.Show("Error" + ex.ToString, "Habitacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
End Class
