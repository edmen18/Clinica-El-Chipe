<%@ Page Language="VB" MasterPageFile="~/WFPrincipal/PaginaMaestra.master" AutoEventWireup="false" CodeFile="Medico.aspx.vb" Inherits="Mantenimiento_Medico" title="Página sin título" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div>

<table>
<tr>
<td style="width: 133px">
    <asp:Label ID="Label1" runat="server" Text="Ingrese el Dato"></asp:Label>
</td>
<td style="width: 364px">
    <asp:TextBox ID="txtdato" runat="server" Width="323px"></asp:TextBox>
    <asp:Button ID="BTNVER" runat="server" Text="VER" Width="32px" />
</td>
</tr>
</table>
<table>
<tr>
<td style="width: 499px">
    <asp:Panel ID="Panel1" runat="server" GroupingText="Resultados" Height="149px">
        <asp:GridView ID="GridView1" runat="server" Width="474px" 
            AutoGenerateColumns="False" AutoGenerateSelectButton="True" CellPadding="4" 
            ForeColor="#333333" GridLines="None" Height="133px">
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <RowStyle BackColor="#EFF3FB" />
            <Columns>
                <asp:BoundField DataField="codigo" HeaderText="Codigo" />
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                <asp:BoundField DataField="Apellidos" HeaderText="Apellidos" />
                <asp:BoundField DataField="Identidad" HeaderText="Doc. Identidad" />
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
</div>
<div>
<table>
<tr>
<td class="style8" style="width: 174px">
    <asp:Label ID="Label2" runat="server" Text="Codigo Medico"></asp:Label>
</td>
<td style="width: 321px">
    <asp:Label ID="lblcodigomedico" runat="server"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnespecialidades" runat="server" Text="Especialidades" />
</td>
</tr>
<tr>
<td class="style8" style="width: 174px">
    <asp:Label ID="Label7" runat="server" Text="Cod. Personal"></asp:Label>
</td>
<td style="width: 321px">
    <asp:Label ID="lblcodpersonal" runat="server"></asp:Label>
</td>
</tr>
<tr>
<td class="style8" style="width: 174px">
    <asp:Label ID="Label3" runat="server" Text="Nombre"></asp:Label>
</td>
<td style="width: 321px">
    <asp:Label ID="lblnombre" runat="server"></asp:Label>
</td>
</tr>
<tr>
<td class="style8" style="width: 174px">
    <asp:Label ID="Label4" runat="server" Text="Apellidos"></asp:Label>
</td>
<td style="width: 321px">
    <asp:Label ID="lblapellido" runat="server"></asp:Label>
</td>
</tr>
<tr> 
<td>
    <asp:Label ID="Label5" runat="server" Text="Profesional Medico"></asp:Label>
</td>
<td>
    <asp:Label ID="lblcodprofesional" runat="server"></asp:Label>
    <asp:Label ID="lblprofesional" runat="server"></asp:Label>
    <asp:Button ID="btneditar" runat="server" Text="Editar" Width="44px" />
</td>
</tr>
</table>
<table>
<tr>
<td>
    <asp:Panel ID="Panel2" runat="server" GroupingText="Tipo Profesional Médico">
        <asp:GridView ID="gvtp" runat="server" AutoGenerateColumns="False" 
            AutoGenerateSelectButton="True" CellPadding="4" ForeColor="#333333" 
            GridLines="None" Width="505px">
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <RowStyle BackColor="#EFF3FB" />
            <Columns>
                <asp:BoundField DataField="Codtipoprofesionalmedico" HeaderText="Codigo" />
                <asp:BoundField DataField="nomtipoprofesionalmedico" 
                    HeaderText="Tipo Profesional" />
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
<table>
<tr>
<td>

    <asp:Button ID="btngrabar" runat="server" Text="Grabar" Width="70px" />

</td>
<td>

    

    <asp:Button ID="btneliminar" runat="server" Text="Eliminar" />

    

</td>
<td>

    <asp:Button ID="btncancelar" runat="server" Text="Cancelar" />
    </td>

</tr>
</table>

</div>
</asp:Content>

