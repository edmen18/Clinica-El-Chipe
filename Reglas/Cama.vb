Imports System.Data.SqlClient
Imports datos
Imports System.Web.UI.WebControls
Imports System.Windows.Forms

Public Class Cama
    Dim cFun As New cFuncionesDB
    Private s_CodCama As String
    Private i_NumCama As Integer
    Private o_Habitacion As Habitacion
    Public Property CodCama() As String
        Get
            Return s_CodCama
        End Get
        Set(ByVal value As String)
            s_CodCama = value
        End Set
    End Property
    Public Property NumCama() As Integer
        Get
            Return i_NumCama
        End Get
        Set(ByVal value As Integer)
            i_NumCama = value
        End Set
    End Property
    Public Property Habitacion() As Habitacion
        Get
            Return o_Habitacion
        End Get
        Set(ByVal value As Habitacion)
            o_Habitacion = value
        End Set
    End Property
    Public Function ModificarEstadoCama(ByRef numerocama As String) As Boolean
        'Para el formulario de programacion medica, para cambiar el estado de la cama a ocupada
        'cuando sea por intervencion quirurgica o tratamiento médico
        Try
            Dim csql As String = "Update Cama set Estado='True' where NumCama='" & numerocama & "'"
            Dim db As BaseDatos = New BaseDatos()
            db.Conectar()
            db.ComenzarTransaccion()
            db.CrearComando(csql)
            db.EjecutarComando()
            db.ConfirmarTransaccion()
            db.Desconectar()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Sub CargarCama2(ByVal COMBO As DropDownList)
        Dim csql As String = "Select CodCama, NumCama from Cama where Estado='False' order by 2"
        cFun.FillListaOrCombo(csql, COMBO, "NumCama", "CodCama")
    End Sub
    Function ListaCama(ByRef codigodpm As String)
        Dim sql As String
        sql = "Select a.NumCama from Cama a inner join DetalleProgramacionMedica b " + _
        "on a.CodCama=b.CodCama " + _
        "where b.CodDetalleProgramacionMedica='" + codigodpm + "'"
        Return sql
    End Function
    Function CargaCama(ByRef fecha As Date)
        Dim sql As String = "Select b.NumCama from DetalleProgramacionMedica a" + _
        "inner join Cama b on a.CodCama=b.CodCama " + _
        "where FechaAtencion<='" & CDate(fecha) & "' and b.Estado='True'"
        Return sql
    End Function
    Function MuestraCama(ByRef cama As String)
        Dim sql As String = "Select a.NumCama from Cama a where a.NumCama<>'" & Cama & "' and a.Estado='False'"
        Return sql
    End Function
    Function Muestracodcama(ByRef num As String) As String
        Dim sql As String
        sql = "Select CodCama from Cama where NumCama='" & num & "'"
        Return sql
    End Function
    Function consultarcama(ByVal del As Date, ByVal al As Date, ByRef grilla As GridView)
        Dim csql As String = "select c.CodCama as codigo,NumCama as numero,convert(char(10),FechaAtencion,103) as fecha,HoraOperacion as hora,'Cama' as desacripcion from dbo.Cama c inner join dbo.DetalleProgramacionMedica dpm on c.codcama=dpm.codcama where FechaAtencion>='" + del + "' and FechaAtencion<='" + al + "'"
        cFun.FillDataGridView(csql, grilla)
    End Function


    ''''''' funciones para mantenimiento
    Function listrar()
        Dim csql As String = "select codcama,Numcama,h.codhabitacion,numhabitacion from cama c inner join Habitacion h on c.codhabitacion=h.codhabitacion where c.estado='1'"
        Return csql
    End Function
    Function buscar(ByVal dato As String)
        Dim csql As String = "select codcama,Numcama,h.codhabitacion,numhabitacion from cama c inner join Habitacion h on c.codhabitacion=h.codhabitacion where Numcama like '%" & dato & "%' and c.estado='1'"
        Return csql
    End Function
    Function generar(ByRef lab As System.Web.UI.WebControls.Label)
        Dim csql As String = "select count(*)+1 from cama"
        lab.Text = "C" & cFun.ConsultaUnDato(csql, 0)
    End Function

    Public Function Agregarcama(ByVal codcama As String, ByVal numcama As String, ByVal codhabit As String, ByVal numhabit As String) As Boolean
        Try
            Dim csql As String = "Insert into cama(codcama,numcama,CodHabitacion,estado) values ('" + codcama + "','" + numcama + "','" & codhabit & "','1')"
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
            MessageBox.Show("Error" + ex.ToString, "Cama", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Public Function Updatecama(ByVal codcama As String, ByVal numcama As String, ByVal codhabit As String, ByVal numhabit As String) As Boolean
        Try
            Dim csql As String = "Update cama set Numcama ='" + numcama + "',codhabitacion='" & codhabit & "' where codcama='" + codcama + "'"
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
            MessageBox.Show("Error" + ex.ToString, "Cama", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try

    End Function

    Public Function deletecama(ByVal codcama As String) As Boolean
        Try
            Dim csql As String = "Update cama set estado ='0' where codcama='" + codcama + "'"
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
            MessageBox.Show("Error" + ex.ToString, "Cama", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
        End Function
End Class
