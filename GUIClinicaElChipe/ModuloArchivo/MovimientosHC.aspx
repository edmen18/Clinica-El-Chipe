<%@ Page Language="VB" MasterPageFile="~/WFPrincipal/PaginaMaestra.master" AutoEventWireup="false" CodeFile="MovimientosHC.aspx.vb" Inherits="ModuloArchivo_MovimientosHC" title="Página sin título" MaintainScrollPositionOnPostback="true" %>
<%@ PreviousPageType VirtualPath="~/ModuloArchivo/BusquedaParaArchivo.aspx" %>

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

<asp:Panel ID="Panel6" runat="server" Height="458px" 
        style="margin-top: 0px" Width="1026px">  

 <table style="width: 710px; height: 10px; margin-left: 70px; margin-top: 8px;" 
            frame="box">
          <tr>
            <td style="height: 28px; font-size: 20px; width: 598px;" align="center">
                <asp:Label ForeColor="#000099" ID="Label2" runat="server" 
                    Text="Módulo de Archivo"></asp:Label>
            </td>
                     
          </tr>
 </table>
 <table bgcolor="#DBEFF7" 
        style="height: 0px; margin-bottom: 0px; width: 710px; margin-left: 70px;">
         <tr>
            <td style="height: 20px; font-size: 18px; width: 2782px;" align="left">
                 <asp:Label ForeColor="Blue" ID="Label1" runat="server" 
                     Text="Movimientos de Historias Clínicas"></asp:Label>
            </td>
            <td style="height: 20px; font-size: 18px; width: 1901px;" align="left">
                
            </td>
          
            <td style="height: 20px; font-size: 18px; width: 800px;" align="left">
                 <asp:LinkButton ID="LinkButton1" runat="server">Volver al Inicio</asp:LinkButton>
            </td>
         </tr>
 </table>
 
   
        <table border="1"                     
            style="background-color: #99CCFF; font-size: medium; width: 670px; margin-left: 68px;">           
             <tr>                          
                <td style="width: 600px" >
                    <asp:Panel ID="Panel7" runat="server" CssClass="style11" 
                        GroupingText="Datos de la Historia Clínica" Height="106px" Width="699px">
                        <table bgcolor="#DBEFF7" style="height: 41px; width: 689px; margin-left: 0px;">
                            <tr>
                                <td style="width: 219px">
                                    &nbsp; Apellidos y Nombres</td>
                                <td style="width: 702px">
                                    &nbsp;
                                    <asp:Label ID="LblPaciente" runat="server"></asp:Label>
                                </td>
                            </tr>
                        </table>
                        <table bgcolor="#DBEFF7" style="height: 41px; width: 688px;">
                            <tr>
                                <td style="width: 1075px">
                                    <asp:Label ID="Label9" runat="server" Text="Historia N°"></asp:Label>
                                </td>
                                <td style="width: 702px">
                                    &nbsp;
                                    <asp:Label ID="LblNHC" runat="server"></asp:Label>
                                </td>
                                <td style="width: 1075px">
                                    &nbsp; 
                                    <asp:Label ID="Label17" runat="server" Text="Num. Ticket"></asp:Label>
                                </td>
                                <td class="style9" style="width: 772px">
                                    &nbsp;
                                    <asp:Label ID="LblNumTicket" runat="server" Text="Label"></asp:Label>
                                    </td>                             
                                <td style="width: 801px">
                                    &nbsp;
                                    <asp:Label ID="Label18" runat="server" Text="Especialidad"></asp:Label>
                                    </td>                               
                                <td style="width: 899px">
                                    &nbsp;
                                    <asp:Label ID="LblEspecialidad" runat="server" Text="Label"></asp:Label>
                                    </td>
                                <td style="width: 899px">
                                    &nbsp;
                                   
                                    <asp:Label ID="LblCodEspecialidad" runat="server"></asp:Label>
                                   
                                    </td>
                            </tr>
                        </table>
                    </asp:Panel>
                    <asp:Panel ID="Panel8" runat="server" CssClass="style11" 
                        GroupingText="Datos del Servicio" Height="84px" Width="699px">
                        <table bgcolor="#DBEFF7" style="height: 54px; width: 687px; margin-left: 0px;">
                            <tr>
                                <td style="width: 1075px">
                                    <asp:Label ID="Label16" runat="server" Text="De"></asp:Label>
                                </td>
                                <td class="style9" style="width: 772px">
                                    <asp:Label ID="LblDe" runat="server" Text="Label"></asp:Label>
                                </td>
                                <td style="width: 942px">
                                    <asp:Label ID="Label19" runat="server" Text="A"></asp:Label>
                                </td>
                                <td style="width: 702px">                                    
                                    <asp:DropDownList ID="DdArea" runat="server">
                                    </asp:DropDownList>
                                </td>
                                <td class="style9" style="width: 772px">                                                                      
                                    &nbsp;</td>
                            </tr>
                        </table>                       
                    </asp:Panel>
                    <asp:Panel ID="Panel9" runat="server" CssClass="style11" Height="53px" 
                        Width="699px">
                        <div style="text-align: left; width: 695px; height: 76px; margin-left: 0px;">
                            <table style="width: 694px; height: 50px">
                                <tr>
                                    <td style="width: 445px">                                      
                                    </td>  
                                    <td style="width: 445px">                                      
                                        <asp:Button ID="BtnRegistrar" runat="server" style="margin-left: 70px" 
                                            Text="Enviar" Width="71px" />
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
     </asp:Panel>
</asp:Content>

