Imports System.Data.SqlClient
Imports datos
Imports System.Windows.Forms

Public Class Servicio
    Dim cFunDB As New cFuncionesDB
    Private s_CodServicio As String
    Private s_NomServicio As String
    Private o_Categoria As Categoria
    Private d_Precio As Double
    Private b_Estado As Boolean
    Public Property CodServicio() As String
        Get
            Return s_CodServicio
        End Get
        Set(ByVal value As String)
            s_CodServicio = value
        End Set
    End Property
    Public Property NomServicio() As String
        Get
            Return s_NomServicio
        End Get
        Set(ByVal value As String)
            s_NomServicio = value
        End Set
    End Property
    Public Property Categoria() As Categoria
        Get
            Return o_Categoria
        End Get
        Set(ByVal value As Categoria)
            o_Categoria = value
        End Set
    End Property
    Public Property Precio() As Double
        Get
            Return d_Precio
        End Get
        Set(ByVal value As Double)
            d_Precio = value
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
    Function ListarServicio(ByRef dato As String) As String
        '***** Para listar solo los servicios de consulta para la pagina de venta
        Dim sql As String
        sql = "Select a.CodServicio,a.NomServicio,a.Precio from servicio a inner join Categoria b on a.CodCategoria=b.CodCategoria where NomServicio like '%" + dato + "%' and a.Estado='True' and b.Estado='True' and b.CodCategoria='1'"
        Return sql
    End Function
    Function ListarServicio2(ByRef dato As String) As String
        '***** Para listar solo los servicios de laboratorio para la pagina de venta servicio
        Dim sql As String
        sql = "Select a.CodServicio,a.NomServicio,a.Precio from servicio a inner join Categoria b on a.CodCategoria=b.CodCategoria where NomServicio like '%" + dato + "%' and a.Estado='True' and b.Estado='True' and b.CodCategoria='4'"
        Return sql
    End Function
    Function CargarServicio() As String
        '***** Para cargar el motivo de hospitalización de la pagina solicitud de la atencion
        Dim sql As String
        sql = "Select a.CodServicio, a.NomServicio from Servicio a " + _
        "inner join Categoria b on a.CodCategoria=b.CodCategoria where a.estado='True' and b.Estado='True' " + _
        "and b.CodCategoria='2' or b.CodCategoria='3'"
        Return sql
    End Function



    Function listrar()
        Dim csql As String = "select CodServicio,NomServicio,Precio,c.CodCategoria,NomCategoria from dbo.Servicio s inner join dbo.Categoria c on c.CodCategoria= s.CodCategoria where s.estado='1'"
        Return csql
    End Function
    Function buscar(ByVal dato As String)
        Dim csql As String = "select CodServicio,NomServicio,Precio,c.CodCategoria,NomCategoria from dbo.Servicio s inner join dbo.Categoria c on c.CodCategoria= s.CodCategoria where Nomservicio like '%" & dato & "%' "
        Return csql
    End Function
    Function generar(ByRef lab As System.Web.UI.WebControls.Label)
        Dim csql As String = "select count(*)+1 from servicio"
        lab.Text = cFunDB.ConsultaUnDato(csql, 0)
    End Function

    Public Function Agregarservicio(ByVal codservic As String, ByVal servicio As String, ByVal categoria As String, ByVal precio As Double) As Boolean
        Try
            Dim csql As String = "Insert into servicio(codservicio,nomservicio,Codcategoria,estado,precio) values ('" + codservic + "','" + servicio + "','" & categoria & "','1','" & precio & "')"
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
            MessageBox.Show("Error" + ex.ToString, "servicio", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Public Function Updateservicio(ByVal codservic As String, ByVal servicio As String, ByVal categoria As String, ByVal precio As Double) As Boolean
        Try
            Dim csql As String = "Update servicio set Nomservicio ='" + servicio + "',codcategoria='" & categoria & "',precio='" & precio & "' where codservicio='" + codservic + "'"
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
            MessageBox.Show("Error" + ex.ToString, "Servicio", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try

    End Function

    Public Function deleteservicio(ByVal codigo As String) As Boolean
        Try
            Dim csql As String = "Update servicio set estado ='0' where codservicio='" + codigo + "'"
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
            MessageBox.Show("Error" + ex.ToString, "Servicio", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
End Class
