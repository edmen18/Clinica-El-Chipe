<%@ Page Language="VB" MasterPageFile="~/WFPrincipal/PaginaMaestra.master" AutoEventWireup="false" CodeFile="HistoriaClinica.aspx.vb" Inherits="ModuloAdmision_HistoriaClinica" title="Página sin título" MaintainScrollPositionOnPostback="true"%>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Panel ID="Panel5" runat="server" Height="41px" BackColor="#5F94C9" 
        style="margin-top: 0px" Width="1141px">   
    <table style="height: 33px; width: 1141px;" bgcolor="#5F94C9">                                    
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
           <td style="width: 831px; height: 4px;">           
               <asp:Label ID="LblTurno" runat="server"></asp:Label>
               <asp:Label ID="LblCT" runat="server" Visible="False"></asp:Label>
           </td>                                                            
         </tr>                                                                
    </table>    
</asp:Panel>

 <table style="width: 872px; height: 10px; margin-left: 70px; margin-top: 8px;" 
            frame="box">
          <tr>
            <td style="height: 28px; font-size: 20px; width: 1027px;" align="center">
                <asp:Label ForeColor="#000099" ID="Label3" runat="server" Text="Módulo de Admisión"></asp:Label>
           
            </td>           
          </tr>
 </table>
 <table bgcolor="#DBEFF7" 
        style="height: 0px; margin-bottom: 0px; width: 871px; margin-left: 70px;">
         <tr>
            <td style="height: 20px; font-size: 18px; width: 13389px;" align="left">
                 <asp:Label ForeColor="Blue" ID="Label5" runat="server" 
                     Text="Apertura de Historia Clínica"></asp:Label>
            </td>
            <td style="height: 20px; font-size: 18px; width: 1901px;" align="left">
                
                <asp:LinkButton ID="LinkButton1" runat="server">Volver al inicio</asp:LinkButton>
                
            </td>         
         </tr>
 </table>
 
 
<asp:Panel ID="Panel7" runat="server" Height="686px" 
    style="margin-left: 72px; margin-right: 1px" Width="870px" >
   <div style="text-align: left; width: 874px; height: 666px; margin-left: 0px;"> 
        <table border="1"                     
            
            style="background-color: #99CCFF; font-size: medium; width: 670px; margin-left: 0px;">           
             <tr>             
               <td colspan="2" style="height: 21px">
                 <table style="height: 24px; width: 740px;" bgcolor="#DBEFF7">
                   <tr>
                     <td style="width: 1075px">
                       <asp:Panel ID="Panel6" runat="server" Height="55px" Width="728px" 
                        CssClass="style17" GroupingText="Datos Generales" style="margin-left: 3px" 
                        BorderStyle="Solid" BorderWidth="1px" BackColor="White">
                        <table style="height: 34px; width: 720px;" bgcolor="White">                                    
                          <tr>
                            <td style="width: 1409px; height: 4px;">
                                <asp:Label ID="Label13" runat="server" Text="Historia Clínica N°"></asp:Label>
                            </td>                           
                            <td style="width: 1075px; height: 4px;">                                
                                <asp:Label ID="LblNHistoriaClinica" runat="server"></asp:Label>
                            </td> 
                             <td style="width: 1409px; height: 4px;">
                                <asp:Label ID="Label9" runat="server" Text="Fecha de Apertura"></asp:Label>
                            </td>                           
                            <td style="width: 1075px; height: 4px;">                                
                                <asp:Label ID="LblFechaApertura" runat="server"></asp:Label>
                                &nbsp;<asp:Label ID="LblCodDireccion" runat="server" Text="Label"></asp:Label>
                            </td> 
                          </tr>                                                                                                               
                       </table>
                      </asp:Panel>
                     </td>                   
                                                                                                                   
                    </tr> 
                    
                    
                    <tr>
                      
                     <td style="width: 1075px">
                       <asp:Panel ID="Panel1" runat="server" Height="98px" Width="728px" 
                        CssClass="style17" GroupingText="Datos del Seguro" style="margin-left: 3px" 
                        BorderStyle="Solid" BorderWidth="1px" BackColor="White">
                        <table style="height: 34px; width: 720px;" bgcolor="White">                                    
                          <tr>
                            <td style="width: 462px; height: 4px;">
                                <asp:Label ID="Label7" runat="server" Text="Seguro"></asp:Label>
                            </td>                           
                            <td style="width: 1208px; height: 4px;">                                
                                <asp:DropDownList ID="DdSeguro" runat="server" Height="21px" Width="120px" 
                                    Enabled="False" AutoPostBack="True">
                                </asp:DropDownList>
                                <asp:Label ID="LblCodRegistroSeguro" runat="server" Text="Label"></asp:Label>
                            </td> 
                            <td style="width: 312px; height: 4px;" align="center">
                                <asp:Label ID="Label1" runat="server" Text="Autogenerado (SIS)" Visible="False"></asp:Label>
                            </td>                           
                            <td style="width: 1980px; height: 4px;">                                
                                <asp:Label ID="LblNumAutogenerado" runat="server" Text="Label" Visible="False"></asp:Label>
                                <br />
                                <asp:DropDownList ID="DdAutogenerado" runat="server" AutoPostBack="True" 
                                    Height="21px" Width="59px" Enabled="False" Visible="False">
                                </asp:DropDownList>
                            </td>
                            <td style="width: 405px; height: 4px;">                               
                                <br />
                                <asp:TextBox ID="TextBox1" runat="server" Width="50px" Visible="False"></asp:TextBox>
                            </td>
                            <td style="width: 702px; height: 4px;">                                
                                <br />
                                <asp:TextBox ID="TextBox2" runat="server" Width="105px" Visible="False"></asp:TextBox>
                            </td>                                                                           
                          </tr>                                                                
                       </table>
                        <table style="height: 33px; width: 720px;" bgcolor="White">                                                          
                          <tr>
                            <td style="width: 1255px; height: 4px;">
                                <asp:Label ID="Label11" runat="server" Text="Fecha Afiliación" Visible="False"></asp:Label>
                            </td>                           
                            <td style="width: 1075px; height: 4px;">
                                &nbsp;
                                <asp:TextBox ID="TxtFechaAfiliacion" runat="server" Width="156px" 
                                    Enabled="False" Visible="False"></asp:TextBox>
                            </td>
                            <td style="width: 1152px; height: 4px;">
                                &nbsp;
                                <asp:Label ID="Label14" runat="server" Text="Fecha Vencimiento" Visible="False"></asp:Label>
                            </td>
                            <td style="width: 702px; height: 4px;">
                                &nbsp;
                                <asp:TextBox ID="TxtFechaVencimiento" runat="server" Width="156px" 
                                    Enabled="False" Visible="False"></asp:TextBox>
                            </td>                                                    
                          </tr>                                                                
                       </table>
                      </asp:Panel>
                     </td>
                    
                    
                    
                    </tr>                                  
                                                                                            
                   </table>                 
                   
                   
                   
                   
                   
                        
                    <table style="height: 371px; width: 740px; margin-left: 0px;" 
                       bgcolor="#DBEFF7">
                         <tr>
                            <td style="width: 1075px"> 
                             <asp:Panel ID="Panel2" runat="server" Height="202px" Width="728px" 
                        CssClass="style17" GroupingText="Datos del Paciente" style="margin-left: 3px" 
                        BorderStyle="Solid" BorderWidth="1px">
                        <table style="height: 34px; width: 720px;" bgcolor="#DBEFF7">                                    
                          <tr>
                            <td style="width: 1409px; height: 4px;">
                                <asp:Label ID="Label2" runat="server" Text="Apellido Paterno"></asp:Label>
                            </td>                           
                            <td style="width: 1075px; height: 4px;">
                                
                                
                                <asp:Label ID="Label24" runat="server" Text="Apellido Materno"></asp:Label>
                                
                                
                            </td> 
                            <td style="width: 1409px; height: 4px;">
                                <asp:Label ID="Label19" runat="server" Text="Nombres"></asp:Label>
                            </td> 
                            <td style="width: 1409px; height: 4px;">
                                &nbsp;</td>                                                                            
                          </tr>    
                          <tr>
                            <td style="width: 1409px; height: 4px;">
                                <asp:TextBox ID="TxtApellidoPaterno" runat="server" Width="210px" 
                                    Enabled="False" CssClass="Mayuscula"></asp:TextBox>
                            </td>                           
                            <td style="width: 1075px; height: 4px;">
                                    <asp:TextBox ID="TxtApellidoMaterno" runat="server" Width="210px" 
                                        Enabled="False" CssClass="Mayuscula"></asp:TextBox>                              
                            </td> 
                            <td style="width: 1409px; height: 4px;">
                                <asp:TextBox ID="TxtNombres" runat="server" Width="210px" Enabled="False" 
                                    CssClass="Mayuscula"></asp:TextBox>
                            </td> 
                            <td style="width: 1409px; height: 4px;">
                                <asp:Label ID="LblCodPaciente" runat="server">Label</asp:Label>
                            </td>                                                                                                    
                          </tr>                                                             
                       </table>
                        <table style="height: 52px; width: 721px;" bgcolor="#DBEFF7">                                    
                          <tr>
                            <td style="width: 892px; height: 4px;">
                                <asp:Label ID="Label4" runat="server" Text="Fecha Nac."></asp:Label>
                            </td>                           
                            <td style="width: 1426px; height: 6px;">                                
                            
                                <asp:TextBox ID="TxtFechaNacimiento" runat="server" Width="121px" 
                                    Enabled="False"></asp:TextBox>
                            
                            </td> 
                            <td style="width: 675px; height: 4px;">                               
                                 <asp:Label ID="Label26" runat="server" Text="Edad"></asp:Label>
                            </td>  
                            <td style="width: 702px; height: 4px;">                               
                                  <asp:Label ID="LblEdad" runat="server"></asp:Label>
                            </td>  
                            <td style="width: 675px; height: 4px;">                               
                                  <asp:Label ID="Label16" runat="server" Text="Sexo"></asp:Label>
                            </td>  
                            <td style="width: 702px; height: 4px;">                               
                                  <asp:DropDownList ID="DdSexo" runat="server" Height="21px" Width="51px" 
                                      Enabled="False">
                                  </asp:DropDownList>
                            </td>     
                            <td style="width: 675px; height: 4px;">                               
                                  <asp:Label ID="Label20" runat="server" Text="Estado Civil"></asp:Label>
                            </td>  
                            <td style="width: 702px; height: 4px;">                               
                                   <asp:DropDownList ID="DdEstadoCivil" runat="server" Enabled="False" 
                                       Height="21px" Width="163px">
                                   </asp:DropDownList>
                            </td>                                                                                                                                                        
                          </tr>                                                                                      
                       </table>
                         <table style="height: 33px; width: 720px;" bgcolor="#DBEFF7">                                    
                          <tr>
                            <td style="width: 744px; height: 4px;">
                                <asp:Label ID="Label8" runat="server" Text="Ocupación"></asp:Label>
                            </td>                           
                            <td style="width: 1075px; height: 4px;">                                
                                <asp:TextBox ID="TxtOcupacion" runat="server" Width="150px" Enabled="False"></asp:TextBox>
                            </td>
                            <td style="width: 405px; height: 4px;">                             
                                <asp:Label ID="Label21" runat="server" Text="Tipo Doc. Identidad"></asp:Label>
                            </td>
                            <td style="width: 702px; height: 4px;">                               
                                <asp:DropDownList ID="DdTipoDocIdentidad" runat="server" Height="21px" 
                                    Width="203px" Enabled="False" AutoPostBack="True">
                                </asp:DropDownList>
                            </td>  
                            <td style="width: 702px; height: 4px;">                               
                                <asp:Label ID="Label27" runat="server" Text="N°"></asp:Label>
                            </td> 
                             <asp:TextBox ID="txtNumeros" runat="server"></asp:TextBox>                                                     
                                                        
                            <td style="width: 702px; height: 4px;">                               
                                <asp:TextBox ID="TxtNumero" runat="server" Width="124px" Enabled="False" 
                                    AutoPostBack="True">
                                </asp:TextBox>                             
                            </td>
                                                                                                             
                          </tr>                                                                                      
                       </table>
                        <table style="height: 33px; width: 720px;" bgcolor="#DBEFF7">                                    
                          <tr>
                            <td style="width: 1189px; height: 4px;">
                                <asp:Label ID="Label22" runat="server" Text="Teléfono"></asp:Label>
                            </td>                           
                            <td style="width: 1075px; height: 4px;">                                
                                <asp:TextBox ID="TxtTelefono" runat="server" Width="150px" Enabled="False"></asp:TextBox>
                            </td>
                            <td style="width: 405px; height: 4px;">                             
                                <asp:Label ID="Label28" runat="server" Text="Celular"></asp:Label>
                            </td>
                            <td style="width: 702px; height: 4px;">                               
                                <asp:TextBox ID="TxtCelular" runat="server" Enabled="False"></asp:TextBox>
                                </td>  
                            <td style="width: 702px; height: 4px;">                               
                                <asp:Label ID="Label29" runat="server" Text="Email"></asp:Label>
                            </td>  
                            <td style="width: 702px; height: 4px;">                               
                                <asp:TextBox ID="TxtEmail" runat="server" Enabled="False" Width="183px"></asp:TextBox>
                            </td>                                                                                 
                          </tr>                                                                                      
                       </table>                       
                      </asp:Panel>                              
                            </td>
                           
                        </tr>
                        <tr>
                            <td style="width: 1075px">
                                     <asp:Panel ID="Panel3" runat="server" Height="190px" Width="728px" 
                        CssClass="style17" GroupingText="Datos de la Dirección" style="margin-left: 3px" 
                        BorderStyle="Solid" BorderWidth="1px">
                        <table style="height: 34px; width: 720px;" bgcolor="#DBEFF7">                                    
                          <tr>
                            <td style="width: 1874px; height: 4px;">
                                <asp:Label ID="Label10" runat="server" Text="País"></asp:Label>
                            </td>                           
                            <td style="width: 324px; height: 4px;">
                                <asp:Button ID="BtnBuscaPais" runat="server" Text="..." Enabled="False" />
                            </td> 
                            <td style="width: 1001px; height: 4px;">
                                <asp:Label ID="Label30" runat="server" Text="Departamento"></asp:Label>
                            </td> 
                            <td style="width: 436px; height: 4px;">
                                &nbsp;
                                <asp:Button ID="BtnBuscaDepa" runat="server" Text="..." Enabled="False" />
                            </td>
                            <td style="width: 1409px; height: 4px;">
                                <asp:Label ID="Label32" runat="server" Text="Provincia"></asp:Label>
                            </td>                           
                            <td style="width: 325px; height: 4px;">
                                <asp:Button ID="BtnBuscaProvincia" runat="server" Text="..." Enabled="False" />
                            </td>                                                                                                      
                          </tr>                                                                
                       </table>
                       <table style="height: 34px; width: 720px;" bgcolor="#DBEFF7">                                    
                          <tr>
                            <td style="width: 1862px; height: 4px;">
                                <asp:DropDownList ID="DdPais" runat="server" Height="21px" 
                                    Width="210px" Enabled="False" AutoPostBack="True">
                                </asp:DropDownList>
                            </td>                           
                            <td style="width: 2313px; height: 4px;">
                                <asp:DropDownList ID="DdDepartamento" runat="server" Height="21px" 
                                    Width="210px" Enabled="False" AutoPostBack="True">
                                </asp:DropDownList>
                            </td> 
                            <td style="width: 1409px; height: 4px;">
                                <asp:DropDownList ID="DdProvincia" runat="server" Height="21px" 
                                    Width="210px" Enabled="False" AppendDataBoundItems="True" 
                                    AutoPostBack="True">
                                </asp:DropDownList>
                            </td>                           
                                                                                                  
                          </tr>                                                                
                       </table>
                         <table style="height: 34px; width: 720px;" bgcolor="#DBEFF7">                                    
                          <tr>
                            <td style="width: 1460px; height: 4px;">
                                <asp:Label ID="Label6" runat="server" Text="Distrito"></asp:Label>
                            </td>                           
                            <td style="width: 324px; height: 4px;">
                                <asp:Button ID="BtnBuscaDistrito" runat="server" Text="..." Enabled="False" />
                            </td> 
                            <td style="width: 1337px; height: 4px;">
                                <asp:Label ID="Label15" runat="server" Text="Centro Poblado"></asp:Label>
                            </td> 
                            <td style="width: 436px; height: 4px;">
                                &nbsp;
                                <asp:Button ID="BtnBuscaCentroPoblado" runat="server" Text="..." 
                                    Enabled="False" />
                            </td>
                            <td style="width: 1450px; height: 4px;">
                                <asp:Label ID="Label17" runat="server" Text="Lugar de Origen"></asp:Label>
                            </td>                           
                            <td style="width: 325px; height: 4px;">
                                &nbsp;
                                <asp:Button ID="BtnBuscaLugarOrigen" runat="server" Text="..." 
                                    Enabled="False" />
                            </td>                                                                                                      
                          </tr>                                                                
                       </table>
                       <table style="height: 34px; width: 720px;" bgcolor="#DBEFF7">                                    
                          <tr>
                            <td style="width: 1862px; height: 4px;">
                                <asp:DropDownList ID="DdDistrito" runat="server" Height="21px" 
                                    Width="210px" Enabled="False" AutoPostBack="True">
                                </asp:DropDownList>
                            </td>                           
                            <td style="width: 2313px; height: 4px;">
                                <asp:DropDownList ID="DdCentroPoblado" runat="server" Height="21px" 
                                    Width="210px" Enabled="False" AutoPostBack="True">
                                </asp:DropDownList>
                            </td> 
                            <td style="width: 1409px; height: 4px;">
                                <asp:DropDownList ID="DdLugarOrigen" runat="server" Height="21px" 
                                    Width="210px" Enabled="False" AutoPostBack="True">
                                </asp:DropDownList>
                            </td>                           
                                                                                                  
                          </tr>                                                                
                       </table>
                       <table style="height: 34px; width: 720px;" bgcolor="#DBEFF7">                                    
                          <tr>
                            <td style="width: 3046px; height: 4px;">                            
                                <asp:Label ID="Label12" runat="server" Text="Nombre de"></asp:Label>                            
                            </td>                           
                            <td style="width: 1409px; height: 4px;">                            
                                <asp:DropDownList ID="DdDato1" runat="server" Height="21px" Width="88px" 
                                    Enabled="False" AutoPostBack="True">
                                </asp:DropDownList>
                            </td> 
                            <td style="width: 1409px; height: 4px;">                            
                                <asp:TextBox ID="TxtDato1" runat="server" Width="156px" Enabled="False"></asp:TextBox>
                            </td> 
                            <td style="width: 1409px; height: 4px;">                            
                                <asp:DropDownList ID="DdDato2" runat="server" Height="21px" AutoPostBack="True" 
                                    Enabled="False">
                                </asp:DropDownList>
                            </td> 
                            <td style="width: 1409px; height: 4px;">                            
                                <asp:TextBox ID="TxtDato2" runat="server" Enabled="False"></asp:TextBox>
                            </td>
                            <td style="width: 1409px; height: 4px;">                            
                                <asp:Label ID="Label35" runat="server" Text="Lote" Visible="False"></asp:Label>
                            </td>
                            <td style="width: 1409px; height: 4px;">                            
                                <asp:TextBox ID="TxtLote" runat="server" Width="32px" 
                                    AutoCompleteType="Disabled" Visible="False"></asp:TextBox>
                            </td>                                                                                                 
                          </tr>                                                                
                       </table>
                      </asp:Panel>
                            </td>                           
                                                            
                        </tr>
                        
                        <tr>
                        
                            
                            <td style="width: 1075px">
                       <asp:Panel ID="Panel4" runat="server" Height="70px" Width="728px" 
                        CssClass="style17" GroupingText="Usuario" style="margin-left: 3px" 
                        BorderStyle="Solid" BorderWidth="1px">
                        <table style="height: 34px; width: 720px;" bgcolor="#DBEFF7">                                    
                          <tr>
                            <td style="width: 61px; height: 4px;">
                                <asp:Label ID="Label18" runat="server" Text="Usuario"></asp:Label>
                            </td>                           
                            <td style="width: 4942px; height: 4px;">                                
                                <asp:Label ID="LblUsuario" runat="server">Label</asp:Label>
                                &nbsp;</td> 
                            <td style="width: 195px; height: 4px;">
                                <asp:Label ID="Label23" runat="server" Text="Clave"></asp:Label>
                                &nbsp;</td>                           
                            <td style="width: 1075px; height: 4px;">                                
                                <asp:Label ID="LblClave" runat="server"></asp:Label>
                            </td>                                                                           
                          </tr> 
                          <tr>
                            <td style="width: 61px; height: 4px;">
                                
                                <asp:Label ID="LblCodUsuario" runat="server" Text="Label" Visible="False"></asp:Label>
                                
                            </td>                           
                            <td style="width: 4942px; height: 4px;">                                
                               
                                <asp:Label ID="LblAutogenerado" runat="server" Text="Label"></asp:Label>
                                <asp:Label ID="LblCodEstadoCivil" runat="server" Text="Label"></asp:Label>
                                <asp:Label ID="LblCodSeguro" runat="server" Text="Label"></asp:Label>
                                <asp:Label ID="LblAutoge" runat="server" Text="Label"></asp:Label>
                                &nbsp;<asp:Label ID="LblCodTipoDocIdentidad" runat="server" Text="Label"></asp:Label>
                               
                                <asp:Label ID="LblPaciente" runat="server" Text="Label"></asp:Label>
                                <asp:Label ID="LblNumero" runat="server" Text="Label"></asp:Label>
                               
                            </td> 
                            <td style="width: 195px; height: 4px;">
                                
                                &nbsp;</td>                           
                            <td style="width: 1075px; height: 4px;">                                
                               
                            </td>                                                                           
                          </tr>                                                               
                       </table>
                       
                      </asp:Panel>
                     </td>  
                        </tr>
                        
                        
                        
                                                                
                    </table>
               </td>               
               <td rowspan="3" style="width: 46px">                        
                    <table bgcolor="#DBEFF7" style="height: 670px; width: 111px">
                        <tr>
                           <td style="height: 9px; font-size: 20px; width: 1027px;" align="center">
                               <asp:Label ID="Label25" runat="server" Text="Opciones" Font-Size="12pt"></asp:Label>
                           </td>               
                        </tr> 
                        <tr>
                           <td align="center" style="height: 1px">
                               <asp:ImageButton ID="BtnNuevo" runat="server" ImageUrl="~/Iconos/32.png" 
                                   ToolTip="Aperturar una Historia Clínica" />
                               <br />
                               <asp:Label ID="Label36" runat="server" Text="Nuevo"></asp:Label>
                           </td>               
                        </tr>  
                        <tr>
                            <td align="center" style="height: 1px">
                               <asp:ImageButton ID="BtnRegistrar" runat="server" ImageUrl="~/Iconos/21.png" 
                                    ToolTip="Registrar una Historia Clínica" />
                                <br />
                                <asp:Label ID="Label37" runat="server" Text="Registrar"></asp:Label>
                           </td>               
                        </tr> 
                        <tr>
                           <td align="center" style="height: 1px">
                               <asp:ImageButton ID="BtnBuscar" runat="server" ImageUrl="~/Iconos/94.png" 
                                   ToolTip="Buscar a un Paciente" />
                               <br />
                               <asp:Label ID="Label38" runat="server" Text="Buscar"></asp:Label>
                               <br />
                               <br />
                               <asp:ImageButton ID="BtnHuella" runat="server" Height="35px" 
                                   ImageUrl="~/Iconos/b_09.png" Width="38px" />
                               <br />
                               Registrar Huella<br />
                           </td>               
                        </tr> 
                        <tr>
                            <td align="center" style="height: 1px">
                               <asp:ImageButton ID="BtnModificar" runat="server" ImageUrl="~/Iconos/56.png" 
                                    ToolTip="Modificar los datos del Paciente" />
                                <br />
                                <asp:Label ID="Label39" runat="server" Text="Modificar"></asp:Label>
                           </td>               
                        </tr> 
                        <tr>
                           <td align="center" style="height: 1px">
                               <asp:ImageButton ID="BtnCancelar" runat="server" Height="32px" 
                                   ImageUrl="~/Iconos/08.png" Width="36px" 
                                   ToolTip="Cancela el proceso realizado" />
                               <br />
                               <asp:Label ID="Label40" runat="server" Text="Cancelar"></asp:Label>
                           </td>               
                        </tr>
                        <tr>
                           <td align="center" style="height: 1px">
                               <asp:ImageButton ID="BtnImprimir" runat="server" ImageUrl="~/Iconos/19.png" 
                                   ToolTip="Imprimir la Historia Clínica del Paciente" />
                               <br />
                               <asp:Label ID="Label41" runat="server" Text="Imprimir"></asp:Label>
                           </td>               
                        </tr>                                            
                    </table>
                </td>    
            </tr>                 
                      
        </table>
         
     </div>                 
</asp:Panel>

<asp:Panel ID="Panel8" runat="server" Height="335px" 
    style="margin-left: 72px; margin-right: 1px" Width="870px" Visible="False" >
     <table bgcolor="#DBEFF7" 
        style="height: 0px; margin-bottom: 0px; width: 869px; margin-left: 2px;">
         <tr>
            <td style="height: 20px; font-size: 18px; width: 4594px;" align="left">
                 <asp:Label ForeColor="Blue" ID="Label31" runat="server" 
                     Text="Búsqueda de Paciente"></asp:Label>
            </td>
            <td style="height: 20px; font-size: 18px; width: 1901px;" align="left">
                
            </td>         
         </tr>
 </table>
 <asp:Panel ID="Panel9" runat="server" Height="83px" Width="866px" CssClass="style17">
       <div style="text-align: left; width: 867px; height: 81px; margin-left: 0px;">
          <table style="width: 861px; height: 82px">
               <tr>              
                  <td style="width: 445px">                                    
                     <asp:Panel ID="Panel10" runat="server" Height="63px" Width="637px" 
                      CssClass="style17"                           
                          GroupingText="Búsqueda por Apellido Paterno del Paciente o NHC">
                       <table style="height: 38px; width: 624px; font-size: 15px;">                                                                                                       
                        <tr>
                            <td style="width: 55px; font-size: inherit; height: 30px;">
                                Dato</td>
                            <td style="width: 114px; height: 30px;">
                                <asp:TextBox ID="TxtBuscar" runat="server" Width="332px" 
                                    style="margin-left: 0px"></asp:TextBox>
                                <br />
                            </td>
                        </tr>                                                             
                      </table>                  
                    </asp:Panel>
                   </td>                             
                   <td rowspan="3">
                       <table style="width: 176px; margin-left: 31px; height: 27px;">                            
                             <tr>
                                  <td style="height: 26px">
                                         <asp:ImageButton ID="BtnBuscarPaciente" runat="server" 
                                             ImageUrl="~/Iconos/94.png" Width="41px" />
                                   </td>                                
                                   <td style="height: 26px">
                                         <asp:ImageButton ID="BtnCancelarPaciente" runat="server" Height="35px" 
                                             ImageUrl="~/Iconos/08.png" Width="38px" />
                                   </td>
                              </tr>
                                                             
                        </table>
                    </td>                 
               </tr>                 
          </table>       
     </div>    
  </asp:Panel>
   <asp:Panel ID="Panel11" runat="server" Height="209px" Width="864px" 
        CssClass="style17" ScrollBars="Vertical">
     <div style="height: 395px; width: 943px;">  
         <asp:GridView ID="GvHCPaciente" runat="server" AutoGenerateColumns="False" 
             AutoGenerateSelectButton="True" CellPadding="3" ForeColor="#333333" 
             style="margin-left: 16px" CellSpacing="2" Width="2943px" Height="56px">
             <RowStyle BackColor="#EFF3FB" BorderWidth="1px" />
             <Columns>
                 <asp:BoundField DataField="NHC" HeaderText="NHC" />
                 <asp:BoundField DataField="CODPACIENTE" HeaderText="COD. PACIENTE" />
                 <asp:BoundField DataField="APELLIDOPATERNO" HeaderText="APELLIDO PATERNO" />
                 <asp:BoundField DataField="APELLIDOMATERNO" HeaderText="APELLIDO MATERNO" />
                 <asp:BoundField DataField="NOMBRES" HeaderText="NOMBRES" />
                 <asp:BoundField DataField="FECHANACIMIENTO" HeaderText="FECHA NACIMIENTO" />
                 <asp:BoundField DataField="CODTIPODOCIDENTIDAD" 
                     HeaderText="COD. TIPO DOC IDENTIDAD" />
                 <asp:BoundField DataField="NOMTIPODOC" HeaderText="TIPO DOC. IDENTIDAD" />
                 <asp:BoundField DataField="NUMERODOCIDENTIDAD" HeaderText="NUMERO" />   
                 <asp:BoundField DataField="CODESTADOCIVIL" HeaderText="COD. ESTADO CIVIL" />                          
                 <asp:BoundField DataField="NOMESTADOCIVIL" HeaderText="ESTADO CIVIL" />
                 <asp:BoundField DataField="CODDIRECCION" HeaderText="COD. DIRECCION" />
                 <asp:BoundField DataField="DATO1" HeaderText="DATO 1" />
                 <asp:BoundField DataField="NOMDIRECCION" HeaderText="DIRECCION" />
                 <asp:BoundField DataField="DATO2" HeaderText="DATO 2" />
                 <asp:BoundField DataField="NUMERO" HeaderText="NUMERO" />
                 <asp:BoundField DataField="LOTE" HeaderText="LOTE" />
                 <asp:BoundField DataField="NOMCENTROPOBLADO" HeaderText="CENTRO POBLADO" />
                 <asp:BoundField DataField="NOMDISTRITO" HeaderText="DISTRITO" />
                 <asp:BoundField DataField="NOMPROVINCIA" HeaderText="PROVINCIA" />
                 <asp:BoundField DataField="NOMDEPARTAMENTO" HeaderText="DEPARTAMENTO" />
                 <asp:BoundField DataField="NOMPAIS" HeaderText="PAIS" />
                 <asp:BoundField DataField="LUGARORIGEN" HeaderText="LUGAR ORIGEN" />
                 <asp:BoundField DataField="CODREGISTROSEGURO" 
                     HeaderText="COD. REGISTRO SEGURO" />
                 <asp:BoundField DataField="CODSEGURO" HeaderText="COD. SEGURO" />
                 <asp:BoundField DataField="NOMSEGURO" HeaderText="SEGURO" />
                 <asp:BoundField DataField="NUMAUTOGENERADO" HeaderText="AUTOGENERADO" />
                 <asp:BoundField DataField="FECHAAFILIACION" HeaderText="FECHA. AFILIACION" />
                 <asp:BoundField DataField="FECHAVENCIMIENTO" HeaderText="FECHA VENCIMIENTO" />
                 <asp:BoundField DataField="FECHAAPERTURA" HeaderText="FECHA APERTURA" />
                 <asp:BoundField DataField="SEXO" HeaderText="SEXO" />
                 <asp:BoundField DataField="OCUPACION" HeaderText="OCUPACION" />
                 <asp:BoundField DataField="CELULAR" HeaderText="CELULAR" />
                 <asp:BoundField DataField="TELEFONO" HeaderText="TELEFONO" />
                 <asp:BoundField DataField="EMAIL" HeaderText="EMAIL" />
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
</asp:Panel>    
</asp:Content>

