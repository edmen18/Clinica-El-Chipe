<%@ Page Language="VB" MasterPageFile="~/WFPrincipal/PaginaMaestra.master" AutoEventWireup="false" CodeFile="Medicoespecialidad.aspx.vb" Inherits="Mantenimiento_Medicoespecialidad" title="Página sin título" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div>
<table>
<tr>
<td>
    <asp:Label ID="Label1" runat="server" Text="Cod. Medico"></asp:Label>
</td>
<td>
    <asp:Label ID="lblcodigo" runat="server" Text="Label"></asp:Label>
</td>
</tr>
<tr>
<td>
    <asp:Label ID="Label2" runat="server" Text="Nombre Apel."></asp:Label>
</td>
<td>
    <asp:Label ID="lblmedico" runat="server" Text="Label"></asp:Label>
</td>
</tr>
</table>
<table>
<tr>
<td>
    <asp:Panel ID="Panel3" runat="server" GroupingText="Especialidad" 
        ScrollBars="Vertical">
    
        <asp:DropDownList ID="ddespecialidad" runat="server" Height="16px" 
            Width="383px">
        </asp:DropDownList>
        <asp:Button ID="btnagregar" runat="server" Text="Agregar" />
    </asp:Panel>

</td>
</tr>
<tr>
<td>
    <asp:Panel ID="Panel2" runat="server" GroupingText="Especialidades" 
        Width="494px" ScrollBars="Vertical">
        <asp:GridView ID="gvespecialidades" runat="server" AutoGenerateColumns="False" 
            AutoGenerateSelectButton="True" CellPadding="4" ForeColor="#333333" 
            GridLines="None">
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <RowStyle BackColor="#EFF3FB" />
            <Columns>
                <asp:BoundField DataField="codmesp" HeaderText="CodMedicoesp" />
                <asp:BoundField DataField="codigo" HeaderText="Codigo" />
                <asp:BoundField DataField="especialidad" HeaderText="Especialidad" />
            </Columns>
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <EditRowStyle BackColor="#2461BF" />
            <AlternatingRowStyle BackColor="White" />
        </asp:GridView>
        <asp:Button ID="btneliminar" runat="server" Text="Eliminar" />
        <asp:Label ID="lblcodmes" runat="server"></asp:Label>
    </asp:Panel>

</td>

</tr>

</table>
</div>
</asp:Content>

