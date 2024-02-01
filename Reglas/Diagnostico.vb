Imports System.Data.SqlClient
Imports datos
Imports System.Web.UI.WebControls
Imports System.Windows.Forms

Public Class Diagnostico
    Dim cFunDB As cFuncionesDB
    Private s_CodDiagnostico As String
    Private s_Codigo As String
    Private s_Diagnostico As String
    Private o_Enfermedad As Enfermedad

    Public Property CodDiagnostico() As String
        Get
            Return s_CodDiagnostico
        End Get
        Set(ByVal value As String)
            s_CodDiagnostico = value
        End Set
    End Property
    Public Property Codigo() As String
        Get
            Return s_Codigo
        End Get
        Set(ByVal value As String)
            s_Codigo = value
        End Set
    End Property
    Public Property Diagnostico() As String
        Get
            Return s_Diagnostico
        End Get
        Set(ByVal value As String)
            s_Diagnostico = value
        End Set
    End Property
    Public Property Enfermedad() As Enfermedad
        Get
            Return o_Enfermedad
        End Get
        Set(ByVal value As Enfermedad)
            o_Enfermedad = value
        End Set
    End Property
    Function ListarDiagnostico() As String
        Dim sql As String
        sql = "select a.Codigo,a.CodDiagnostico,a.Diagnostico,b.CodEnfermedad,b.NomEnfermedad from diagnostico a " + _
        "inner join Enfermedad b on a.CodEnfermedad=b.CodEnfermedad"
        Return sql
    End Function
    Function BuscarDiagnostico(ByRef dato As String) As String
        Dim sql As String
        sql = "Select a.Codigo,a.CodDiagnostico,a.Diagnostico,b.CodEnfermedad,b.NomEnfermedad from diagnostico a " + _
        "inner join Enfermedad b on a.CodEnfermedad=b.CodEnfermedad where a.Codigo like '%" + dato + "%' or a.Diagnostico like '%" + dato + "%'"
        Return sql
    End Function
    Function listardiag(ByRef combo As DropDownList)
        Dim csql As String = "select coddiagnostico,diagnostico from diagnostico"
        cFunDB.FillListaOrCombo(csql, combo, "diagnostico", "coddiagnostico")
    End Function
    Function listartipodiag(ByRef combo As DropDownList)
        Dim csql As String = "select CodTipoDiagnostico,NomTipoDiagnostico from tipodiagnostico"
        cFunDB.FillListaOrCombo(csql, combo, "NomTipoDiagnostico", "CodTipoDiagnostico")
    End Function
    Function generar()
        Dim csql As String = "select count(*)+1 from diagnostico"
        Return csql
    End Function
    Function generardiag(ByVal enfermedad As String)
        Dim csql As String = "select count(*)+1 from diagnostico where codenfermedad ='" & enfermedad & "'"
        Return csql
        Return csql
    End Function
    Function lista()
        Dim csql As String = "select CodDiagnostico as coddiag,d.Codigo as codigo,Diagnostico,e.CodEnfermedad,NomEnfermedad from dbo.Diagnostico d inner join dbo.Enfermedad e on d.CodEnfermedad =e.CodEnfermedad"
        Return csql
    End Function
    Function buscar(ByVal text As String)
        Dim csql As String = "select CodDiagnostico as coddiag,d.Codigo as codigo,Diagnostico,e.CodEnfermedad,NomEnfermedad from dbo.Diagnostico d inner join dbo.Enfermedad e on d.CodEnfermedad =e.CodEnfermedad where Diagnostico like '%" + text + "%'"
        Return csql
    End Function
    Public Function AgregarDIAG(ByVal codDIAG As String, ByVal CODIGO As String, ByVal TEXT As String, ByVal ENF As String) As Boolean
        Try
            Dim csql As String = "Insert into DIAGNOSTICO (coddiagnostico,codigo,diagnostico,codenfermedad) values ('" + codDIAG + "','" + CODIGO + "','" + TEXT + "','" + ENF + "')"
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
            MessageBox.Show("Error" + ex.ToString, "Diagnostico", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Public Function UpdateDIAG(ByVal codDIAG As String, ByVal CODIGO As String, ByVal TEXT As String, ByVal ENF As String) As Boolean
        Try
            Dim csql As String = "update DIAGNOSTICO  set codigo='" + CODIGO + "',diagnostico='" + TEXT + "',codenfermedad='" + ENF + "' where coddiagnostico='" + codDIAG + "'"
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
            MessageBox.Show("Error" + ex.ToString, "Diagnostico", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

End Class
