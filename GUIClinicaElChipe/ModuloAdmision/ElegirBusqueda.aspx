<%@ Page Language="VB" MasterPageFile="~/WFPrincipal/PaginaMaestra.master" AutoEventWireup="false" CodeFile="ElegirBusqueda.aspx.vb" Inherits="ModuloAdmision_ElegirBusqueda" title="Página sin título" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   
    <asp:Panel ID="Panel2" runat="server" GroupingText="Seleccione una Opcion">
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" Height="45px">
            <asp:ListItem>Busqueda Simple</asp:ListItem>
            <asp:ListItem>Por Huella Digital</asp:ListItem>
        </asp:RadioButtonList>
        &nbsp;&nbsp;
        <asp:Button ID="btnbuscar" runat="server" Text="Buscar" />
    </asp:Panel>
   
</asp:Content>

