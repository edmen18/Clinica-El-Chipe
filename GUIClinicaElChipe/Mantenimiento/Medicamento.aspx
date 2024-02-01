<%@ Page Language="VB" MasterPageFile="~/WFPrincipal/PaginaMaestra.master" AutoEventWireup="false" CodeFile="Medicamento.aspx.vb" Inherits="Mantenimiento_Medicamento" title="Página sin título" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div>
<table>
<tr>
<td style="width: 95px">
    <asp:Label ID="Label1" runat="server" Text="Còdigo"></asp:Label>
</td>
<td style="width: 454px">
    <asp:Label ID="lblcodigo" runat="server"></asp:Label>
</td>
</tr>
<tr>
<td style="width: 95px">
    <asp:Label ID="Label2" runat="server" Text="Medicamento"></asp:Label>
</td>
<td style="width: 454px">
    <asp:TextBox ID="txtmedicamento" runat="server" MaxLength="50" Width="435px"></asp:TextBox>
</td>
</tr>
<tr>
<td style="width: 95px">
    <asp:Label ID="Label3" runat="server" Text="Precio Unit."></asp:Label>
</td>
<td style="width: 454px">
    <asp:TextBox ID="txtpunit" runat="server" MaxLength="9" Width="128px"></asp:TextBox>
&nbsp;<asp:Label ID="lblind" runat="server"></asp:Label>
</td>
</tr>
<tr>
<td style="width: 95px">
    <asp:Label ID="Label4" runat="server" Text="Utilidad"></asp:Label>
</td>
<td style="width: 454px">
    <asp:TextBox ID="txtutilidad" runat="server" MaxLength="200" 
        TextMode="MultiLine" Width="438px"></asp:TextBox>
</td>
</tr>
</table>
<table>

<tr>

<td class="style5" style="width: 96px">
    <asp:Label ID="Label5" runat="server" Text="Buscar"></asp:Label>
</td>
<td style="width: 323px">
    <asp:TextBox ID="txtbuscar" runat="server" Width="311px"></asp:TextBox>
</td>
<td>
    <asp:Button ID="btnbuscar" runat="server" Text="Buscar" />
</td>
<td>
    <asp:Button ID="Btncancel" runat="server" Text="xx" Width="54px" />
</td>
</tr>
</table>
<table>

<tr>
<td style="width: 412px">
    <asp:Panel ID="Panel1" runat="server" GroupingText="Lista de Medicamentos" 
        ScrollBars="Vertical" Width="416px">
        <asp:GridView ID="gvmedicamentos" runat="server" AutoGenerateColumns="False" 
            CellPadding="4" ForeColor="#333333" GridLines="None" 
            AutoGenerateSelectButton="True">
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <RowStyle BackColor="#EFF3FB" />
            <Columns>
                <asp:BoundField DataField="CodMedicamento" HeaderText="Codigo" />
                <asp:BoundField DataField="nomMedicamento" HeaderText="Medicamento" />
                <asp:BoundField DataField="Preciounitario" HeaderText="Precio" />
                <asp:BoundField DataField="Utilidad" HeaderText="Utilidad" />
            </Columns>
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <EditRowStyle BackColor="#2461BF" />
            <AlternatingRowStyle BackColor="White" />
        </asp:GridView>
    </asp:Panel>
</td>
<td style="width: 121px">
    <asp:Panel ID="Panel2" runat="server" GroupingText="Opciones" Width="102px">
        <br />
        <asp:Button ID="Btnnuevo" runat="server" Text="Nuevo" Width="76px" />
        <br />
        <br />
        <asp:Button ID="Btngrabar" runat="server" Text="Grabar" Width="77px" />
        <br />
        <br />
        <asp:Button ID="Btncancelar" runat="server" Text="Cancelar" />
        <br />
    </asp:Panel>

</td>
</tr>
</table>

</div>

</asp:Content>

