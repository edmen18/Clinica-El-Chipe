<%@ Page Language="VB" MasterPageFile="~/WFPrincipal/PaginaMaestra.master" AutoEventWireup="false" CodeFile="Diagnostico.aspx.vb" Inherits="Mantenimiento_Diagnostico" title="Página sin título" Debug="true" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<table>
<tr>
<td style="width: 95px">
    <asp:Label ID="Label6" runat="server" Text="Buscar Enfermedad"></asp:Label>
</td>
<td style="width: 454px">
    <asp:TextBox ID="txtbenfermedad" runat="server" Width="264px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnbuscarenf" runat="server" Text="Buscar" />
</td>
</tr>
<tr>
<td style="width: 95px">
    &nbsp;</td>
<td style="width: 454px">
    <asp:Panel ID="pnenfermedades" runat="server" GroupingText="Seleccionar Enfermedad" 
        Width="379px" ScrollBars="Vertical">
        
        <asp:GridView ID="gvenfermedad" runat="server" AutoGenerateColumns="False" 
            AutoGenerateSelectButton="True" CellPadding="4" ForeColor="#333333" 
            GridLines="None" Height="43px" Width="353px">
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <RowStyle BackColor="#EFF3FB" />
            <Columns>
                <asp:BoundField DataField="Codenfermedad" HeaderText="Codigo" />
                <asp:BoundField DataField="NomEnfermedad" HeaderText="Enfermedad" />
            </Columns>
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <EditRowStyle BackColor="#2461BF" />
            <AlternatingRowStyle BackColor="White" />
        </asp:GridView>
        
    </asp:Panel>  </td>
</tr>
<tr>
<td style="width: 95px">
    <asp:Label ID="Label7" runat="server" Text="Cod Enfermedad"></asp:Label>
    </td>
<td style="width: 454px">
&nbsp;<asp:Label ID="lblcodenfermedad" runat="server"></asp:Label>
    <asp:Label ID="lblind" runat="server"></asp:Label>
</td>
</tr>
<tr>
<td style="width: 95px">
    <asp:Label ID="Label8" runat="server" Text="Enfermedad"></asp:Label>
    </td>
<td style="width: 454px">
    <asp:Label ID="lblenfermedad" runat="server"></asp:Label>
    </td>
</tr>
<tr>
<td>

    <asp:Label ID="Label9" runat="server" Text="Codigos Diagnostico"></asp:Label>

</td>
<td>

    <asp:Label ID="lblcodigo" runat="server"></asp:Label>
    <asp:Label ID="lblcoddiag" runat="server"></asp:Label>

</td>

</tr>
<tr>
<td>

    <asp:Label ID="Label10" runat="server" Text="Dignostico"></asp:Label>

</td>
<td>

    <asp:TextBox ID="txtdiag" runat="server" Width="437px"></asp:TextBox>

</td>
</tr>
</table>
<table>

<tr>

<td class="style5" style="width: 128px">
    <asp:Label ID="Label5" runat="server" Text="Buscar"></asp:Label>
</td>
<td style="width: 323px">
    <asp:TextBox ID="txtbuscar" runat="server" Width="311px"></asp:TextBox>
</td>
<td>
    <asp:Button ID="btnbuscar" runat="server" Text="Buscar" />
</td>
<td>
    <asp:Button ID="Btncancel" runat="server" Text="Cancel" Width="54px" />
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
                <asp:BoundField DataField="coddiag" HeaderText="Item" />
                <asp:BoundField DataField="codigo" HeaderText="Codigo" />
                <asp:BoundField DataField="Diagnostico" HeaderText="diagnostico" />
                <asp:BoundField DataField="CodEnfermedad" HeaderText="CodEnfermedad" />
                <asp:BoundField DataField="NomEnfermedad" HeaderText="Enfermedad" />
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
</asp:Content>

