Imports System.Data.SqlClient
Imports datos
Imports System.Web.UI.WebControls
Imports System.Windows.Forms

Public Class SalaOperacion
    Dim cFun As New cFuncionesDB
    Private s_CodSalaOperacion As String
    Private i_NumSala As Integer
    Public Property CodSalaOperacion() As String
        Get
            Return s_CodSalaOperacion
        End Get
        Set(ByVal value As String)
            s_CodSalaOperacion = value
        End Set
    End Property
    Public Property NumSala() As Integer
        Get
            Return i_NumSala
        End Get
        Set(ByVal value As Integer)
            i_NumSala = value
        End Set
    End Property
    Function CargarSalaOperacion(ByRef fecha As Date, ByRef hora As String) As String
        Dim sql As String
        sql = "Select b.NumSala from DetalleProgramacionMedica a inner join SalaOperacion b on a.CodSalaOperacion=b.CodSalaOperacion where FechaAtencion='" & CDate(fecha) & "' and HoraOperacion='" & hora & "'"
        Return sql
    End Function
    Function MostrarSalaOperacion(ByRef numerosala As String) As String
        Dim sql As String
        sql = "Select NumSala from SalaOperacion where NumSala<>'" & numerosala & "'"
        Return sql
    End Function
    Function MostrarSala(ByRef n1 As String, ByRef n2 As String, ByRef n3 As String, ByRef n4 As String, ByRef n5 As String) As String
        Dim sql As String
        sql = "Select NumSala from SalaOperacion where NumSala<>'" & n1 & "' and NumSala<>'" & n2 & "' and NumSala<>'" & n3 & "' and NumSala<>'" & n4 & "' and NumSala<>'" & n5 & "'"
        Return sql
    End Function
    Public Sub CargarSala(ByVal COMBO As DropDownList)
        Dim csql As String = "Select CodSalaOperacion, NumSala from SalaOperacion order by 2"
        cFun.FillListaOrCombo(csql, COMBO, "NumSala", "CodSalaOperacion")
    End Sub
    Function Muestracodsala(ByRef num As String) As String
        Dim sql As String
        sql = "Select CodSalaOperacion from SalaOperacion where NumSala='" & num & "'"
        Return sql
    End Function
    Function consultasala(ByVal del As Date, ByVal al As Date, ByRef grilla As GridView)
        Dim csql As String = "select c.CodSalaOperacion as codigo,NunSala as numero,convert(char(10),FechaAtencion,103) as fecha,HoraOperacion as hora,'Sala Operacion' as desacripcion from dbo.salaoperacion c inner join dbo.DetalleProgramacionMedica dpm on c.CodSalaOperacion=dpm.CodSalaOperacion where FechaAtencion>='" + del + "' and FechaAtencion<='" + al + "'"
        cFun.FillDataGridView(csql, grilla)
    End Function




    ''''' funciones para mantenimiento

    Function listrar()
        Dim csql As String = "select codSalaOperacion,NumSala from SalaOperacion"
        Return csql
    End Function
    Function buscar(ByVal dato As String)
        Dim csql As String = "select codSalaOperacion,NumSala from SalaOperacion where NumSala like '%" & dato & "%'"
        Return csql
    End Function
    Function generar(ByRef lab As System.Web.UI.WebControls.Label)
        Dim csql As String = "select count(*)+1 from SalaOperacion"
        lab.Text = "SO" & cFun.ConsultaUnDato(csql, 0)
    End Function

    Public Function AgregarSalaOperacion(ByVal codtp As String, ByVal nomtp As String) As Boolean
        Try
            Dim csql As String = "Insert into SalaOperacion(CodSalaOperacion,NumSala) values ('" + codtp + "','" + nomtp + "')"
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
            MessageBox.Show("Error" + ex.ToString, "SalaOperacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Public Function UpdateSalaOperacion(ByRef codigo As String, ByRef nombre As String) As Boolean
        Try
            Dim csql As String = "Update SalaOperacion set NumSala ='" + nombre + "' where codSalaOperacion='" + codigo + "'"
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
            MessageBox.Show("Error" + ex.ToString, "SalaOperacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
End Class
