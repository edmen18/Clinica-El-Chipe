<%@ Page Language="VB" MasterPageFile="~/WFPrincipal/PaginaMaestra.master" AutoEventWireup="false" CodeFile="ReporteOperatorio.aspx.vb" Inherits="Hospitalizacion_ReporteOperatorio" title="Página sin título" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:100%;">
        <tr>
            <td style="width: 120px">
                <asp:Label ID="Label1" runat="server" Text="Paciente"></asp:Label>
            </td>
            <td style="width: 365px">
                <asp:TextBox ID="txtbuscar" runat="server" Width="272px"></asp:TextBox>
            &nbsp;<asp:Button ID="btnbuscar" runat="server" Text="Buscar" />
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
            <td style="width: 120px">
                <asp:Label ID="Label2" runat="server" Text="Duración"></asp:Label>
            </td>
            <td style="width: 365px">
                <asp:TextBox ID="txtduracion" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Fecha"></asp:Label>
            &nbsp;<asp:Label ID="lblhospitalizacion" runat="server"></asp:Label>
&nbsp;<asp:Label ID="lblreporte" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 120px">
                <asp:Label ID="Label3" runat="server" Text="Hora"></asp:Label>
                <br />
                <br />
                <asp:Label ID="Label5" runat="server" Text="Hallazgos"></asp:Label>
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
            </td>
            <td style="width: 365px">
                <asp:TextBox ID="txthora" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:TextBox ID="txthallazgos" runat="server" Height="91px" 
                    TextMode="MultiLine" Width="278px"></asp:TextBox>
                <br />
                <br />
                <br />
&nbsp;</td>
            <td>
                <asp:Calendar ID="cfecha" runat="server" BackColor="White" 
                    BorderColor="#3366CC" BorderWidth="1px" CellPadding="1" 
                    DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" 
                    ForeColor="#003399" Height="200px" Width="220px">
                    <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                    <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
                    <WeekendDayStyle BackColor="#CCCCFF" />
                    <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
                    <OtherMonthDayStyle ForeColor="#999999" />
                    <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
                    <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
                    <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" 
                        Font-Bold="True" Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
                </asp:Calendar>
            </td>
        </tr>
    </table>
    <table style="width: 100%;">
        <tr>
            <td style="width: 596px; height: 264px;">
                &nbsp;
                    <asp:Panel ID="Panel3" runat="server" GroupingText="Diagnóstico Pre Operatorio" 
                    Height="70px">
                    &nbsp;
                    <br />
                    <asp:Label ID="Label6" runat="server" Text="Diagnóstico"></asp:Label>
                    &nbsp;&nbsp;
                    <asp:DropDownList ID="ddiag" runat="server" Height="18px" Width="110px">
                    </asp:DropDownList>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <br />
                </asp:Panel>
            </td>
            <td style="height: 264px">
                &nbsp;
                <asp:Panel ID="Panel4" runat="server" 
                    GroupingText="Diagnóstico Post Operatorio" Height="70px" Width="477px">
                    <br />
                    <asp:Label ID="Label8" runat="server" Text="Diagnóstico"></asp:Label>
                    &nbsp;<asp:DropDownList ID="dddiagn" runat="server" Height="28px" 
                        Width="262px">
                    </asp:DropDownList>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </asp:Panel>
            </td>
            <td style="height: 264px">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td style="width: 596px">
                &nbsp;
                <asp:Panel ID="Panel5" runat="server" GroupingText="Médicos" Height="212px" 
                    Width="574px">
                    <br />
                    <asp:Label ID="Label10" runat="server" Text="Dr."></asp:Label>
                    &nbsp;<asp:DropDownList ID="ddmedico" runat="server" Height="21px" 
                        Width="202px">
                    </asp:DropDownList>
                    &nbsp;<asp:Label ID="Label11" runat="server" Text="Función"></asp:Label>
                    &nbsp;<asp:DropDownList ID="ddcargo" runat="server" Height="16px" 
                        Width="187px">
                        <asp:ListItem>Seleccione</asp:ListItem>
                        <asp:ListItem>Cirujano</asp:ListItem>
                        <asp:ListItem>Anestesiólogo</asp:ListItem>
                        <asp:ListItem>Ayudante</asp:ListItem>
                        <asp:ListItem>Instrumentista</asp:ListItem>
                    </asp:DropDownList>
                    &nbsp;<asp:Button ID="btnagregar" runat="server" Text="+" Width="33px" />
                    <asp:Button ID="btnquitar" runat="server" Text="-" Width="33px" />
                    <br />
                    <br />
                    <asp:GridView ID="gvprogramacion" runat="server" Height="123px" Width="531px" 
                        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" 
                        GridLines="None" AutoGenerateSelectButton="True">
                        <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                        <Columns>
                            <asp:BoundField HeaderText="Cod. Medico" DataField="columna1" />
                            <asp:BoundField HeaderText="Médico" DataField="columna2" />
                            <asp:BoundField HeaderText="Función" DataField="columna3" />
                        </Columns>
                        <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                        <AlternatingRowStyle BackColor="White" />
                    </asp:GridView>
                </asp:Panel>
            </td>
            <td>
                <asp:Button ID="btnnuevo" runat="server" Text="Nuevo" Width="77px" />
                <br />
                <br />
                <asp:Button ID="btngrabar" runat="server" Text="Grabar" Width="76px" />
                <br />
                <br />
                <asp:Button ID="btncancelar" runat="server" Text="Cancelar" />
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td style="width: 596px">
                &nbsp;
            </td>
            <td>
                &nbsp;
                <asp:HyperLink ID="HyperLink3" runat="server" 
                    NavigateUrl="~/Hospitalizacion/MenuHospitalizacion.aspx">Regresar</asp:HyperLink>
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
    </table>
</asp:Content>

