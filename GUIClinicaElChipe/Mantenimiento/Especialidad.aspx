<%@ Page Language="VB" MasterPageFile="~/WFPrincipal/PaginaMaestra.master" AutoEventWireup="false" CodeFile="Especialidad.aspx.vb" Inherits="Mantenimiento_Especialidad" title="Página sin título" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div>
<table>
<tr>

<td>

    <asp:Label ID="Label1" runat="server" Text="Codigo"></asp:Label>

</td>
<td>

    <asp:Label ID="lblcodespecialidad" runat="server" BorderStyle="Inset" 
        Width="125px"></asp:Label>

</td>
</tr>

<tr>

<td>

    <asp:Label ID="Label2" runat="server" Text="Especialidad"></asp:Label>

</td>
<td>

    <asp:TextBox ID="txtespecialidad" runat="server" BorderStyle="Inset" 
        Width="381px"></asp:TextBox>

</td>
</tr>
</table>
<table>
<tr>
<td>
    <asp:Panel ID="Panel1" runat="server" GroupingText="Listado" 
        ScrollBars="Vertical">
        <asp:GridView ID="gvespecialidades" runat="server" AutoGenerateColumns="False" 
        CellPadding="4" ForeColor="#333333" GridLines="None" Width="463px" 
            AutoGenerateSelectButton="True">
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <RowStyle BackColor="#EFF3FB" />
            <Columns>
                <asp:BoundField DataField="Codespecialidad" HeaderText="Código" />
                <asp:BoundField DataField="Nomespecialidad" HeaderText="Especialidad" />
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
    <asp:Panel ID="Panel2" runat="server" GroupingText="Opciones" Width="90px">
        <asp:Button ID="Btnnuevo" runat="server" Text="Nuevo" Width="76px" />
        <br />
        <asp:Button ID="Btngrabar" runat="server" Text="Grabar" Width="77px" />
        <asp:Button ID="Btncancelar" runat="server" Text="Cancelar" />
        <br />
        <asp:Label ID="lblflag" runat="server"></asp:Label>
    </asp:Panel>
</td>
</tr>
</table>
</div>

</asp:Content>

