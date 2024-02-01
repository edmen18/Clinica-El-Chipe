<%@ Page Language="VB" MasterPageFile="~/WFPrincipal/PaginaMaestra.master" AutoEventWireup="false" CodeFile="SolicitudAtencion.aspx.vb" Inherits="ModuloAdmision_SolicitudAtencion" title="Página sin título" MaintainScrollPositionOnPostback="true" %>
<%@ PreviousPageType VirtualPath="~/ModuloAdmision/BusquedaParaSolicitudAtencion.aspx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
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
 <table style="width: 886px; height: 10px; margin-left: 70px; margin-top: 8px;" 
            frame="box">
          <tr>
            <td style="height: 28px; font-size: 20px; width: 10830px;" align="center">
                <asp:Label ForeColor="#000099" ID="Label2" runat="server" Text="ADMISIÓN"></asp:Label>
            </td> 
              <td style="height: 20px; font-size: 18px; width: 1901px;" align="left">                
                <asp:LinkButton ID="LinkButton1" runat="server">Volver al inicio</asp:LinkButton>                
            </td>          
          </tr>
 </table>
 <table bgcolor="White" 
        style="height: 0px; margin-bottom: 0px; width: 885px; margin-left: 70px;">
         <tr>
            <td style="height: 20px; font-size: 18px; width: 10813px;" align="left">
                 <asp:Label ForeColor="Blue" ID="Label1" runat="server" 
                     Text="Solicitud de Atención"></asp:Label>
            </td>
            <td style="height: 20px; font-size: 18px; width: 1901px;" align="left">                
                <asp:LinkButton ID="LinkButton2" runat="server">Volver a buscar</asp:LinkButton>                
            </td>     
         </tr>
 </table>
 
   
        <table border="1"                     
            style="background-color: #99CCFF; font-size: medium; width: 670px; margin-left: 68px;">           
             <tr>                          
                <td style="width: 600px" >
                 <asp:Panel ID="Panel6" runat="server" Height="62px" Width="874px" 
                      CssClass="style11" GroupingText="Datos de la Solicitud de Atención" style="margin-left: 3px" 
                        BorderStyle="Solid" BorderWidth="1px" BackColor="White">
                     <table style="height: 34px; width: 865px;" bgcolor="White">                                    
                        <tr>
                            <td style="width: 985px; height: 4px;">
                                <asp:Label ID="Label13" runat="server" Text="Num. Solicitud Atención"></asp:Label>
                            </td>                           
                            <td style="width: 298px; height: 4px;">
                                &nbsp;
                                <asp:Label ID="LblNumSA" runat="server"></asp:Label>
                            </td>
                            <td style="width: 1062px">
                                    &nbsp; Apellidos y Nombres
                            </td>
                            <td style="width: 4034px">
                                    &nbsp;
                            <asp:Label ID="LblPaciente" runat="server"></asp:Label>
                            </td> 
                            <td style="width: 711px">
                                    <asp:Label ID="Label10" runat="server" Text="Historia N°"></asp:Label>
                            </td>
                            <td style="width: 320px">
                                    &nbsp;
                            <asp:Label ID="LblNHC" runat="server"></asp:Label>
                            </td>                        
                                                    
                        </tr>                                                                
                    </table>
                  </asp:Panel>
                   
                    <asp:Panel ID="Panel8" runat="server" CssClass="style11" 
                        GroupingText="Datos del Servicio" Height="242px" Width="874px" 
                        BackColor="White">
                       <table bgcolor="White" 
                            style="height: 153px; width: 864px; margin-left: 0px; margin-right: 0px;">
                         <tr>
                           <td style="width: 255px">
                            <table style="width: 246px; margin-left: 7px; height: 176px;">
                               <tr>
                                 <td align="left" style="width: 161px">
                                     <asp:Label ID="Label18" runat="server" Text="Fecha de Atención"></asp:Label>
                                      
                                 </td>                                                                                                
                               </tr>                              
                               <tr>
                                 <td style="width: 161px">
                                    <asp:Calendar ID="CFecha" runat="server" BackColor="White" 
                                        BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" 
                                        Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="16px" 
                                        Width="190px" style="margin-left: 11px; margin-right: 9px">
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
                           </td>   
                           <td>
                            <table style="height: 210px; width: 602px; margin-left: 0px; margin-right: 0px;">
                               <tr>
                                 <td align="left" style="height: 37px">
                                     <asp:Label ID="Label19" runat="server" Text="Turno"></asp:Label>
                                 </td>
                                  <td align="left" style="height: 37px; color: #FF0000;">
                                      <asp:DropDownList ID="DdTurno" runat="server" AutoPostBack="True" Height="21px" 
                                          Width="100px" Enabled="False">
                                      </asp:DropDownList>
                                      &nbsp;*</td>
                                 <td style="height: 37px; color: #FF0000;">
                                     &nbsp;</td> 
                                 <td style="height: 37px">
                                     <asp:Label ID="LblCodTurno" runat="server" Visible="False">Label</asp:Label>
                                 </td>
                               
                               </tr>
                                <tr align="center">
                                 <td align="left" style="height: 52px">
                                     <asp:Label ID="Label20" runat="server" Text="Especialidad"></asp:Label>
                                 </td>
                                  <td align="left" style="height: 52px; color: #FF0000;">
                                      <asp:DropDownList ID="DdEspecialidad" runat="server" AutoPostBack="True" 
                                          Enabled="False" Height="21px" Width="332px" style="margin-left: 0px">
                                      </asp:DropDownList>
                                      &nbsp;*</td>
                                 <td style="color: #FF0000; height: 52px;">
                                     &nbsp;</td>
                                  <td style="height: 52px">
                                     
                                      <asp:Label ID="LblCodPaciente" runat="server" Text="Label"></asp:Label>
                                     
                                      <asp:Label ID="LblCodEspecialidad" runat="server" Visible="False">Label</asp:Label>
                                     
                                 </td>
                               </tr>
                                <tr>
                                 <td style="height: 73px">
                                     <asp:Label ID="LblCantidad" runat="server" Visible="False"></asp:Label>
                                 </td>
                                  <td align="left" style="height: 73px">
                                      <asp:ImageButton ID="Button2" runat="server" Height="26px" 
                                          ImageUrl="~/Iconos/86.png" style="margin-left: 8px" Width="29px" />
                                      <br />
                                      <asp:Label ID="Label29" runat="server" Text="Limpiar"></asp:Label>
                                 </td>
                                 <td style="color: #FF0000; height: 73px;">
                                     &nbsp;</td>
                                     <td style="height: 73px">
                                     
                                         <asp:Label ID="LblCodV" runat="server" Visible="False"></asp:Label>
                                     
                                         <asp:Label ID="LblCodDetalleProgramacionMedica" runat="server" Text="Label" 
                                             Visible="False"></asp:Label>
                                     
                                 </td>
                               </tr>  
                               <tr>
                                 <td align="left" style="height: 42px">
                                     <asp:Label ID="Label30" runat="server" Text="Médico"></asp:Label>
                                 </td>
                                  <td align="left" style="height: 42px; color: #FF0000;">
                                      &nbsp;<asp:DropDownList ID="DdMedicos" runat="server" AutoPostBack="True" 
                                          Height="21px" Width="332px">
                                      </asp:DropDownList>
                                      &nbsp;*<br />
                                 </td>
                                 <td style="color: #FF0000; height: 42px;">
                                     <br />
                                   </td>
                                    <td style="height: 42px">
                                     
                                        <asp:Label ID="LblCodigo" runat="server"></asp:Label>
                                   </td>
                               </tr>                        
                            </table>                          
                          </td>                                           
                         </tr>                                       
                       </table>                                                                                  
                                                             
                    </asp:Panel>
                                 
                     <asp:Panel ID="Panel2" runat="server" CssClass="style11" 
                        GroupingText="Motivo de Hospitalización" Height="64px" Width="874px" 
                        Visible="False" BackColor="White">
                        <table bgcolor="White" style="height: 46px; width: 863px;">
                            <tr>
                                <td style="width: 807px" class="style9">
                                    <asp:Label ID="Label28" runat="server" Text="Motivo de Hospitalización"></asp:Label>
                                </td>
                                <td style="width: 505px; color: #FF0000;">
                                    <asp:DropDownList ID="DdMotivoHospitalizacion" runat="server" Height="21px" 
                                        Width="355px">
                                    </asp:DropDownList>
                                    &nbsp;*</td>                               
                                <td style="width: 776px" class="style9" align="right">
                                    <asp:Label ID="Label5" runat="server" Text="Cama"></asp:Label>
                                </td>
                                <td style="width: 878px" align="center">                                  
                                    <asp:Label ID="Lblcama" runat="server"></asp:Label>
                                </td>                               
                            </tr>
                        </table>
                    </asp:Panel>
                     <asp:Panel ID="Panel3" runat="server" CssClass="style11" Height="50px" Width="874px" 
                        Visible="False" BackColor="White">
                        <table bgcolor="White" style="height: 57px; width: 871px;">
                            <tr>
                                <td style="width: 807px" class="style9">
                                    <asp:Label ID="LblCodTiComprobar" runat="server" Visible="False"></asp:Label>
                                    <asp:Label ID="LblDpm" runat="server" Visible="False"></asp:Label>
                                    <asp:Label ID="LblContar" runat="server" Text="Label" Visible="False"></asp:Label>
                                </td>
                                <td style="width: 505px">
                                    <asp:Label ID="LblNTiComprobar" runat="server" Visible="False"></asp:Label>
                                </td>                               
                                <td style="width: 776px" class="style9">
                                    <asp:Label ID="LblMeComprueba" runat="server" Visible="False"></asp:Label>
                                    <asp:Label ID="LblFechaAtencion" runat="server" Visible="False"></asp:Label>
                                </td>
                                <td style="width: 878px">                                  
                                    <asp:Label ID="LblEsComprueba" runat="server" Visible="False"></asp:Label>
                                    <asp:Label ID="LblCodSoliAten" runat="server"></asp:Label>
                                </td>                               
                            </tr>
                        </table>
                    </asp:Panel>
                             
                    <asp:Panel ID="Panel1" runat="server" CssClass="style11" Height="101px" 
                        Width="874px" BackColor="#99CCFF">
                        <div style="text-align: left; width: 870px; height: 22px; margin-left: 0px;">
                             <table style="width: 870px; height: 25px" align="center">
                                <tr>
                                    <td style="width: 161px" align="center">                                      
                                        <asp:Label ID="Label4" runat="server" ForeColor="Red" Text="!Ten en cuenta que ...!" 
                                            Visible="False"></asp:Label>
                                    </td>                                                                   
                                </tr>                              
                            </table>
                            <table style="width: 869px; height: 36px">
                                <tr>
                                    <td style="width: 161px">                                      
                                        <asp:Label ID="Label3" runat="server" ForeColor="Blue" Text="Para" 
                                            Visible="False"></asp:Label>
                                    </td>  
                                    <td style="width: 779px">                                      
                                        <asp:Label ID="LblEspecialidad" runat="server" Visible="False" ForeColor="Blue"></asp:Label>
                                    </td>
                                    <td style="width: 458px">                                      
                                        <asp:Label ID="Label21" runat="server" Text="en el turno" Visible="False" 
                                            ForeColor="Blue"></asp:Label>
                                    </td>
                                    <td style="width: 579px">                                      
                                        <asp:Label ID="LblTurno2" runat="server" ForeColor="Blue" Visible="False"></asp:Label>
                                    </td>
                                    <td style="width: 445px">                                      
                                        <asp:Label ID="Label22" runat="server" Text="con el médico" Visible="False" 
                                            ForeColor="Blue"></asp:Label>
                                    </td>                                
                                </tr>                              
                            </table>
                            <table style="width: 868px; height: 34px">
                                 <tr>
                                    <td style="width: 187px">                                      
                                        <asp:Label ID="LblMedico" runat="server" Visible="False" ForeColor="Blue"></asp:Label>
                                    </td>  
                                    <td style="width: 35px">                                      
                                        <asp:Label ID="Label6" runat="server" Visible="False" ForeColor="Blue">van</asp:Label>
                                    </td> 
                                    <td style="width: 13px" class="style21">                                      
                                        <asp:Label ID="Label7" runat="server" Visible="False" ForeColor="Red"></asp:Label>
                                    </td> 
                                    <td style="width: 44px">                                      
                                        <asp:Label ID="Label23" runat="server" ForeColor="Blue" Text="de" 
                                            Visible="False"></asp:Label>
                                    </td>
                                    <td style="width: 66px">                                      
                                        <asp:Label ID="LblNumCon" runat="server" Visible="False" 
                                            ForeColor="Blue"></asp:Label>
                                    </td>
                                    <td style="width: 128px">                                      
                                        <asp:Label ID="Label25" runat="server" ForeColor="Blue" Text="solicitudes de atención" 
                                            Visible="False"></asp:Label>
                                    </td>                                
                                </tr>
                            </table>
                        </div>
                    </asp:Panel>
                    <asp:Panel ID="Panel9" runat="server" CssClass="style11" Height="63px" 
                        Width="874px">
                        <div style="text-align: left; width: 695px; height: 76px; margin-left: 0px;">
                            <table style="width: 869px; height: 50px" bgcolor="White">
                                <tr>
                                    <td style="width: 445px">                                      
                                    </td>  
                                    <td style="width: 445px" align="center">                                      
                                        <asp:ImageButton ID="BtnRegistrar" runat="server" ImageUrl="~/Iconos/21.png" 
                                            Height="41px" Width="45px" Enabled="False" />
                                        <br />
                                        <asp:Label ID="Label27" runat="server" Text="Registrar"></asp:Label>
                                    </td>                                    
                                    <td style="width: 445px">                                      
                                    </td>                                 
                                </tr>
                            </table>
                        </div>
                    </asp:Panel>
               </td>              
      
            </tr>                             
        </table>         
     
</asp:Content>

