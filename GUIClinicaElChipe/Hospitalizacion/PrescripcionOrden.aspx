<%@ Page Language="VB" MasterPageFile="~/WFPrincipal/PaginaMaestra.master" AutoEventWireup="false" CodeFile="PrescripcionOrden.aspx.vb" Inherits="Hospitalizacion_PrescripcionOrden" title="Página sin título" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:100%;">
        <tr>
            <td class="style8" style="width: 95px">
                <asp:Label ID="Label1" runat="server" Text="Paciente"></asp:Label>
            </td>
            <td style="width: 649px">
                <asp:TextBox ID="txtbuscar" runat="server" Width="375px"></asp:TextBox>
            &nbsp;<asp:Button ID="btnbuscar" runat="server" Text="Buscar" />
                <asp:Button ID="btnnuevo" runat="server" Text="Nuevo" />
            </td>
            <td>
                <asp:Panel ID="Panel2" runat="server" 
                    GroupingText="Datos del Paciente Intervenido" Height="158px" 
                    ScrollBars="Vertical">
                    <asp:GridView ID="gvhospitalizaciones" runat="server" AutoGenerateColumns="False" 
    AutoGenerateSelectButton="True" BackColor="White" BorderColor="#CC9966" 
    BorderStyle="None" BorderWidth="1px" CellPadding="4" Height="140px" 
    Width="581px">
                        <RowStyle BackColor="White" ForeColor="#330099" />
                        <Columns>
                            <asp:BoundField DataField="CodHospitalizacion" HeaderText="Hospitalización" />
                            <asp:BoundField DataField="paciente" 
                                HeaderText="Paciente" />
                            <asp:BoundField DataField="solicitud" 
                                HeaderText="Solicitud" />
                            <asp:BoundField DataField="motivo" HeaderText="Motivo" />
                            <asp:BoundField DataField="fecha" HeaderText="Fecha" />
                        </Columns>
                        <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                        <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" 
                            HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" 
                            ForeColor="#663399" />
                        <HeaderStyle BackColor="#990000" Font-Bold="True" 
                            ForeColor="#FFFFCC" />
                    </asp:GridView>
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td class="style8" style="width: 95px">
                <asp:Label ID="Label2" runat="server" Text="Prescripción"></asp:Label>
            </td>
            <td style="width: 649px">
                <asp:Label ID="lbltrescripcion" runat="server"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Hospitalización N°"></asp:Label>
&nbsp;&nbsp;
                <asp:Label ID="lblhospitalizacion" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style8" style="width: 95px">
                <asp:Label ID="Label4" runat="server" Text="Medicamento"></asp:Label>
            </td>
            <td style="width: 649px">
                <asp:DropDownList ID="ddmedicamento" runat="server" Height="16px" Width="370px">
                </asp:DropDownList>
            </td>
            <td>
                <asp:Label ID="lblprescripcion" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
    <table style="width: 100%;">
        <tr>
            <td class="style5">
                <asp:Label ID="Label5" runat="server" Text="Dosis"></asp:Label>
            </td>
            <td style="width: 501px">
                &nbsp;
                <asp:TextBox ID="txtdosis" runat="server" TextMode="MultiLine" Width="486px"></asp:TextBox>
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="style5">
                <asp:Label ID="Label6" runat="server" Text="Tratamiento"></asp:Label>
            </td>
            <td style="width: 501px">
                &nbsp;
                <asp:TextBox ID="txttrata" runat="server" TextMode="MultiLine" Width="482px"></asp:TextBox>
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="style5">
                <asp:Label ID="Label7" runat="server" Text="Via Administración"></asp:Label>
            </td>
            <td style="width: 501px">
                &nbsp;
                <asp:TextBox ID="txtva" runat="server" TextMode="MultiLine" Width="480px"></asp:TextBox>
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="style5">
                <asp:Label ID="Label8" runat="server" Text="Fecha"></asp:Label>
            </td>
            <td style="width: 501px">
                &nbsp;&nbsp;<asp:Calendar ID="Calendar1" runat="server" BackColor="#FFFFCC" 
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
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
        <td>
            <asp:Label ID="Label10" runat="server" Text="Dieta"></asp:Label></td>
        <td>
            <asp:TextBox ID="txtdieta" runat="server" TextMode="MultiLine" Width="492px"></asp:TextBox>
            </td>
        <td>
            <asp:HyperLink ID="HyperLink3" runat="server" 
                NavigateUrl="~/Hospitalizacion/MenuHospitalizacion.aspx">Regresar</asp:HyperLink>
            </td>
        </tr>
         <tr>
            <td class="style5">
                <asp:Label ID="Label9" runat="server" Text="Hora"></asp:Label>
            </td>
            <td style="width: 501px">
                &nbsp;
                <asp:TextBox ID="txthora" runat="server"></asp:TextBox>
            &nbsp;&nbsp;
                <asp:Button ID="btnagregar" runat="server" Text="Agregar" />
&nbsp;
                <asp:Button ID="Button1" runat="server" Text="Quitar" />
            </td>
            <td>
                &nbsp;
                <asp:Button ID="btnguardar" runat="server" Text="Guardar" Width="76px" />
                <asp:Button ID="btncancelar" runat="server" Text="Cancelar" />
            </td>
        </tr>
    </table>
    <table>
    <tr>
    <td>
     <asp:Panel ID="Panel1" runat="server" GroupingText="Tratamiento" Width="1119px">
     
         <asp:GridView ID="gvgvdetalle" runat="server" AutoGenerateColumns="False" 
             AutoGenerateSelectButton="True" CellPadding="4" ForeColor="#333333" 
             GridLines="None" Width="1100px">
             <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
             <Columns>
                 <asp:BoundField DataField="columna1" HeaderText="Cod. Medicamento" />
                 <asp:BoundField DataField="columna2" HeaderText="Medicamento" />
                 <asp:BoundField DataField="columna3" HeaderText="Dosis" />
                 <asp:BoundField DataField="columna4" HeaderText="Tratamiento" />
                 <asp:BoundField DataField="columna5" HeaderText="Via Adm." />
                 <asp:BoundField DataField="columna6" HeaderText="Fecha" />
                 <asp:BoundField DataField="columna7" HeaderText="Hora" />
             </Columns>
             <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
             <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
             <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
             <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
             <AlternatingRowStyle BackColor="White" />
         </asp:GridView>
        </asp:Panel>
    </td>
       
    </tr>
    
    </table>
    
</asp:Content>

