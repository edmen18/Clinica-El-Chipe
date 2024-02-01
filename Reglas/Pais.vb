Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Imports datos
Imports System.Web.UI.WebControls
Imports System.Windows.Forms

Public Class Pais
    Dim cFunDb As New cFuncionesDB
    Private s_CodPais As String
    Private s_NomPais As String
    Public Property CodPais() As String
        Get
            Return s_CodPais
        End Get
        Set(ByVal value As String)
            s_CodPais = value
        End Set
    End Property
    Public Property NomPais() As String
        Get
            Return s_NomPais
        End Get
        Set(ByVal value As String)
            s_NomPais = value
        End Set
    End Property
    Function ListaPais() As String
        Dim sql As String = "Select CodPais,NomPais from Pais"
        Return sql
    End Function
    Function ListarPais(ByRef grilla As GridView) As String
        Dim sql As String = "Select CodPais,NomPais from Pais"
        cFunDb.FillDataGridView(sql, grilla)
    End Function
    Public Function generar(ByRef lab As System.Web.UI.WebControls.Label)
        Dim csql As String = "select max(convert(int,right(codpais,3)))from pais"
        lab.Text = Format(CInt(cFunDb.ConsultaUnDato(csql, 0)) + 1, "000")
    End Function

    Public Function AgregarPais(ByVal codigo As String, ByVal nombre As String) As Boolean
        Try
            Dim csql As String = "Insert into pais(codpais,nompais) values ('" + codigo + "','" + nombre + "')"
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
    Public Function UpdatePais(ByRef codigo As String, ByRef nombre As String) As Boolean
        Try
            Dim csql As String = "Update pais set Nompais ='" + nombre + "'where codpais='" + codigo + "'"
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
            MessageBox.Show("Error Actualización de Material" + ex.ToString, "Material", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
End Class
