<%@ Page Language="VB" MasterPageFile="~/WFPrincipal/PaginaMaestra.master" AutoEventWireup="false" CodeFile="BuscarPaciente.aspx.vb" Inherits="ModuloAdmision_hc_perintal_BuscarPaciente" title="Página sin título" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Panel ID="Panel5" runat="server" Height="45px" BackColor="#5F94C9" 
        style="margin-top: 0px" Width="1141px">   
    <table style="height: 33px; width: 1026px;" bgcolor="#5F94C9">                                    
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

 <table style="width: 950px; height: 35px; margin-left: 70px; margin-top: 8px;" 
            frame="box">
          <tr>
            <td style="height: 28px; font-size: 20px; width: 814px;" align="center">
                <asp:Label ForeColor="#000099" ID="Label2" runat="server" Text="Módulo de Admisión"></asp:Label>
            </td> 
            <td>            
                <asp:LinkButton ID="LinkButton1" runat="server">Volver al Inicio</asp:LinkButton>
            </td>          
          </tr>
 </table>
 <table style="margin-left: 70px" bgcolor="White">
         <tr>
            <td style="height: 28px; font-size: 18px; width: 946px;" align="left">
                <asp:Label ForeColor="Blue" ID="Label1" runat="server" Text="Búsqueda de Paciente"></asp:Label>
            </td>
         </tr>
 </table> 
<asp:Panel ID="Panel1" runat="server" Height="83px" Width="953px" 
        style="margin-left: 70px" BackColor="White">
       <div style="text-align: left; width: 955px; height: 76px; margin-left: 0px;">
          <table style="width: 950px; height: 82px">
               <tr>              
                  <td style="width: 445px">                                    
                     <asp:Panel ID="Panel2" runat="server" Height="63px" Width="725px" 
                      CssClass="style14"                     
                            
                          
                          GroupingText="Búsqueda por Apellidos, Nombres, N° de Historia Clínica o DNI" 
                          BackColor="White">
                       <table style="height: 38px; width: 713px; font-size: 15px;">                                                                                                       
                        <tr>
                            <td style="width: 51px; font-size: inherit; height: 30px;">
                                Dato
                            </td>
                            <td style="width: 114px; height: 30px;">
                                <asp:TextBox ID="TxtBuscar" runat="server" Width="609px" 
                                    style="margin-left: 0px"></asp:TextBox>                               
                            </td>
                            <td style="width: 10px; height: 27px; color: #FF0000;">
                                *
                            </td>                          
                        </tr>                                                             
                      </table>                  
                    </asp:Panel>
                   </td>                             
                   <td rowspan="3">
                       <table style="width: 82px; margin-left: 67px; height: 27px;">                            
                             <tr>                                                            
                                   <td style="height: 26px">
                                         <asp:ImageButton ID="ImageButton1" runat="server" Height="37px" 
                                             ImageUrl="~/Iconos/94.png" Width="46px" />
                                   </td>  
                              </tr>                                                             
                             <tr>
                                 <td style="height: 26px">
                                     &nbsp;</td>
                             </tr>
                        </table>
                    </td>                 
               </tr>                 
          </table>       
     </div>    
  </asp:Panel>
 
 
  <asp:Panel ID="Panel3" runat="server" Height="291px" Width="953px" 
        ScrollBars="Vertical" BackColor="White" style="margin-left: 70px" 
        GroupingText="Datos">
     <div style="height: 395px; width: 943px;">  
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
</asp:Content>
