Imports datos
Imports Reglas
Imports System.Data
Imports System.Windows.Forms
Partial Class Hospitalizacion_HistoriaClinicaPerinatal
    Inherits System.Web.UI.Page
    Dim parto As New Parto
    Dim nac As New Nacimiento
    Dim am As New Antecedentesmaternos
    Dim cFun As New cFuncionesDB
    Dim d As New Diagnostico
    Dim u As New Usuario
    Dim t As New Turno
    Dim tipopart As String
    Dim liqam As String
    Dim cordon As String
    Dim placenta As String
    Dim anestecia As String
    Dim reanimacion As String
    Dim droga As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.lblcodpaciente.Text = Request.QueryString("codhosp")
        Me.LblPaciente.Text = Request.QueryString("paciente")
    End Sub

    Protected Sub Menu1_MenuItemClick(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.MenuEventArgs) Handles Menu10.MenuItemClick
        MultiView1.ActiveViewIndex = Int32.Parse(e.Item.Value)

        Menu10.Items(0).ImageUrl = "~/Imagenes/Parto.jpg"
        Menu10.Items(1).ImageUrl = "~/Imagenes/Antecedentes.jpg"
        Menu10.Items(2).ImageUrl = "~/Imagenes/Nacimiento.jpg"

        Select Case e.Item.Value
            Case 0
                Menu10.Items(0).ImageUrl = "~/Imagenes/Consulta2.jpg"
            Case 1
                Menu10.Items(1).ImageUrl = "~/Imagenes/Diagnostico.jpg"
            Case 2
                Menu10.Items(2).ImageUrl = "~/Imagenes/TratamientoReceta.jpg"
        End Select
    End Sub

    Protected Sub tipoparto_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tipoparto.SelectedIndexChanged
        
    End Sub

    Protected Sub BtnRegistrarConsulta_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles BtnRegistrarConsulta.Click
        'para tipoparto
        For i = 0 To Me.tipoparto.Items.Count - 1
            If Me.tipoparto.Items(i).Selected = True Then
                tipopart = tipopart & "," & Me.tipoparto.Items(i).Text
            End If
        Next
        'para anestecia
        For i = 0 To Me.chkanestecia.Items.Count - 1
            If Me.chkanestecia.Items(i).Selected = True Then
                anestecia = anestecia & "," & Me.chkanestecia.Items(i).Text
            End If
        Next
        'para liquido amniotico
        liqam = Me.lblclaro.Text & ":" & Me.txtclaro.Text & "," & Me.lblmclaro.Text & ":" & Me.txtmclaro.Text & "," & Me.lblmespeso.Text & ":" & Me.txtmespeso.Text & "," & Me.lblfetido.Text & ":" & Me.txtfetido.Text & "," & Me.lblmfetido.Text & ":" & Me.txtmfetido.Text & "," & Me.lblhemorragia.Text & ":" & Me.txthemorragia.Text
        'para cordon
        cordon = Me.lblcordon.Text & ":" & Me.lblpatologico.Text & ":" & Me.txtpatologico.Text & "," & Me.lblnormal.Text & ":" & Me.txtnormal.Text
        'para placenta
        placenta = Me.lblplanormal.Text & ":" & Me.txtplanormal.Text & "," & Me.lblpatolo.Text & ":" & Me.txtpatolo.Text & "," & Me.lblpeso.Text & ":" & Me.txtpeso.Text
        'para reanimacion
        If rbreanimacion.SelectedIndex = 0 Then
            reanimacion = "Si"
            For i = 0 To Me.chkreanimar.Items.Count - 1
                If Me.chkreanimar.Items(i).Selected = True Then
                    reanimacion = reanimacion & "," & Me.chkreanimar.Items(i).Text
                End If
            Next
        Else
            reanimacion = "No"
        End If
        'para drogras
        For i = 0 To Me.chkdrogas.Items.Count - 1
            If Me.chkdrogas.Items(i).Selected = True Then
                droga = droga & "," & Me.chkdrogas.Items(i).Text
            End If
            droga = droga & "," & Me.txtotros.Text
        Next
        parto.generar(Me.lblparto)
        parto.AgregarPaciente(Me.lblparto.Text, Me.lblcodpaciente.Text, Me.tipopart, anestecia, cordon, liqam, placenta, reanimacion, droga)

    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        am.generar(Me.lblam)
        am.registrar(Me.lblam.Text, Me.lblparto.Text, Me.txtgestacion.Text, Me.txtparidad.Text, Me.txttermino.Text, Me.txtprematuros.Text, Me.txtabortos.Text, Me.txtobito.Text, rtfactoresriesgo.Text, Me.txttiempogestacion.Text & " " & Me.lblsemanas.Text, Me.Label17.Text & ":" & Me.txtpatologiaembarazo.Text & "," & Me.Label19.Text & ":" & Me.txtantecedentes.Text, Me.txtfechaparto.Text, Me.txthoraparto.Text, Me.lblinducida.Text & ":" & Me.txtinducida.Text & "," & Me.lblexpontanea.Text & ":" & Me.txtexpontanea.Text, txtcaracteristicas.Text, txtdrogas.Text)

    End Sub

    Protected Sub BtnRegistrarReceta_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles BtnRegistrarReceta.Click
        nac.generar(Me.lblnac)
        nac.Registrar(Me.lblnac.Text, Me.lblparto.Text, Me.txtnombre.Text, Me.ddsexo.Text, Me.txtegest.Text, Me.txtfechaparto.Text, Me.txthoraparto.Text, Me.txttalla.Text, Me.txtpesorn.Text, Me.txtpc.Text, Me.txtptx.Text, Me.txtpab.Text, Me.txtfc.Text, Me.txter.Text, Me.txttm.Text, Me.txtref.Text, Me.txtcol.Text, Me.txtt.Text, Me.txtobservaciones.Text, Me.lblaspectofisico.Text & ":" & Me.txtaspecto.Text & "," & Me.lblpiel.Text & ":" & Me.txtpiel.Text & "," & Me.lblccuello.Text & ":" & Me.txtcabeza.Text & "," & Me.lblojos.Text & ":" & Me.txtojos.Text & "," & Me.lblnariz.Text & ":" & Me.txtoido.Text & "," & Me.lbltorax.Text & ":" & Me.txttorax.Text & "," & Me.lblpulmones.Text & ":" & Me.txtpulmones.Text & "," & Me.lblcorazon.Text & ":" & Me.txtcorazon.Text & "," & Me.lblabdomen.Text & ":" & Me.txtabdomen.Text & "," & Me.lblcolumna.Text & ":" & Me.txtcol.Text & "," & Me.lblextremidades.Text & ":" & Me.txtextremidades.Text & "," & Me.lblneuro.Text & ":" & Me.txtneurologico.Text & "," & Me.lblano.Text & ":" & Me.txtano.Text, Me.dddiag1.Text & "," & Me.dddiag2.Text & "," & Me.dddiag3.Text)
        Server.Transfer("~/Hospitalizacion/Reportes/Reporte.aspx?ind=" & 5 & "&reporte=" & Me.lblparto.Text & "", True)

    End Sub
End Class
