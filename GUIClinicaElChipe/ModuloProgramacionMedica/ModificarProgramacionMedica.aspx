<%@ Page Language="VB" MasterPageFile="~/WFPrincipal/PaginaMaestra.master" AutoEventWireup="false" CodeFile="ModificarProgramacionMedica.aspx.vb" Inherits="ModuloProgramacionMedica_ModificarProgramacionMedica" title="Página sin título" MaintainScrollPositionOnPostback="true" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<asp:Panel ID="Panel5" runat="server" Height="41px" BackColor="#5F94C9"
        style="margin-top: 0px" Width="1146px">   
    <table style="height: 33px; width: 1144px;" bgcolor="#5F94C9">                                    
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
           <td style="width: 702px; height: 4px;">           
               <asp:Label ID="LblTurno" runat="server" Font-Bold="True" ForeColor="White"></asp:Label>
               <asp:Label ID="LblCT" runat="server" Visible="False" Font-Bold="True" 
                   ForeColor="White"></asp:Label>
           </td>                                                             
         </tr>                                                                
    </table>    
</asp:Panel>

<asp:Panel ID="Panel10" runat="server" height="573px">
 <table style="width: 632px; height: 10px; margin-left: 70px; margin-top: 8px;" 
            frame="box">
          <tr>
            <td style="height: 28px; font-size: 20px; width: 1027px;" align="center">
                <asp:Label ForeColor="#000099" ID="Label2" runat="server" 
                    Text="Programación Médica"></asp:Label>
            </td>           
          </tr>
 </table>
 <table bgcolor="White" 
        style="height: 0px; margin-bottom: 0px; width: 631px; margin-left: 70px;">
         <tr>
            <td style="height: 20px; font-size: 18px; width: 2782px;" align="left">
                 <asp:Label ForeColor="Blue" ID="Label1" runat="server" 
                     Text="Modificar Programación Médica"></asp:Label>
            </td>
            <td style="height: 20px; font-size: 18px; width: 1901px;" align="left">
                
            </td>
            <td style="height: 20px; font-size: 18px; width: 1027px;" align="left">
                 &nbsp;</td>
            <td style="height: 20px; font-size: 18px; width: 1179px; color: #0000FF;" 
                 align="left">
                 &nbsp;</td>                     
            <td style="height: 20px; font-size: 18px; width: 1901px;" align="left">                
                <asp:LinkButton ID="LinkButton1" runat="server">Volver al inicio</asp:LinkButton>                
            </td> 
         </tr>
 </table>
 
   
        <table border="1"                         
        
        style="background-color: #99CCFF; font-size: medium; width: 629px; margin-left: 68px; height: 447px;">           
             <tr>                          
                <td style="width: 512px; height: 433px;" >
                    <asp:Panel ID="Panel7" runat="server" CssClass="style18" 
                        GroupingText="Elija los datos de la Programación Médica" Height="134px" 
                        Width="506px" BackColor="White">
                        <table bgcolor="White" style="height: 115px; width: 494px; margin-left: 0px;">
                            <tr>
                                <td style="width: 130px">
                                    <asp:Label ID="Label24" runat="server" Text="Especialidad"></asp:Label>
                                </td>
                                <td style="width: 508px">                                   
                                    <asp:DropDownList ID="DdEspecialidad" runat="server" Height="20px" 
                                        Width="331px" AutoPostBack="True">
                                    </asp:DropDownList>
                                </td>                              
                            </tr>
                            <tr>
                                <td style="width: 130px">
                                    <asp:Label ID="Label25" runat="server" Text="Médico"></asp:Label>
                                </td>
                                <td style="width: 508px">                                   
                                    <asp:DropDownList ID="DdMedico" runat="server" Height="20px" Width="331px">
                                    </asp:DropDownList>
                                </td>                                
                            </tr>
                            <tr>
                                <td style="width: 130px">
                                    <asp:Label ID="Label26" runat="server" Text="Turno"></asp:Label>
                                </td>
                                <td style="width: 508px">                                   
                                    <asp:DropDownList ID="DdTurno" runat="server" Height="20px" Width="331px">
                                    </asp:DropDownList>
                                </td>
                            </tr>
                             <tr>
                                <td style="width: 130px">
                                    <asp:Label ID="Label3" runat="server" Text="Tipo Atención"></asp:Label>
                                </td>
                                <td style="width: 508px">                                   
                                    <asp:DropDownList ID="DdTipoAtencion" runat="server" Height="20px" 
                                        Width="331px" AutoPostBack="True">
                                    </asp:DropDownList>
                                </td>
                            </tr>
                        </table>
                        
                    </asp:Panel>
                             
                    <asp:Panel ID="Panel13" runat="server" Height="191px" Width="506px" 
                      CssClass="style18" GroupingText="Seleccione la fecha de atención que desea modificar" 
                        style="margin-left: 3px" BorderStyle="Solid" BorderWidth="1px" 
                        BackColor="White">
                      <table bgcolor="White" style="height: 143px; width: 433px;" align="center">
                       <tr>
                          <td>
                          
                              <asp:Label ID="Label27" runat="server" Text="Fecha"></asp:Label>
                          
                          </td>
                          <td style="width: 540px; height: 4px;">
                              <asp:Calendar ID="CFecha1" runat="server" BackColor="White" 
                                  BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" 
                                  Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="118px" 
                                  style="margin-left: 34px" Width="245px">
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
                          <td>
                          
                              <asp:ImageButton ID="BtnVer" runat="server" Height="37px" 
                                  ImageUrl="~/Iconos/65.png" Width="37px" />
                              <br />
                              <asp:Label ID="Label34" runat="server" Text="Ver"></asp:Label>
                          
                          </td>                                                           
                       </tr>
                      </table>                         
                  </asp:Panel>
                    <asp:Panel ID="Panel8" runat="server" CssClass="style18" 
                        GroupingText="Datos de la Programación Médica" Height="119px" 
                        Width="506px" BackColor="White">
                        <table bgcolor="White" style="height: 88px; width: 487px; margin-left: 0px;">
                            <tr>
                                <td style="width: 711px; height: 33px;">
                                    <asp:Label ID="Label17" runat="server" Text="Fecha"></asp:Label>
                                </td>
                                <td class="style9" style="width: 439px; height: 33px;">
                                  
                                    <asp:Label ID="LblFechapm" runat="server"></asp:Label>
                                  
                                </td>
                                <td style="width: 942px; height: 33px;">
                                    <asp:Label ID="LblCodProgramacionMedica" runat="server" SkinID="Label" 
                                        Text="Label" Visible="False"></asp:Label>
                                    <asp:Label ID="LblCodDetalleProgramacionMedica" runat="server" Text="Label" 
                                        Visible="False"></asp:Label>
                                    <asp:Label ID="LblCodMedicoEspecialidad" runat="server" Text="Label" 
                                        Visible="False"></asp:Label>
                                    <asp:Label ID="LblAtencion" runat="server" Text="Label" Visible="False"></asp:Label>
                                </td>
                                <td style="width: 702px; height: 33px;">
                                 
                                    <asp:Label ID="LblSA" runat="server" Visible="False"></asp:Label>
                                 
                                    </td>                               
                            </tr>
                            <tr>
                                <td style="width: 711px">
                                    <asp:Label ID="Label21" runat="server" Text="N° de Consultas"></asp:Label>
                                </td>
                                <td class="style9" style="width: 439px">
                                  
                                    <asp:TextBox ID="TxtCantidadConsultas" runat="server" Width="47px"></asp:TextBox>
                                  
                                </td>
                                <td style="width: 942px">
                                    <asp:CompareValidator ID="CompareValidator1" runat="server" 
                                        ControlToValidate="TxtCantidadConsultas" 
                                        ErrorMessage="Error. Debe ingresar SÓLO NÚMEROS" Font-Size="11pt" 
                                        Operator="DataTypeCheck" Type="Integer"></asp:CompareValidator>
                                </td>
                                <td style="width: 702px">
                                 
                                    <asp:Label ID="LblNC" runat="server" Visible="False"></asp:Label>
                                </td>                               
                            </tr>
                            <tr>
                                <td style="width: 711px">
                                    <asp:Label ID="LblRUC" runat="server" Text="Atención"></asp:Label>
                                </td>
                                <td class="style9" style="width: 439px">
                                  
                                    <asp:CheckBox ID="ChkAtencion" runat="server" />
                                  
                                </td>
                                <td style="width: 942px">
                                
                                    &nbsp;</td>
                                <td style="width: 702px">
                                 
                                </td>                             
                            </tr>                           
                        </table>                       
                    </asp:Panel>                       
               </td> 
               <td style="height: 433px">
               
                    <asp:Panel ID="Panel9" runat="server" CssClass="style18" Height="447px" 
                        Width="100px" BackColor="White">
                        <div style="text-align: left; width: 101px; height: 453px; margin-left: 0px;">
                            <table style="width: 101px; height: 457px" bgcolor="White">
                                <tr>
                                    <td style="width: 411px" align="center">                                      
                                        
                                        <asp:Label ID="Label35" runat="server" Text="Opciones"></asp:Label>
                                        
                                    </td> 
                                </tr>
                                <tr>                                    
                                    <td style="width: 474px" align="center">                                      
                                        <asp:ImageButton ID="BtnNuevo" runat="server" Height="38px" Width="38px" 
                                            ImageUrl="~/Iconos/32.png" />
                                    </td>
                                </tr>
                                <tr>
                                  <td style="width: 474px" align="center">                                      
                                        <asp:Label ID="Label30" runat="server" Text="Nuevo"></asp:Label>
                                    </td>  
                                </tr>
                                <tr>                                   
                                     <td style="width: 582px" align="center">                                      
                                        <asp:ImageButton ID="BtnModificar" runat="server" Height="38px" Width="38px" 
                                            ImageUrl="~/Iconos/56.png" />
                                    </td> 
                                </tr>  
                                <tr>
                                 <td align="center" style="width: 582px">                                      
                                        <asp:Label ID="Label31" runat="server" Text="Modificar"></asp:Label>
                                    </td>                                 
                                </tr>
                                <tr>                                
                                    <td align="center" style="width: 499px">                                      
                                        <asp:ImageButton ID="BtnCancelar" runat="server" ImageUrl="~/Iconos/08.png" />
                                    </td> 
                                </tr>
                                <tr>
                                  <td style="width: 499px" align="center">                                      
                                        <asp:Label ID="Label32" runat="server" Text="Cancelar"></asp:Label>
                                    </td>                                
                                </tr>
                                <tr>                             
                                    <td style="width: 457px" align="center">                                      
                                        <asp:ImageButton ID="BtnEliminar" runat="server" ImageUrl="~/Iconos/07.png" />
                                    </td> 
                                </tr>
                                <tr>
                                   <td style="width: 457px" align="center">                                      
                                        <asp:Label ID="Label33" runat="server" Text="Eliminar"></asp:Label>
                                    </td>                                 
                                </tr>
                                <tr>
                                    <td style="width: 445px" align="center">                                      
                                        &nbsp;</td>                                                                                                     
                                </tr>                                                            
                            </table>
                        </div>
                    </asp:Panel>
               </td>             
      
            </tr>                             
        </table>  
  </asp:Panel>       
</asp:Content>

