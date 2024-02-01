<%@ Page Language="VB" MasterPageFile="~/WFPrincipal/PaginaMaestra.master" AutoEventWireup="false" CodeFile="ReprogramacionSolicitudAtencion.aspx.vb" Inherits="ModuloAdmision_ReprogramacionSolicitudAtencion" title="Página sin título" MaintainScrollPositionOnPostback="true" %>

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
               <asp:Label ID="LblTurno2" runat="server" Font-Bold="True" ForeColor="White"></asp:Label>
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
            <td style="height: 20px; font-size: 18px; width: 12000px;" align="left">
                 <asp:Label ForeColor="Blue" ID="Label1" runat="server" 
                     Text="Reprogramación de la Solicitud de Atención"></asp:Label>
            </td>
            <td style="height: 20px; font-size: 18px; width: 1901px;" align="left">
                
                <asp:LinkButton ID="LinkButton1" runat="server">Volver al inicio</asp:LinkButton>
                
            </td>         
         </tr>
 </table>
 
    
      
 
   
        <table border="1"                     
            style="background-color: #99CCFF; font-size: medium; width: 670px; margin-left: 68px;">           
             <tr>                          
                <td style="width: 600px" >
                
                <asp:Panel ID="Panel2" runat="server" Height="198px" Width="886px" 
                        CssClass="style11">
       <div style="text-align: left; width: 479px; height: 215px; margin-left: 0px;">
          <table style="width: 480px; height: 82px">
               <tr>              
                  <td style="width: 445px">                                    
                     <asp:Panel ID="Panel3" runat="server" Height="214px" Width="474px" 
                      GroupingText="Ingrese la Fecha y el ApellidoPaterno del Paciente" 
                          BackColor="White">
                       <table style="height: 38px; width: 462px; font-size: 15px;">                                                                                                       
                        <tr>
                             <td style="width: 565px; height: 30px;">
                                 <asp:Calendar ID="CFecha2" runat="server" BackColor="White" 
                                     BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" 
                                     Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="115px" 
                                     style="margin-left: 15px" Width="185px">
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
                                <asp:Label ID="Label5" runat="server" Text="Apellido Paterno "></asp:Label>
                                <br />
                                <asp:TextBox ID="TxtBuscar" runat="server" Width="193px" 
                                    style="margin-left: 0px"></asp:TextBox>
                                
                                <br />
                                <asp:Label ID="LblFechaPrueba" runat="server" Text="Label" Visible="False"></asp:Label>
                                
                                &nbsp;
                                <asp:Label ID="LblFechaReprogramacion2" runat="server" Text="Label" 
                                    Visible="False"></asp:Label>
                                <asp:Label ID="LblFecha2" runat="server" Text="Label" Visible="False"></asp:Label>
                                
                            </td>
                            <td style="height: 26px">
                                      <asp:ImageButton ID="BtnBuscar" runat="server" ImageUrl="~/Iconos/94.png" 
                                          Height="34px" Width="40px" />                                                                                                                                                                                             
                                      <br />
                                      <asp:Label ID="Label8" runat="server" Text="Buscar"></asp:Label>
                                   </td>                              
                                  
                        </tr>                                                             
                      </table>                  
                    </asp:Panel>
                   </td> 
                   <td bgcolor="White">
                   <asp:Panel ID="Panel10" runat="server" Height="182px" Width="387px" 
                      CssClass="style11" style="margin-left: 3px" 
                        BorderStyle="Solid" BorderWidth="1px" ScrollBars="Vertical" BackColor="White">
                     <div style="height: 395px; width: 943px;">  
         <asp:GridView ID="GvListaSoliAtenReprogramacion" runat="server" AutoGenerateColumns="False" 
             AutoGenerateSelectButton="True" CellPadding="3" ForeColor="#333333" 
             style="margin-left: 16px" CellSpacing="2" Width="2523px">
             <RowStyle BackColor="#EFF3FB" BorderWidth="1px" />
             <Columns>
                 <asp:BoundField DataField="NHC" HeaderText="NHC" />
                 <asp:BoundField DataField="PACIENTE" HeaderText="PACIENTE" />
                 <asp:BoundField DataField="CODPACIENTE" HeaderText="COD. PACIENTE" />
                 <asp:BoundField DataField="CODIGOSOLICITUDATENCION" 
                     HeaderText="CODIGO SOLICITUD ATENCION" />
                 <asp:BoundField DataField="NUMSOLICITUDATENCION" 
                     HeaderText="NUM. SOLICITUD ATENCION" />
                 <asp:BoundField DataField="NOMESPECIALIDAD" HeaderText="ESPECIALIDAD" />
                 <asp:BoundField DataField="CODESPECIALIDAD" HeaderText="COD. ESPECIALIDAD" />
                 <asp:BoundField DataField="MEDICO" HeaderText="MEDICO" />
                 <asp:BoundField DataField="CODMEDICO" HeaderText="COD. MEDICO" />
                 <asp:BoundField DataField="NOMTURNO" HeaderText="TURNO" />
                 <asp:BoundField DataField="FECHAATENCION" HeaderText="FECHA ATENCION" />
                 <asp:BoundField DataField="CODVENTA" HeaderText="COD. VENTA" />
                 <asp:BoundField DataField="USUARIO" HeaderText="USUARIO" />
                 <asp:BoundField DataField="CODUSUARIO" HeaderText="COD. USUARIO" />
                 <asp:BoundField DataField="FECHA" HeaderText="FECHA" />
                 <asp:BoundField DataField="CODDETALLEPROGRAMACIONMEDICA" 
                     HeaderText="COD. DETALLE PROGRAMACIÓN MÉDICA" />
                 <asp:BoundField DataField="FECHAREPROGRAMACION" 
                     HeaderText="FECHA REPROGRAMACION" />
                 <asp:BoundField DataField="CODTURNO" HeaderText="CODTURNO" />
                 <asp:BoundField DataField="ESTADO" HeaderText="ESTADOVENTA" />
                 <asp:BoundField DataField="CODSOLICITUDATENCION" 
                     HeaderText="CODSOLICITUD ATENCION" />
                 <asp:BoundField DataField="REPROGRAMADO" HeaderText="REPROGRAMADO" />
                 <asp:BoundField DataField="HORAREGISTRO" HeaderText="HORA" />
                 <asp:BoundField DataField="ANULADO" HeaderText="ANULADO" />
                 <asp:BoundField DataField="FECHAANULACION" HeaderText="FECHAANULACION" />
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
                           
               </tr>                 
          </table>       
     </div>    
  </asp:Panel>
                
                  
                
                 <asp:Panel ID="Panel6" runat="server" Height="78px" Width="886px" 
                      CssClass="style11" GroupingText="Datos de la Atención" style="margin-left: 3px" 
                        BorderStyle="Solid" BorderWidth="1px" BackColor="White">
                     <table style="height: 34px; width: 875px;" bgcolor="White">                                    
                        <tr>
                            <td style="width: 1330px; height: 4px;">
                                <asp:Label ID="Label13" runat="server" Text="Num. Solicitud Atencion"></asp:Label>
                            </td>                           
                            <td style="width: 1075px; height: 4px;">
                                &nbsp;
                                <asp:Label ID="LblNumSoliAten" runat="server"></asp:Label>
                            </td>
                            <td style="width: 405px; height: 4px;">
                                &nbsp;
                                <asp:Label ID="Label30" runat="server" Text="Paciente"></asp:Label>
                                </td>
                            <td style="width: 2668px; height: 4px;">
                                &nbsp;
                                <asp:Label ID="LblPaciente" runat="server"></asp:Label>
                                </td>
                            <td style="width: 1226px; height: 4px;">
                                &nbsp;
                                <asp:Label ID="Label9" runat="server" Text="Historia N°"></asp:Label>
                                </td>
                            <td style="width: 801px; height: 4px;">
                                &nbsp;
                                <asp:Label ID="LblNHC" runat="server"></asp:Label>
                                </td> 
                             <td style="width: 433px">                                   
                                    <asp:Label ID="Label27" runat="server" Text="Fecha de Reprogramación"></asp:Label>
                                </td>
                                <td class="style9" style="width: 772px">                                    
                                    <asp:Label ID="LblFechaReprogramacion" runat="server" Text="Label"></asp:Label>
                                </td>                         
                        </tr>                                                                
                    </table>
                  </asp:Panel>
                    
                    <asp:Panel ID="Panel8" runat="server" CssClass="style11" 
                        GroupingText="Datos del Servicio" Height="302px" Width="886px" 
                        BackColor="White">
                       <table bgcolor="White" style="height: 153px; width: 869px; margin-left: 0px;">
                         <tr>
                           <td style="width: 255px">
                            <table style="width: 262px; margin-left: 7px">
                               <tr>
                                 <td align="left">
                                     <asp:Label ID="Label18" runat="server" Text="Fecha de Atención"></asp:Label>
                                 </td> 
                                                                
                               </tr>                               
                               <tr>
                                 <td>
                                    <asp:Calendar ID="CFecha" runat="server" BackColor="White" 
                                        BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" 
                                        Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="73px" 
                                        Width="193px" style="margin-left: 15px; margin-right: 9px">
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
                               </tr>                         
                           </table>                          
                           </td>   
                           <td>
                            <table style="height: 213px; width: 595px">
                               <tr>
                                 <td>
                                     <asp:Label ID="Label19" runat="server" Text="Turno"></asp:Label>
                                 </td>
                                  <td>
                                      <asp:DropDownList ID="DdTurno" runat="server" AutoPostBack="True" Height="21px" 
                                          Width="100px" Enabled="False">
                                      </asp:DropDownList>
                                 </td>
                                 <td>
                                     <asp:Label ID="LblCodTurno" runat="server" Visible="False">Label</asp:Label>
                                 </td>
                                 <td>
                                 
                                     <asp:Label ID="LblCodigo" runat="server"></asp:Label>
                                 
                                 </td>
                                 <td>
                                 
                                 </td>
                               </tr>
                                <tr>
                                 <td>
                                     <asp:Label ID="Label20" runat="server" Text="Especialidad"></asp:Label>
                                 </td>
                                  <td>
                                      <asp:DropDownList ID="DdEspecialidad" runat="server" AutoPostBack="True" 
                                          Enabled="False" Height="21px" Width="184px">
                                      </asp:DropDownList>
                                 </td>
                                 <td>
                                     <asp:Label ID="LblCodVenta" runat="server" Text="Label" Visible="False"></asp:Label>
                                 </td>
                                 <td>
                                     <asp:Label ID="LblCodSoliAtenAnterior" runat="server" Text="Label" 
                                         Visible="False"></asp:Label>
                                 </td>
                               </tr>
                                <tr>
                                 <td>
                                     <asp:Label ID="LblCantidad" runat="server"></asp:Label>
                                 </td>
                                 <td>
                                      <asp:ImageButton ID="Button2" runat="server" Height="26px" 
                                          ImageUrl="~/Iconos/86.png" style="margin-left: 8px" Width="29px" />
                                      <br />
                                      <asp:Label ID="Label10" runat="server" Text="Limpiar"></asp:Label>
                                 </td>
                                 <td>
                                     <asp:Label ID="LblCodDetalleProgramacionMedica" runat="server" Text="Label" 
                                         Visible="False"></asp:Label>
                                    </td>
                                     <td>
                                 
                                         <asp:Label ID="LblNumSoliAtenAnterior" runat="server" Text="Label" 
                                             Visible="False"></asp:Label>
                                 
                                 </td>
                               </tr>  
                               <tr>
                                 <td>
                                     <asp:Label ID="Label31" runat="server" Text="Médico"></asp:Label>
                                   </td>
                                  <td>
                                      &nbsp;<asp:DropDownList ID="DdMedicos" runat="server" AutoPostBack="True" 
                                          Height="21px" Width="313px">
                                      </asp:DropDownList>
                                      <br />
                                 </td>
                                 <td>
                                     &nbsp;</td>
                                    <td>
                                 
                                 </td>
                               </tr>                        
                            </table>                          
                          </td>                                           
                         </tr>                                       
                       </table>                                                                 
                                               
                       <table bgcolor="White" style="height: 64px; width: 870px;">
                            <tr>
                                <td style="width: 306px" class="style9">
                                    <asp:Label ID="Label29" runat="server" Text="Motivo de Reprogramacion"></asp:Label>
                                </td>
                                <td style="width: 702px">
                                    <asp:TextBox ID="TxtMotivo" runat="server" Height="49px" TextMode="MultiLine" 
                                        Width="462px"></asp:TextBox>
                                </td>                               
                               
                            </tr>
                        </table>
                    </asp:Panel>
                      <asp:Panel ID="Panel4" runat="server" CssClass="style11" Height="50px" Width="886px" 
                        Visible="False" BackColor="White">
                        <table bgcolor="White" style="height: 57px; width: 871px;">
                            <tr>
                                <td style="width: 807px" class="style9">
                                    <asp:Label ID="LblCodTiComprobar" runat="server" Visible="False"></asp:Label>
                                    <asp:Label ID="LblCodPaciente" runat="server" Text="Label" Visible="False"></asp:Label>
                                    <asp:Label ID="LblCodVentaReprogramacion" runat="server" Text="Label" 
                                        Visible="False"></asp:Label>
                                </td>
                                <td style="width: 505px">
                                    <asp:Label ID="LblNTiComprobar" runat="server" Visible="False"></asp:Label>
                                    <asp:Label ID="LblCodEspecialidadRepro" runat="server" Text="Label" 
                                        Visible="False"></asp:Label>
                                </td>                               
                                <td style="width: 776px" class="style9">
                                    <asp:Label ID="LblMeComprueba" runat="server" Visible="False"></asp:Label>
                                    <asp:Label ID="LblCodAuditoria" runat="server" Text="Label" Visible="False"></asp:Label>
                                    <asp:Label ID="LblContar" runat="server" Text="Label" Visible="False"></asp:Label>
                                </td>
                                <td style="width: 878px">                                  
                                    <asp:Label ID="LblEsComprueba" runat="server" Visible="False"></asp:Label>
                                    <asp:Label ID="LblCodSoliAten" runat="server" Text="Label"></asp:Label>
                                    <asp:Label ID="LblFechaAtencion" runat="server" Text="Label" Visible="False"></asp:Label>
                                </td>                               
                            </tr>
                        </table>
                    </asp:Panel>
                    <asp:Panel ID="Panel1" runat="server" CssClass="style11" Height="97px" 
                        Width="886px" BackColor="#99CCFF">
                        <div style="text-align: left; width: 695px; height: 22px; margin-left: 0px;">
                             <table style="width: 884px; height: 25px" align="center">
                                <tr>
                                    <td style="width: 161px" align="center">                                      
                                        <asp:Label ID="Label4" runat="server" ForeColor="Red" Text="!Ten en cuenta que ...!" 
                                            Visible="False"></asp:Label>
                                    </td>                                                                   
                                </tr>                              
                            </table>
                            <table style="width: 884px; height: 32px">
                                <tr>
                                    <td style="width: 161px">                                      
                                        <asp:Label ID="Label3" runat="server" ForeColor="Blue" Text="Para" 
                                            Visible="False"></asp:Label>
                                    </td>  
                                    <td style="width: 779px">                                      
                                        <asp:Label ID="LblEspecialidad" runat="server" Visible="False" ForeColor="Blue"></asp:Label>
                                    </td>
                                    <td style="width: 458px">                                      
                                        <asp:Label ID="Label21" runat="server" Text="en el turno" Visible="False" 
                                            ForeColor="Blue"></asp:Label>
                                    </td>
                                    <td style="width: 579px">                                      
                                        <asp:Label ID="LblTurno" runat="server" Visible="False" ForeColor="Blue"></asp:Label>
                                    </td>
                                    <td style="width: 445px">                                      
                                        <asp:Label ID="Label22" runat="server" Text="con el médico" Visible="False" 
                                            ForeColor="Blue"></asp:Label>
                                    </td>                                
                                </tr>                              
                            </table>
                            <table style="width: 884px; height: 21px">
                                 <tr>
                                    <td style="width: 258px">                                      
                                        <asp:Label ID="LblMedico" runat="server" Visible="False" ForeColor="Blue"></asp:Label>
                                    </td>  
                                    <td style="width: 33px" class="style5">                                      
                                        <asp:Label ID="Label6" runat="server" Visible="False" ForeColor="Blue">van</asp:Label>
                                    </td> 
                                    <td style="width: 63px">                                      
                                        <asp:Label ID="Label7" runat="server" Visible="False" ForeColor="Red"></asp:Label>
                                    </td> 
                                    <td style="width: 28px">                                      
                                        <asp:Label ID="Label23" runat="server" ForeColor="Blue" Text="de" 
                                            Visible="False"></asp:Label>
                                    </td>
                                    <td style="width: 95px">                                      
                                        <asp:Label ID="LblNumCon" runat="server" Visible="False" 
                                            ForeColor="Blue"></asp:Label>
                                    </td>
                                    <td style="width: 128px">                                      
                                        <asp:Label ID="Label25" runat="server" ForeColor="Blue" Text="solicitudes de atención" 
                                            Visible="False"></asp:Label>
                                    </td>                                
                                </tr>
                            </table>
                        </div>
                    </asp:Panel>                    
                    <asp:Panel ID="Panel9" runat="server" CssClass="style11" Height="62px" 
                        Width="886px" BackColor="White">
                        <div style="text-align: left; width: 884px; height: 76px; margin-left: 0px;">
                            <table style="width: 882px; height: 50px" bgcolor="White">
                                <tr>
                                    <td style="width: 445px">                                      
                                    </td>  
                                    <td style="width: 445px" align="center">                                      
                                        <asp:ImageButton ID="BtnImprimir" runat="server" ImageUrl="~/Iconos/21.png" 
                                            Height="36px" Width="43px" Enabled="False" />
                                        <br />
                                        <asp:Label ID="Label28" runat="server" Text="Registrar"></asp:Label>
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
                       
               
</asp:Content>

