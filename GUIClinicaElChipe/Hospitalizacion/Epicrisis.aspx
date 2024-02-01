<%@ Page Language="VB" MasterPageFile="~/WFPrincipal/PaginaMaestra.master" AutoEventWireup="false" CodeFile="Epicrisis.aspx.vb" Inherits="Hospitalizacion_Epicrisis" title="Página sin título" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:100%;">
        <tr>
            <td style="width: 105px">
                <asp:Label ID="Label1" runat="server" Text="Paciente"></asp:Label>
            </td>
            <td style="width: 692px">
                <asp:TextBox ID="txtbuscar" runat="server" Width="577px"></asp:TextBox>
            &nbsp; <asp:Button ID="btnbuscar" runat="server" Text="Buscar" />
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
            <td style="width: 105px">
                <asp:Label ID="Label10" runat="server" Text="Hospitalización n°"></asp:Label>
            </td>
            <td style="width: 692px">
                <asp:Label ID="lblhospitalizacion" runat="server"></asp:Label>
            </td>
            <td>
                <asp:Label ID="lblepicrisis" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 105px">
                <asp:Label ID="Label2" runat="server" Text="Complicaciones"></asp:Label>
            </td>
            <td style="width: 692px">
                <asp:TextBox ID="TXTCOMPLICACIONES" runat="server" TextMode="MultiLine" 
                    Width="684px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    <table style="width: 100%;">
        <tr>
            <td class="style8" style="width: 102px">
                &nbsp;
                <asp:Label ID="Label3" runat="server" Text="Fecha Egreso"></asp:Label>
            </td>
            <td style="width: 234px">
                &nbsp;
                <asp:Calendar ID="clegreso" runat="server"></asp:Calendar>
            </td>
            <td>
                &nbsp;
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style8" style="width: 102px">
                &nbsp;
                <asp:Label ID="Label4" runat="server" Text="Hora Egreso"></asp:Label>
            </td>
            <td style="width: 234px">
                &nbsp;
                <asp:TextBox ID="txthoraegreso" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="style8" style="width: 102px">
                &nbsp;
                <asp:Label ID="Label5" runat="server" Text="Estadia Total"></asp:Label>
            </td>
            <td style="width: 234px">
                &nbsp;
                <asp:Label ID="txtestadia" runat="server"></asp:Label>
                <asp:Label ID="lbldias" runat="server" Text="dias"></asp:Label>
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
    </table>
    
    <table style="width: 100%;">
        <tr>
    <td class="style8" style="width: 132px">
        <asp:Label ID="Label12" runat="server" Text="Diagnóstico"></asp:Label>
        </td>
     <td style="width: 351px">&nbsp;&nbsp;<asp:DropDownList ID="dddiagnostico" runat="server" 
             Height="30px" Width="324px">
         </asp:DropDownList>
        </td>
      <td></td>
    </tr>
    <tr>
    <td>
    
        <asp:Label ID="Label13" runat="server" Text="Tipo Diagnostico"></asp:Label>
    
    </td>
    <td>&nbsp;&nbsp;
        <asp:DropDownList ID="ddtdiagnostico" runat="server" Height="17px" 
            Width="323px">
        </asp:DropDownList>
        </td>
    <td></td>
    </tr>
        <tr>
            <td style="width: 101px">
                &nbsp;
                <asp:CheckBox ID="chknecropsia" runat="server" Text="Necropsia" />
            </td>
            <td style="width: 290px">
                &nbsp;
                &nbsp;
                <asp:CheckBox ID="chkmortalidad" runat="server" Text="Mortalidad" />
            </td>
            <td>
                &nbsp;
                <asp:Label ID="lblparto" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 101px">
                &nbsp;
                <asp:Label ID="lblperinatal" runat="server" Text="Muerte Perinatal"></asp:Label>
            </td>
            <td style="width: 290px">
                &nbsp;
                <asp:Calendar ID="Clperinatal" runat="server"></asp:Calendar>
            </td>
            <td>
                &nbsp;
                <asp:Label ID="Label8" runat="server" Text="FechaNacimiento"></asp:Label>
                <asp:Calendar ID="clnacimiento" runat="server"></asp:Calendar>
            </td>
        </tr>
        <tr>
        <td>
            <asp:Button ID="btnnuevo" runat="server" Text="Nuevo" /></td>
        <td style="width: 290px">
            <asp:Button ID="btnguardar" runat="server" Text="Grabar" /></td>
        <td>
            <asp:Button ID="btncancelar" runat="server" Text="Cancelar" />
            <asp:HyperLink ID="HyperLink3" runat="server" 
                NavigateUrl="~/Hospitalizacion/MenuHospitalizacion.aspx">Regresar</asp:HyperLink>
            </td>
        </tr>
    </table>
</asp:Content>

