Imports System.Data.SqlClient
Imports datos
Imports System.Windows.Forms

Public Class Categoria
    Dim cFunDb As New cFuncionesDB
    Private s_CodCategoria As String
    Private s_NomCategoria As String
    Private b_Estado As Boolean
    Public Property CodCategoria() As String
        Get
            Return s_CodCategoria
        End Get
        Set(ByVal value As String)
            s_CodCategoria = value
        End Set
    End Property
    Public Property NomCategoria() As String
        Get
            Return s_NomCategoria
        End Get
        Set(ByVal value As String)
            s_NomCategoria = value
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
    ''funciones para mantenimiento
    Function buscar(ByVal dato As String)
        Dim csql As String = "select codcategoria,nomcategoria from categoria where estado='1' and nomcategoria like '%" & dato & "%'"
        Return csql
    End Function

    Function listar()
        Dim csql As String = "select codcategoria,nomcategoria from categoria where estado='1'"
        Return csql
    End Function

    Function generar(ByRef lab As System.Web.UI.WebControls.Label)
        Dim csql As String = "select count(*)+1 from categoria"
        lab.Text = cFunDB.ConsultaUnDato(csql, 0)
    End Function

    Public Function Agregarcategoria(ByVal codcategori As String, ByVal categoria As String) As Boolean
        Try
            Dim csql As String = "Insert into categoria(codcategoria,nomcategoria,estado) values ('" + codcategori + "','" + categoria + "','1')"
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
            MessageBox.Show("Error" + ex.ToString, "categoria", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Public Function Updatecategoria(ByVal codcategori As String, ByVal categoria As String) As Boolean
        Try
            Dim csql As String = "Update categoria set Nomcategoria ='" + categoria + "'where codcategoria='" + codcategori + "'"
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
            MessageBox.Show("Error" + ex.ToString, "categoria", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try

    End Function

    Public Function deletecategoria(ByVal codigo As String) As Boolean
        Try
            Dim csql As String = "Update categoria set estado ='0' where codcategoria='" + codigo + "'"
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
            MessageBox.Show("Error" + ex.ToString, "categoria", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
End Class
