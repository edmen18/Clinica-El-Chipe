<%@ Page Language="VB" MasterPageFile="~/WFPrincipal/PaginaMaestra.master" AutoEventWireup="false" CodeFile="ModuloProgramacionMedica.aspx.vb" Inherits="ModuloProgramacionMedica_ModuloProgramacionMedica" title="Página sin título" MaintainScrollPositionOnPostback="true" %>
<%@ PreviousPageType VirtualPath="~/InicioSesion.aspx" %>
<%@ outputcache Location="None" %> 

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Panel ID="Panel5" runat="server" Height="41px" BackColor="#5F94C9"
        style="margin-top: 0px" Width="1146px">   
    <table style="height: 33px; width: 1143px;" bgcolor="#5F94C9">                                    
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

<asp:Panel ID="Panel7" runat="server" Height="470px" 
    style="margin-left: 1px; margin-right: 1px" >
   <div style="text-align: left; width: 1023px; height: 465px; margin-left: 0px;">
        <table style="width: 888px; height: 35px; margin-left: 89px; margin-top: 8px;" 
            frame="box">
          <tr>
            <td style="height: 28px; font-size: 20px; width: 1027px;" align="center">
                <asp:Label ForeColor="#000099" ID="Label1" runat="server" 
                    Text="Programación Médica" Font-Bold="False"></asp:Label>
            </td>           
          </tr>
        </table>  
        <table border="1"                     
            
            style="background-color: #99CCFF; font-size: medium; width: 670px; margin-left: 90px;">           
             <tr>             
             <td rowspan="3" style="width: 46px">                        
                    <table bgcolor="White" style="height: 334px; width: 148px">
                        <tr>
                           <td style="height: 1px; font-size: 20px; width: 1027px;" align="center">
                            <asp:Label ForeColor="#000099" ID="Label2" runat="server" 
                                   Text="Procesos de Programación Médica" Font-Size="Medium"></asp:Label>
                           </td>               
                        </tr>
                        <tr>
                           <td align="center" style="height: 81px">
                               <asp:TreeView ID="TrvProcesoAdmision" runat="server" >
                                   <Nodes>
                                       <asp:TreeNode Text="Módulo P. Médica" Value="Módulo Admisión">
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
                <td colspan="2">
                    <table style="height: 24px; width: 520px;" bgcolor="White">
                      
                       <tr>
                            <td style="width: 1075px">
                                &nbsp;
                            </td>
                            <td style="height: 28px; font-size: 20px; width: 1566px;" align="center">
                            <asp:Label ForeColor="#000099" ID="Label4" runat="server" 
                                    Text="Procesos de la Programación Médica" Font-Size="13pt"></asp:Label>
                            </td>
                            <td style="width: 801px">
                                &nbsp;
                            </td>                                                                      
                        </tr>                                                                            
                    </table>           
                
                    <table style="height: 212px; width: 520px;" bgcolor="White">
                         <tr>
                            <td style="width: 1075px; height: 52px;">                               
                            </td>
                            <td style="width: 1080px; height: 52px;" align="center">
                                <asp:LinkButton ID="LinkButton6" runat="server" Font-Underline="false">Programación 
                                Médica</asp:LinkButton>
                               </td>
                            <td style="width: 100px; height: 52px;">
                            </td>
                            <td style="width: 2029px; height: 52px;" class="style9" align="center">
                                <asp:LinkButton ID="LinkButton5" runat="server" Font-Underline="false">Modificar 
                                y Eliminar Programación Médica para consulta</asp:LinkButton>
                            </td>
                            <td style="width: 1075px; height: 52px;">
                                &nbsp;
                            </td>
                            <td style="width: 801px; height: 52px;" align="center">                               
                                </td>
                            <td style="width: 1075px; height: 52px;">
                                &nbsp;
                            </td>
                            <td style="width: 899px; height: 52px;" align="center">
                                </td>
                            <td style="width: 1075px; height: 52px;">
                                &nbsp;
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 1075px; height: 71px;">
                                &nbsp;
                            </td>
                            <td style="width: 1080px; height: 71px;" align="center">
                                &nbsp;<asp:Image ID="Image1" runat="server" Height="63px" Width="71px" 
                                    ImageUrl="~/Imagenes/PM5.jpg" />
                            </td>
                            <td style="width: 100px; height: 71px;">
                            </td>
                            <td style="width: 2029px; height: 71px;" class="style9" align="center">
                                &nbsp;
                                <asp:Image ID="Image2" runat="server" Height="74px" Width="75px" 
                                    ImageUrl="~/Imagenes/MP1.jpg" />
                            </td>
                            <td style="width: 1075px; height: 71px;">
                                &nbsp;
                                </td>
                            <td style="width: 801px; height: 71px;">
                                &nbsp;
                                </td>
                            <td style="width: 1075px; height: 71px;">
                                &nbsp;
                            </td>
                            <td style="width: 899px; height: 71px;">
                                &nbsp;
                                </td>
                            <td style="width: 1075px; height: 71px;">
                                &nbsp;
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 1075px; height: 13px;">
                                &nbsp;
                            </td>
                            <td style="width: 1080px; height: 13px;">
                                &nbsp;
                                </td>
                            <td style="width: 100px; height: 13px;">
                            </td>
                            <td style="width: 2029px; height: 13px;" class="style9">
                                &nbsp;
                            </td>
                            <td style="width: 1075px; height: 13px;">
                                &nbsp;
                            </td>
                            <td style="width: 801px; height: 13px;">
                                &nbsp;
                            </td>
                            <td style="width: 1075px; height: 13px;">
                                &nbsp;
                            </td>
                            <td style="width: 899px; height: 13px;">
                                &nbsp;
                            </td>
                            <td style="width: 1075px; height: 13px;">
                                &nbsp;
                            </td>
                        </tr>  
                        <tr>
                            <td style="width: 1075px; height: 12px;">                               
                            </td>
                            <td style="width: 1080px; height: 12px;">                                
                            </td>
                            <td style="width: 100px; height: 12px;">
                            </td>
                            <td style="width: 2029px; height: 12px;" class="style9">                               
                            </td>
                            <td style="width: 1075px; height: 12px;">                               
                            </td>
                            <td style="width: 801px; height: 12px;">                                
                            </td>
                            <td style="width: 1075px; height: 12px;">                               
                            </td>
                            <td style="width: 899px; height: 12px;">                               
                            </td>
                            <td style="width: 1075px; height: 12px;">                               
                            </td>
                        </tr>                                         
                    </table>
               </td>               
               <td rowspan="3" style="width: 46px">                        
                    <table bgcolor="White" style="height: 335px; width: 194px">
                        <tr>
                           <td style="height: 28px; font-size: 20px; width: 1027px;" align="center">
                               <asp:Image ID="Image5" runat="server" Height="299px" Width="174px" 
                                   ImageUrl="~/Flash/Fondo-PM.gif" />
                           </td>               
                        </tr>                       
                    </table>
                </td>    
            </tr>                 
            <tr>
                <td colspan="2" style="height: 86px" align="center" bgcolor="White">
                    <asp:Label ID="Label5" runat="server" 
                        Text="En la programación médica podrá registrar el horario de atención de cada uno de los médicos tanto para consulta como para hospitalización. Asi mismo podrá modificar la programación médica en consulta"></asp:Label>
                </td>
            </tr>
            
        </table>       
 
     
                    
    </asp:Panel>
<body>
</body>
</asp:Content>

