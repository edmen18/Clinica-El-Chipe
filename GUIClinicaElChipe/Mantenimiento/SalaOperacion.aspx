<%@ Page Language="VB" MasterPageFile="~/WFPrincipal/PaginaMaestra.master" AutoEventWireup="false" CodeFile="SalaOperacion.aspx.vb" Inherits="Mantenimiento_SalaOperacion" title="Página sin título" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div>
<table style="width: 163px">
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
    <asp:Label ID="Label3" runat="server" Text="Nº"></asp:Label>
    </td>
<td style="width: 493px">
    <asp:TextBox ID="txtdescripcion" runat="server" Width="61px"></asp:TextBox>
    </td>
</tr>
</table>
<table>
<tr>
<td class="style21" style="width: 43px">
    <asp:Label ID="Label1" runat="server" Text="Buscar"></asp:Label>
    </td>
<td style="width: 62px" class="style8">
    <asp:TextBox ID="Ttxtdato" runat="server" Width="62px"></asp:TextBox>
    </td>
    <td>
        <asp:Button ID="btnver" runat="server" Text="Ver" Width="43px" />
    </td>
</tr>
</table>
<table>
<tr>
<td>
    <asp:Panel ID="Panel2" runat="server" GroupingText="Listado" 
        ScrollBars="Vertical" style="margin-right: 0px">
        <asp:GridView ID="gvtp" runat="server" AutoGenerateColumns="False" 
        AutoGenerateSelectButton="True" CellPadding="4" ForeColor="#333333" 
        GridLines="None">
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <RowStyle BackColor="#EFF3FB" />
        <Columns>
            <asp:BoundField DataField="Codsalaoperacion" HeaderText="Codigo" />
            <asp:BoundField DataField="Numsala" HeaderText="Número" />
        </Columns>
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <EditRowStyle BackColor="#2461BF" />
        <AlternatingRowStyle BackColor="White" />
    </asp:GridView>
    </asp:Panel>
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

