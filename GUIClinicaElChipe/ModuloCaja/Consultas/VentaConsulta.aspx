<%@ Page Language="VB" MasterPageFile="~/WFPrincipal/PaginaMaestra.master" AutoEventWireup="false" CodeFile="VentaConsulta.aspx.vb" Inherits="ModuloCaja_VentaConsulta" title="Página sin título" MaintainScrollPositionOnPostback="true" %>
<%@ PreviousPageType VirtualPath="~/ModuloCaja/BusquedaParaCaja.aspx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<asp:Panel ID="Panel5" runat="server" Height="41px" BackColor="#5F94C9" 
        style="margin-top: 0px" Width="1026px">   
    <table style="height: 33px; width: 1026px;" bgcolor="#5F94C9">                                    
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
           <td style="width: 702px; height: 4px;">            
           </td>                                                   
         </tr>                                                                
    </table>    
</asp:Panel>


 <table style="width: 883px; height: 10px; margin-left: 70px; margin-top: 8px;" 
            frame="box">
          <tr>
            <td style="height: 28px; font-size: 20px; width: 1027px;" align="center">
                <asp:Label ForeColor="#000099" ID="Label2" runat="server" Text="Módulo de Caja"></asp:Label>
            </td>           
          </tr>
 </table>
 <table bgcolor="#DBEFF7" 
        style="height: 0px; margin-bottom: 0px; width: 880px; margin-left: 70px;">
         <tr>
            <td style="height: 20px; font-size: 18px; width: 13963px;" align="left">
                 <asp:Label ForeColor="Blue" ID="Label1" runat="server" 
                     Text="Pago de las Solicitudes de Consulta"></asp:Label>
            </td>
            <td style="height: 20px; font-size: 18px; width: 1901px;" align="left">
                
                <asp:LinkButton ID="LinkButton1" runat="server">Volver al inicio</asp:LinkButton>
                
            </td>           
         </tr>
 </table>
 
   
        <table border="1"                     
            
        style="background-color: #99CCFF; font-size: medium; width: 713px; margin-left: 68px;">           
             <tr>                          
                <td style="width: 600px" >
                    <asp:Panel ID="Panel7" runat="server" CssClass="style11" 
                        GroupingText="Datos del Paciente" Height="106px" Width="869px">
                        <table bgcolor="#DBEFF7" style="height: 41px; width: 859px; margin-left: 0px;">
                            <tr>
                                <td style="width: 219px">
                                    &nbsp; Apellidos y Nombres</td>
                                <td style="width: 702px">
                                    &nbsp;
                                    <asp:Label ID="LblPaciente" runat="server"></asp:Label>
                                </td>
                            </tr>
                        </table>
                        <table bgcolor="#DBEFF7" style="height: 41px; width: 860px;">
                            <tr>
                                <td style="width: 1075px">
                                    <asp:Label ID="Label9" runat="server" Text="Historia N°"></asp:Label>
                                </td>
                                <td style="width: 702px">
                                    &nbsp;
                                    <asp:Label ID="LblNHC" runat="server"></asp:Label>
                                </td>
                                <td style="width: 1609px">
                                    &nbsp;
                                    <asp:Label ID="Label16" runat="server" Text="Num. Ticket"></asp:Label>
                                </td>
                                <td class="style9" style="width: 772px">
                                    &nbsp;
                                    <asp:Label ID="LblNumTicket" runat="server"></asp:Label>
                                </td>                             
                                <td style="width: 801px">
                                    &nbsp;
                                    <asp:Label ID="Label38" runat="server" Text="Especialidad"></asp:Label>
                                    </td>                               
                                <td style="width: 899px">
                                    &nbsp;
                                    <asp:Label ID="LblEspecialidad" runat="server" Text="Label"></asp:Label>
                                    </td>
                                <td style="width: 899px">
                                    &nbsp;
                                   
                                    <asp:Label ID="LblCodPaciente" runat="server" Text="Label"></asp:Label>
                                   
                                    &nbsp;<asp:Label ID="LblCodEspecialidad" runat="server" Text="Label" Visible="False"></asp:Label>
                                   
                                </td>
                            </tr>
                        </table>
                    </asp:Panel>
                     <asp:Panel ID="Panel6" runat="server" Height="51px" Width="870px" 
                      CssClass="style11" GroupingText="Datos de la Venta" style="margin-left: 3px" 
                        BorderStyle="Solid" BorderWidth="1px">
                     <table style="height: 29px; width: 861px;" bgcolor="#DBEFF7">                                    
                        <tr>
                            <td style="width: 1409px; height: 4px;">
                                <asp:Label ID="Label13" runat="server" Text="Cod. Venta"></asp:Label>
                            </td>                           
                            <td style="width: 1075px; height: 4px;">
                                
                                <asp:Label ID="LblCodVenta" runat="server"></asp:Label>
                                </td>
                            <td style="width: 405px; height: 4px;">
                                
                                </td>                                                   
                        </tr>                                                                
                    </table>
                  </asp:Panel>
                  <asp:Panel ID="Panel12" runat="server" Height="61px" Width="871px" 
                      CssClass="style11" GroupingText="Servicio" style="margin-left: 3px" 
                        BorderStyle="Solid" BorderWidth="1px">
                       <table bgcolor="#DBEFF7" style="height: 40px; width: 859px;">
                                  <tr>
                                      <td style="width: 1409px; height: 4px;">
                                          <asp:Label ID="Label4" runat="server" Text="Ingrese nombre del servicio"></asp:Label>
                                      </td>
                                      <td style="width: 960px; height: 4px;">
                                          &nbsp;
                                          <asp:TextBox ID="TxtBuscar" runat="server" Width="321px" 
                                              AutoCompleteType="Disabled"></asp:TextBox>
                                      </td>
                                      <td style="width: 118px; height: 4px;">
                                          <asp:ImageButton ID="BtnBuscar" runat="server" Height="33px" 
                                              ImageUrl="~/Iconos/94.png" Width="36px" />
                                      </td>
                                  </tr>
                             </table>                         
                  </asp:Panel>
                    <asp:Panel ID="Panel13" runat="server" Height="171px" Width="872px" 
                      CssClass="style11" GroupingText="Listado de Servicios" 
                        style="margin-left: 3px" BorderStyle="Solid" BorderWidth="1px" 
                        ScrollBars="Vertical">
                      <table bgcolor="#DBEFF7" style="height: 143px; width: 862px;">
                       <tr>
                          <td style="width: 1409px; height: 4px;">
                           <asp:GridView ID="GvListadoServicio" runat="server" AutoGenerateColumns="False" 
             AutoGenerateSelectButton="True" CellPadding="3" ForeColor="#333333" 
             style="margin-left: 16px" CellSpacing="2" Width="696px" Visible="False" Height="119px">
             <RowStyle BackColor="#EFF3FB" BorderWidth="1px" />
             <Columns>
                 <asp:BoundField DataField="CodServicio" HeaderText="Cod. Servicio" />
                 <asp:BoundField DataField="NomServicio" HeaderText="Servicio" />
                 <asp:BoundField DataField="Precio" HeaderText="Precio" />
                </Columns>
             <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White"/>
             <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
             <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
             <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
             <EditRowStyle BackColor="#2461BF" />
             <AlternatingRowStyle BackColor="White" />
         </asp:GridView>           
                          </td>                                     
                       </tr>
                      </table>                         
                  </asp:Panel>
                    <asp:Panel ID="Panel8" runat="server" CssClass="style11" 
                        GroupingText="Datos del Servicio" Height="85px" Width="870px">
                        <table bgcolor="#DBEFF7" style="height: 64px; width: 860px; margin-left: 0px;">
                            <tr>
                                <td style="width: 1075px; height: 42px;">
                                    <asp:Label ID="Label17" runat="server" Text="Cod. Servicio"></asp:Label>
                                </td>
                                <td class="style9" style="width: 772px; height: 42px;">
                                  
                                    <asp:Label ID="LblCodServicio" runat="server" Text="Label"></asp:Label>
                                  
                                </td>
                                <td style="width: 942px; height: 42px;">
                                    <asp:Label ID="Label18" runat="server" Text="Cantidad"></asp:Label>
                                </td>
                                <td style="width: 702px; height: 42px;">
                                 
                                    <asp:TextBox ID="TxtCantidad" runat="server" Width="70px"></asp:TextBox>
                                 
                                </td>
                                <td class="style9" style="width: 772px; height: 42px;">
                                                                      
                                    <asp:Label ID="Label19" runat="server" Text="Precio"></asp:Label>
                                                                      
                                </td>
                                <td class="style9" style="width: 772px; height: 42px;">
                                                                      
                                    <asp:Label ID="LblPrecio" runat="server"></asp:Label>
                                                                      
                                </td>
                                 <td class="style9" style="width: 772px; height: 42px;">
                                                                      
                                     <asp:Label ID="Label12" runat="server" Text="Total"></asp:Label>
                                                                      
                                </td>
                                 <td class="style9" style="width: 772px; height: 42px;">
                                                                      
                                     <asp:Label ID="LblTotal" runat="server"></asp:Label>
                                                                      
                                </td>
                            </tr>                           
                           
                        </table>                       
                    </asp:Panel>
                     <asp:Panel ID="Panel1" runat="server" CssClass="style11" 
                        GroupingText="Comprobante" Height="111px" Width="870px">
                        <table bgcolor="#DBEFF7" style="height: 82px; width: 860px; margin-left: 0px;">
                            <tr>
                                <td style="width: 1075px; height: 42px;">
                                    <asp:Label ID="Label8" runat="server" Text="Cod. Comprobante"></asp:Label>
                                </td>
                                <td class="style9" style="width: 772px; height: 42px;">
                                  
                                    <asp:Label ID="LblCodCom" runat="server"></asp:Label>
                                  
                                </td>
                                <td style="width: 942px; height: 42px;">
                                    <asp:Label ID="Label24" runat="server" Text="TipoComprobante"></asp:Label>
                                </td>
                                <td style="width: 702px; height: 42px;">
                                 
                                    <asp:DropDownList ID="DdTipoComprobante" runat="server" AutoPostBack="True" 
                                        Height="21px" Width="114px">
                                    </asp:DropDownList>
                                 
                                </td>
                                <td class="style9" style="width: 772px; height: 42px;">
                                                                      
                                    <asp:Label ID="Label40" runat="server" Text="IGV" Visible="False"></asp:Label>
                                </td>
                                <td class="style9" style="width: 772px; height: 42px;">
                                                                      
                                    <asp:Label ID="LblIGV" runat="server" Visible="False"></asp:Label>
                                </td>
                                 <td class="style9" style="width: 165px; height: 42px;">
                                                                      
                                     &nbsp;</td> 
                                <td class="style9" style="width: 772px; height: 42px;">
                                                                      
                                     <asp:Label ID="Label41" runat="server" Text="Total IGV" Visible="False"></asp:Label>
                                </td> 
                                <td class="style9" style="width: 772px; height: 42px;">
                                                                      
                                     <asp:Label ID="LblTotalIGV" runat="server" Visible="False"></asp:Label>
                                </td>                                
                            </tr>
                            <tr>
                                <td style="width: 1075px">
                                    <asp:Label ID="Label29" runat="server" Text="Num. Serie" Visible="False"></asp:Label>
                                </td>
                                <td class="style9" style="width: 772px">
                                  
                                    <asp:TextBox ID="TxtNumSerie" runat="server" Width="68px" Visible="False"></asp:TextBox>
                                  
                                </td>
                                <td style="width: 942px">
                                    <asp:Label ID="Label30" runat="server" Text="Corre. Inicio" Visible="False"></asp:Label>
                                </td>
                                <td style="width: 702px">
                                 
                                    <asp:TextBox ID="TxtCorreInicio" runat="server" Width="84px" Visible="False"></asp:TextBox>
                                 
                                </td>
                                <td class="style9" style="width: 772px">
                                                                      
                                    <asp:Label ID="Label36" runat="server" Text="Corre. Fin" Visible="False"></asp:Label>
                                                                      
                                </td>
                                   <td class="style9" style="width: 772px; height: 42px;">
                                                                      
                                       <asp:TextBox ID="TxtCorreFin" runat="server" Width="95px" Visible="False"></asp:TextBox>
                                                                      
                                </td>
                                 <td class="style9" style="width: 165px; height: 42px;">
                                                                      
                                     <asp:Label ID="Label37" runat="server" Text="Corre. Intermedio" Visible="False"></asp:Label>
                                                                      
                                </td>
                                <td class="style9" style="width: 772px; height: 42px;">
                                                                      
                                     <asp:TextBox ID="TxtCorreIntermedio" runat="server" Width="79px" 
                                         Visible="False"></asp:TextBox>
                                </td> 
                                  <td class="style9" style="width: 772px; height: 42px;">
                                                                      
                                      <asp:Label ID="LblCodIGV" runat="server" Visible="False"></asp:Label>
                                </td>
                                                                    
                            </tr>                       
                        </table>                       
                    </asp:Panel>
                    <asp:Panel ID="Panel9" runat="server" CssClass="style11" Height="80px" 
                        Width="869px">
                        <div style="text-align: left; width: 866px; height: 76px; margin-left: 0px;">
                            <table style="width: 863px; height: 79px">
                                <tr>
                                    <td style="width: 445px">                                      
                                    </td>  
                                    <td style="width: 445px" align="center">                                      
                                        <asp:ImageButton ID="BtnRegistrar" runat="server" Height="40px" 
                                            ImageUrl="~/Iconos/21.png" Width="42px" />
                                        <br />
                                        <asp:Label ID="Label39" runat="server" Text="Registrar"></asp:Label>
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

