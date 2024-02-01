<%@ Page Language="VB" MasterPageFile="~/WFPrincipal/PaginaMaestra.master" AutoEventWireup="false" CodeFile="Reporte.aspx.vb" Inherits="Hospitalizacion_Reportes_Reporte" title="Página sin título" %>

<%@ Register assembly="CrystalDecisions.Web, Version=10.5.3700.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:HyperLink ID="hpregresar" runat="server">Regresar</asp:HyperLink>
    <br />
    <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" 
    AutoDataBind="true"></CR:CrystalReportViewer>
<asp:Label ID="Label1" runat="server" Text="1"></asp:Label>
</asp:Content>

