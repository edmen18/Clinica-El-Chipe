<%@ Page Language="VB" MasterPageFile="~/WFPrincipal/PaginaMaestra.master" AutoEventWireup="false" CodeFile="Reportes.aspx.vb" Inherits="ModuloCaja_Reportes_Reportes" title="Página sin título" %>

<%@ Register assembly="CrystalDecisions.Web, Version=10.5.3700.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table>
    
    <tr>
    <td>
    <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" 
    AutoDataBind="true" DisplayGroupTree="False" />
<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </td>
    </tr>
    <tr>
    
    <td>
        <asp:Button ID="imprimi" runat="server" Text="Imprimir" />
    &nbsp;<asp:Button ID="btnpdf" runat="server" Text="Exp.PDF" />
&nbsp;<asp:Button ID="btnexcel" runat="server" Text="Exp. Excel" />
    </td>
    </tr>
    </table>
     
</asp:Content>

