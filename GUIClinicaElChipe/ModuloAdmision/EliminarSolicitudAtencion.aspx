<%@ Page Language="VB" MasterPageFile="~/WFPrincipal/PaginaMaestra.master" AutoEventWireup="false" CodeFile="EliminarSolicitudAtencion.aspx.vb" Inherits="ModuloAdmision_EliminarSolicitudAtencion" title="Página sin título" MaintainScrollPositionOnPostback="true"%>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <asp:Panel ID="Panel5" runat="server" Height="41px" BackColor="#5F94C9"
        style="margin-top: 0px" Width="1141px">   
    <table style="height: 33px; width: 1141px;" bgcolor="#5F94C9">                                    
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
         </tr>                                                                
    </table>
    
</asp:Panel>

 <table style="width: 886px; height: 10px; margin-left: 70px; margin-top: 8px;" 
            frame="box">
          <tr>
            <td style="height: 28px; font-size: 20px; width: 1027px;" align="center">
                <asp:Label ForeColor="#000099" ID="Label2" runat="server" Text="ADMISIÓN"></asp:Label>
            </td>           
          </tr>
 </table>
 <table bgcolor="#DBEFF7" 
        style="height: 0px; margin-bottom: 0px; width: 886px; margin-left: 70px;">
         <tr>
            <td style="height: 20px; font-size: 18px; width: 4594px;" align="left">
                 <asp:Label ForeColor="Blue" ID="Label1" runat="server" 
                     Text="Eliminar Solicitudes de Atención"></asp:Label>
            </td>
            <td style="height: 20px; font-size: 18px; width: 1901px;" align="left">
                
            </td>         
         </tr>
 </table>
 
 <table border="1"                     
            style="background-color: #99CCFF; font-size: medium; width: 670px; margin-left: 68px;">           
             <tr>                          
                <td style="width: 600px" >
                 <asp:Panel ID="Panel2" runat="server" Height="220px" Width="886px" 
                        CssClass="style11" BackColor="White">
       <div style="text-align: left; width: 398px; height: 215px; margin-left: 0px;">
          <table style="width: 885px; height: 82px">
               <tr>              
                  <td style="width: 433px">                                    
                     <asp:Panel ID="Panel3" runat="server" Height="201px" Width="394px" 
                      GroupingText="Ingrese la Fecha y el Apellido Paterno del Paciente" 
                          BackColor="White">
                       <table style="height: 38px; width: 388px; font-size: 15px;">                                                                                                       
                        <tr>
                             <td style="width: 229px; height: 30px;">
                                 <asp:Calendar ID="CFecha" runat="server" BackColor="White" 
                                     BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" 
                                     Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="56px" 
                                     style="margin-left: 15px" Width="171px">
                                     <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                                     <SelectorStyle BackColor="#CCCCCC" />
                                     <WeekendDayStyle BackColor="#FFFFCC" />
                                     <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                                     <OtherMonthDayStyle ForeColor="#808080" />
                                     <NextPrevStyle VerticalAlign="Bottom" />
                                     <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                                     <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                                 </asp:Calendar>
                                
                            </td>                         
                            <td style="width: 114px; height: 30px;">
                                <asp:Label ID="Label24" runat="server" Text="Apellido Paterno"></asp:Label>
                                <br />
                                <asp:TextBox ID="TxtBuscar" runat="server" Width="179px" 
                                    style="margin-left: 0px"></asp:TextBox>
                                
                                <br />
                                <asp:Label ID="LblFechaPrueba" runat="server" Text="Label"></asp:Label>
                                <asp:Label ID="LblFecha2" runat="server" Text="Label"></asp:Label>
                                
                            </td>
                        </tr>                                                             
                      </table>                  
                    </asp:Panel>
                   </td> 
                   <td bgcolor="White">
                     <asp:Panel ID="Panel4" runat="server" Height="182px" Width="370px" 
                      CssClass="style11" style="margin-left: 3px" 
                        BorderStyle="Solid" BorderWidth="1px" ScrollBars="Vertical" BackColor="White">
                     <div style="height: 188px; width: 943px;">  
         <asp:GridView ID="GvListaCopiaSolicitudAtencion" runat="server" AutoGenerateColumns="False" 
             AutoGenerateSelectButton="True" CellPadding="3" ForeColor="#333333" 
             style="margin-left: 16px" CellSpacing="2" Width="2303px">
             <RowStyle BackColor="#EFF3FB" BorderWidth="1px" />
             <Columns>
                 <asp:BoundField DataField="NHC" HeaderText="NHC" />
                 <asp:BoundField DataField="NUMSOLICITUDATENCION" 
                     HeaderText="NUM. SOLICITUD ATENCION" />
                 <asp:BoundField DataField="PACIENTE" HeaderText="PACIENTE" />
                 <asp:BoundField DataField="FECHA" HeaderText="FECHA" />
                 <asp:BoundField DataField="CODPACIENTE" HeaderText="COD. PACIENTE" />
                 <asp:BoundField DataField="CODIGOSOLICITUDATENCION" 
                     HeaderText="CODIGO SOLICITUD ATENCION" />
                 <asp:BoundField DataField="NOMESPECIALIDAD" HeaderText="ESPECIALIDAD" />
                 <asp:BoundField DataField="CODESPECIALIDAD" HeaderText="COD. ESPECIALIDAD" />
                 <asp:BoundField DataField="MEDICO" HeaderText="MEDICO" />
                 <asp:BoundField DataField="CODMEDICO" HeaderText="COD. MEDICO" />   
                 <asp:BoundField DataField="NOMTURNO" HeaderText="TURNO" />                          
                 <asp:BoundField DataField="FECHAATENCION" HeaderText="FECHA ATENCION" />
                 <asp:BoundField DataField="CODVENTA" HeaderText="COD. VENTA" />
                 <asp:BoundField DataField="USUARIO" HeaderText="USUARIO" />
                 <asp:BoundField DataField="CODUSUARIO" 
                     HeaderText="COD. USUARIO" />
                 <asp:BoundField DataField="CODDETALLEPROGRAMACIONMEDICA" 
                     HeaderText="COD. DETALLE PROGRAMACIÓN MÉDICA" />
                 <asp:BoundField DataField="FECHAREPROGRAMACION" 
                     HeaderText="FECHA REPROGRAMACION" />
                 <asp:BoundField DataField="CODTURNO" HeaderText="COD. TURNO" />
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
                   
                   
                   </td>                            
                   <td rowspan="3">
                       <table style="width: 80px; margin-left: 27px; height: 27px;">                            
                             <tr>
                                  <td style="height: 26px" align="center">
                                         <asp:ImageButton ID="ImageButton1" runat="server" Height="32px" 
                                             ImageUrl="~/Iconos/32.png" Width="36px" />
                                   </td>                                                                                                                               
                              </tr>
                              <tr>
                                   <td style="height: 26px" align="center">
                                                                                                                                                                                                                                 
                                       <asp:Label ID="Label25" runat="server" Text="Nuevo"></asp:Label>
                                                                                                                                                                                                                                 
                                   </td>
                              </tr>
                              <tr>
                                  <td style="height: 26px" align="center">
                                         <asp:ImageButton ID="BtnBuscar" runat="server" Height="22px" 
                                             ImageUrl="~/Iconos/94.png" Width="29px" />
                                   </td> 
                              </tr>
                              <tr>
                                   <td style="height: 26px" align="center">
                                                                                                                                                                                                                              
                                       <asp:Label ID="Label26" runat="server" Text="Buscar"></asp:Label>
                                                                                                                                                                                                                              
                                   </td>
                              </tr>
                              <tr>
                                   <td style="height: 26px" align="center">
                                         <asp:ImageButton ID="ImageButton2" runat="server" Height="30px" 
                                             ImageUrl="~/Iconos/86.png" Width="28px" />
                                   </td>
                              </tr>
                              <tr>
                                   <td style="height: 26px" align="center">
                                                                                                                                                                                                                                   
                                       <asp:Label ID="Label27" runat="server" Text="Cancelar"></asp:Label>
                                                                                                                                                                                                                                   
                                   </td>
                              </tr>                                                             
                        </table>
                    </td>                 
               </tr>                 
          </table>       
     </div>    
  </asp:Panel>
                 
            
               
                  
                 
                 <asp:Panel ID="Panel6" runat="server" Height="320px" Width="886px" 
                      CssClass="style11" style="margin-left: 3px" 
                        BorderStyle="Solid" BorderWidth="1px" BackColor="White">
                        <table>
                          <tr>
                         <td colspan="2" style="height: 21px" bgcolor="White">
                    <table style="height: 24px; width: 877px;" bgcolor="White">
                      
                       <tr>
                            <td style="width: 799px">
                                &nbsp;
                            </td>
                            <td style="height: 28px; font-size: 20px; width: 901px;" align="center">
                            <asp:Label ForeColor="#000099" ID="Label4" runat="server" 
                                    Text="Solicitudes de Atención" Font-Size="13pt"></asp:Label>
                            </td>
                            <td style="width: 801px">
                                &nbsp;
                            </td>                                                                      
                        </tr>                                                                            
                    </table>           
                
                    <table style="height: 249px; width: 687px;" bgcolor="White">
                         <tr>
                            <td style="width: 856px; height: 69px;" align="center">                               
                                <asp:Button ID="Button1" runat="server" Height="65px" Width="90px" 
                                    Text="Atención 1" />
                            </td>
                            <td style="width: 856px; height: 69px;" align="center">                               
                                <asp:Button ID="Button2" runat="server" Height="65px" Width="90px" 
                                    Text="Atención 2" />
                            </td>
                             <td style="width: 856px; height: 69px;" align="center">                               
                                <asp:Button ID="Button3" runat="server" Height="65px" 
                                    Width="90px" Text="Atención 3" />
                            </td>
                            <td style="width: 856px; height: 69px;" align="center">                               
                                <asp:Button ID="Button4" runat="server" Height="65px" 
                                    Width="90px" Text="Atención 4" />
                            </td>
                            <td style="width: 856px; height: 69px;" align="center">                               
                                <asp:Button ID="Button5" runat="server" Height="65px" 
                                    Width="90px" Text="Atención 5" />
                            </td>
                            <td style="width: 856px; height: 69px;" align="center">                               
                                <asp:Button ID="Button6" runat="server" Height="65px" 
                                    Width="90px" Text="Atención 6" />
                            </td>
                           <td style="width: 856px; height: 69px;" align="center">                               
                                <asp:Button ID="Button7" runat="server" Height="65px" 
                                    Width="90px" Text="Atención 7" />
                            </td> 
                             <td style="width: 856px; height: 69px;" align="center">                               
                                <asp:Button ID="Button8" runat="server" Height="65px" 
                                    Width="90px" Text="Atención 8" />
                            </td>  
                            <td style="width: 856px; height: 69px;" align="center">                               
                                <asp:Button ID="Button9" runat="server" Height="65px" 
                                    Width="90px" Text="Atención 9" />
                            </td>                        
                        </tr>
                          <tr>                          
                             <td style="width: 856px; height: 69px;" align="center">                               
                                <asp:Button ID="Button10" runat="server" Height="65px" 
                                    Width="92px" Text="Atención 10" />
                            </td>
                            <td style="width: 856px; height: 69px;" align="center">                               
                                <asp:Button ID="Button11" runat="server" Height="65px" 
                                    Width="90px" Text="Atención 11" />
                            </td>
                            <td style="width: 856px; height: 69px;" align="center">                               
                                <asp:Button ID="Button12" runat="server" Height="65px" 
                                    Width="90px" Text="Atención 12" />
                            </td>
                            <td style="width: 856px; height: 69px;" align="center">                               
                                <asp:Button ID="Button13" runat="server" Height="65px" 
                                    Width="90px" Text="Atención 13" />
                            </td>
                           <td style="width: 856px; height: 69px;" align="center">                               
                                <asp:Button ID="Button14" runat="server" Height="65px" 
                                    Width="90px" Text="Atención 14" />
                            </td> 
                             <td style="width: 856px; height: 69px;" align="center">                               
                                <asp:Button ID="Button15" runat="server" Height="65px" 
                                    Width="90px" Text="Atención 15" />
                            </td>
                            <td style="width: 856px; height: 69px;" align="center">                               
                                <asp:Button ID="Button16" runat="server" Height="65px" 
                                    Width="90px" Text="Atención 16" />
                            </td> 
                             <td style="width: 856px; height: 69px;" align="center">                               
                                <asp:Button ID="Button17" runat="server" Height="65px" 
                                    Width="90px" Text="Atención 17" />
                            </td>
                            <td style="width: 856px; height: 69px;" align="center">                               
                                <asp:Button ID="Button18" runat="server" Height="65px" 
                                    Width="90px" Text="Atención 18" />
                            </td>                         
                        </tr>
                          <tr>                         
                            
                            <td style="width: 856px; height: 69px;" align="center">                               
                                <asp:Button ID="Button19" runat="server" Height="65px" 
                                    Width="90px" Text="Atención 19" />
                            </td>
                            <td style="width: 856px; height: 69px;" align="center">                               
                                <asp:Button ID="Button20" runat="server" Height="65px" 
                                    Width="90px" Text="Atención 20" />
                            </td>
                           <td style="width: 856px; height: 69px;" align="center">                               
                               <asp:Button ID="Button21" runat="server" Height="65px" 
                                    Width="90px" Text="Atención 21" /> 
                           </td>
                           <td style="width: 856px; height: 69px;" align="center">                               
                                <asp:Button ID="Button22" runat="server" Height="65px" Width="90px" 
                                    Text="Atención 22" />
                            </td>
                            <td style="width: 856px; height: 69px;" align="center">                               
                                <asp:Button ID="Button23" runat="server" Height="65px" Width="90px" 
                                    Text="Atención 23" />
                            </td>
                             <td style="width: 856px; height: 69px;" align="center">                               
                                <asp:Button ID="Button24" runat="server" Height="65px" 
                                    Width="90px" Text="Atención 24" />
                            </td>
                            <td style="width: 856px; height: 69px;" align="center">                               
                                <asp:Button ID="Button25" runat="server" Height="65px" 
                                    Width="90px" Text="Atención 25" />
                            </td>
                            <td style="width: 856px; height: 69px;" align="center">                               
                                <asp:Button ID="Button26" runat="server" Height="65px" 
                                    Width="90px" Text="Atención 26" />
                            </td>
                            <td style="width: 856px; height: 69px;" align="center">                               
                                <asp:Button ID="Button27" runat="server" Height="65px" 
                                    Width="90px" Text="Atención 27" />
                            </td>
                             <td style="width: 856px; height: 69px;" align="center">                               
                                <asp:GridView ID="GvNumSoliAten" runat="server" AutoGenerateColumns="False" 
                                    Height="16px" Width="16px">
                                    <Columns>
                                        <asp:BoundField DataField="NumSolicitudAtencion" HeaderText="SOLIATEN" />
                                    </Columns>
                                </asp:GridView>
                             </td>                            
                        </tr>                                         
                    </table>
               </td> 
                        
                        
                          </tr>                        
                        </table>                   
                  </asp:Panel>
                  
                  
                    <asp:Panel ID="Panel9" runat="server" CssClass="style11" Height="19px" 
                        Width="886px" Visible="False">
                        <div style="text-align: left; width: 842px; height: 76px; margin-left: 0px;">
                            <table style="width: 886px; height: 9px">
                                <tr>                                     
                                    <td style="width: 445px">                                      
                                        <asp:Label ID="LblNumCeldas" runat="server" Text="Label"></asp:Label>
                                        <asp:Label ID="Lblcantidadconsultas" runat="server" Text="Label"></asp:Label>
                                        <asp:Label ID="LblCodconsulta" runat="server" Text="Label"></asp:Label>
                                    </td>                                 
                                </tr>
                            </table>
                        </div>
                    </asp:Panel>
               </td>              
      
            </tr>                             
        </table>        
     

</asp:Content>

