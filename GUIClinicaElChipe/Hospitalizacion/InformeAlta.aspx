<%@ Page Language="VB" MasterPageFile="~/WFPrincipal/PaginaMaestra.master" AutoEventWireup="false" CodeFile="InformeAlta.aspx.vb" Inherits="Hospitalizacion_InformeAlta" title="Página sin título" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:100%;">
        <tr>
            <td style="width: 67px" class="style5">
                <asp:Label ID="Label1" runat="server" Text="Paciente"></asp:Label>
            </td>
            <td style="width: 298px">
                <asp:TextBox ID="txtbuscar" runat="server" Width="418px"></asp:TextBox>
                <br />
                <asp:Button ID="btnbuscar" runat="server" Text="Buscar" />
            </td>
            <td>
                <asp:Panel ID="Panel2" runat="server" 
                    GroupingText="Datos del Paciente y Solicitud de Atención" Height="158px" 
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
            <td style="width: 67px" class="style5">
                <asp:Label ID="Label2" runat="server" Text="Condición de Alta"></asp:Label>
            </td>
            <td style="width: 298px">
                <asp:TextBox ID="txtcondicion" runat="server" Height="65px" 
                    TextMode="MultiLine" Width="431px"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="lblhospitalizacion" runat="server"></asp:Label>
                <br />
                <asp:Label ID="Label3" runat="server" Text="Informe N°"></asp:Label>
&nbsp;
                <asp:Label ID="lblinforme" runat="server"></asp:Label>
            </td>
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
          <asp:HyperLink ID="HyperLink1" runat="server" 
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
        
        <tr>
            <td style="width: 67px" class="style5">
                &nbsp;</td>
            <td style="width: 298px">
                <asp:Button ID="btnNuevo" runat="server" Text="Nuevo" />
&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btngrabar" runat="server" Text="Grabar" />
&nbsp;&nbsp;
                <asp:Button ID="btncancelar" runat="server" Text="Cancelar" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        
    </table>
</asp:Content>

