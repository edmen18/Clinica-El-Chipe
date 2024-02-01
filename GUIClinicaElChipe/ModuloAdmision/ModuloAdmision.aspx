<%@ Page Language="VB" MasterPageFile="~/WFPrincipal/PaginaMaestra.master" AutoEventWireup="false" CodeFile="ModuloAdmision.aspx.vb" Inherits="ModuloAdmision_ServicioAdmision" title="Página sin título" MaintainScrollPositionOnPostback="true" %>
<%@ outputcache Location="None" %> 

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Panel ID="Panel5" runat="server" Height="38px" BackColor="#6F81FF"
        style="margin-top: 0px" Width="1141px">   
    <table style="height: 33px; width: 1141px;" bgcolor="#6F81FF">                                    
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
           <td style="width: 702px; height: 4px;">
              <asp:HyperLink ID="HyperLink1" runat="server" 
                   NavigateUrl="~/InicioSesion.aspx">Cerrar Sesion</asp:HyperLink>
            
           </td>                                                   
         </tr>                                                                
    </table>    
</asp:Panel>

<asp:Panel ID="Panel7" runat="server" Height="474px" 
    style="margin-left: 1px; margin-right: 1px">
   <div style="text-align: left; width: 1127px; height: 518px; margin-left: 0px;">
        <table style="width: 909px; height: 35px; margin-left: 67px; margin-top: 11px;" 
            frame="box">
          <tr>
            <td style="height: 28px; font-size: 20px; width: 1027px;" align="center">
                <asp:Label ForeColor="#000099" ID="Label1" runat="server" 
                    Text="ADMISIÓN" Font-Bold="False"></asp:Label>
            </td>           
          </tr>           
        </table>  
        <table border="1"                     
            
            style="background-color: #C4E1FF; font-size: medium; width: 909px; margin-left: 68px;">           
             <tr>             
                <td rowspan="3" style="width: 46px">                        
                    <table bgcolor="White" style="height: 404px; width: 148px">
                        <tr>
                           <td style="height: 1px; font-size: 20px; width: 1027px;" align="center">
                            <asp:Label ForeColor="#000099" ID="Label2" runat="server" 
                                   Text="Procesos de Admisión" Font-Size="Medium"></asp:Label>
                           </td>               
                        </tr>
                        <tr>
                           <td align="center" style="height: 81px">
                               <asp:TreeView ID="TrvProcesoAdmision" runat="server" >
                                   <Nodes>
                                       <asp:TreeNode Text="Módulo Admisión" Value="Módulo Admisión">
                                           <asp:TreeNode Text="Procesos" Value="Procesos"></asp:TreeNode>
                                           <asp:TreeNode Text="Reportes" Value="Reportes"></asp:TreeNode>
                                       </asp:TreeNode>
                                   </Nodes>
                               </asp:TreeView>
                           </td>               
                        </tr>
                        <tr>
                           <td style="height: 28px; font-size: 20px; width: 1027px;" align="center">
                           
                           </td>               
                        </tr>
                    </table>
                </td>
                <td colspan="2" style="height: 21px">
                    <table style="height: 24px; width: 544px;" bgcolor="White">
                      
                       <tr>
                            <td style="width: 1075px">
                                &nbsp;
                            </td>
                            <td style="height: 28px; font-size: 20px; width: 1075px;" align="center">
                            <asp:Label ForeColor="#000099" ID="Label4" runat="server" 
                                    Text="Procesos de Admisión" Font-Size="13pt"></asp:Label>
                            </td>
                            <td style="width: 801px">
                                &nbsp;
                            </td>                                                                      
                        </tr>                                                                            
                    </table>           
                
                    <table style="height: 287px; width: 543px;" bgcolor="White">
                         <tr>
                            <td style="width: 655px; height: 81px;">                               
                            </td>
                            <td style="width: 1223px; height: 81px;" align="center">
                                <asp:LinkButton ID="LinkButton6" runat="server" Font-Underline="false">Historia Clínica del 
                                Paciente</asp:LinkButton>
                               </td>
                            <td style="width: 100px; height: 81px;">
                            </td>
                            <td style="width: 713px; height: 81px;" class="style9" align="center">
                                <asp:LinkButton ID="LinkButton5" runat="server" Font-Underline="false">Solicitud 
                                de Atención</asp:LinkButton>
                            </td>
                            <td style="width: 656px; height: 81px;">
                                
                            </td>
                            <td style="width: 801px; height: 81px;" align="center">                               
                                <asp:LinkButton ID="LinkButton4" runat="server" Font-Underline="false">Reprogramación 
                                de Solicitud de Atención</asp:LinkButton>
                            </td>
                            <td style="width: 2152px; height: 81px;" align="center">
                                
                                <asp:LinkButton ID="LinkButton7" runat="server" Font-Underline="false">Eliminar 
                                solicitud de atención para consultas</asp:LinkButton>
                                
                            </td>
                            <td style="width: 899px; height: 81px;" align="center">
                            </td>                          
                        </tr>
                        <tr>
                            <td style="width: 655px; height: 102px;">
                               
                            </td>
                            <td style="width: 1223px; height: 102px;">
                                <asp:Image ID="Image1" runat="server" Height="77px" Width="78px" />
                            </td>
                            <td style="width: 100px; height: 102px;">
                            </td>
                            <td style="width: 713px; height: 102px;" class="style9">
                                
                                <asp:Image ID="Image2" runat="server" Height="74px" Width="67px" />
                            </td>
                            <td style="width: 656px; height: 102px;">
                                
                            </td>
                            <td style="width: 801px; height: 102px;">
                                
                                <asp:Image ID="Image3" runat="server" Width="68px" />
                            </td>
                            <td style="width: 2152px; height: 102px;">
                                
                                <asp:Image ID="Image6" runat="server" Width="68px" />
                                
                            </td>
                            <td style="width: 899px; height: 102px;">
                                
                            </td>                          
                        </tr>
                        <tr>
                            <td style="width: 655px; height: 37px;">
                                &nbsp;
                            </td>
                            <td style="width: 1223px; height: 37px;">
                                &nbsp;
                                </td>
                            <td style="width: 100px; height: 37px;">
                            </td>
                            <td style="width: 713px; height: 37px;" class="style9">
                                &nbsp;
                            </td>
                            <td style="width: 656px; height: 37px;">
                                &nbsp;
                            </td>
                            <td style="width: 801px; height: 37px;">
                                &nbsp;
                            </td>
                            <td style="width: 2152px; height: 37px;">
                                &nbsp;
                            </td>
                            <td style="width: 899px; height: 37px;">
                                &nbsp;
                            </td>                          
                        </tr>  
                        <tr>
                            <td style="width: 655px">                               
                            </td>
                            <td style="width: 1223px">                                
                                &nbsp;</td>
                            <td style="width: 100px">
                            </td>
                            <td style="width: 713px" class="style9">                               
                            </td>
                            <td style="width: 656px">                               
                            </td>
                            <td style="width: 801px">                                
                            </td>
                            <td style="width: 2152px">                               
                            </td>
                            <td style="width: 899px">                               
                            </td>                           
                        </tr>                                         
                    </table>
               </td>               
               <td rowspan="3" style="width: 46px">                        
                    <table bgcolor="White" style="height: 405px; width: 194px">
                        <tr>
                           <td style="height: 28px; font-size: 20px; width: 1027px;" align="center">
                               <asp:Image ID="Image5" runat="server" Height="379px" Width="174px" />
                           </td>               
                        </tr>                       
                    </table>
                </td>    
            </tr>                 
            <tr>
                 <td colspan="2" style="height: 86px" align="center" bgcolor="White">
                    <asp:Label ID="Label5" runat="server" 
                        
                         Text="En admisión podrá aperturar una historia clínica, registrar una solicitud de atención, reprogramar y eliminar la solicitud de atención que es requerida por los pacientes"></asp:Label>
                </td>
            </tr>
            
        </table>
         
     </div>                 
</asp:Panel>
<body>
</body>
</asp:Content>