<%@ Page Language="VB" MasterPageFile="~/WFPrincipal/PaginaMaestraPrincipal.master" AutoEventWireup="false" CodeFile="PaginaPrincipal.aspx.vb" Inherits="WFPrincipal_PaginaPrincipal" title="Página sin título" MaintainScrollPositionOnPostback="true" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <script type="text/javascript" src="http://maps.google.com/maps?file=api&amp;v=2&amp;key=ABQIAAAAJvDxgZaLhLWtKaGRZOZ3gRR4lgekxMwBBfaaIcdVfepGUtY3zhTnVB7kAynRT-i3wmeDyj6xJhibvg"></script>
    <!-- Script principal de la pagina de inicio -->
    <script type="text/javascript" src="../Imagenes/todo-min.js"></script>

    
     <asp:Panel ID="Panel20" runat="server" Height="363px">           
       <table border="1" 
             style="font-size: medium; width: 770px; margin-left: 12px; height: 362px;">           
             <tr>             
                <td rowspan="3" style="width: 207px">  
                 <table style="height: 310px; width: 249px; margin-left: 4px; margin-top: 0px;">
                        <tr>
                            <td style="width: 659px; height: 63px;">                                                             
                                <asp:Menu ID="Menu2" runat="server" BorderColor="#FF6600" 
                                    BorderStyle="Solid" BorderWidth="1px" Height="250px" Width="236px">
                                    <StaticMenuStyle BackColor="#404E7B" BorderWidth="1px" Height="300px" />
                                    <StaticMenuItemStyle BorderWidth="1px" Font-Size="12pt" ForeColor="White" />
                                    <DynamicMenuItemStyle BackColor="#003366" />
                                    <StaticHoverStyle BackColor="#33CCFF" Font-Bold="False" ForeColor="Black" />
                                    <Items>
                                        <asp:MenuItem Text="Clínica El Chipe" Value="Clínica El Chipe " 
                                            ImageUrl="~/Imagenes/Clinica.jpg"></asp:MenuItem>
                                        <asp:MenuItem Text="Sistema" Value="Sistema" NavigateUrl="~/WFPrincipal/Sistema.aspx" 
                                            ImageUrl="~/Imagenes/Sistema.jpg"></asp:MenuItem>
                                        <asp:MenuItem Text="Programación Médica" Value="Programación Médica" 
                                            ImageUrl="~/Imagenes/Calendario.jpg">
                                        </asp:MenuItem>
                                    </Items>
                                </asp:Menu>     
                            </td>
                        </tr>                                                     
                    </table>                      
                </td>
                <td colspan="2" style="height: 21px">
                    <table style="height: 317px; width: 849px;">
                         <tr>
                            <td style="width: 1075px">                               
                                <img alt="" src="../Flash/Fondo2.gif" 
                                    style="width: 727px; height: 299px; margin-left: 59px;" /></td>
                           
                        </tr>                                   
                    </table>
               </td>                   
            </tr>             
        </table>                     
     </asp:Panel> 
     <asp:Panel ID="Panel21" runat="server" Height="143px" Width="1112px">               
          <table border="1" style="font-size: medium; width: 1006px; margin-left: 11px; height: 138px;">           
             <tr>             
                <td rowspan="3" style="height: 104px">  
                 <table style="height: 121px; width: 1109px; margin-left: 0px;">
                        <tr>
                           <td style="width: 659px"> 
                            <div>                              
                              <ul id="circular" class="jcarousel-skin-belen">
                                  <li><a href="../InicioSesion.aspx"><img 
                                    class="crecer" alt="" src="../Imagenes/como-atenderse.jpg" width="202" height="82"/>
                                    </a>
                                  </li>
                                  <li><a href="../InicioSesion.aspx"><img
                                     class="crecer" alt="" src="../Imagenes/como-llegar.jpg" 
                                     width="202" height="82"/>
                                     </a>
                                  </li>
                                  <li><a href="../InicioSesion.aspx"><img 
                                      class="crecer" alt="" src="../Imagenes/cElChipe-imagenes.jpg" 
                                      width="202" height="82"/>
                                     </a>
                                  </li>
                                  <li><a href="../InicioSesion.aspx"><img 
                                      class="crecer" alt="" src="../Imagenes/Sistemaweb.jpg" 
                                      width="202" height="82"/>
                                      </a>
                                  </li>
                                </ul> 
                               </div>
                            </td>                       
                        </tr>                          
                    </table>                      
                </td>                              
            </tr>             
        </table>      
             
                              
     </asp:Panel> 
    
</asp:Content>

