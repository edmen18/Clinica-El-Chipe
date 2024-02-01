<%@ Page Language="VB" MasterPageFile="~/WFPrincipal/PaginaMaestra.master" AutoEventWireup="false" CodeFile="Hospitalizacion.aspx.vb" Inherits="Hospitalizacion_Hospitalizacion" title="Página sin título" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:100%;">
        <tr>
            <td style="height: 91px; width: 103px">
                <asp:Label ID="Label1" runat="server" Text="Paciente"></asp:Label>
            </td>
            <td style="height: 91px; width: 252px">
                Buscar<asp:TextBox ID="txtbuscar" runat="server" Width="272px"></asp:TextBox>
            &nbsp;<asp:Button ID="btnbuscar" runat="server" Text="Buscar" />
            </td>
            <td style="height: 91px">
                <asp:Panel ID="Panel2" runat="server" 
                    GroupingText="Datos del Paciente y Solicitud de Atención" Height="158px" 
                    ScrollBars="Vertical">
                    <asp:GridView ID="gvsolicitudes" runat="server" AutoGenerateColumns="False" 
    AutoGenerateSelectButton="True" BackColor="White" BorderColor="#CC9966" 
    BorderStyle="None" BorderWidth="1px" CellPadding="4" Height="140px" 
    Width="586px">
                        <RowStyle BackColor="White" ForeColor="#330099" />
                        <Columns>
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
            <td style="width: 103px">
                <asp:Label ID="Label2" runat="server" Text="Cod. Solicitud"></asp:Label>
            </td>
            <td style="width: 252px">
                <asp:Label ID="lblsolicitud" runat="server"></asp:Label>
            </td>
            <td>
                <asp:Label ID="lblhospitalizacion" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 103px">
                <asp:Label ID="Label3" runat="server" Text="Paciente"></asp:Label>
            </td>
            <td style="width: 252px">
                <asp:Label ID="lblpaciente" runat="server"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    <table style="width: 100%;">
        <tr>
            <td style="width: 133px">
                &nbsp;
                <asp:Label ID="Label4" runat="server" Text="Ex. Clinico General"></asp:Label>
            </td>
            <td>
                &nbsp;
                <asp:TextBox ID="txtcligeneral" runat="server" Height="44px" 
                    TextMode="MultiLine" Width="855px"></asp:TextBox>
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td style="width: 133px">
                &nbsp;
                <asp:Label ID="Label5" runat="server" Text="Ex. Clinico Regional"></asp:Label>
            </td>
            <td>
                &nbsp;
                <asp:TextBox ID="txtcliregional" runat="server" Height="51px" 
                    TextMode="MultiLine" Width="854px"></asp:TextBox>
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td style="width: 133px">
                &nbsp;
                <asp:Label ID="Label6" runat="server" Text="Anamnesis"></asp:Label>
            </td>
            <td>
                &nbsp;
                <asp:TextBox ID="txtAnamnesis" runat="server" Height="49px" 
                    TextMode="MultiLine" Width="853px"></asp:TextBox>
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
    </table>
    <table>
    <tr>
    <td class="style8" style="width: 132px">
        <asp:Label ID="Label7" runat="server" Text="Diagnóstico"></asp:Label>
        </td>
     <td style="width: 351px">&nbsp;&nbsp;<asp:DropDownList ID="dddiagnostico" runat="server" 
             Height="30px" Width="324px">
         </asp:DropDownList>
        </td>
      <td></td>
    </tr>
    <tr>
    <td>
    
        <asp:Label ID="Label8" runat="server" Text="Tipo Diagnostico"></asp:Label>
    
    </td>
    <td>&nbsp;&nbsp;
        <asp:DropDownList ID="ddtdiagnostico" runat="server" Height="17px" 
            Width="323px">
        </asp:DropDownList>
        </td>
    <td>
        <asp:HyperLink ID="HyperLink3" runat="server" 
            NavigateUrl="~/Hospitalizacion/MenuHospitalizacion.aspx">Regresar</asp:HyperLink>
        </td>
    </tr>
    
    
    <tr>
    <td class="style8" style="width: 132px">
    
        <asp:Button ID="btnnuevo" runat="server" Text="Nuevo" />
    
    </td>
    <td style="width: 351px">
    
        <asp:Button ID="btnGrabar" runat="server" Text="Grabar" />
    
    </td>
    <td>
    
        <asp:Button ID="btncancelar" runat="server" Text="Cancelar" />
    
    </td>
    </tr>
    </table>
</asp:Content>

