<%@ Page Language="VB" MasterPageFile="~/WFPrincipal/PaginaMaestra.master" AutoEventWireup="false" CodeFile="EvolucionMedica.aspx.vb" Inherits="Hospitalizacion_EvolucionMedica" title="Página sin título" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:100%;">
        <tr>
            <td style="width: 116px">
                <asp:Label ID="Label1" runat="server" Text="Paciente"></asp:Label>
            </td>
            <td style="width: 384px">
                <asp:TextBox ID="txtbuscar" runat="server" Width="577px"></asp:TextBox>
            &nbsp;<asp:Button ID="btnbuscar" runat="server" Text="Buscar" />
            </td>
            <td>
                <asp:Panel ID="Panel2" runat="server" 
                    GroupingText="Datos del Paciente Intervenido" Height="158px" 
                    ScrollBars="Vertical">
                    <asp:GridView ID="gvhospitalizaciones" runat="server" AutoGenerateColumns="False" 
    AutoGenerateSelectButton="True" BackColor="White" BorderColor="#CC9966" 
    BorderStyle="None" BorderWidth="1px" CellPadding="4" Height="140px" 
    Width="581px">
                        <RowStyle BackColor="White" ForeColor="#330099" />
                        <Columns>
                            <asp:BoundField DataField="CodHospitalizacion" HeaderText="Hospitalización" />
                            <asp:BoundField DataField="paciente" 
                                HeaderText="Paciente" />
                            <asp:BoundField DataField="solicitud" 
                                HeaderText="Solicitud" />
                            <asp:BoundField DataField="motivo" HeaderText="Motivo" />
                            <asp:BoundField DataField="fecha" HeaderText="Fecha" />
                        </Columns>
                        <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                        <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" 
                            HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" 
                            ForeColor="#663399" />
                        <HeaderStyle BackColor="#990000" Font-Bold="True" 
                            ForeColor="#FFFFCC" />
                    </asp:GridView>
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td style="width: 116px">
                <asp:Label ID="Label2" runat="server" Text="Apreciación Objetiva"></asp:Label>
            </td>
            <td style="width: 384px">
                <asp:TextBox ID="txtao" runat="server" TextMode="MultiLine" Width="638px"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="Label10" runat="server" Text="Hospitalización"></asp:Label>
&nbsp;&nbsp;
                <asp:Label ID="lblhospitalizacion" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 116px">
                <asp:Label ID="Label3" runat="server" Text="Apreciación Subjetiva"></asp:Label>
            </td>
            <td style="width: 384px">
                <asp:TextBox ID="txtas" runat="server" TextMode="MultiLine" Width="640px"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="lblevolucion" runat="server"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lbldetalle" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
        <td>
            <asp:Label ID="Label4" runat="server" Text="Verificación Tratamiento"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtvt" runat="server" TextMode="MultiLine" Width="638px"></asp:TextBox>
        </td>
        <td>
        </td>
        </tr>
    </table>
   <table>
   <tr>
    <td style="width: 144px">
        <asp:Label ID="Label5" runat="server" Text="Servicio"></asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddservicio" runat="server" Height="40px" Width="570px">
            </asp:DropDownList>
        </td>
   </tr>
   <tr>
    <td style="width: 144px">
        <asp:Label ID="Label6" runat="server" Text="Resultado Examen"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtre" runat="server" TextMode="MultiLine" Width="572px"></asp:TextBox>
        </td>
   </tr>
   <tr>
    <td style="width: 144px">
        <asp:Label ID="Label7" runat="server" Text="Observaciones"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtobs" runat="server" TextMode="MultiLine" Width="571px"></asp:TextBox>
        </td>
   </tr>
   <tr>
    <td style="width: 144px">
        <asp:Label ID="Label8" runat="server" Text="Fecha "></asp:Label>
        </td>
        <td>
            <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
        </td>
   </tr>
   <tr>
    <td style="width: 144px">
        <asp:Label ID="Label9" runat="server" Text="Hora"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txthora" runat="server"></asp:TextBox>
        </td>
   </tr>
   <tr>
   <td style="width: 144px">
       <asp:Label ID="Label11" runat="server" Text="Nota Enfermera"></asp:Label>
       </td>
   <td>
       <asp:TextBox ID="txtenfermera" runat="server" TextMode="MultiLine" 
           Width="492px"></asp:TextBox>
       <asp:Button ID="btnagregar" runat="server" Text="+" />
&nbsp;<asp:Button ID="btnquitar" runat="server" Text="-" />
       </td>
   <td>
       <asp:Button ID="btnNuevo" runat="server" Text="Nuevo" />
       &nbsp;<asp:Button ID="BtnGrabar" runat="server" Text="Grabar" />
       &nbsp;<asp:Button ID="btncancelar" runat="server" Text="Cancelar" />
       </td>
      </tr>
   
   
   <tr>
   <td style="width: 144px">
       &nbsp;</td>
   <td>
       &nbsp;<asp:Panel ID="Panel3" runat="server" 
                    GroupingText="Datos Listados" Height="158px" 
                    ScrollBars="Vertical">
           <asp:GridView ID="gvgvdetalle" runat="server" AutoGenerateColumns="False" 
    AutoGenerateSelectButton="True" BackColor="White" BorderColor="#CC9966" 
    BorderStyle="None" BorderWidth="1px" CellPadding="4" Height="140px" 
    Width="581px">
               <RowStyle BackColor="White" ForeColor="#330099" />
               <Columns>
                   <asp:BoundField DataField="columna1" HeaderText="Apreciacion Subjetiva" />
                   <asp:BoundField DataField="columna2" 
                                HeaderText="ApreciacionObjetiva" />
                   <asp:BoundField DataField="columna3" 
                                HeaderText="VerificacionTratamiento" />
                   <asp:BoundField DataField="columna4" HeaderText="ResultadoExamen" />
                   <asp:BoundField DataField="columna5" HeaderText="Observaciones" />
                   <asp:BoundField DataField="columna6" HeaderText="Fecha" />
                   <asp:BoundField DataField="columna7" HeaderText="Hora" />
                   <asp:BoundField DataField="columna8" HeaderText="Nota Enfermeria" />
               </Columns>
               <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
               <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" 
                            HorizontalAlign="Center" />
               <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" 
                            ForeColor="#663399" />
               <HeaderStyle BackColor="#990000" Font-Bold="True" 
                            ForeColor="#FFFFCC" />
           </asp:GridView>
                </asp:Panel>
       </td>
   <td>
       &nbsp;</td>
   
   </tr>
   <tr>
    <td class="style8" style="width: 132px">
        <asp:Label ID="Label12" runat="server" Text="Diagnóstico"></asp:Label>
        </td>
     <td style="width: 351px">&nbsp;&nbsp;<asp:DropDownList ID="dddiagnostico" runat="server" 
             Height="30px" Width="324px">
         </asp:DropDownList>
        </td>
      <td>
          <asp:HyperLink ID="HyperLink3" runat="server" 
              NavigateUrl="~/Hospitalizacion/MenuHospitalizacion.aspx">Regresar</asp:HyperLink>
       </td>
    </tr>
    <tr>
    <td>
    
        <asp:Label ID="Label13" runat="server" Text="Tipo Diagnostico"></asp:Label>
    
    </td>
    <td>&nbsp;&nbsp;
        <asp:DropDownList ID="ddtdiagnostico" runat="server" Height="17px" 
            Width="323px">
        </asp:DropDownList>
        </td>
    <td></td>
    </tr>
      </table>
</asp:Content>

