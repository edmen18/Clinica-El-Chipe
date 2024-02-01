<%@ Page Language="VB" MasterPageFile="~/WFPrincipal/PaginaMaestra.master" AutoEventWireup="false" CodeFile="BusquedaParaControlesVitales.aspx.vb" Inherits="Hospitalizacion_BusquedaParaControlesVitales" title="Página sin título" %>

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
           <td style="width: 702px; height: 4px;">           
               <asp:Label ID="LblTurno" runat="server" Font-Bold="True" ForeColor="White"></asp:Label>
               <asp:Label ID="LblCT" runat="server" Visible="False" Font-Bold="True" 
                   ForeColor="White"></asp:Label>
           </td>  
           <td style="width: 702px; height: 4px;">            
               &nbsp;</td>                                                   
         </tr>                                                                
    </table>    
</asp:Panel>



<asp:Panel ID="Panel10" runat="server" Height="458px">   
       <table frame="box" 
             style="width: 709px; height: 35px; margin-left: 71px; margin-top: 8px;">
             <tr>
                 <td align="center" style="height: 28px; font-size: 20px; width: 849px;">
                     <asp:Label ID="Label2" runat="server" ForeColor="#000099" 
                         Text="HOSPITALIZACIÓN"></asp:Label>
                 </td>
                 <td style="width: 150px">
                     <asp:LinkButton ID="LinkButton1" runat="server">Volver al inicio</asp:LinkButton>
                 </td>
             </tr>
         </table>
 <table style="width: 710px; margin-left: 70px; " bgcolor="White">
          <tr>
            <td style="height: 28px; font-size: 18px; width: 946px;" align="left">
                <asp:Label ForeColor="Blue" ID="Label1" runat="server" 
                    Text="Búsqueda de Paciente"></asp:Label>
            </td>  
          </tr>
 </table>
<asp:Panel ID="Panel1" runat="server" Height="83px" Width="708px" 
        CssClass="style14" BackColor="White">
       <div style="text-align: left; width: 702px; height: 76px; margin-left: 0px;">
          <table style="width: 705px; height: 82px">
               <tr>              
                  <td style="width: 445px">                                    
                     <asp:Panel ID="Panel2" runat="server" Height="63px" Width="568px" 
                      GroupingText="Búsqueda por Apellidos, Nombres, N° de Historia Clínica o DNI" 
                          BackColor="White" style="margin-left: 13px">
                       <table style="height: 38px; width: 551px; font-size: 15px;">                                                                                                       
                        <tr>
                            <td style="width: 55px; font-size: inherit; height: 30px;">
                                Dato</td>
                            <td style="width: 114px; height: 30px;">
                                <asp:TextBox ID="TxtBuscar" runat="server" Width="400px" 
                                    style="margin-left: 0px"></asp:TextBox>
                                <br />
                            </td>
                        </tr>                                                             
                      </table>                  
                    </asp:Panel>
                   </td>                             
                  <td rowspan="3">
                       <table style="width: 82px; margin-left: 23px; height: 27px;">                            
                             <tr>                                                            
                                   <td style="height: 26px">
                                         <asp:ImageButton ID="BtnBuscar" runat="server" Height="37px" 
                                             ImageUrl="~/Iconos/94.png" Width="46px" />
                                   </td>  
                              </tr>                                                             
                        </table>
                    </td>                 
               </tr>                 
          </table>       
     </div>    
  </asp:Panel>
 
 
  <asp:Panel ID="Panel3" runat="server" Height="194px" Width="710px" 
        CssClass="style14" ScrollBars="Horizontal" BackColor="White">
     <div style="height: 194px; width: 707px;">  
         
         <asp:GridView ID="gvhospitalizaciones" runat="server" 
             AutoGenerateColumns="False" AutoGenerateSelectButton="True" BackColor="White" 
             BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" 
             Height="140px" Width="581px">
             <RowStyle BackColor="White" ForeColor="#330099" />
             <Columns>
                 <asp:BoundField DataField="CodHospitalizacion" HeaderText="Hospitalización" />
                 <asp:BoundField DataField="paciente" HeaderText="Paciente" />
                 <asp:BoundField DataField="solicitud" HeaderText="Solicitud" />
                 <asp:BoundField DataField="motivo" HeaderText="Motivo" />
                 <asp:BoundField DataField="fecha" HeaderText="Fecha" />
             </Columns>
             <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
             <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
             <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
             <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
         </asp:GridView>
    </div>  
  </asp:Panel> 
 </asp:Panel>
</asp:Content>

