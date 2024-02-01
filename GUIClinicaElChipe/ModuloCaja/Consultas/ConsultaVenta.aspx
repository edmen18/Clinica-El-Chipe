<%@ Page Language="VB" MasterPageFile="~/WFPrincipal/PaginaMaestra.master" AutoEventWireup="false" CodeFile="ConsultaVenta.aspx.vb" Inherits="ModuloCaja_Consultas_ConsultaVenta" title="Página sin título" MaintainScrollPositionOnPostback="true" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
    
        <table style="width: 100%;">
            <tr>
                <td>
                    &nbsp;<asp:Panel ID="pnOpciones" runat="server" GroupingText="Opciones" 
                        Width="485px">
                        <asp:RadioButtonList ID="rblista" runat="server">
                            <asp:ListItem>Por estado</asp:ListItem>
                            <asp:ListItem>Por Comprobante</asp:ListItem>
                            <asp:ListItem>Por Fecha</asp:ListItem>
                        </asp:RadioButtonList>
                    </asp:Panel>
&nbsp;</td>
               
            </tr>

                </table>
    <table>
    <tr>
    <td>&nbsp;
        <asp:DropDownList ID="ddestado" runat="server" Height="16px" Width="222px">
            <asp:ListItem>Seleccione</asp:ListItem>
            <asp:ListItem>Efectivas</asp:ListItem>
            <asp:ListItem>Anuladas</asp:ListItem>
        </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
    <td>&nbsp;<asp:DropDownList ID="DropDownList1" runat="server" Height="16px" 
            Width="188px">
        </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
    <td>&nbsp;&nbsp;<asp:Button ID="btnconsultar" runat="server" Text="Consultar" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
    </tr> 
    </table>
    <table>
    <tr>
    <td>
        <asp:Calendar ID="clfechadel" runat="server" BackColor="#FFFFCC" 
            BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" 
            Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="200px" 
            ShowGridLines="True" Width="220px">
            <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
            <SelectorStyle BackColor="#FFCC66" />
            <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
            <OtherMonthDayStyle ForeColor="#CC9966" />
            <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
            <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
            <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" 
                ForeColor="#FFFFCC" />
        </asp:Calendar> </td>
    <td>
        <asp:Calendar ID="clfechaal" runat="server" BackColor="#FFFFCC" 
            BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" 
            Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="200px" 
            ShowGridLines="True" Width="220px">
            <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
            <SelectorStyle BackColor="#FFCC66" />
            <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
            <OtherMonthDayStyle ForeColor="#CC9966" />
            <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
            <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
            <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" 
                ForeColor="#FFFFCC" />
        </asp:Calendar>
    </td> 
      
    </tr>       
    </table>
    <table>
    <tr>
    <td>
        <asp:Panel ID="Panel1" runat="server" GroupingText="Resultados" Width="915px">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" 
                CellPadding="4" Width="820px" AutoGenerateSelectButton="True">
                <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                <RowStyle BackColor="White" ForeColor="#003399" />
                <Columns>
                    <asp:BoundField DataField="codventa" HeaderText="Venta" />
                    <asp:BoundField DataField="Comprobante" HeaderText="Comprobante" />
                    <asp:BoundField DataField="Numero" HeaderText="Numero" />
                    <asp:BoundField DataField="Nomturno" HeaderText="Turno" />
                    <asp:BoundField DataField="paciente" HeaderText="Paciente" />
                    <asp:BoundField DataField="fecha" HeaderText="Fecha" />
                    <asp:BoundField DataField="total" HeaderText="Total" />
                    <asp:BoundField DataField="totaligv" HeaderText="Total igv" />
                    <asp:BoundField DataField="usuario" HeaderText="Usuario" />
                    <asp:CheckBoxField DataField="Anula" HeaderText="Anulada?" />
                    <asp:BoundField DataField="Codtc" Visible="False" HeaderText="codigo" />
                </Columns>
                <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
            </asp:GridView>
        </asp:Panel>
    
    </td>
    <td>
        <asp:Button ID="btnDetalle" runat="server" Text="Detalle" Width="68px" />
        <br />
        <br />
        <asp:Button ID="btnreporte" runat="server" Text="Reporte" />
        <br />
        <br />
    
    </td>
    </tr>
    <tr>
    <td>
    
        <asp:Label ID="Label1" runat="server"></asp:Label>
        </td>
    </tr>
    </table>  
         
    </div>
</asp:Content>

