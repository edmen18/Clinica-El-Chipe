<%@ Page Language="VB" MasterPageFile="~/WFPrincipal/PaginaMaestra.master" AutoEventWireup="false" CodeFile="ProgramacionMedica.aspx.vb" Inherits="ModuloProgramacionMedica_ProgramacionMedica" title="Página sin título" MaintainScrollPositionOnPostback="true"%>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Panel ID="Panel5" runat="server" Height="41px" BackColor="#5F94C9"
        style="margin-top: 0px" Width="1146px">   
    <table style="height: 33px; width: 1144px;" bgcolor="#5F94C9">                                    
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
<asp:Panel ID="Panel10" runat="server" height="599px">
 <table style="width: 525px; height: 10px; margin-left: 70px; margin-top: 8px;" 
            frame="box">
          <tr>
            <td style="height: 28px; font-size: 20px; width: 1027px;" align="center">
                <asp:Label ForeColor="#000099" ID="Label2" runat="server" 
                    Text="Programación Médica"></asp:Label>
            </td>  
             <td>
            <asp:Panel ID="Panel6" runat="server" Height="16px" Width="950px" 
                      CssClass="style18" style="margin-left: 3px" BorderStyle="Solid" BorderWidth="1px" 
                       BackColor="#DBEFF7" Visible="False"> 
              <table>
               <tr>
                <td style="height: 28px; font-size: 20px; width: 1027px;" align="center">
                <asp:Label ForeColor="#000099" ID="Label7" runat="server" 
                    Text="Programación Médica"></asp:Label>
            </td> 
                <td>
                    <asp:TextBox ID="TextBox4" runat="server" Height="16px" Width="267px" 
                        Visible="False"></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox ID="TextBox5" runat="server" Height="16px" Width="561px" 
                        Visible="False"></asp:TextBox>
                </td>
               </tr>                          
              </table>   
              </asp:Panel>   
            </td> 
                    
          </tr>
 </table>
 <table bgcolor="White" 
        style="height: 6px; margin-bottom: 0px; width: 525px; margin-left: 68px;">
         <tr>
             <td>
               <asp:Label ForeColor="Blue" ID="Label1" runat="server" 
                     Text="Registro de Programación Médica"></asp:Label>
               </td>
          
            <td>
            <asp:Panel ID="Panel4" runat="server" Height="16px" Width="788px" 
                      CssClass="style18" style="margin-left: 3px" BorderStyle="Solid" BorderWidth="1px" 
                       BackColor="White" Visible="False"> 
              <table>
               <tr>
               <td>
               <asp:Label ForeColor="Blue" ID="Label6" runat="server" 
                     Text="Registro de Programación Médica"></asp:Label>
               </td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" Height="16px" Width="190px" 
                        Visible="False"></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server" Height="18px" Width="499px" 
                        Visible="False"></asp:TextBox>
                </td>
               </tr>                          
              </table>   
              </asp:Panel>   
            </td>
                 
             <td>
            <asp:Panel ID="Panel11" runat="server" Height="16px" Width="153px" 
                      CssClass="style18" style="margin-left: 3px" BorderStyle="Solid" BorderWidth="1px" 
                       BackColor="White"> 
              <table>
               <tr>
               <td>
                   &nbsp;</td>
                 <td style="height: 20px; font-size: 18px; width: 2000px;" align="right">                
                <asp:LinkButton ID="LinkButton1" runat="server">Volver al Inicio</asp:LinkButton>
            </td>
                 </tr>                          
              </table>   
              </asp:Panel>   
            </td>     
                 
                 
            
         </tr>
 </table>
 
   
        <table style="background-color: #FFFFFF; font-size: medium; width: 508px; margin-left: 68px;" 
        bgcolor="White">           
             <tr>                          
                <td style="width: 600px" >
                    <asp:Panel ID="Panel7" runat="server" CssClass="style18" 
                        GroupingText="Elija los datos de la Programación Médica" Height="163px" 
                        Width="505px" BackColor="White">
                        <table bgcolor="White" style="height: 144px; width: 496px; margin-left: 0px;">
                            <tr>
                                <td style="width: 130px">
                                    <asp:Label ID="Label24" runat="server" Text="Especialidad"></asp:Label>
                                </td>
                                <td style="width: 250px">                                   
                                    <asp:DropDownList ID="DdEspecialidad" runat="server" Height="20px" 
                                        Width="331px" AutoPostBack="True">
                                    </asp:DropDownList>
                                </td>
                                 <td style="width: 130px" align="center">
                                     <asp:ImageButton ID="BtnNue" runat="server" Height="29px" 
                                         ImageUrl="~/Iconos/32.png" Width="29px" />
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 130px">
                                    <asp:Label ID="Label25" runat="server" Text="Médico"></asp:Label>
                                </td>
                                <td style="width: 250px">                                   
                                    <asp:DropDownList ID="DdMedico" runat="server" Height="20px" Width="331px">
                                    </asp:DropDownList>
                                </td>
                                 <td style="width: 130px" align="center">
                                     <asp:Label ID="Label29" runat="server" Text="Nuevo"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 130px">
                                    <asp:Label ID="Label26" runat="server" Text="Turno"></asp:Label>
                                </td>
                                <td style="width: 250px">                                   
                                    <asp:DropDownList ID="DdTurno" runat="server" Height="20px" Width="331px">
                                    </asp:DropDownList>
                                </td>
                                 <td style="width: 130px">
                                     &nbsp;</td>
                            </tr>
                             <tr>
                                <td style="width: 130px">
                                    <asp:Label ID="Label3" runat="server" Text="Tipo Atención"></asp:Label>
                                </td>
                                <td style="width: 250px">                                   
                                    <asp:DropDownList ID="DdTipoAtencion" runat="server" Height="20px" 
                                        Width="331px" AutoPostBack="True">
                                    </asp:DropDownList>
                                </td>
                                 <td style="width: 130px">
                                     &nbsp;</td>
                            </tr>
                        </table>                        
                    </asp:Panel>
                    <asp:Panel ID="Panel3" runat="server" Height="197px" Width="502px" 
                      CssClass="style18" GroupingText="Elija las fechas de la Programación Médica" 
                        style="margin-left: 3px" BorderStyle="Solid" BorderWidth="1px" 
                        BackColor="White">
                      <table bgcolor="White" style="height: 178px; width: 494px;">
                       <tr>
                          <td style="width: 1409px; height: 4px;">
                              <asp:Calendar ID="CFecha1" runat="server" BackColor="White" 
                                  BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" 
                                  Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="16px" 
                                  style="margin-left: 20px" Width="200px">
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
                          <td style="width: 1409px; height: 4px;" bgcolor="White">
                              <asp:Calendar ID="CFecha2" runat="server" BackColor="White" 
                                  BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" 
                                  Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="16px" 
                                  Width="200px" Enabled="False" Visible="False">
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
                   </asp:Panel>
                    </td>
                    <td>
                        <asp:Panel ID="Panel2" runat="server" Height="353px" Width="435px" 
                      CssClass="style18" GroupingText="Fechas de Programación Médica" 
                        style="margin-left: 3px" BorderStyle="Solid" BorderWidth="1px" 
                        ScrollBars="Vertical" BackColor="White" Visible="False">
                      <table bgcolor="White" style="height: 309px; width: 424px;">
                       <tr>
                          <td style="width: 1409px; height: 4px;">
                             <asp:GridView ID="gvprogramacion" runat="server" AutoGenerateColumns="False" 
                            CellPadding="4" Width="367px" ForeColor="#333333" GridLines="None" 
                                  style="margin-left: 21px">
                            <RowStyle BackColor="#EFF3FB" />
                            <Columns>                                                        
                               <asp:BoundField DataField="columna1" HeaderText="Fecha" ReadOnly="True" />                                                                               
                                <asp:TemplateField HeaderText="NumAtenciones" SortExpression="TextBox">                            
                                  <ItemTemplate> 
                                    <asp:TextBox ID="Txt1" Width="30px" Height="14px" EnableViewState="true" 
                                    runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.columna2") %>'></asp:TextBox>  
                                  </ItemTemplate>  
                                </asp:TemplateField>                                         
                                                    
                                <asp:TemplateField HeaderText="Atencion">
                                    <ItemTemplate>
                                        <asp:CheckBox ID="Ckeckbox1" runat="server"
                                        Text='<%# DataBinder.Eval(Container, "DataItem.columna3") %>' />                                       
                                    </ItemTemplate>
                                </asp:TemplateField>   
                                                        
                            </Columns>
                            <FooterStyle BackColor="#507CD1" ForeColor="White" Font-Bold="True" />
                            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                 <EditRowStyle BackColor="#2461BF" />
                                 <AlternatingRowStyle BackColor="White" />
                        </asp:GridView>   
                                        
                              <asp:GridView ID="GvNumSala" runat="server" AutoGenerateColumns="False" 
                                  Height="16px" Width="16px">
                                  <Columns>
                                      <asp:BoundField DataField="NUMSALA" HeaderText="NUMSALA" />
                                  </Columns>
                              </asp:GridView>
                              <asp:GridView ID="GvNumSala1" runat="server" AutoGenerateColumns="False" 
                                  Height="16px" Width="16px">
                                  <Columns>
                                      <asp:BoundField DataField="NUMSALA" HeaderText="NUMSALA" />
                                  </Columns>
                              </asp:GridView>
                          </td>                                     
                       </tr>
                      </table>                         
                  </asp:Panel>
                    
                    </td>
                   <td>
                   <asp:Panel ID="Panel8" runat="server" CssClass="style18" 
                        GroupingText="Datos de la Programación Médica" Height="295px" 
                        Width="435px" BackColor="White" Visible="False" >
                        <table bgcolor="White" style="height: 276px; width: 423px; margin-left: 0px;">
                            <tr>
                                <td style="width: 723px; height: 42px;">
                                    <asp:Label ID="Label17" runat="server" Text="Fecha"></asp:Label>
                                </td>
                                <td class="style9" style="width: 3953px; height: 42px;">
                                  
                                    <asp:Label ID="LblFechapm" runat="server"></asp:Label>
                                  
                                </td>
                                <td style="width: 208px; height: 42px;">
                                    <asp:Label ID="LblCodProgramacionMedica" runat="server" SkinID="Label" 
                                        Text="Label" Visible="False"></asp:Label>
                                    <asp:Label ID="LblCodDetalleProgramacionMedica" runat="server" Text="Label" 
                                        Visible="False"></asp:Label>
                                    <br />
                                    <asp:Label ID="LblCodMedicoEspecialidad" runat="server" Text="Label" 
                                        Visible="False"></asp:Label>
                                    <asp:Label ID="LblAtencion" runat="server" Text="Label" Visible="False"></asp:Label>
                                </td>
                                <td style="width: 3745px; height: 42px;">                                
                                </td> 
                                                              
                            </tr>
                            <tr>
                                <td style="width: 723px">
                                    <asp:Label ID="Label21" runat="server" Text="Cantidad Pacientes"></asp:Label>
                                </td>
                                <td class="style9" style="width: 3953px">
                                  
                                    <asp:TextBox ID="TxtCantidadConsultas" runat="server" Width="48px" 
                                        Visible="False"></asp:TextBox>
                                  
                                    <asp:Label ID="LblAtencionHospi" runat="server" Text="1" Visible="False"></asp:Label>
                                  
                                    <asp:CompareValidator ID="CompareValidator1" runat="server" 
                                        ControlToValidate="TxtCantidadConsultas" 
                                        ErrorMessage="Error. Debe ingresar SÓLO NÚMEROS" Font-Size="11pt" 
                                        Operator="DataTypeCheck" Type="Integer"></asp:CompareValidator>
                                  
                                </td>
                                <td style="width: 208px">
                                    <asp:Label ID="Label28" runat="server" Text="Duración Aprox. Operación" 
                                        Visible="False"></asp:Label>
                                </td>
                                <td style="width: 3745px">                                
                                    <asp:TextBox ID="TxtDuracionOperacion" runat="server" Visible="False" 
                                        Width="72px"></asp:TextBox>
                                </td>
                                                                
                            </tr>
                             <tr>
                                <td style="width: 208px">
                                    <asp:Label ID="Label27" runat="server" Text="Hora Operación" Visible="False"></asp:Label>
                                </td>
                                <td style="width: 3953px">
                                
                                    &nbsp;<asp:DropDownList ID="DdHoraOperacion" runat="server" Visible="False" 
                                        Width="59px" AutoPostBack="True">
                                    </asp:DropDownList>
                                    <asp:DropDownList ID="Ddhora" runat="server" Height="20px" 
                                        Visible="False" Width="65px" AutoPostBack="True">
                                    </asp:DropDownList>
                                
                                    <br />
                                
                                </td> 
                                <td style="width: 723px">
                                    &nbsp;</td>
                                <td class="style9" style="width: 395px">                                  
                                    <asp:CheckBox ID="Ch1" runat="server" Checked="True" Visible="False" />
                                </td>
                                                             
                            </tr>
                            <tr>
                                <td style="width: 723px">
                                    <asp:Label ID="Label4" runat="server" Text="N° Sala Operación" Visible="False"></asp:Label>
                                </td>
                                <td class="style9" style="width: 3953px">
                                  
                                    <asp:DropDownList ID="DdSalaOperacion" runat="server" Height="19px" 
                                        Visible="False" Width="105px" AutoPostBack="True">
                                    </asp:DropDownList>
                                  
                                    <asp:TextBox ID="TxtCodSala" runat="server" Visible="False" Width="34px"></asp:TextBox>
                                  
                                </td>
                                <td style="width: 208px">
                                
                                    &nbsp;</td>
                                <td style="width: 3745px">
                                 
                                    <asp:TextBox ID="TxtSala" runat="server" Width="42px" Visible="False"></asp:TextBox>
                                 
                                    <asp:Label ID="LblHoraope" runat="server" Text="Label" Visible="False"></asp:Label>
                                 
                                </td> 
                                                             
                            </tr>                           
                        </table>                       
                    </asp:Panel>
                     <asp:Panel ID="Panel1" runat="server" CssClass="style18" 
                        GroupingText="Cama" Height="62px" 
                        Width="430px" Visible="False" BackColor="White">
                        <table bgcolor="White" style="height: 25px; width: 423px; margin-left: 0px;">
                            <tr>
                                <td style="width: 723px; height: 42px;">
                                    <asp:Label ID="Label5" runat="server" Text="Num. Cama"></asp:Label>
                                </td>
                                <td class="style9" style="width: 395px; height: 42px;">
                                  
                                    <asp:DropDownList ID="DdCamas" runat="server" AutoPostBack="True">
                                    </asp:DropDownList>
                                  
                                </td>
                                <td style="width: 208px; height: 42px;">
                                    <asp:GridView ID="GvNumCama1" runat="server" AutoGenerateColumns="False" 
                                        Height="16px" Width="16px">
                                        <Columns>
                                            <asp:BoundField DataField="NUMCAMA" HeaderText="NUMCAMA" />
                                        </Columns>
                                    </asp:GridView>
                                </td>
                                <td style="width: 3745px; height: 42px;">                                
                                    <asp:GridView ID="GvNumCama" runat="server" AutoGenerateColumns="False" 
                                        Height="16px" Width="16px">
                                        <Columns>
                                            <asp:BoundField DataField="NUMCAMA" HeaderText="NUMCAMA" />
                                        </Columns>
                                    </asp:GridView>
                                </td> 
                                                               
                            </tr>
                                                                              
                        </table>                       
                    </asp:Panel>
                   
                   
                   </td>
                  
                   
                  </tr> 
                  
                </table> 
                             
                
                 
                
                   
                 <table style="background-color: #FFFFFF; font-size: medium; width: 525px; margin-left: 68px; margin-top: 0px; height: 76px;" 
        bgcolor="White">  
                  <tr>
                   <td>
                    <asp:Panel ID="Panel9" runat="server" CssClass="style18" Height="65px" 
                        Width="954px" BackColor="White" Visible="False">
                        <div style="text-align: left; width: 954px; height: 78px; margin-left: 0px;">
                            <table style="height: 67px; width: 956px;">
                                <tr>
                                    <td style="width: 445px">                                      
                                        
                                    </td> 
                                    <td style="width: 987px" align="center">                                      
                                        <asp:ImageButton ID="BtnNuevo" runat="server" Height="38px" Width="38px" 
                                            ImageUrl="~/Iconos/32.png" />
                                    </td>  
                                    <td align="center">                                      
                                        <asp:ImageButton ID="BtnRegistrar" runat="server" ImageUrl="~/Iconos/21.png" />
                                    </td> 
                                    <td style="width: 445px" align="center">                                      
                                        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Iconos/08.png" />
                                    </td>  
                                    <td style="width: 445px" align="center">                                      
                                        <asp:ImageButton ID="BtnImprimir" runat="server" Height="35px" 
                                            ImageUrl="~/Iconos/19.png" Width="36px" />
                                    </td> 
                                     <td style="width: 445px" align="center">                                      
                                         &nbsp;</td>
                                     <td style="width: 445px">                                      
                                       
                                         <asp:TextBox ID="TxtCodCama" runat="server" Visible="False" Width="29px"></asp:TextBox>
                                       
                                    </td>                                
                                </tr>
                                 <tr>
                                    <td style="width: 445px">                                      
                                        
                                    </td> 
                                    <td style="width: 987px" align="center">                                      
                                        <asp:Label ID="Label30" runat="server" Text="Nuevo"></asp:Label>
                                    </td>  
                                    <td align="center">                                      
                                        <asp:Label ID="Label31" runat="server" Text="Registrar"></asp:Label>
                                    </td> 
                                    <td style="width: 445px" align="center">                                      
                                        <asp:Label ID="Label32" runat="server" Text="Cancelar"></asp:Label>
                                    </td>  
                                    <td style="width: 445px" align="center">                                      
                                        <asp:Label ID="Label33" runat="server" Text="Imprimir"></asp:Label>
                                    </td> 
                                     <td style="width: 445px" align="center">                                      
                                         &nbsp;</td>
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

