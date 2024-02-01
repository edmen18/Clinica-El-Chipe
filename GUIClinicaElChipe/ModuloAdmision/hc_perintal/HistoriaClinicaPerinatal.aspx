<%@ Page Language="VB" MasterPageFile="~/WFPrincipal/PaginaMaestra.master" AutoEventWireup="false" CodeFile="HistoriaClinicaPerinatal.aspx.vb" Inherits="Hospitalizacion_HistoriaClinicaPerinatal" title="Página sin título" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <asp:Panel ID="Panel6" runat="server" Height="41px" BackColor="#5F94C9" 
        style="margin-top: 0px" Width="1145px">   
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
<asp:Panel ID="Panel16" runat="server" > 
 <table style="width: 824px; height: 10px; margin-left: 69px; margin-top: 8px;" 
            frame="box">
          <tr>
            <td style="height: 28px; font-size: 20px; width: 1027px;" align="center">
                <asp:Label ForeColor="#000099" ID="Label2" runat="server" 
                    Text="HOSPITALIZACIÓN"></asp:Label>
            </td>           
          </tr>
 </table>
 <table bgcolor="White" 
        style="height: 0px; margin-bottom: 0px; width: 822px; margin-left: 70px;">
         <tr>
            <td style="height: 20px; font-size: 18px; width: 6964px;" align="left">
                 <asp:Label ForeColor="Blue" ID="Label1" runat="server" 
                     Text="Historia Clínica Perintal"></asp:Label>
                 &nbsp;<asp:Label ID="lblparto" runat="server"></asp:Label>
                 &nbsp;<asp:Label ID="lblam" runat="server"></asp:Label>
                 <asp:Label ID="lblnac" runat="server"></asp:Label>
            </td>
            <td style="height: 20px; font-size: 18px; width: 1027px;" align="left">
                <asp:LinkButton ID="LinkButton1" runat="server">Volver al inicio</asp:LinkButton>
            </td>
         </tr>
 </table>   
 <table border="1"                            
        style="background-color: #99CCFF; font-size: medium; width: 810px; margin-left: 70px; height: 450px;">           
             <tr>                          
                <td style="height: 100px; width: 175px;" >
                <asp:Menu ID="Menu10" Width="810px" runat="server" Orientation="Horizontal" StaticEnableDefaultPopOutImage="False"
                  OnMenuItemClick="Menu1_MenuItemClick" Height="20px">
                   <Items>
                    <%--Add a MenuItem for each tab.--%>
                    <asp:MenuItem ImageUrl="~/Imagenes/Parto.jpg" Value="0" Text=" "></asp:MenuItem>
                    <asp:MenuItem ImageUrl="~/Imagenes/Antecedentes.jpg" Text=" " Value="1"></asp:MenuItem>
                    <asp:MenuItem ImageUrl="~/Imagenes/Nacimiento.jpg" Text=" " Value="2"></asp:MenuItem>
                   </Items>
                </asp:Menu>
                
                <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
                <%--Add View controls, one for each 'tab'.--%>
                <asp:View ID="ViewParto" runat="server" >                
                 
                    <table height="400" cellpadding=0 cellspacing=0 
                        style="width: 807px; height: 50px;">
                        <tr valign="top">
                            <td style="width: 578px">
                              <asp:Panel ID="Panel3" runat="server" CssClass="style16" 
                        GroupingText="Datos del Paciente" Height="45px" Width="810px" BackColor="White">
                        <table bgcolor="White" style="height: 23px; width: 802px; margin-left: 0px;">
                            <tr>
                                <td style="width: 2529px">
                                    &nbsp;
                                    <asp:Label ID="Label42" runat="server" Text="Paciente"></asp:Label>
                                </td>
                                <td style="width: 5987px">
                                    <asp:Label ID="LblPaciente" runat="server"></asp:Label>
                                </td>
                                <td style="width: 2210px">
                                     <asp:Label ID="lblcodpaciente" runat="server"></asp:Label>
                                </td>
                                <td style="width: 702px">
                                    &nbsp;
                                    </td>
                                 <td style="width: 219px" align="center">
                                     &nbsp;</td>
                                <td style="width: 722px">
                                    &nbsp;
                                    </td>
                            </tr>
                        </table>                    
                    </asp:Panel>
                    </td>
                                              
                    </tr>
                   </table> 
                   <table cellpadding=0 cellspacing=0 style="width: 807px; height: 102px;">
                        <tr valign="top">
                            <td style="width: 578px">
                      <asp:Panel ID="Panel2" runat="server" CssClass="style16" Height="182px" Width="393px" 
                                    BackColor="White" GroupingText="Tipo de Parto">
                        <table bgcolor="White" style="height: 72px; width: 375px; margin-left: 0px;">
                            <tr>
                                <td style="width: 219px">
                                    <asp:CheckBoxList ID="tipoparto" runat="server" Height="129px">
                                        <asp:ListItem>Espontaneo</asp:ListItem>
                                        <asp:ListItem>Forceps Bajo</asp:ListItem>
                                        <asp:ListItem>Vacuon Electivo</asp:ListItem>
                                        <asp:ListItem>Cesarea Primaria Elect</asp:ListItem>
                                        <asp:ListItem>Cesarea Iteractiva Elect</asp:ListItem>
                                        <asp:ListItem>Cesaria de Emergencia</asp:ListItem>
                                    </asp:CheckBoxList>
                                    <br />
                                    &nbsp;&nbsp;</td>                                                         
                            </tr>
                        </table> 
                    </asp:Panel>                  
                    </td>
                    <td>
                    <asp:Panel ID="Panel19" runat="server" CssClass="style16" 
                        GroupingText="Anestesia" Height="184px" Width="414px" BackColor="White">
                        <table bgcolor="White" style="height: 165px; width: 405px; margin-left: 0px;">
                            <tr>
                                <td style="width: 2973px; height: 14px;">
                                </td>
                                <td style="width: 5987px; height: 14px;">
                                    <asp:Label ID="Label49" runat="server" Text="Drogas"></asp:Label>
                                </td>                                
                            </tr>
                            <tr>
                                <td style="width: 2973px">
                                    <asp:CheckBoxList ID="chkanestecia" runat="server">
                                        <asp:ListItem>Epidural</asp:ListItem>
                                        <asp:ListItem>Raquidea</asp:ListItem>
                                        <asp:ListItem>Bloque</asp:ListItem>
                                        <asp:ListItem>General</asp:ListItem>
                                    </asp:CheckBoxList>
                                    <br />
                                </td>
                                <td style="width: 5987px">
                                    <asp:TextBox ID="TextBox1" runat="server" Height="127px" TextMode="MultiLine"></asp:TextBox>
                                </td>                                
                            </tr>
                        </table>                    
                    </asp:Panel> 
                    </td>            
                    </tr>
                    </table>
                     <table cellpadding=0 cellspacing=0 style="width: 807px; height: 102px;">
                        <tr valign="top">
                            <td style="width: 578px">
                      <asp:Panel ID="Panel20" runat="server" CssClass="style16" Height="182px" Width="393px" 
                                    BackColor="White" GroupingText="Líquido Amniótico">
                        <table bgcolor="White" style="height: 72px; width: 375px; margin-left: 0px;">
                            <tr>
                                <td style="width: 219px">
                                    <asp:Label ID="lblclaro" runat="server" Text="Claro"></asp:Label>
                                </td>
                                <td>
                                
                                    <asp:TextBox ID="txtclaro" runat="server"></asp:TextBox>
                                
                                </td>                                                         
                            </tr>
                            <tr>
                                <td style="width: 219px">
                                    <asp:Label ID="lblmclaro" runat="server" Text="Meconial Claro"></asp:Label>
                                </td>
                                <td>
                                
                                    <asp:TextBox ID="txtmclaro" runat="server"></asp:TextBox>
                                
                                </td>                                                         
                            </tr>
                            <tr>
                                <td style="width: 219px">
                                    <asp:Label ID="lblmespeso" runat="server" Text="Meconial Espeso"></asp:Label>
                                </td>
                                <td>
                                
                                    <asp:TextBox ID="txtmespeso" runat="server" Height="22px" Width="128px"></asp:TextBox>
                                
                                </td>                                                         
                            </tr>
                            <tr>
                                <td style="width: 219px">
                                    <asp:Label ID="lblfetido" runat="server" Text="Fétido"></asp:Label>
                                </td>
                                <td>
                                
                                    <asp:TextBox ID="txtfetido" runat="server" Height="22px" Width="128px"></asp:TextBox>
                                
                                </td>                                                         
                            </tr>
                            <tr>
                                <td style="width: 219px">
                                    <asp:Label ID="lblmfetido" runat="server" Text="Fétido Meconial"></asp:Label>
                                </td>
                                <td>
                                
                                    <asp:TextBox ID="txtmfetido" runat="server"></asp:TextBox>
                                
                                </td>                                                         
                            </tr>
                            <tr>
                                <td style="width: 219px">
                                    <asp:Label ID="lblhemorragia" runat="server" Text="Hemorragia"></asp:Label>
                                </td>
                                <td>
                                
                                    <asp:TextBox ID="txthemorragia" runat="server"></asp:TextBox>
                                
                                </td>                                                         
                            </tr>
                        </table> 
                    </asp:Panel>                  
                    </td>
                    <td>
                    <asp:Panel ID="Panel21" runat="server" CssClass="style16" 
                        GroupingText="Cordón Umbilical y Placenta" Height="184px" Width="414px" 
                            BackColor="White">
                        <table bgcolor="White" style="height: 165px; width: 405px; margin-left: 0px;">
                            <tr>
                                <td style="width: 3381px; height: 14px;">
                                    <asp:Label ID="lblcordon" runat="server" Text="Cordón Umbilical"></asp:Label>
                                </td>
                                <td style="width: 5987px; height: 14px;">
                                    &nbsp;</td>  
                                 <td style="width: 5987px; height: 14px;">
                                     &nbsp;</td>
                                 <td style="width: 5987px; height: 14px;">
                                     &nbsp;</td>
                                 <td style="width: 5987px; height: 14px;">
                                     &nbsp;</td> 
                                 <td style="width: 5987px; height: 14px;">
                                     &nbsp;</td> 
                                                            
                            </tr>
                             <tr>
                                <td style="width: 3381px; height: 14px;">
                                    <asp:Label ID="lblpatologico" runat="server" Text="Patológico"></asp:Label>
                                </td>
                                <td style="width: 5987px; height: 14px;">
                                    <asp:TextBox ID="txtpatologico" runat="server" Width="43px"></asp:TextBox>
                                </td>  
                                 <td style="width: 5987px; height: 14px;">
                                     <asp:Label ID="lblnormal" runat="server" Text="Normal"></asp:Label>
                                </td>
                                 <td style="width: 5987px; height: 14px;">
                                     <asp:TextBox ID="txtnormal" runat="server" Width="64px"></asp:TextBox>
                                </td>
                                 <td style="width: 5987px; height: 14px;">
                                     &nbsp;</td> 
                                 <td style="width: 5987px; height: 14px;">
                                     &nbsp;</td> 
                                                              
                            </tr>
                             <tr>
                                <td style="width: 3381px; height: 14px;">
                                    <asp:Label ID="lblplacenta" runat="server" Text="Placenta"></asp:Label>
                                </td>
                                <td style="width: 5987px; height: 14px;">
                                    &nbsp;</td>  
                                 <td style="width: 5987px; height: 14px;">
                                     &nbsp;</td>
                                 <td style="width: 5987px; height: 14px;">
                                     &nbsp;</td>
                                 <td style="width: 5987px; height: 14px;">
                                     &nbsp;</td> 
                                 <td style="width: 5987px; height: 14px;">
                                     &nbsp;</td> 
                                                             
                            </tr>
                            <tr>
                                <td style="width: 3381px; height: 14px;">
                                    <asp:Label ID="lblplanormal" runat="server" Text="Normal"></asp:Label>
                                </td>
                                <td style="width: 5987px; height: 14px;">
                                    <asp:TextBox ID="txtplanormal" runat="server" Width="43px"></asp:TextBox>
                                </td>  
                                 <td style="width: 5987px; height: 14px;">
                                     <asp:Label ID="lblpatolo" runat="server" Text="Patolo"></asp:Label>
                                </td>
                                 <td style="width: 5987px; height: 14px;">
                                     <asp:TextBox ID="txtpatolo" runat="server" Width="43px"></asp:TextBox>
                                </td>
                                 <td style="width: 5987px; height: 14px;">
                                     <asp:Label ID="lblpeso" runat="server" Text="Peso"></asp:Label>
                                </td>  
                                 <td style="width: 5987px; height: 14px;">
                                     <asp:TextBox ID="txtpeso" runat="server" Width="52px"></asp:TextBox>
                                </td> 
                                                            
                            </tr>
                            
                        </table>                    
                    </asp:Panel>
                    
                    
                    </td>            
                    </tr>
                    </table>
                     <table cellpadding=0 cellspacing=0 style="width: 807px; height: 102px;">
                        <tr valign="top">
                            <td style="width: 578px">
                      <asp:Panel ID="Panel22" runat="server" CssClass="style16" Height="189px" Width="393px" 
                                    BackColor="White" GroupingText="Reanimación">
                        <table bgcolor="White" style="height: 72px; width: 375px; margin-left: 0px;">
                           <tr>
                           <td>
                           
                               <asp:RadioButtonList ID="rbreanimacion" runat="server" AutoPostBack="True" 
                                   RepeatDirection="Horizontal" Width="144px">
                                   <asp:ListItem Value="A. Espontáneo">Si</asp:ListItem>
                                   <asp:ListItem>No</asp:ListItem>
                               </asp:RadioButtonList>
                           
                           </td>
                           </tr>
                            <tr>
                                <td style="width: 219px">
                                    <asp:CheckBoxList ID="chkreanimar" runat="server">
                                        <asp:ListItem>Oxigeno</asp:ListItem>
                                        <asp:ListItem>Mascara</asp:ListItem>
                                        <asp:ListItem>Bolsa y Mascara</asp:ListItem>
                                        <asp:ListItem>Intubacion</asp:ListItem>
                                        <asp:ListItem>Otros</asp:ListItem>
                                    </asp:CheckBoxList>
                                </td>                                                         
                            </tr>
                        </table> 
                    </asp:Panel>                  
                    </td>
                    <td>
                    <asp:Panel ID="Panel23" runat="server" CssClass="style16" 
                        GroupingText="Drogas Usadas" Height="188px" Width="414px" BackColor="White">
                        <table bgcolor="White" style="height: 170px; width: 405px; margin-left: 0px;">
                            
                            <tr>
                                <td style="width: 2973px">
                                    <asp:CheckBoxList ID="chkdrogas" runat="server">
                                        <asp:ListItem>Adrenalina</asp:ListItem>
                                        <asp:ListItem>Bicarbonato</asp:ListItem>
                                        <asp:ListItem>Calcio</asp:ListItem>
                                        <asp:ListItem>Glucosa</asp:ListItem>
                                        <asp:ListItem>Otros</asp:ListItem>
                                    </asp:CheckBoxList>
                                </td>
                                <td style="width: 5987px">
                                    <br />
                                    <br />
                                    <br />
                                    <br />
                                    <br />
                                    <br />
                                    <asp:TextBox ID="txtotros" runat="server"></asp:TextBox>
                                </td>                                
                            </tr>
                        </table>                    
                    </asp:Panel> 
                    </td>            
                    </tr>
                    </table>
                  
                              
                      
                      <table>
                       <tr>
                        <td>  
                        <asp:Panel ID="Panel17" runat="server" CssClass="style16" Height="53px" 
                        Width="810px" BackColor="White">
                            <div style="text-align: left; width: 801px; height: 76px; margin-left: 0px;">
                               <table style="width: 799px; height: 50px">
                                <tr>
                                    <td style="width: 445px">                                      
                                        &nbsp;</td>  
                                    <td style="width: 445px" align="center">                                      
                                        <asp:ImageButton ID="BtnRegistrarConsulta" runat="server" Height="30px" 
                                            ImageUrl="~/Iconos/21.png" Width="36px" />
                                        <br />
                                        <asp:Label ID="Label43" runat="server" Text="Registrar"></asp:Label>
                                    </td>                                    
                                    <td style="width: 445px">                                      
                                        &nbsp;</td>                                 
                                    </tr>
                                  </table>
                                 </div>
                               </asp:Panel>  
                             </td>
                             </tr>
                             </table>
                                
                                             
                </asp:View>
                <asp:View ID="ViewAntecedentesMaternos" runat="server">
                    <table cellpadding=0 cellspacing=0 style="width: 805px; height: 462px;">
                        <tr valign="top">
                            <td style="width: 578px">
                    <asp:Panel ID="Panel7" runat="server" CssClass="style16" 
                        GroupingText="Antecedentes Maternos" Height="104px" Width="810px" BackColor="White">
                        <table bgcolor="White" style="height: 87px; width: 801px; margin-left: 0px;">
                            <tr>
                                <td style="width: 219px; height: 7px;">
                                    <asp:Label ID="Label57" runat="server" Text="Gestación"></asp:Label>
                                </td>
                                <td style="width: 702px; height: 7px;">
                                    &nbsp;
                                    <asp:TextBox ID="txtgestacion" runat="server" Width="94px"></asp:TextBox>
                                </td>                              
                                <td style="width: 219px; height: 7px;">
                                    <asp:Label ID="Label58" runat="server" Text="Paridad"></asp:Label>
                                </td>
                                <td style="width: 2720px; height: 7px;">
                                    &nbsp;
                                    <asp:TextBox ID="txtparidad" runat="server" Width="94px"></asp:TextBox>
                                </td>                              
                                 <td style="width: 219px; height: 7px;">
                                     &nbsp;<asp:Label ID="Label59" runat="server" Text="Término"></asp:Label>
                                </td>
                                <td style="width: 702px; height: 7px;">
                                    &nbsp;
                                    <asp:TextBox ID="txttermino" runat="server"></asp:TextBox>
                                </td> 
                                <td style="width: 702px; height: 7px;">
                                    &nbsp;
                                    </td>                                                           
                            </tr>
                            <tr>
                                <td style="width: 219px">
                                    <asp:Label ID="Label60" runat="server" Text="Prematuros"></asp:Label>
                                </td>
                                <td style="width: 702px">
                                    &nbsp;
                                    <asp:TextBox ID="txtprematuros" runat="server" Width="107px"></asp:TextBox>
                                </td>
                                <td style="width: 219px">
                                    <asp:Label ID="Label61" runat="server" Text="Abortos"></asp:Label>
                                </td>
                                <td style="width: 2720px">
                                    &nbsp;
                                    <asp:TextBox ID="txtabortos" runat="server" Width="87px"></asp:TextBox>
                                </td>                              
                                 <td style="width: 219px">
                                     &nbsp;
                                     <asp:Label ID="Label62" runat="server" Text="Obito"></asp:Label>
                                </td>
                                <td style="width: 702px">
                                    &nbsp;
                                    <asp:TextBox ID="txtobito" runat="server"></asp:TextBox>
                                </td>  
                                <td style="width: 702px; height: 17px;">
                                    &nbsp;
                                    </td>                                                           
                            </tr>
                        </table>
                        <table bgcolor="White" style="height: 39px; width: 802px; margin-left: 0px;">
                            <tr>
                                <td style="width: 219px; height: 7px;">
                                    <asp:Label ID="Label3" runat="server" Text="Factores Médicos de Riesgo"></asp:Label>
                                </td> 
                                <td style="width: 219px; height: 7px;">
                                    <asp:RadioButtonList ID="RadioButtonList4" runat="server" AutoPostBack="True" 
                                        RepeatDirection="Horizontal" Width="144px">
                                        <asp:ListItem Value="A. Espontáneo">Si</asp:ListItem>
                                        <asp:ListItem>No</asp:ListItem>
                                    </asp:RadioButtonList>
                                </td>                                                                                     
                            </tr>                                                   
                        </table>
                        <table bgcolor="White" style="height: 39px; width: 802px; margin-left: 0px;">
                            <tr>
                                <td style="width: 219px; height: 7px;">
                                    <asp:TextBox ID="rtfactoresriesgo" runat="server" Height="63px" TextMode="MultiLine" 
                                        Width="733px"></asp:TextBox>
                                </td>                                                                                                                  
                            </tr>                                                   
                        </table>  
                         <table bgcolor="White" style="height: 44px; width: 802px; margin-left: 0px;">
                            <tr>
                                <td style="width: 251px; height: 7px;">
                                    <asp:Label ID="lbltg" runat="server" Text="Tiempo de Gestación"></asp:Label>
                                </td> 
                                <td style="width: 219px; height: 7px;">
                                    <asp:TextBox ID="txttiempogestacion" runat="server"></asp:TextBox>
                                </td>  
                                 <td style="width: 219px; height: 7px;">
                                    <asp:Label ID="lblsemanas" runat="server" Text="Semanas"></asp:Label>
                                </td>
                                 <td style="width: 219px; height: 7px;">
                                    <asp:Label ID="lblcpn" runat="server" Text="CPN"></asp:Label>
                                </td>
                                 <td style="width: 219px; height: 7px;">
                                     <asp:RadioButtonList ID="RadioButtonList5" runat="server" AutoPostBack="True" 
                                         RepeatDirection="Horizontal" Width="144px">
                                         <asp:ListItem Value="A. Espontáneo">Si</asp:ListItem>
                                         <asp:ListItem>No</asp:ListItem>
                                     </asp:RadioButtonList>
                                </td>                                                                                   
                            </tr>                           
                        </table> 
                         <table bgcolor="White" style="height: 47px; width: 802px; margin-left: 0px;">
                            <tr>
                                <td style="width: 219px; height: 7px;">
                                    <asp:Label ID="Label17" runat="server" Text="Patología de Embarazo"></asp:Label>
                                </td> 
                                <td style="width: 219px; height: 7px;">
                                    <asp:TextBox ID="txtpatologiaembarazo" runat="server"></asp:TextBox>
                                </td>  
                                 <td style="width: 219px; height: 7px;">
                                    <asp:Label ID="Label19" runat="server" Text="Ant.Fam. Patología"></asp:Label>
                                </td>
                                 <td style="width: 219px; height: 7px;">
                                     <asp:TextBox ID="txtantecedentes" runat="server"></asp:TextBox>
                                </td>                                                                                                                 
                            </tr>                           
                        </table>
                           <table bgcolor="White" style="height: 43px; width: 802px; margin-left: 0px;">
                            <tr>
                                <td style="width: 219px; height: 7px;">
                                    <asp:Label ID="Label21" runat="server" Text="Fecha de Parto"></asp:Label>
                                </td> 
                                <td style="width: 219px; height: 7px;">
                                    <asp:TextBox ID="txtfechaparto" runat="server"></asp:TextBox>
                                </td>  
                                 <td style="width: 219px; height: 7px;">
                                    <asp:Label ID="Label23" runat="server" Text="Hora de Parto"></asp:Label>
                                </td>
                                 <td style="width: 219px; height: 7px;">
                                     <asp:TextBox ID="txthoraparto" runat="server"></asp:TextBox>
                                </td>                                                                                                                 
                            </tr>                           
                        </table> 
                        <table bgcolor="White" style="height: 35px; width: 802px; margin-left: 0px;">
                            <tr>
                                <td style="width: 373px; height: 7px;">
                                    <asp:Label ID="Label25" runat="server" Text="Indicio de labor de parto"></asp:Label>
                                </td> 
                                <td style="width: 219px; height: 7px;" align="center">
                                    <asp:Label ID="lblinducida" runat="server" Text="Inducidad"></asp:Label>
                                </td>  
                                 <td style="width: 219px; height: 7px;">
                                     <asp:TextBox ID="txtinducida" runat="server"></asp:TextBox>
                                </td>
                                 <td style="width: 219px; height: 7px;">
                                    <asp:Label ID="lblexpontanea" runat="server" Text="Expontánea"></asp:Label>
                                </td> 
                                <td style="width: 219px; height: 7px;">
                                    <asp:TextBox ID="txtexpontanea" runat="server"></asp:TextBox>
                                </td>                                                                                                                
                            </tr>                           
                        </table>  
                           <table bgcolor="White" style="height: 35px; width: 802px; margin-left: 0px;">
                            <tr>
                                <td style="width: 236px; height: 7px;">
                                    <asp:Label ID="Label30" runat="server" Text="RPM Características"></asp:Label>
                                </td> 
                                <td style="width: 219px; height: 7px;">
                                    <asp:TextBox ID="txtcaracteristicas" runat="server" Width="527px"></asp:TextBox>
                                </td>                                                                                                                                                   
                            </tr>                           
                        </table>    
                           <table bgcolor="White" style="height: 40px; width: 802px; margin-left: 0px;">
                            <tr>
                                <td style="width: 237px; height: 7px;">
                                    <asp:Label ID="Label35" runat="server" Text="Drogas durante la labor de Parto"></asp:Label>
                                </td> 
                                <td style="width: 219px; height: 7px;">
                                    <asp:TextBox ID="txtdrogas" runat="server" Width="527px"></asp:TextBox>
                                </td>                                                                                                                                                   
                            </tr>                           
                        </table> 
                                                                                                     
                    </asp:Panel>
                            </td>
                        </tr>
                       
                    </table> 
                    <table>
                       <tr>
                        <td>  
                        <asp:Panel ID="Panel1" runat="server" CssClass="style16" Height="53px" 
                        Width="810px" BackColor="White">
                            <div style="text-align: left; width: 801px; height: 76px; margin-left: 0px;">
                               <table style="width: 799px; height: 50px">
                                <tr>
                                    <td style="width: 445px">                                      
                                        &nbsp;</td>  
                                    <td style="width: 445px" align="center">                                      
                                        <asp:ImageButton ID="ImageButton1" runat="server" Height="30px" 
                                            ImageUrl="~/Iconos/21.png" Width="36px" />
                                        <br />
                                        <asp:Label ID="Label41" runat="server" Text="Registrar"></asp:Label>
                                    </td>                                    
                                    <td style="width: 445px">                                      
                                        &nbsp;</td>                                 
                                    </tr>
                                  </table>
                                 </div>
                               </asp:Panel>  
                             </td>
                             </tr>
                             </table>                  
                </asp:View>
                <asp:View ID="ViewNacimiento" runat="server">
                    <table width="578" height="400" cellpadding=0 cellspacing=0>
                        <tr valign="top">
                            <td style="width: 578px">
 
 
  <asp:Panel ID="Panel4" runat="server" Height="202px" Width="810px" 
        CssClass="style16" BackColor="White" GroupingText="Recién Nacido">
      <table bgcolor="White" style="height: 24px; width: 797px; margin-left: 0px;">
          <tr>
              <td style="width: 886px">
                  &nbsp;
                  <asp:Label ID="Label31" runat="server" Text="E. Gest"></asp:Label>
              </td>
              <td style="width: 702px">
                  &nbsp;
                  <asp:TextBox ID="txtegest" runat="server" Width="150px"></asp:TextBox>
              </td>
              <td style="width: 1414px">
                  <asp:Label ID="Label32" runat="server" Text="Sem (Por Ex. Físico)"></asp:Label>
              </td>
              <td style="width: 702px">
                  &nbsp;
                  <asp:Label ID="Label90" runat="server" Text="Nombre"></asp:Label>
              </td>
              <td style="width: 702px">
                  &nbsp;
                  <asp:TextBox ID="txtnombre" runat="server"></asp:TextBox>
              </td>
              <td style="width: 702px">
                  &nbsp;
              </td>
              <td style="width: 702px">
                  &nbsp;
              </td>
          </tr>
      </table>
      <table bgcolor="White" style="height: 71px; width: 799px; margin-left: 0px;">
          <tr>
              <td style="width: 203px">
                  <asp:Label ID="Label34" runat="server" Text="Sexo"></asp:Label>
              </td>
              <td style="width: 434px">
                  <asp:DropDownList ID="ddsexo" runat="server" Width="50px">
                      <asp:ListItem>M</asp:ListItem>
                      <asp:ListItem>F</asp:ListItem>
                  </asp:DropDownList>
              </td>
              <td align="center" style="width: 219px">
                  <asp:Label ID="Label63" runat="server" Text="Talla"></asp:Label>                 
              </td>
              <td style="width: 219px">
                  <asp:TextBox ID="txttalla" runat="server" Width="60px"></asp:TextBox>
              </td>
              <td style="width: 219px">
                  <asp:Label ID="Label64" runat="server" Text="Peso"></asp:Label>
              </td>
                  <td style="width: 219px">
                      <asp:TextBox ID="txtpesorn" runat="server" Width="60px"></asp:TextBox>
              </td>
                  <td style="width: 203px">
                  <asp:Label ID="Label13" runat="server" Text="PC"></asp:Label>
              </td>
              <td style="width: 434px">
                  <asp:TextBox ID="txtpc" runat="server" Width="60px"></asp:TextBox>
              </td>
              <td align="center" style="width: 219px">
                  <asp:Label ID="Label16" runat="server" Text="P. TX"></asp:Label>               
              </td>
              <td style="width: 219px">
                  <asp:TextBox ID="txtptx" runat="server" Width="60px"></asp:TextBox>
              </td>
              <td style="width: 219px">
                  <asp:Label ID="Label18" runat="server" Text="P.ABD"></asp:Label>
              </td>
                  <td style="width: 219px">
                      <asp:TextBox ID="txtpab" runat="server" Width="60px"></asp:TextBox>
              </td>
          </tr>
           <tr>
              <td style="width: 203px">
                  <asp:Label ID="Label4" runat="server" Text="FC"></asp:Label>
              </td>
              <td style="width: 434px">
                  <asp:TextBox ID="txtfc" runat="server" Width="60px"></asp:TextBox>
              </td>
              <td align="center" style="width: 219px">
                  <asp:Label ID="Label65" runat="server" Text="ER"></asp:Label>
              </td>
              <td style="width: 219px">
                  <asp:TextBox ID="txter" runat="server" Width="60px"></asp:TextBox>
              </td>
              <td style="width: 219px">
                  <asp:Label ID="Label66" runat="server" Text="TM"></asp:Label>
              </td>
              <td style="width: 219px">
                  <asp:TextBox ID="txttm" runat="server" Width="60px"></asp:TextBox>
              </td>
              <td style="width: 203px">
                  <asp:Label ID="Label20" runat="server" Text="REF"></asp:Label>
              </td>
              <td style="width: 434px">
                  <asp:TextBox ID="txtref" runat="server" Width="60px"></asp:TextBox>
              </td>
              <td align="center" style="width: 219px">
                  <asp:Label ID="Label22" runat="server" Text="COL"></asp:Label>                  
              </td>
              <td style="width: 219px">
                  <asp:TextBox ID="txtcol" runat="server" Width="60px"></asp:TextBox>
              </td>
              <td style="width: 219px">
                  <asp:Label ID="Label24" runat="server" Text="T"></asp:Label>
              </td>
                  <td style="width: 219px">
                      <asp:TextBox ID="txtt" runat="server" Width="60px"></asp:TextBox>
              </td>
          </tr>
      </table>
      <table>
       <tr>
         <td>
         
             <asp:Label ID="Label67" runat="server" Text="Observaciones"></asp:Label>
         
         </td>         
       </tr>
        <tr>
         <td>
         
             <asp:TextBox ID="TextBox41" runat="server" Height="51px" TextMode="MultiLine" 
                 Width="776px"></asp:TextBox>
         
         </td>         
       </tr>
      </table>
  </asp:Panel>   
  <asp:Panel ID="Panel5" runat="server" Height="411px" Width="810px" 
        CssClass="style16" BackColor="White" GroupingText="Exámen Físico">
      <table bgcolor="White" style="height: 71px; width: 799px; margin-left: 0px;">
          <tr>
              <td style="width: 203px">
                  <asp:Label ID="lblaspectofisico" runat="server" Text="Aspecto General"></asp:Label>
              </td>
              <td style="width: 434px">
                  <asp:Label ID="lblpiel" runat="server" Text="Piel"></asp:Label>
              </td>
              <td style="width: 219px" align="left">
                  <asp:Label ID="lblccuello" runat="server" Text="Cabeza y Cuello"></asp:Label>
              </td>                         
          </tr>
         <tr>
              <td style="width: 203px">
                  <asp:TextBox ID="txtaspecto" runat="server" Height="51px" TextMode="MultiLine" 
                      Width="260px"></asp:TextBox>
              </td>
              <td style="width: 434px">
                  <asp:TextBox ID="txtpiel" runat="server" Height="51px" TextMode="MultiLine" 
                      Width="260px"></asp:TextBox>
              </td>
              <td style="width: 219px" align="center">
                  <asp:TextBox ID="txtcabeza" runat="server" Height="51px" TextMode="MultiLine" 
                      Width="260px"></asp:TextBox>
              </td>                         
          </tr>
           <tr>
              <td style="width: 203px">
                  <asp:Label ID="lblojos" runat="server" Text="Ojos"></asp:Label>
              </td>
              <td style="width: 434px">
                  <asp:Label ID="lblnariz" runat="server" Text="Oido, Nariz, Garganta"></asp:Label>
              </td>
              <td style="width: 219px" align="left">
                  <asp:Label ID="lbltorax" runat="server" Text="Torax"></asp:Label>
              </td>                         
          </tr>
         <tr>
              <td style="width: 203px">
                  <asp:TextBox ID="txtojos" runat="server" Height="51px" TextMode="MultiLine" 
                      Width="260px"></asp:TextBox>
              </td>
              <td style="width: 434px">
                  <asp:TextBox ID="txtoido" runat="server" Height="51px" TextMode="MultiLine" 
                      Width="260px"></asp:TextBox>
              </td>
              <td style="width: 219px" align="center">
                  <asp:TextBox ID="txttorax" runat="server" Height="51px" TextMode="MultiLine" 
                      Width="260px"></asp:TextBox>
              </td>                         
          </tr>
           <tr>
              <td style="width: 203px">
                  <asp:Label ID="lblpulmones" runat="server" Text="Pulmones"></asp:Label>
              </td>
              <td style="width: 434px">
                  <asp:Label ID="lblcorazon" runat="server" Text="Corazón"></asp:Label>
              </td>
              <td style="width: 219px" align="center">
                  <asp:Label ID="lblabdomen" runat="server" Text="Abdomen"></asp:Label>
              </td>                         
          </tr>
         <tr>
              <td style="width: 203px">
                  <asp:TextBox ID="txtpulmones" runat="server" Height="51px" TextMode="MultiLine" 
                      Width="260px"></asp:TextBox>
              </td>
              <td style="width: 434px">
                  <asp:TextBox ID="txtcorazon" runat="server" Height="51px" TextMode="MultiLine" 
                      Width="260px"></asp:TextBox>
              </td>
              <td style="width: 219px" align="center">
                  <asp:TextBox ID="txtabdomen" runat="server" Height="51px" TextMode="MultiLine" 
                      Width="260px"></asp:TextBox>
              </td>                         
          </tr>
           <tr>
              <td style="width: 203px">
                  <asp:Label ID="lblcolumna" runat="server" Text="Columna"></asp:Label>
              </td>
              <td style="width: 434px">
                  <asp:Label ID="lblextremidades" runat="server" Text="Extremidades"></asp:Label>
              </td>
              <td style="width: 219px" align="center">
                  <asp:Label ID="lblneuro" runat="server" Text="Neurológico"></asp:Label>
              </td>                         
          </tr>
         <tr>
              <td style="width: 203px">
                  <asp:TextBox ID="txtcolumna" runat="server" Height="51px" TextMode="MultiLine" 
                      Width="260px"></asp:TextBox>
              </td>
              <td style="width: 434px">
                  <asp:TextBox ID="txtextremidades" runat="server" Height="51px" TextMode="MultiLine" 
                      Width="260px"></asp:TextBox>
              </td>
              <td style="width: 219px" align="center">
                  <asp:TextBox ID="txtneurologico" runat="server" Height="51px" TextMode="MultiLine" 
                      Width="260px"></asp:TextBox>
              </td>                         
          </tr>
           <tr>
              <td style="width: 203px">
                  <asp:Label ID="lblano" runat="server" Text="Ano"></asp:Label>
              </td>
              <td style="width: 434px">
                  <asp:Label ID="Label89" runat="server" Text="Observaciones"></asp:Label>
              </td>
              <td style="width: 219px" align="center">
              </td>                         
          </tr>
         <tr>
              <td style="width: 203px">
                  <asp:TextBox ID="txtano" runat="server" Height="51px" TextMode="MultiLine" 
                      Width="260px"></asp:TextBox>
              </td>
              <td style="width: 434px">
                  <asp:TextBox ID="txtobservaciones" runat="server" Height="51px" TextMode="MultiLine" 
                      Width="260px"></asp:TextBox>
              </td>
              <td style="width: 219px" align="center">
              </td>                         
          </tr>
      </table>
     
  </asp:Panel>         
  
  <asp:Panel ID="Panel8" runat="server" Height="70px" Width="810px" 
        CssClass="style16" BackColor="White" GroupingText="Diagnóstico">
      <table bgcolor="White" style="height: 51px; width: 799px; margin-left: 0px;">
          <tr>
              <td style="width: 203px">
                  <asp:Label ID="Label27" runat="server" Text="A)"></asp:Label>
              </td>
              <td style="width: 434px">
                  <asp:Label ID="Label29" runat="server" Text="B)"></asp:Label>
              </td>
              <td style="width: 434px">
                  <asp:Label ID="Label33" runat="server" Text="C)"></asp:Label>
              </td>
                                     
          </tr>
         <tr>
              <td style="width: 203px">
                  <asp:DropDownList ID="dddiag1" runat="server" Width="250px">
                  </asp:DropDownList>
              </td>
              <td style="width: 434px">
                  <asp:DropDownList ID="dddiag2" runat="server" Width="250px">
                  </asp:DropDownList>
              </td>    
               <td style="width: 434px">
                  <asp:DropDownList ID="dddiag3" runat="server" Width="250px">
                  </asp:DropDownList>
              </td>                               
          </tr>
      </table>
     
  </asp:Panel>   
  
                
                     <asp:Panel ID="Panel9" runat="server" Height="53px" Width="810px" 
        CssClass="style16" BackColor="White">
     <div style="height: 76px; width: 803px; text-align: left; margin-left: 0px;">  
         <table style="width: 800px; height: 50px">
             <tr>
                 <td style="width: 445px">
                 </td>
                 <td align="center" style="width: 445px">
                     <asp:ImageButton ID="BtnRegistrarReceta" runat="server" Height="30px" 
                         ImageUrl="~/Iconos/21.png" Width="36px" />
                     <br />
                     <asp:Label ID="Label48" runat="server" Text="Registrar"></asp:Label>
                 </td>
                 <td style="width: 445px">
                     &nbsp;</td>
             </tr>
         </table>
    </div>  
  </asp:Panel> 
                            </td>
                        </tr>
                        
                        
                    </table>
                   </asp:View>          
            </asp:MultiView>        
                
                
             
             
             
             
             
                   
                     
       
                                                             
                  
               </td>              
      
            </tr>                             
        </table>      
</asp:Panel>   
     
</asp:Content>

