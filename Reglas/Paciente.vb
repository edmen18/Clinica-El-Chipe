Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports System.Web.UI.WebControls
Imports datos
Public Class Paciente
    Dim cFun As New cFuncionesDB
    Private s_CodPaciente As String
    Private s_Nombres As String
    Private s_ApellidoPaterno As String
    Private s_ApellidoMaterno As String
    Private o_TipoDocIdentidad As TipoDocIdentidad
    Private d_FechaNacimiento As Date
    Private o_Direccion As Direccion
    Private c_Sexo As Char
    Private o_EstadoCivil As EstadoCivil
    Private s_Ocupacion As String
    Private s_Celular As String
    Private s_Telefono As String
    Private s_Email As String
    Private o_Usuario As Usuario
    Private s_NumeroDocIdentidad As String
    Private s_LugarOrigen As String
    Public Property CodPaciente() As String
        Get
            Return s_CodPaciente
        End Get
        Set(ByVal value As String)
            s_CodPaciente = value
        End Set
    End Property
    Public Property Nombres() As String
        Get
            Return s_Nombres
        End Get
        Set(ByVal value As String)
            s_Nombres = value
        End Set
    End Property
    Public Property ApellidoPaterno() As String
        Get
            Return s_ApellidoPaterno
        End Get
        Set(ByVal value As String)
            s_ApellidoPaterno = value
        End Set
    End Property
    Public Property ApellidoMaterno() As String
        Get
            Return s_ApellidoMaterno
        End Get
        Set(ByVal value As String)
            s_ApellidoMaterno = value
        End Set
    End Property
    Public Property TipoDocIdentidad() As TipoDocIdentidad
        Get
            Return o_TipoDocIdentidad
        End Get
        Set(ByVal value As TipoDocIdentidad)
            o_TipoDocIdentidad = value
        End Set
    End Property
    Public Property FechaNacimiento() As Date
        Get
            Return d_FechaNacimiento
        End Get
        Set(ByVal value As Date)
            d_FechaNacimiento = value
        End Set
    End Property
    Public Property Direccion() As Direccion
        Get
            Return o_Direccion
        End Get
        Set(ByVal value As Direccion)
            o_Direccion = value
        End Set
    End Property
    Public Property Sexo() As Char
        Get
            Return c_Sexo
        End Get
        Set(ByVal value As Char)
            c_Sexo = value
        End Set
    End Property
    Public Property EstadoCivil() As EstadoCivil
        Get
            Return o_EstadoCivil
        End Get
        Set(ByVal value As EstadoCivil)
            o_EstadoCivil = value
        End Set
    End Property
    Public Property Ocupacion() As String
        Get
            Return s_Ocupacion
        End Get
        Set(ByVal value As String)
            s_Ocupacion = value
        End Set
    End Property
    Public Property Celular() As String
        Get
            Return s_Celular
        End Get
        Set(ByVal value As String)
            s_Celular = value
        End Set
    End Property
    Public Property Telefono() As String
        Get
            Return s_Telefono
        End Get
        Set(ByVal value As String)
            s_Telefono = value
        End Set
    End Property
    Public Property Email() As String
        Get
            Return s_Email
        End Get
        Set(ByVal value As String)
            s_Email = value
        End Set
    End Property
    Public Property Usuario() As Usuario
        Get
            Return o_Usuario
        End Get
        Set(ByVal value As Usuario)
            o_Usuario = value
        End Set
    End Property
    Public Property NumeroDocIdentidad() As String
        Get
            Return s_NumeroDocIdentidad
        End Get
        Set(ByVal value As String)
            s_NumeroDocIdentidad = value
        End Set
    End Property
    Public Property LugarOrigen() As String
        Get
            Return s_LugarOrigen
        End Get
        Set(ByVal value As String)
            s_LugarOrigen = value
        End Set
    End Property
    Public Function AgregarPaciente(ByRef codigopaciente As String, ByRef nombres As String, ByRef apellidopaterno As String, ByRef apellidomaterno As String, ByRef codtipodocidentidad As String, ByRef fechanacimiento As Date, ByRef codigodireccion As String, ByRef sexo As String, ByRef codigoestadocivil As String, ByRef ocupacion As String, ByRef celular As String, ByRef telefono As String, ByRef email As String, ByRef codigoregistroseguro As String, ByRef codigousuario As String, ByRef numerodocidentidad As String, ByRef lugarorigen As String) As Boolean
        Try
            Dim csql As String = "Insert into Paciente(CodPaciente,Nombres,ApellidoPaterno,ApellidoMaterno,CodTipoDocIdentidad,FechaNacimiento,CodDireccion,Sexo,CodEstadoCivil,Ocupacion,Celular,Telefono,Email,CodRegistroSeguro,CodUsuario,NumeroDocIdentidad,LugarOrigen) values ('" & codigopaciente & "','" & nombres & "','" & apellidopaterno & "','" & apellidomaterno & "','" & codtipodocidentidad & "','" & CDate(fechanacimiento) & "','" & codigodireccion & "','" & sexo & "','" & codigoestadocivil & "','" & ocupacion & "','" & celular & "','" & telefono & "','" & email & "','" & codigoregistroseguro & "','" & codigousuario & "','" & numerodocidentidad & "','" & lugarorigen & "')"
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
    Public Function ModificarPaciente(ByRef nombre As String, ByRef apellidopaterno As String, ByRef apellidomaterno As String, ByRef codtipodocidentidad As String, ByRef fechanacimiento As Date, ByRef Sexo As String, ByRef codestadocivil As String, ByRef ocupacion As String, ByRef celular As String, ByRef telefono As String, ByRef email As String, ByRef numerodocidentidad As String, ByRef lugarorigen As String, ByRef codigopaciente As String) As Boolean
        Try
            Dim csql As String = "Update Paciente set Nombres='" + nombre + "',ApellidoPaterno='" + apellidopaterno + "',ApellidoMaterno='" + apellidomaterno + "',CodTipoDocIdentidad='" + codtipodocidentidad + "',FechaNacimiento='" + CDate(fechanacimiento) + "'," + _
            "Sexo='" + Sexo + "',CodEstadoCivil='" + codestadocivil + "',Ocupacion='" + ocupacion + "',Celular='" + celular + "',Telefono='" + telefono + "',Email='" + email + "',NumeroDocIdentidad='" + numerodocidentidad + "',LugarOrigen='" + lugarorigen + "'" + _
            "where CodPaciente='" + codigopaciente + "'"
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
    Function ListaHistoriaClinicaPaciente(ByRef dato As String)
        Dim sql As String
        sql = "Select b.NHC,a.CodPaciente,a.ApellidoPaterno,a.ApellidoMaterno,a.Nombres,a.FechaNacimiento,c.CodTipoDocIdentidad," + _
        "c.NomTipoDoc,a.NumeroDocIdentidad,d.CodEstadoCivil,d.NomEstadoCivil,f.CodDireccion," + _
        "f.Dato1,f.NomDireccion,f.Dato2,f.Numero,f.Lote,g.NomCentroPoblado,h.NomDistrito,i.NomProvincia,j.NomDepartamento,k.NomPais,a.LugarOrigen," + _
        "e.CodRegistroSeguro,l.CodSeguro,l.NomSeguro," + _
        "e.NumAutogenerado,e.FechaAfiliacion,e.FechaVencimiento,b.FechaApertura,a.Sexo,a.Ocupacion," + _
        "a.Celular,a.Telefono,a.Email from Paciente a " + _
        "inner join HistoriaClinica b on a.CodPaciente=b.CodPaciente " + _
        "inner join TipoDocIdentidad c on c.CodTipoDocIdentidad=a.CodTipoDocIdentidad " + _
        "inner join EstadoCivil d on d.CodEstadoCivil=a.CodEstadoCivil " + _
        "inner join Direccion f on f.CodDireccion=a.CodDireccion " + _
        "inner join CentroPoblado g on g.CodCentroPoblado=f.CodCentroPoblado " + _
        "inner join Distrito h on h.CodDistrito=g.CodDistrito " + _
        "inner join Provincia i on i.CodProvincia=h.CodProvincia " + _
        "inner join Departamento j on j.CodDepartamento=i.CodDepartamento " + _
        "inner join Pais k on k.CodPais=j.CodPais " + _
        "inner join RegistroSeguro e on e.CodRegistroSeguro=a.CodRegistroSeguro " + _
        "inner join Seguro l on l.CodSeguro=e.CodSeguro " + _
        "where a.ApellidoPaterno like '%" + dato + "%' or a.ApellidoMaterno like '%" + dato + "%' or a.Nombres like '%" + dato + "%'"
        Return sql
    End Function
    Function ListaPaciente() As String
        Dim sql As String
        sql = "Select k.NHC, a.ApellidoPaterno+' '+a.ApellidoMaterno+' , '+a.Nombres as PACIENTE," + _
        "b.Abreviatura, a.NumeroDocIdentidad," + _
        "c.Dato1+' '+c.NomDireccion+' '+c.Dato2+' '+c.Numero+' '+c.Lote+' '+d.NomCentroPoblado+' '+e.NomDistrito+' '" + _
        "+f.NomProvincia+' '+g.NomDepartamento+' -  '+h.NomPais as DIRECCION,i.NomEstadoCivil," + _
        "a.Ocupacion,j.NumAutogenerado," + _
        "a.FechaNacimiento, a.CodPaciente from Paciente a " + _
        "inner join TipoDocIdentidad b on a.CodTipoDocIdentidad=b.CodTipoDocIdentidad " + _
        "inner join Direccion c on c.CodDireccion=a.CodDireccion " + _
        "inner join CentroPoblado d on d.CodCentroPoblado=c.CodCentroPoblado " + _
        "inner join Distrito e on e.CodDistrito=d.CodDistrito " + _
        "inner join Provincia f on f.CodProvincia=e.CodProvincia " + _
        "inner join Departamento g on g.CodDepartamento=f.CodDepartamento " + _
        "inner join Pais h on h.CodPais=g.CodPais " + _
        "inner join EstadoCivil i on i.CodEstadoCivil=a.CodEstadoCivil " + _
        "inner join RegistroSeguro j on j.CodRegistroSeguro=a.CodRegistroSeguro " + _
        "inner join HistoriaClinica k on a.CodPaciente=k.CodPaciente " + _
        "order by k.NHC asc "
        Return sql
    End Function
    Function BuscarPaciente(ByRef dato As String) As String
        Dim sql As String
        sql = "Select k.NHC, a.ApellidoPaterno+' '+a.ApellidoMaterno+' , '+a.Nombres as PACIENTE," + _
        "b.Abreviatura, a.NumeroDocIdentidad," + _
        "c.Dato1+' '+c.NomDireccion+' '+c.Dato2+' '+c.Numero+' '+c.Lote+' '+d.NomCentroPoblado+' '+e.NomDistrito+' '" + _
        "+f.NomProvincia+' '+g.NomDepartamento+' -  '+h.NomPais as DIRECCION,i.NomEstadoCivil," + _
        "a.Ocupacion,a.FechaNacimiento, a.CodPaciente from Paciente a " + _
        "inner join TipoDocIdentidad b on a.CodTipoDocIdentidad=b.CodTipoDocIdentidad " + _
        "inner join Direccion c on c.CodDireccion=a.CodDireccion " + _
        "inner join CentroPoblado d on d.CodCentroPoblado=c.CodCentroPoblado " + _
        "inner join Distrito e on e.CodDistrito=d.CodDistrito " + _
        "inner join Provincia f on f.CodProvincia=e.CodProvincia " + _
        "inner join Departamento g on g.CodDepartamento=f.CodDepartamento " + _
        "inner join Pais h on h.CodPais=g.CodPais " + _
        "inner join EstadoCivil i on i.CodEstadoCivil=a.CodEstadoCivil " + _
        "inner join HistoriaClinica k on a.CodPaciente=k.CodPaciente where a.ApellidoPaterno like '%" + dato + "%'" + _
        "or a.ApellidoMaterno like '%" + dato + "%' or a.Nombres like '%" + dato + "%'" + _
        "or k.NHC='" + dato + "' or a.NumeroDocIdentidad='" + dato + "'" + _
        "order by k.NHC asc"
        Return sql
    End Function

    Function BuscarPacienteHuella(ByRef dato As String) As String
        Dim sql As String
        sql = "Select k.NHC, a.ApellidoPaterno+' '+a.ApellidoMaterno+' , '+a.Nombres as PACIENTE," + _
        "b.Abreviatura, a.NumeroDocIdentidad," + _
        "c.Dato1+' '+c.NomDireccion+' '+c.Dato2+' '+c.Numero+' '+c.Lote+' '+d.NomCentroPoblado+' '+e.NomDistrito+' '" + _
        "+f.NomProvincia+' '+g.NomDepartamento+' -  '+h.NomPais as DIRECCION,i.NomEstadoCivil," + _
        "a.Ocupacion,a.FechaNacimiento, a.CodPaciente from Paciente a " + _
        "inner join TipoDocIdentidad b on a.CodTipoDocIdentidad=b.CodTipoDocIdentidad " + _
        "inner join Direccion c on c.CodDireccion=a.CodDireccion " + _
        "inner join CentroPoblado d on d.CodCentroPoblado=c.CodCentroPoblado " + _
        "inner join Distrito e on e.CodDistrito=d.CodDistrito " + _
        "inner join Provincia f on f.CodProvincia=e.CodProvincia " + _
        "inner join Departamento g on g.CodDepartamento=f.CodDepartamento " + _
        "inner join Pais h on h.CodPais=g.CodPais " + _
        "inner join EstadoCivil i on i.CodEstadoCivil=a.CodEstadoCivil " + _
        "inner join HistoriaClinica k on a.CodPaciente=k.CodPaciente where a.codpaciente='" + dato + "'"
        Return sql
    End Function

    Function ComprobarPaciente(ByRef num As String, ByRef nom As String, ByRef apepaterno As String, ByRef apematerno As String) As String
        Dim sql As String
        sql = "Select Nombres+' '+ApellidoPaterno+' '+ApellidoMaterno as Paciente,NumeroDocIdentidad from paciente where NumeroDocIdentidad='" + num + "' and " + _
        "Nombres='" + nom + "' and ApellidoPaterno='" + apepaterno + "' and ApellidoMaterno='" + apematerno + "'"
        Return sql
    End Function
    Public Function BusquedaPaciente(ByVal texto As String, ByVal grid As GridView)
        Dim sql As String = "Select p.CodPaciente,ApellidoPaterno+'  '+ApellidoPaterno+' '+Nombres as nombre, NHC from Paciente p inner join HistoriaClinica h on h.CodPaciente=p.CodPaciente where ApellidoPaterno+'  '+ApellidoPaterno+''+Nombres like '%" + texto + "%' or Nombres+''+ApellidoPaterno+'  '+ApellidoPaterno like '%" + texto + "%' or NumeroDocIdentidad like '%" + texto + "%'"
        cFun.FillDataGridView(sql, grid)
    End Function
    Function GeneraCodigoPaciente() As String
        Dim sql As String
        Sql = "Select Max(Convert(Int,right(CodPaciente,50))) from Paciente"
        Dim dato As String = cFun.ConsultaUnDato(Sql, 0)
        Return dato
    End Function
End Class
