<%@ Page Language="VB" MasterPageFile="~/WFPrincipal/PaginaMaestra.master" AutoEventWireup="false" CodeFile="Area.aspx.vb" Inherits="Mantenimiento_Area" title="Página sin título" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:100%;">
        <tr>
            <td style="width: 75px">
                <asp:Label ID="Label1" runat="server" Text="Cod Area"></asp:Label>
            </td>
            <td style="width: 383px">
                <asp:Label ID="lblcodarea" runat="server"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 75px">
                <asp:Label ID="Label2" runat="server" Text="Area"></asp:Label>
            </td>
            <td style="width: 383px">
                <asp:TextBox ID="txtarea" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 75px">
                <asp:Label ID="Label3" runat="server" Text="Unidad"></asp:Label>
            </td>
            <td style="width: 383px">
                <asp:TextBox ID="txtunidad" runat="server" Width="289px"></asp:TextBox>
                &nbsp;<asp:Button ID="btnver" runat="server" Text="Ver" />
            </td>
            <td>
                <asp:Label ID="lblunidad" runat="server"></asp:Label>
                <asp:Label ID="lblflag" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
    <table>
    <tr>
    <td>
        <asp:Panel ID="Panel2" runat="server" ScrollBars="Vertical" 
            GroupingText="Unidades">
            <asp:GridView ID="gvunidades" runat="server" AutoGenerateColumns="False" 
                AutoGenerateSelectButton="True" CellPadding="4" ForeColor="#333333" 
                GridLines="None" Height="54px" Width="466px">
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <RowStyle BackColor="#EFF3FB" />
                <Columns>
                    <asp:BoundField HeaderText="Código" DataField="Codunidad" />
                    <asp:BoundField HeaderText="Unidad" DataField="NomUnidad" />
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
        <asp:Panel ID="Panel1" runat="server" GroupingText="Listado de Areas" 
            Width="480px">
            <asp:GridView ID="gvareas" runat="server" AutoGenerateColumns="False" 
                AutoGenerateSelectButton="True" CellPadding="4" ForeColor="#333333" 
                GridLines="None" Width="462px">
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <RowStyle BackColor="#EFF3FB" />
                <Columns>
                    <asp:BoundField DataField="codarea" HeaderText="Codigo" />
                    <asp:BoundField DataField="nomarea" HeaderText="Area" />
                    <asp:BoundField DataField="Codunidad" HeaderText="CodUnidad" />
                    <asp:BoundField DataField="Unidad" HeaderText="Unidad" />
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
        <asp:Panel ID="Panel3" runat="server" GroupingText="Operaciones" Height="173px" 
            Width="103px">
            &nbsp;&nbsp;&nbsp;
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Text="Nuevo " />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btngrabar" runat="server" Text="Grabar" />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btneliminar" runat="server" Text="Eliminar" Width="58px" />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btncancelar" runat="server" Text="Cancelar" Width="58px" />
        </asp:Panel>
    </td>
    </tr>
        </table>
</asp:Content>

