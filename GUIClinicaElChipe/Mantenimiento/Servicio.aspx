<%@ Page Language="VB" MasterPageFile="~/WFPrincipal/PaginaMaestra.master" AutoEventWireup="false" CodeFile="Servicio.aspx.vb" Inherits="Mantenimiento_Servicio" title="Página sin título" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div>
<table>
<tr>
<td>
    <asp:Label ID="lblcategoria" runat="server"></asp:Label>
</td>
<td>
    <asp:TextBox ID="Txtcategoria" runat="server"></asp:TextBox>
    <asp:Button ID="Btnbuscar" runat="server" Text="Ver" />
</td>
</tr>
</table>
<table>
<tr>
<td>
    <asp:Panel ID="PNHABIT" runat="server" GroupingText="Categoria" 
        ScrollBars="Vertical">
        <asp:GridView ID="GVHABITACION" runat="server" AutoGenerateColumns="False" 
            AutoGenerateSelectButton="True" CellPadding="4" ForeColor="#333333" 
            GridLines="None">
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <RowStyle BackColor="#EFF3FB" />
            <Columns>
                <asp:BoundField DataField="Codcategoria" HeaderText="Código" />
                <asp:BoundField DataField="Nomcategoria" HeaderText="Categoria" />
            </Columns>
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <EditRowStyle BackColor="#2461BF" />
            <AlternatingRowStyle BackColor="White" />
        </asp:GridView>
    </asp:Panel>
</td>
</tr>
</table>

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
    <asp:Label ID="Label3" runat="server" Text="Servicio"></asp:Label>
    </td>
<td style="width: 493px">
    <asp:TextBox ID="txtdescripcion" runat="server" Width="389px"></asp:TextBox>
    </td>
</tr>
<tr>
<td>
    <asp:Label ID="Label2" runat="server" Text="Precio"></asp:Label></td>
<td>
    <asp:TextBox ID="txtprecio" runat="server"></asp:TextBox></td>
</tr>
</table>
<table>
<tr>
<td class="style21" style="width: 43px">
    <asp:Label ID="Label1" runat="server" Text="Buscar"></asp:Label>
    </td>
<td style="width: 62px" class="style8">
    <asp:TextBox ID="Ttxtdato" runat="server" Width="345px" 
        style="margin-left: 5px"></asp:TextBox>
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
            <asp:BoundField DataField="Codservicio" HeaderText="Codigo" />
            <asp:BoundField DataField="Nomservicio" HeaderText="Número" />
            <asp:BoundField DataField="Precio" HeaderText="Precio" />
            <asp:BoundField DataField="Codcategoria" HeaderText="Cod. Categoria" />
            <asp:BoundField DataField="Nomcategoria" HeaderText="Categoria" />
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
        <asp:Button ID="btnnuevo" runat="server" Text="Nuevo" Width="77px" />
        <br />
        <asp:Button ID="btngrabar" runat="server" Text="Grabar" Width="77px" />
        <br />
        <asp:Button ID="btneliminar" runat="server" Text="Eliminar" Width="77px" />
        <br />
        <asp:Button ID="btncancelar" runat="server" Text="Cancelar" />
        <asp:Label ID="lblind" runat="server"></asp:Label>
    </asp:Panel>
</td>
</tr>
</table>
</div>
</asp:Content>

