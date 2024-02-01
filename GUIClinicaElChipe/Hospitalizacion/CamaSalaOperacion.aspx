<%@ Page Language="VB" MasterPageFile="~/WFPrincipal/PaginaMaestra.master" AutoEventWireup="false" CodeFile="CamaSalaOperacion.aspx.vb" Inherits="Hospitalizacion_CamaSalaOperacion" title="Página sin título" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div>
    <table style="width: 100%;">
        <tr>
            <td style="width: 178px">
                &nbsp;
                <asp:Panel ID="pnopciones" runat="server" GroupingText="Seleccione una Opción" 
                    Width="171px">
                    <asp:RadioButtonList ID="rblista" runat="server">
                        <asp:ListItem>Cama</asp:ListItem>
                        <asp:ListItem>Sala Operación</asp:ListItem>
                    </asp:RadioButtonList>
                </asp:Panel>
            </td>
            <td style="width: 234px">
                &nbsp;<br />
                <asp:Label ID="Label1" runat="server" Text="Del"></asp:Label>
                <asp:Calendar ID="dtdel" runat="server" BackColor="White" 
                    BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" 
                    Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" 
                    Width="200px">
                    <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                    <SelectorStyle BackColor="#CCCCCC" />
                    <WeekendDayStyle BackColor="#FFFFCC" />
                    <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                    <OtherMonthDayStyle ForeColor="#808080" />
                    <NextPrevStyle VerticalAlign="Bottom" />
                    <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                    <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                </asp:Calendar>
&nbsp;
                </td>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Al"></asp:Label>
                <asp:Calendar ID="dtal" runat="server" BackColor="White" 
                    BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" 
                    Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" 
                    Width="200px">
                    <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                    <SelectorStyle BackColor="#CCCCCC" />
                    <WeekendDayStyle BackColor="#FFFFCC" />
                    <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                    <OtherMonthDayStyle ForeColor="#808080" />
                    <NextPrevStyle VerticalAlign="Bottom" />
                    <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                    <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                </asp:Calendar>
            </td>
        </tr>
        <tr>
            <td style="width: 178px">
                &nbsp;
            </td>
            <td style="width: 234px">
                &nbsp;<asp:Button ID="btnconsultar" runat="server" Text="Consultar" />
&nbsp;</td>
            <td>
                &nbsp;
            </td>
        </tr>
            </table>
<table>
<tr>
<td>

    <asp:Panel ID="Panel2" runat="server" GroupingText="Resultados" 
        ScrollBars="Vertical" Width="1131px">
        <asp:GridView ID="gvlista" runat="server" AutoGenerateColumns="False" 
            CellPadding="4" ForeColor="#333333" GridLines="None">
            <RowStyle BackColor="#EFF3FB" />
            <Columns>
                <asp:BoundField DataField="codigo" HeaderText="Codigo" />
                <asp:BoundField DataField="numero" HeaderText="Numero" />
                <asp:BoundField DataField="fecha" HeaderText="Fecha" />
                <asp:BoundField DataField="Hora" HeaderText="Hora" />
                <asp:BoundField DataField="desacripcion" HeaderText="Descripción" />
            </Columns>
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
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
</asp:Content>

