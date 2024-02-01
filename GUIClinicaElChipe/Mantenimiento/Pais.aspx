<%@ Page Language="VB" MasterPageFile="~/WFPrincipal/PaginaMaestra.master" AutoEventWireup="false" CodeFile="Pais.aspx.vb" Inherits="Mantenimiento_Pais" title="Página sin título" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div>
<table>
<tr>
<td>
    <asp:Label ID="Label1" runat="server" Text="Cod Pais"></asp:Label>
</td>
<td>
    <asp:Label ID="lblcodpais" runat="server"></asp:Label>
</td>
</tr>
<tr>
<td>
    <asp:Label ID="Label3" runat="server" Text="Nom Pais"></asp:Label>
</td>
<td>
    <asp:TextBox ID="txtnompais" runat="server" Width="483px"></asp:TextBox>
    <asp:Label ID="lblflag" runat="server"></asp:Label>
</td>
</tr>
</table>
<table>
<tr>
<td>
    <asp:Panel ID="Panel1" runat="server" ScrollBars="Vertical" Width="547px">
    <asp:GridView ID="gvpais" runat="server" AutoGenerateColumns="False" 
            CellPadding="4" ForeColor="#333333" GridLines="None" Width="546px" 
            AutoGenerateSelectButton="True">
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <RowStyle BackColor="#EFF3FB" />
        <Columns>
            <asp:BoundField DataField="CodPais" HeaderText="Cod. Pais" />
            <asp:BoundField DataField="Nompais" HeaderText="Pais" />
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
    <asp:Panel ID="Panel2" runat="server" GroupingText="Operaciones" Width="111px">
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Btnnuevo" runat="server" Text="Nuevo" Width="75px" />
        <br />
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="Btngrabar" runat="server" Text="Grabar" Width="75px" />
        <br />
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="Btneliminar" runat="server" Text="Eliminar" Width="77px" />
        <br />
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="Btncancelar" runat="server" Text="Cancelar" />
    </asp:Panel>

</td>
</tr>
</table>
</div>
</asp:Content>

