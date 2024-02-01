<%@ Page Language="VB" MasterPageFile="~/WFPrincipal/PaginaMaestra.master" AutoEventWireup="false" CodeFile="AnularVenta.aspx.vb" Inherits="ModuloCaja_Consultas_ConsultaVenta" title="Página sin título" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Panel ID="Panel5" runat="server" Height="41px" BackColor="#5F94C9"
        style="margin-top: 0px" Width="1146px">   
    <table style="height: 33px; width: 1146px;" bgcolor="#5F94C9">                                    
         <tr>
           <td style="width: 144px; height: 4px;">            
               <asp:Label ID="LblCodU" runat="server" Visible="False" Font-Bold="True" 
                   ForeColor="White"></asp:Label>            
           </td>
           <td style="width: 181px; height: 4px;">            
               <asp:Label ID="LblUsu" runat="server" Visible="False" Font-Bold="True" 
                   ForeColor="White"></asp:Label>            
           </td>
           <td style="width: 2596px; height: 4px;">            
               <asp:Label ID="LblPersonal" runat="server" Font-Bold="True" ForeColor="White"></asp:Label>
           </td>
           <td style="width: 702px; height: 4px;">            
               <asp:Label ID="LblFecha" runat="server" Font-Bold="True" ForeColor="White"></asp:Label>
           </td>
           <td style="width: 702px; height: 4px;">          
               <asp:Label ID="LblHora" runat="server" Font-Bold="True" ForeColor="White"></asp:Label>
               <asp:Label ID="LblHoraampm" runat="server" Text="Label" Font-Bold="True" 
                   ForeColor="White"></asp:Label>
           </td>
           <td style="width: 831px; height: 4px;">           
               <asp:Label ID="LblTurno" runat="server" Font-Bold="True" ForeColor="White"></asp:Label>
               <asp:Label ID="LblCT" runat="server" Visible="False" Font-Bold="True" 
                   ForeColor="White"></asp:Label>
           </td>                                                               
         </tr>                                                                
    </table>
    
</asp:Panel>

 <table style="width: 950px; height: 35px; margin-left: 70px; margin-top: 8px;" 
            frame="box">
          <tr>
            <td style="height: 28px; font-size: 20px; width: 814px;" align="center">
                <asp:RadioButtonList ID="rblista" runat="server" 
                    style="text-align: left">
                    <asp:ListItem>Por Paciente</asp:ListItem>
                    <asp:ListItem>Por fecha</asp:ListItem>
                    <asp:ListItem>Por paciente y fecha</asp:ListItem>
                </asp:RadioButtonList>
                <asp:Button ID="Button1" runat="server" Text="V" />
&nbsp;</td> 
            <td>            
                <asp:LinkButton ID="LinkButton1" runat="server">Volver al Inicio</asp:LinkButton>
            </td>          
          </tr>
 </table>
 <table style="margin-left: 70px" bgcolor="White">
         <tr>
            <td style="height: 28px; font-size: 18px; width: 946px;" align="left">
                &nbsp;</td>
         </tr>
 </table> 
 
 
  <asp:Panel ID="Panel3" runat="server" Height="291px" Width="953px" 
        ScrollBars="Vertical" BackColor="White" style="margin-left: 70px">
     <div style="height: 360px; width: 943px;">  
         <asp:Panel ID="Panel6" runat="server">
             <asp:Panel ID="Panel2" runat="server" BackColor="White" CssClass="style14" 
                 GroupingText="Búsqueda por Apellidos, Nombres, N° de Historia Clínica o DNI" 
                 Height="63px" Width="725px">
                 <table style="height: 38px; width: 677px; font-size: 15px;">
                     <tr>
                         <td style="width: 51px; font-size: inherit; height: 30px;">
                             Dato
                         </td>
                         <td style="width: 114px; height: 30px;">
                             <asp:TextBox ID="TxtBuscar" runat="server" style="margin-left: 0px" 
                                 Width="609px"></asp:TextBox>
                         </td>
                         <td style="width: 10px; height: 27px; color: #FF0000;">
                             *
                         </td>
                         <td style="width: 10px; height: 27px; color: #FF0000;">
                                                                      <asp:ImageButton ID="ImageButton1" runat="server" Height="37px" 
                                             ImageUrl="~/Iconos/94.png" Width="46px" />
                                   
                         </td>
                     </tr>
                 </table>
             </asp:Panel>
             <asp:GridView ID="Gvpaciente" runat="server" AutoGenerateColumns="False" 
                 AutoGenerateSelectButton="True" CellPadding="3" CellSpacing="2" 
                 ForeColor="#333333" style="margin-left: 16px" Width="1941px">
                 <RowStyle BackColor="#EFF3FB" BorderWidth="1px" />
                 <Columns>
                     <asp:BoundField DataField="NHC" HeaderText="NHC" />
                     <asp:BoundField DataField="PACIENTE" HeaderText="PACIENTE" />
                     <asp:BoundField DataField="ABREVIATURA" HeaderText="TIPO DOCUMENTO" />
                     <asp:BoundField DataField="NUMERODOCIDENTIDAD" HeaderText="NUMDOC" />
                     <asp:BoundField DataField="DIRECCION" HeaderText="DIRECCIÓN" />
                     <asp:BoundField DataField="NomEstadoCivil" HeaderText="ESTADOCIVIL" />
                     <asp:BoundField DataField="OCUPACION" HeaderText="OCUPACION" />
                     <asp:BoundField DataField="FECHANACIMIENTO" HeaderText="FECHANACIMIENTO" />
                     <asp:BoundField DataField="CODPACIENTE" HeaderText="CODPACIENTE" />
                 </Columns>
                 <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                 <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                 <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                 <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                 <EditRowStyle BackColor="#2461BF" />
                 <AlternatingRowStyle BackColor="White" />
             </asp:GridView>
         </asp:Panel>
    </div>  
       
    
  </asp:Panel> 
  
          <table style="width: 100%;">
            <tr>
                <td>
                    &nbsp;
                    <asp:Panel ID="Panel8" runat="server" GroupingText="Por Fecha">
                        <asp:Calendar ID="Calendar1" runat="server" BackColor="#FFFFCC" 
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
                    </asp:Panel>
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;<asp:ImageButton ID="imbuscar" runat="server" Height="37px" 
                                             ImageUrl="~/Iconos/28.png" Width="46px" />
                                   
                                                                      <asp:ImageButton ID="imanular" runat="server" Height="37px" 
                                             ImageUrl="~/Iconos/86.png" Width="46px" />
                                   
                         &nbsp;<asp:Panel ID="Panel7" runat="server" 
                        GroupingText="Datos de la venta" Width="1142px">
                        <asp:GridView ID="gvventas" runat="server" AutoGenerateColumns="False" 
                            AutoGenerateSelectButton="True" BackColor="White" BorderColor="#CCCCCC" 
                            BorderStyle="None" BorderWidth="1px" CellPadding="3" Width="1111px">
                            <RowStyle ForeColor="#000066" />
                            <Columns>
                                <asp:BoundField DataField="Codventa" HeaderText="Cod. Venta" />
                                <asp:BoundField DataField="NomTurno" HeaderText="Turno" />
                                <asp:BoundField DataField="codPaciente" HeaderText="Cod.Paciente" />
                                <asp:BoundField DataField="Paciente" HeaderText="Paciente" />
                                <asp:BoundField DataField="fechaAtencion" HeaderText="FechaAtencion" />
                                <asp:BoundField DataField="Total" HeaderText="Total" />
                            </Columns>
                            <FooterStyle BackColor="White" ForeColor="#000066" />
                            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                        </asp:GridView>
                    </asp:Panel>
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td>
                    Motivo de anulación&nbsp;
                    <br />
                    <asp:TextBox ID="TextBox1" runat="server" Height="57px" TextMode="MultiLine" 
                        Width="1121px"></asp:TextBox>
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
        </table>
    
</asp:Content>


