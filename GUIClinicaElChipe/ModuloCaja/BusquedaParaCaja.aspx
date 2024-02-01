<%@ Page Language="VB" MasterPageFile="~/WFPrincipal/PaginaMaestra.master" AutoEventWireup="false" CodeFile="BusquedaParaCaja.aspx.vb" Inherits="ModuloCaja_BusquedaParaCaja" title="Página sin título" MaintainScrollPositionOnPostback="true"%>
<%@ PreviousPageType VirtualPath="~/ModuloCaja/ModuloCaja.aspx" %>

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
               &nbsp;</td>                                                   
         </tr>                                                                
    </table>    
</asp:Panel>

 <table style="width: 959px; height: 35px; margin-left: 15px; margin-top: 8px;" 
            frame="box">
          <tr>
           <td style="height: 28px; font-size: 20px; width: 847px;" align="center">
                <asp:Label ForeColor="#000099" ID="Label2" runat="server" Text="Módulo de Caja"></asp:Label>
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
                    Text="Búsqueda para Pago de Consultas"></asp:Label>
            </td>
         </tr>
 </table> 
<asp:Panel ID="Panel1" runat="server" Height="89px" Width="953px" 
        CssClass="style14">
       <div style="text-align: left; width: 955px; height: 125px; margin-left: 0px;">
          <table style="width: 950px; height: 82px; margin-left: 0px;">
               <tr>              
                  <td style="width: 445px">                                    
                     <asp:Panel ID="Panel2" runat="server" Height="82px" Width="764px" 
                      CssClass="style14" GroupingText="Búsqueda ">
                       <table style="height: 61px; width: 745px; font-size: 15px;">                                                                                                       
                         <tr>
                            <td style="width: 151px; font-size: inherit; height: 30px;">
                                <asp:Label ID="Label4" runat="server" Text="Ingrese dato a buscar"></asp:Label>
                            </td>
                            <td style="width: 114px; height: 30px;">
                                <asp:TextBox ID="TxtBuscar" runat="server" Width="454px" 
                                    style="margin-left: 0px"></asp:TextBox>
                                <br />
                            </td>
                        </tr>                                                             
                      </table>                  
                    </asp:Panel>
                   </td>                             
                <td rowspan="3">
                       <table style="width: 82px; margin-left: 40px; height: 27px;">                            
                             <tr>                                                            
                                   <td style="height: 26px">
                                         <asp:ImageButton ID="ImageButton1" runat="server" Height="37px" 
                                             ImageUrl="~/Iconos/94.png" Width="46px" />
                                   </td>  
                              </tr>                                                             
                        </table>
                    </td>                 
               </tr>                 
          </table>       
     </div>    
  </asp:Panel>
  
 
  <asp:Panel ID="Panel3" runat="server" Height="308px" Width="953px" 
        CssClass="style14" ScrollBars="Vertical">
     <div style="height: 221px; width: 953px;">  
         <asp:GridView ID="GvListadoSolicitudAtencion" runat="server" AutoGenerateColumns="False" 
             AutoGenerateSelectButton="True" CellPadding="3" ForeColor="#333333" 
             style="margin-left: 16px" CellSpacing="2" Width="1941px" Visible="False">
             <RowStyle BackColor="#EFF3FB" BorderWidth="1px" />
             <Columns>
                 <asp:BoundField DataField="NHC" HeaderText="NHC" />
                 <asp:BoundField DataField="NUMSOLICITUDATENCION" 
                     HeaderText="NUM.SOLICITUD ATENCION" />
                 <asp:BoundField DataField="PACIENTE" HeaderText="PACIENTE" />
                 <asp:BoundField DataField="CODVENTA" HeaderText="CODIGO VENTA" />
                 <asp:BoundField DataField="CODPACIENTE" HeaderText="COD. PACIENTE" />
                 <asp:BoundField DataField="FECHAATENCION" HeaderText="FECHA ATENCION" />
                 <asp:BoundField DataField="NOMESPECIALIDAD" HeaderText="ESPECIALIDAD" />
                 <asp:BoundField DataField="CODESPECIALIDAD" HeaderText="COD. ESPECIALIDAD" />
                </Columns>
             <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White"/>
             <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
             <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
             <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
             <EditRowStyle BackColor="#2461BF" />
             <AlternatingRowStyle BackColor="White" />
         </asp:GridView>  
    </div>  
  </asp:Panel> 
</asp:Content>

