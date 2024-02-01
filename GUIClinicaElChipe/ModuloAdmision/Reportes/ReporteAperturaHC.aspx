<%@ Page Language="VB" MasterPageFile="~/WFPrincipal/PaginaMaestra.master" AutoEventWireup="false" CodeFile="ReporteAperturaHC.aspx.vb" Inherits="ModuloAdmision_Reportes_ReporteAperturaHC" title="Página sin título" MaintainScrollPositionOnPostback="true" %>

<%@ Register assembly="CrystalDecisions.Web, Version=10.5.3700.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Panel ID="Panel5" runat="server" Height="41px" BackColor="#33CCFF" 
        style="margin-top: 0px" Width="1026px">   
    <table style="height: 33px; width: 1026px;" bgcolor="#33CCFF">                                    
         <tr>
           <td style="width: 144px; height: 4px;">            
               <asp:Label ID="LblCodU" runat="server" Visible="False"></asp:Label>            
           </td>
           <td style="width: 181px; height: 4px;">           
               <asp:Label ID="LblUsu" runat="server" Visible="False"></asp:Label>            
           </td>
           <td style="width: 2596px; height: 4px;">            
               <asp:Label ID="LblPersonal" runat="server"></asp:Label>
           </td>
           <td style="width: 702px; height: 4px;">            
               <asp:Label ID="LblFecha" runat="server"></asp:Label>
           </td>
           <td style="width: 702px; height: 4px;">          
               <asp:Label ID="LblHora" runat="server"></asp:Label>
               <asp:Label ID="LblHoraampm" runat="server" Text="Label"></asp:Label>
           </td>
           <td style="width: 702px; height: 4px;">           
               <asp:Label ID="LblTurno" runat="server"></asp:Label>
               <asp:Label ID="LblCT" runat="server" Visible="False"></asp:Label>
           </td>                                                        
         </tr>                                                                
    </table>    
</asp:Panel>

 <table style="width: 959px; height: 35px; margin-left: 14px; margin-top: 8px;" 
            frame="box">
          <tr>
            <td style="height: 28px; font-size: 20px; width: 847px;" align="center">
                <asp:Label ForeColor="#000099" ID="Label2" runat="server" Text="Módulo de Admisión"></asp:Label>
            </td> 
            <td>            
                <asp:LinkButton ID="LinkButton1" runat="server">Volver al Inicio</asp:LinkButton>
            </td>          
          </tr>
 </table>
 <table class="style14">
         <tr>
            <td style="height: 28px; font-size: 18px; width: 1027px;" align="left">
                <asp:Label ForeColor="Blue" ID="Label1" runat="server" 
                    Text="Reporte de Historias Clínicas Aperturadas"></asp:Label>
            </td>
         </tr>
 </table> 
<asp:Panel ID="Panel1" runat="server" Height="250px" Width="953px" 
        CssClass="style14">
       <div style="text-align: left; width: 955px; height: 245px; margin-left: 0px;">
          <table style="width: 950px; height: 82px">
               <tr>              
                  <td style="width: 445px">                                    
                     <asp:Panel ID="Panel2" runat="server" Height="230px" Width="721px" 
                      CssClass="style14"
                      
                            
                       GroupingText="Elija las Fechas de las Aperturas de las Historias Clínicas">
                       <table style="height: 38px; width: 669px; font-size: 15px;">                                                                                                       
                        <tr>
                            <td style="width: 51px; font-size: inherit; height: 30px;">
                                <asp:Label ID="Label3" runat="server" Text="Del"></asp:Label>
                                <asp:Label ID="LblFechaDel" runat="server" Visible="False"></asp:Label>
                            </td>
                            <td style="width: 114px; height: 30px;">
                                <asp:Label ID="Label4" runat="server" Text="Al"></asp:Label>
                                <asp:Label ID="LblFechaAl" runat="server" Visible="False"></asp:Label>
                            </td>                          
                        </tr>  
                        <tr>
                            <td style="width: 51px; font-size: inherit; height: 30px;">
                                
                                <asp:Calendar ID="Calendar1" runat="server" BackColor="White" 
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
                                
                                &nbsp;</td>
                            <td style="width: 114px; height: 30px;">
                                <asp:Calendar ID="Calendar2" runat="server" BackColor="White" 
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
                      </table>                  
                    </asp:Panel>
                   </td>                             
                   <td rowspan="3">
                       <table style="width: 63px; margin-left: 67px; height: 27px;">                            
                             <tr>                                                            
                                   <td style="height: 26px">
                                         <asp:ImageButton ID="BtnMostrar" runat="server" Height="37px" 
                                             ImageUrl="~/Iconos/b_09.png" Width="46px" />
                                         <br />
                                         <asp:Label ID="Label5" runat="server" Text="Mostrar"></asp:Label>
                                   </td>  
                              </tr>                                                             
                        </table>
                    </td>                 
               </tr>                 
          </table>       
     </div>    
  </asp:Panel>
 
 
  <asp:Panel ID="Panel3" runat="server" Height="291px" Width="953px" 
        CssClass="style14" ScrollBars="Vertical">
     <div style="height: 395px; width: 943px;">  
     
          
         <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" 
             AutoDataBind="true" />
     
          
    </div>  
  </asp:Panel> 
</asp:Content>

