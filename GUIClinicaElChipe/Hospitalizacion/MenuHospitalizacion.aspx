<%@ Page Language="VB" MasterPageFile="~/WFPrincipal/PaginaMaestra.master" AutoEventWireup="false" CodeFile="MenuHospitalizacion.aspx.vb" Inherits="Hospitalizacion_MenuHospitalizacion" title="Página sin título" MaintainScrollPositionOnPostback="true" %>
<%@ outputcache Location="None" %> 
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Panel ID="Panel5" runat="server" Height="41px" BackColor="#5F94C9"
        style="margin-top: 0px" Width="1026px">   
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
        <table style="width: 888px; height: 35px; margin-left: 67px; " 
            frame="box">
          <tr>
            <td style="height: 28px; font-size: 20px; width: 1027px;" align="center">
                <asp:Label ForeColor="#000099" ID="Label1" runat="server" 
                    Text="Módulo de Hospitalización" Font-Bold="False"></asp:Label>
            </td>           
          </tr>           
        </table>  
        <table border="1"                     
            style="background-color: #99CCFF; font-size: medium; width: 670px; margin-left: 68px;">           
             <tr>             
                <td rowspan="3" style="width: 46px">                        
                    <table bgcolor="#DBEFF7" style="height: 404px; width: 148px">
                        <tr>
                           <td style="height: 1px; font-size: 20px; width: 1027px;" align="center">
                            <asp:Label ForeColor="#000099" ID="Label2" runat="server" 
                                   Text="Procesos de Hospitalización" Font-Size="Medium"></asp:Label>
                           </td>               
                        </tr>
                        <tr>
                           <td align="center" style="height: 81px">
                               &nbsp;</td>               
                        </tr>
                        <tr>
                           <td style="height: 28px; font-size: 20px; width: 1027px;" align="center">
                           
                           </td>               
                        </tr>
                    </table>
                </td>
                <td colspan="2" style="height: 21px">
                    <table style="height: 24px; width: 520px;" bgcolor="#DBEFF7">
                      
                       <tr>
                            <td style="width: 1075px">
                                &nbsp;
                            </td>
                            <td style="height: 28px; font-size: 20px; width: 1075px;" align="center">
                            <asp:Label ForeColor="#000099" ID="Label4" runat="server" 
                                    Text="Procesos de Hospitalización" Font-Size="13pt"></asp:Label>
                            </td>
                            <td style="width: 801px">
                                &nbsp;
                            </td>                                                                      
                        </tr>                                                                            
                    </table>           
                
                    <table style="height: 287px; width: 520px;" bgcolor="#DBEFF7">
                         <tr>
                            <td style="width: 1075px">                               
                            </td>
                            <td style="width: 1223px" align="center">
                                <asp:LinkButton ID="LinkButton6" runat="server" Font-Underline="false" 
                                    PostBackUrl="~/Hospitalizacion/Hospitalizacion.aspx">Hospitalizacion</asp:LinkButton>
                               </td>
                            <td style="width: 100px">
                            </td>
                            <td style="width: 713px" class="style9" align="center">
                                <asp:LinkButton ID="LinkButton5" runat="server" Font-Underline="false" 
                                    PostBackUrl="~/Hospitalizacion/ReporteOperatorio.aspx">Reporte Operatorio</asp:LinkButton>
                            </td>
                            <td style="width: 1075px">
                                
                            </td>
                            <td style="width: 801px" align="center">                               
                                <asp:LinkButton ID="LinkButton3" runat="server" Font-Underline="false" 
                                    PostBackUrl="~/Hospitalizacion/EvolucionMedica.aspx">Evolución</asp:LinkButton>
                            </td>
                            <td style="width: 1075px">
                                
                            </td>
                            <td style="width: 899px" align="center">
                                <asp:LinkButton ID="LinkButton4" runat="server" Font-Underline="false" 
                                    PostBackUrl="~/Hospitalizacion/PrescripcionOrden.aspx">Prescripción Médica</asp:LinkButton>
                            </td>
                            <td style="width: 1075px">
                                
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 1075px">
                               
                            </td>
                            <td style="width: 1223px">
                                <asp:Image ID="Image1" runat="server" Height="77px" Width="78px" />
                            </td>
                            <td style="width: 100px">
                            </td>
                            <td style="width: 713px" class="style9">
                                
                                <asp:Image ID="Image2" runat="server" Height="74px" Width="67px" />
                            </td>
                            <td style="width: 1075px">
                                
                            </td>
                            <td style="width: 801px">
                                
                                <asp:Image ID="Image3" runat="server" Width="68px" />
                            </td>
                            <td style="width: 1075px">
                                
                            </td>
                            <td style="width: 899px">
                                
                                <asp:Image ID="Image4" runat="server" Height="74px" Width="67px" />
                            </td>
                            <td style="width: 1075px">
                                
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 1075px; height: 37px;">
                                &nbsp;
                            </td>
                            <td style="width: 1223px; height: 37px;">
                                &nbsp;
                                <asp:LinkButton ID="LinkButton7" runat="server" Font-Underline="false" 
                                    PostBackUrl="~/Hospitalizacion/Epicrisis.aspx">Epicrisis</asp:LinkButton>
                            </td>
                            <td style="width: 100px; height: 37px;">
                            </td>
                            <td style="width: 713px; height: 37px;" class="style9">
                                &nbsp;
                                <asp:LinkButton ID="LinkButton8" runat="server" Font-Underline="false" 
                                    PostBackUrl="~/Hospitalizacion/InformeAlta.aspx">Informe Médico</asp:LinkButton>
                            </td>
                            <td style="width: 1075px; height: 37px;">
                                &nbsp;
                            </td>
                            <td style="width: 801px; height: 37px;">
                                &nbsp;
                                <asp:HyperLink ID="HyperLink2" runat="server">Cambio de Tratamiento</asp:HyperLink>
                            </td>
                            <td style="width: 1075px; height: 37px;">
                                &nbsp;
                            </td>
                            <td style="width: 899px; height: 37px;">
                                &nbsp;
                            </td>
                            <td style="width: 1075px; height: 37px;">
                                &nbsp;
                            </td>
                        </tr>  
                        <tr>
                            <td style="width: 1075px">                               
                            </td>
                            <td style="width: 1223px">                                
                                <asp:Image ID="Image6" runat="server" Height="75px" style="margin-left: 5px" 
                                    Width="71px" />
                            </td>
                            <td style="width: 100px">
                            </td>
                            <td style="width: 713px" class="style9">                               
                            </td>
                            <td style="width: 1075px">                               
                            </td>
                            <td style="width: 801px">                                
                            </td>
                            <td style="width: 1075px">                               
                            </td>
                            <td style="width: 899px">                               
                            </td>
                            <td style="width: 1075px">                               
                            </td>
                        </tr>                                         
                    </table>
               </td>               
               <td rowspan="3" style="width: 46px">                        
                    <table bgcolor="#DBEFF7" style="height: 405px; width: 194px">
                        <tr>
                           <td style="height: 28px; font-size: 20px; width: 1027px;" align="center">
                               <asp:Image ID="Image5" runat="server" Height="379px" Width="174px" />
                           </td>               
                        </tr>                       
                    </table>
                </td>    
            </tr>                 
            <tr>
                <td colspan="2" style="height: 21px">
                    <asp:TextBox ID="TextBox1" runat="server" TextMode="MultiLine" Height="83px" 
                        Width="517px"></asp:TextBox>
                </td>
            </tr>
            
        </table>
         
     </div>                 
</asp:Panel>
<body onload="if(history.length>0)history.go(+1)">
</body>></body>
</asp:Content>

