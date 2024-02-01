Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports datos
Imports System.Web.UI.WebControls
Imports System.Windows.Forms

Public Class Area
    Dim cFunDb As New cFuncionesDB
    Private s_CodArea As String
    Private s_NomArea As String
    Private o_Unidad As Unidad
    Private b_Estado As Boolean
    Public Property CodArea() As String
        Get
            Return s_CodArea
        End Get
        Set(ByVal value As String)
            s_CodArea = value
        End Set
    End Property
    Public Property NomArea() As String
        Get
            Return s_NomArea
        End Get
        Set(ByVal value As String)
            s_NomArea = value
        End Set
    End Property
    Public Property Unidad() As Unidad
        Get
            Return o_Unidad
        End Get
        Set(ByVal value As Unidad)
            o_Unidad = value
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
    Public Function ListarArea() As String
        Dim sql As String
        sql = "Select CodArea,NomArea,a.codunidad,nomunidad as unidad from Area a inner join unidad u on u.codunidad=a.codunidad where a.estado='1'"
        Return sql
    End Function
    Public Function ListarUnidades(ByRef grilla As GridView, ByVal text As String) As String
        Dim sql As String = "Select Codunidad,Nomunidad from unidad where estado='1' and nomunidad like '%" + text + "%'"
        cFunDb.FillDataGridView(sql, grilla)
    End Function
    Public Function generar(ByRef lab As System.Web.UI.WebControls.Label)
        Dim csql As String = "select max(convert(int,right(codarea,5)))from area"
        lab.Text = "A" & Format(CInt(cFunDb.ConsultaUnDato(csql, 0)) + 1, "00000")
    End Function

    Public Function Agregararea(ByVal codare As String, ByVal nomare As String, ByVal unidad As String) As Boolean
        Try
            Dim csql As String = "Insert into area(Codarea,Nomarea,codunidad,estado) values ('" + codare + "','" + nomare + "','" + unidad + "','1')"
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
    Public Function Updatearea(ByRef codigo As String, ByRef nombre As String, ByVal unidad As String) As Boolean
        Try
            Dim csql As String = "Update area set Nomarea ='" + nombre + "',codunidad='" + unidad + "' where codarea='" + codigo + "'"
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

    Public Function DeleteArea(ByRef codigo As String) As Boolean
        Try
            Dim csql As String = "Update area set estado='0' where codarea='" + codigo + "'"
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
