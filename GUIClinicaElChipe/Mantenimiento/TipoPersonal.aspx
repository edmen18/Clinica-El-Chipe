<%@ Page Language="VB" MasterPageFile="~/WFPrincipal/PaginaMaestra.master" AutoEventWireup="false" CodeFile="TipoPersonal.aspx.vb" Inherits="Mantenimiento_TipoPersonal" title="Página sin título" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div>
<table style="width: 318px">
<tr>
<td>
    <asp:Label ID="lblcodig" runat="server" Text="Código"></asp:Label>
    </td>
<td style="width: 493px">
    <asp:Label ID="lblcodigo" runat="server"></asp:Label>
    </td>
</tr>
<tr> 
<td>
    <asp:Label ID="Label3" runat="server" Text="Descripción"></asp:Label>
    </td>
<td style="width: 493px">
    <asp:TextBox ID="txtdescripcion" runat="server" Width="231px"></asp:TextBox>
    </td>
</tr>
</table>
<table>
<tr>
<td class="style21" style="width: 73px">
    <asp:Label ID="Label1" runat="server" Text="Buscar"></asp:Label>
    </td>
<td style="width: 236px">
    <asp:TextBox ID="Ttxtdato" runat="server" Width="231px"></asp:TextBox>
    </td>
    <td>
        <asp:Button ID="btnver" runat="server" Text="Ver" />
    </td>
</tr>
</table>
<table>
<tr>
<td>
    <asp:GridView ID="gvtp" runat="server" AutoGenerateColumns="False" 
        AutoGenerateSelectButton="True" CellPadding="4" ForeColor="#333333" 
        GridLines="None">
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <RowStyle BackColor="#EFF3FB" />
        <Columns>
            <asp:BoundField DataField="CodTipoPersonal" HeaderText="Codigo" />
            <asp:BoundField DataField="NomTipoPersonal" HeaderText="Descripción" />
        </Columns>
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <EditRowStyle BackColor="#2461BF" />
        <AlternatingRowStyle BackColor="White" />
    </asp:GridView>
</td>
<td>
    <asp:Panel ID="Panel1" runat="server" GroupingText="Opciones" Height="103px" 
        Width="88px">
        <asp:Button ID="btnnuevo" runat="server" Text="Nuevo" Width="75px" />
        <br />
        <asp:Button ID="btngrabar" runat="server" Text="Grabar" Width="77px" />
        <br />
        <asp:Button ID="btncancelar" runat="server" Text="Cancelar" />
        <asp:Label ID="lblind" runat="server"></asp:Label>
    </asp:Panel>
</td>
</tr>
</table>
</div>
</asp:Content>

