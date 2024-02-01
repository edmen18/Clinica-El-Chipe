Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports System.Web.UI.WebControls
Imports datos
Public Class Unidad
    Dim cFunDb As New cFuncionesDB
    Private s_CodUnidad As String
    Private s_NomUnidad As String
    Private b_Estado As Boolean
    Public Property NomUnidad() As String
        Get
            Return s_NomUnidad
        End Get
        Set(ByVal value As String)
            s_NomUnidad = value
        End Set
    End Property
    Public Property CodUnidad() As String
        Get
            Return s_CodUnidad
        End Get
        Set(ByVal value As String)
            s_CodUnidad = value
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
    Public Function AgregarUnidad() As Boolean
        Try
            Dim csql As String = "Insert into Unidad(CodUnidad,NomUnidad,Estado) values ('" + Me.codunidad + "','" + Me.nomunidad + "','1')"
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
            ' MessageBox.Show("Error Alta Convenio" + ex.ToString, "Convenio", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Public Function UpdateMaterial(ByRef codigo As String, ByRef nombre As String) As Boolean
        Try
            Dim csql As String = "Update Unidad set NomUnidad ='" + nombre + "' where item='" + codigo + "'"
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
            'MessageBox.Show("Error Actualización de Material" + ex.ToString, "Material", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Function GeneraCodigoUnidad() As String
        Dim strsql As String
        strsql = "Select Max(Convert(Int,right(codunidad,3))) as CCod from Unidad"
        Dim dato As String = cFunDb.ConsultaUnDato(strsql, 0)
        If dato = "" Then
            dato = "0"
            dato = CStr(dato)
        End If
        Return dato
    End Function
End Class
