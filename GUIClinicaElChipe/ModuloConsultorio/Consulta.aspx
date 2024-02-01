<%@ Page Language="VB" MasterPageFile="~/WFPrincipal/PaginaMaestra.master" AutoEventWireup="false" CodeFile="Consulta.aspx.vb" Inherits="ModuloConsultorio_Consulta" title="Página sin título" MaintainScrollPositionOnPostback="true" %>

<%@ PreviousPageType VirtualPath="~/ModuloConsultorio/BusquedaParaConsultorio.aspx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<asp:Panel ID="Panel6" runat="server" Height="41px" BackColor="#5F94C9" 
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
 <table style="width: 977px; height: 10px; margin-left: 23px; margin-top: 8px;" 
            frame="box">
          <tr>
            <td style="height: 28px; font-size: 20px; width: 1027px;" align="center">
                <asp:Label ForeColor="#000099" ID="Label2" runat="server" 
                    Text="Módulo de Consultorio"></asp:Label>
            </td>           
          </tr>
 </table>
 <table bgcolor="#DBEFF7" 
        style="height: 0px; margin-bottom: 0px; width: 975px; margin-left: 23px;">
         <tr>
            <td style="height: 20px; font-size: 18px; width: 6964px;" align="left">
                 <asp:Label ForeColor="Blue" ID="Label1" runat="server" 
                     Text="Consulta"></asp:Label>
            </td>
            <td style="height: 20px; font-size: 18px; width: 1027px;" align="left">
                <asp:LinkButton ID="LinkButton1" runat="server">Volver al inicio</asp:LinkButton>
            </td>
         </tr>
 </table>   
 <table border="1"                             
        
        style="background-color: #99CCFF; font-size: medium; width: 939px; margin-left: 22px; height: 1398px;">           
             <tr>                          
                <td style="height: 100px" >
                    <asp:Panel ID="Panel3" runat="server" CssClass="style16" 
                        GroupingText="Datos del Paciente" Height="68px" Width="970px">
                        <table bgcolor="#DBEFF7" style="height: 41px; width: 959px; margin-left: 0px;">
                            <tr>
                                <td style="width: 2529px">
                                    &nbsp; Apellidos y Nombres</td>
                                <td style="width: 5987px">
                                    <asp:Label ID="LblPaciente" runat="server"></asp:Label>
                                </td>
                                 <td style="width: 1301px">
                                     <asp:Label ID="Label37" runat="server" Text="Cod. Soli. Atención"></asp:Label>
                                </td>
                                <td style="width: 702px">
                                    &nbsp;
                                    <asp:Label ID="LblCodigoSolicitudAtencion" runat="server">Label</asp:Label>
                                </td>
                                 <td style="width: 419px">
                                     <asp:Label ID="Label38" runat="server" Text="Num. Soli. Atención"></asp:Label>
                                </td>
                                <td style="width: 702px">
                                    &nbsp;
                                    <asp:Label ID="LblNumSolicitudAtencion" runat="server">Label</asp:Label>
                                </td>
                                 <td style="width: 219px" align="center">
                                     &nbsp;<asp:Label ID="Label39" runat="server" Text="Venta"></asp:Label>
                                </td>
                                <td style="width: 722px">
                                    &nbsp;
                                    <asp:Label ID="LblCodVenta" runat="server">Label</asp:Label>
                                </td>
                            </tr>
                        </table>                    
                    </asp:Panel>
                      <asp:Panel ID="Panel2" runat="server" CssClass="style16" 
                        GroupingText="Historia Clínica" Height="101px" Width="970px">
                        <table bgcolor="#DBEFF7" style="height: 30px; width: 960px; margin-left: 0px;">
                            <tr>
                                <td style="width: 219px">
                                    &nbsp; NHC</td>
                                <td style="width: 702px">
                                    &nbsp;
                                    <asp:Label ID="LblNHC" runat="server"></asp:Label>
                                </td>
                                <td style="width: 702px">
                                    &nbsp;
                                    <asp:Label ID="Label3" runat="server">Especialidad</asp:Label>
                                </td>
                                <td style="width: 702px">
                                    &nbsp;
                                    <asp:Label ID="LblEspecialidad" runat="server"></asp:Label>
                                </td>  
                                <td style="width: 702px">
                                    &nbsp;
                                    <asp:Label ID="LblCodEspecialidad" runat="server"></asp:Label>
                                </td>                            
                            </tr>
                        </table> 
                        <table bgcolor="#DBEFF7" style="height: 50px; width: 959px; margin-left: 0px;">
                            <tr>
                                <td style="width: 219px">
                                    &nbsp; Antecedentes</td>
                                <td style="width: 702px">
                                    &nbsp;
                                    <asp:Label ID="LblAntecedentes" runat="server"></asp:Label>
                                </td>                              
                            </tr>
                        </table>                    
                    </asp:Panel>                  
                   
                    <asp:Panel ID="Panel1" runat="server" CssClass="style16" 
                        GroupingText="Triaje" Height="61px" Width="970px">
                        <table bgcolor="#DBEFF7" style="height: 40px; width: 959px; margin-left: 0px;">
                            <tr>
                                <td style="width: 1075px">
                                    &nbsp; Codigo</td>
                                <td style="width: 702px">
                                    &nbsp;
                                    <asp:Label ID="LblCodTriaje" runat="server" Text="Label"></asp:Label>
                                </td>
                                <td style="width: 1075px">
                                    &nbsp; T°</td>
                                <td class="style9" style="width: 772px">
                                    &nbsp;
                                    <asp:Label ID="LblTemperatura" runat="server" Text="Label"></asp:Label>
                                </td>
                                 <td style="width: 1075px">
                                    &nbsp; FR</td>
                                <td class="style9" style="width: 772px">
                                    &nbsp;
                                    <asp:Label ID="LblFR" runat="server" Text="Label"></asp:Label>
                                </td>
                                 <td style="width: 1075px">
                                    &nbsp; PA</td>
                                <td class="style9" style="width: 772px">
                                    &nbsp;
                                    <asp:Label ID="LblPA" runat="server" Text="Label"></asp:Label>
                                </td>
                                 <td style="width: 1075px">
                                    &nbsp; Peso</td>
                                <td class="style9" style="width: 772px">
                                    &nbsp;
                                    <asp:Label ID="LblPeso" runat="server" Text="Label"></asp:Label>
                                </td>
                                 <td style="width: 1075px">
                                    &nbsp; Talla</td>
                                <td class="style9" style="width: 772px">
                                    &nbsp;
                                    <asp:Label ID="LblTalla" runat="server" Text="Label"></asp:Label>
                                </td>
                                 <td style="width: 1075px">
                                    &nbsp; Fecha</td>
                                 <td class="style9" style="width: 772px">
                                    &nbsp;
                                    <asp:Label ID="LblFechaTriaje" runat="server" Text="Label"></asp:Label>
                                </td>
                                 <td class="style9" style="width: 772px">
                                    &nbsp;
                                     </td>
                            </tr>
                        </table>                    
                    </asp:Panel>
                    <asp:Panel ID="Panel5" runat="server" CssClass="style16" 
                        GroupingText="Consulta" Height="183px" Width="970px">
                        <table bgcolor="#DBEFF7" style="height: 41px; width: 958px; margin-left: 0px;">
                            <tr>
                                <td style="width: 219px">
                                    &nbsp; Código</td>
                                <td style="width: 702px">
                                    &nbsp;
                                    <asp:Label ID="LblCodigoConsulta" runat="server">Label</asp:Label>
                                </td>
                                <td style="width: 219px">
                                    &nbsp; Cod. Consulta</td>
                                <td style="width: 702px">
                                    &nbsp;
                                    <asp:Label ID="LblCodConsulta" runat="server"></asp:Label>
                                </td>
                                 <td style="width: 219px">
                                    &nbsp; Num. Consulta</td>
                                <td style="width: 702px">
                                    &nbsp;
                                    <asp:Label ID="LblNumConsulta" runat="server"></asp:Label>
                                </td>
                                 <td style="width: 219px">
                                     &nbsp; </td>
                                <td style="width: 702px">
                                    &nbsp;
                                    </td>                                
                            </tr>
                        </table>                         
                        <table bgcolor="#DBEFF7" style="height: 119px; width: 959px; margin-left: 0px;">
                            <tr>
                                <td style="width: 279px">
                                    &nbsp; Relato de la Enfermedad</td>
                                <td style="width: 434px">
                                    <asp:TextBox ID="TxtRelatoEnfermedad" runat="server" Height="57px" 
                                        Width="311px" TextMode="MultiLine"></asp:TextBox>
                                </td>
                                <td style="width: 202px">
                                    &nbsp; Examen Físico</td>
                                <td style="width: 702px">
                                    &nbsp;
                                    <asp:TextBox ID="TxtExamenFisico" runat="server" Height="57px" Width="337px" 
                                        TextMode="MultiLine"></asp:TextBox>
                                </td>                                                                                              
                            </tr>
                            <tr>
                                <td style="width: 279px">
                                    &nbsp;
                                    <asp:Label ID="Label36" runat="server" Text="Descripción"></asp:Label>
                                </td>
                                <td style="width: 434px">
                                    <asp:TextBox ID="TxtDescripcion" runat="server" Height="35px" 
                                        TextMode="MultiLine" Width="311px"></asp:TextBox>
                                </td>
                                <td style="width: 202px">
                                    &nbsp;
                                    <asp:Label ID="Label41" runat="server" Text="Resultado de Exámenes"></asp:Label>
                                    </td>
                                <td style="width: 702px">
                                    &nbsp;
                                    <asp:TextBox ID="TxtResultadoExamenes" runat="server" Height="37px" 
                                        TextMode="MultiLine" Width="337px"></asp:TextBox>
                                    </td>                                                                                              
                            </tr>
                        </table>                                         
                    </asp:Panel>
                     <asp:Panel ID="Panel8" runat="server" Height="83px" Width="970px" 
        CssClass="style16">
       <div style="text-align: left; width: 963px; height: 76px; margin-left: 0px;">
          <table style="width: 960px; height: 82px">
               <tr>              
                  <td style="width: 445px">                                    
                     <asp:Panel ID="Panel11" runat="server" Height="63px" Width="677px" 
                      CssClass="style16"
                      
                            GroupingText="Buscar Diagnóstico">
                       <table style="height: 38px; width: 669px; font-size: 15px;">                                                                                                       
                        <tr>
                            <td style="width: 55px; font-size: inherit; height: 30px;">
                                Dato</td>
                            <td style="width: 114px; height: 30px;">
                                <asp:TextBox ID="TxtBuscarDiagnostico" runat="server" Width="243px" 
                                    style="margin-left: 0px"></asp:TextBox>
                                <br />
                            </td>
                        </tr>                                                             
                      </table>                  
                    </asp:Panel>
                   </td>                             
                   <td rowspan="3">
                       <table style="width: 98px; margin-left: 7px; height: 27px;">                            
                             <tr>
                                  <td style="height: 26px">
                                         <asp:Button ID="Button1" runat="server" BackColor="#99CCFF" 
                                          Font-Bold="True" Text="Buscar" Width="73px" Height="27px"/>                                                                          
                                         &nbsp;                                                                          
                                   </td>                                   
                              </tr>
                                                             
                        </table>
                    </td>                 
               </tr>                 
          </table>       
     </div>    
  </asp:Panel>
  
  <asp:Panel ID="Panel13" runat="server" Height="130px" Width="970px" 
        CssClass="style16" ScrollBars="Vertical">
     <div style="height: 140px; width: 965px;">  
         <asp:GridView ID="GvListaDiagnostico" runat="server" 
             AutoGenerateColumns="False" AutoGenerateSelectButton="True" CellPadding="3" 
             CellSpacing="2" ForeColor="#333333" style="margin-left: 16px" Width="950px">
             <RowStyle BackColor="#EFF3FB" BorderWidth="1px" />
             <Columns>
                 <asp:BoundField DataField="CODDIAGNOSTICO" HeaderText="COD. DIAGNOSTICO" />
                 <asp:BoundField DataField="CODIGO" HeaderText="CODIGO" />
                 <asp:BoundField DataField="DIAGNOSTICO" HeaderText="DIAGNOSTICO" />
                 <asp:BoundField DataField="CODENFERMEDAD" HeaderText="COD. ENFERMEDAD" />
                 <asp:BoundField DataField="NOMENFERMEDAD" HeaderText="ENFERMEDAD" />
             </Columns>
             <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
             <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
             <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
             <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
             <EditRowStyle BackColor="#2461BF" />
             <AlternatingRowStyle BackColor="White" />
         </asp:GridView>
    </div>  
  </asp:Panel>  
                    <asp:Panel ID="Panel7" runat="server" CssClass="style16" 
                        GroupingText="Diagnóstico" Height="130px" Width="970px">
                        <table bgcolor="#DBEFF7" style="height: 110px; width: 959px; margin-left: 0px;">
                            <tr>
                                <td style="width: 219px; height: 17px;">
                                    &nbsp;Enfermedad</td>
                                <td style="width: 702px; height: 17px;">
                                    &nbsp;
                                    <asp:Label ID="LblE1" runat="server"></asp:Label>
                                </td>
                                <td style="width: 702px; height: 17px;">
                                    &nbsp;
                                    <asp:Label ID="LblCodE1" runat="server"></asp:Label>
                                </td>
                                <td style="width: 219px; height: 17px;">
                                    &nbsp;Diagnóstico</td>
                                <td style="width: 2720px; height: 17px;">
                                    &nbsp;
                                    <asp:Label ID="LblDiag1" runat="server"></asp:Label>
                                </td>
                                <td style="width: 702px; height: 17px;">
                                    &nbsp;
                                    <asp:Label ID="LblCodD1" runat="server"></asp:Label>
                                </td>
                                 <td style="width: 219px; height: 17px;">
                                     &nbsp; Tipo<br />
                                     Diagnóstico</td>
                                <td style="width: 702px; height: 17px;">
                                    &nbsp;
                                    <asp:DropDownList ID="DdTipoDiagnostico" runat="server">
                                    </asp:DropDownList>
                                </td> 
                                <td style="width: 702px; height: 17px;">
                                    &nbsp;
                                    <asp:Button ID="Button2" runat="server" Text="Button" />
                                </td>                                                           
                            </tr>
                            <tr>
                                <td style="width: 219px">
                                    &nbsp;Enfermedad</td>
                                <td style="width: 702px">
                                    &nbsp;
                                    <asp:Label ID="LblE2" runat="server"></asp:Label>
                                </td>
                                <td style="width: 702px">
                                    &nbsp;
                                    <asp:Label ID="LblCodE2" runat="server"></asp:Label>
                                </td>
                                <td style="width: 219px">
                                    &nbsp;Diagnóstico</td>
                                <td style="width: 2720px">
                                    &nbsp;
                                    <asp:Label ID="LblDiag2" runat="server"></asp:Label>
                                </td>
                                <td style="width: 702px">
                                    &nbsp;
                                    <asp:Label ID="LblCodD2" runat="server"></asp:Label>
                                </td>
                                 <td style="width: 219px">
                                     &nbsp; Tipo<br />
                                     Diagnóstico</td>
                                <td style="width: 702px">
                                    &nbsp;
                                    <asp:DropDownList ID="DdTipoDiag" runat="server">
                                    </asp:DropDownList>
                                </td>  
                                <td style="width: 702px; height: 17px;">
                                    &nbsp;
                                    <asp:Button ID="Button3" runat="server" Text="Button" />
                                </td>                                                           
                            </tr>
                        </table>                                                                                 
                    </asp:Panel> 
                    <asp:Panel ID="Panel14" runat="server" Height="83px" Width="970px" 
        CssClass="style16">
       <div style="text-align: left; width: 963px; height: 76px; margin-left: 0px;">
          <table style="width: 961px; height: 82px">
               <tr>              
                  <td style="width: 445px">                                    
                     <asp:Panel ID="Panel12" runat="server" Height="63px" Width="677px" 
                      CssClass="style16"
                      
                            GroupingText="Buscar Medicamento">
                       <table style="height: 38px; width: 669px; font-size: 15px;">                                                                                                       
                        <tr>
                            <td style="width: 55px; font-size: inherit; height: 30px;">
                                Dato</td>
                            <td style="width: 114px; height: 30px;">
                                <asp:TextBox ID="TxtBuscarMedicamento" runat="server" Width="243px" 
                                    style="margin-left: 0px"></asp:TextBox>
                                <br />
                            </td>
                        </tr>                                                             
                      </table>                  
                    </asp:Panel>
                   </td>                             
                   <td rowspan="3">
                       <table style="width: 98px; margin-left: 7px; height: 27px;">                            
                             <tr>
                                  <td style="height: 26px">
                                         <asp:Button ID="BtnBuscar" runat="server" BackColor="#99CCFF" 
                                          Font-Bold="True" Text="Buscar" Width="73px" Height="27px"/>                                                                          
                                         &nbsp;                                                                          
                                   </td>                                   
                              </tr>
                                                             
                        </table>
                    </td>                 
               </tr>                 
          </table>       
     </div>    
  </asp:Panel>
 
 
  <asp:Panel ID="Panel10" runat="server" Height="126px" Width="970px" 
        CssClass="style16" ScrollBars="Vertical">
     <div style="height: 136px; width: 963px;">  
         <asp:GridView ID="GvListaMedicamento" runat="server" AutoGenerateColumns="False" 
             AutoGenerateSelectButton="True" CellPadding="3" ForeColor="#333333" 
             style="margin-left: 16px" CellSpacing="2" Width="817px">
             <RowStyle BackColor="#EFF3FB" BorderWidth="1px" />
             <Columns>
                 <asp:BoundField DataField="CODMEDICAMENTO" HeaderText="COD. MEDICAMENTO" />
                 <asp:BoundField DataField="NOMMEDICAMENTO" HeaderText="MEDICAMENTO" />
                 <asp:BoundField DataField="UTILIDAD" HeaderText="UTILIDAD" />
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
                       <asp:Panel ID="Panel4" runat="server" CssClass="style16" 
                        GroupingText="Tratamiento y Receta" Height="176px" Width="970px">                         
                        <table bgcolor="#DBEFF7" style="height: 69px; width: 957px; margin-left: 0px;">
                            <tr>
                                <td style="width: 219px">
                                    &nbsp;
                                    <asp:Label ID="Label30" runat="server" Text="Cod. Receta"></asp:Label>
                                </td>
                                <td style="width: 702px">
                                    &nbsp;
                                    <asp:Label ID="LblCodReceta" runat="server">Label</asp:Label>
                                </td>
                                <td style="width: 219px">
                                    &nbsp;
                                    <asp:Label ID="Label31" runat="server" Text="Num. Receta"></asp:Label>
                                </td>
                                <td style="width: 702px">
                                    &nbsp;
                                    <asp:TextBox ID="TxtNumReceta" runat="server" Width="71px"></asp:TextBox>
                                </td>
                                 <td style="width: 219px">
                                     <asp:Label ID="Label32" runat="server" Text="Medicamento"></asp:Label>
                                </td>
                                <td style="width: 702px">
                                    &nbsp;
                                    <asp:Label ID="LblM" runat="server"></asp:Label>
                                </td> 
                                 <td style="width: 702px">
                                     &nbsp;
                                    <asp:Label ID="LblCodM" runat="server"></asp:Label>
                                </td>  
                                <td style="width: 702px">
                                    &nbsp;
                                    <asp:Label ID="LblCan" runat="server">Cantidad</asp:Label>
                                </td> 
                                    <td style="width: 702px">
                                        &nbsp;
                                        <asp:TextBox ID="TxtCantidad" runat="server" Width="50px"></asp:TextBox>
                                </td> 
                                    <td style="width: 702px">
                                        &nbsp;
                                    <asp:Label ID="LblUtilidad" runat="server"></asp:Label>
                                </td>                                                              
                            </tr>                           
                        </table>
                         <table bgcolor="#DBEFF7" style="height: 85px; width: 957px; margin-left: 0px;">
                            <tr>
                                <td style="width: 203px">
                                    <asp:Label ID="Label34" runat="server" Text="Tratamiento"></asp:Label>
                                </td>
                                <td style="width: 434px">
                                    <asp:TextBox ID="TxtTratamiento" runat="server" Height="66px" Width="491px" 
                                        TextMode="MultiLine"></asp:TextBox>
                                </td>
                                <td style="width: 219px">
                                    <asp:Button ID="BtnNuevo" runat="server" Text="Nuevo" />
                                    &nbsp;
                                    <asp:Button ID="Button4" runat="server" Text="Agregar" />
                                 </td>
                                 <td style="width: 219px">
                                     <asp:Label ID="Label40" runat="server" Text="Fecha Prox. Cita"></asp:Label>
                                 </td> 
                                 <td style="width: 219px">
                                     <asp:TextBox ID="TxtProximaCita" runat="server"></asp:TextBox>
                                 </td>                                                                                             
                                                                                                                               
                            </tr>
                        </table>                                                                                                        
                    </asp:Panel> 
                     <asp:Panel ID="Panel15" runat="server" Height="109px" Width="970px" 
        CssClass="style16" ScrollBars="Vertical">
     <div style="height: 118px; width: 964px;">  
         <asp:GridView ID="GvTratamiento" runat="server" AutoGenerateColumns="False" 
             AutoGenerateSelectButton="True" CellPadding="4" ForeColor="#333333" 
             GridLines="None" Height="16px" Width="579px">
             <RowStyle BackColor="#EFF3FB" />
             <Columns>
                 <asp:BoundField DataField="Columna1" HeaderText="Cod. Receta" />
                 <asp:BoundField DataField="Columna2" HeaderText="Cod. Medicamento" />
                 <asp:BoundField DataField="Columna3" HeaderText="Medicamento" />
                 <asp:BoundField DataField="Columna4" HeaderText="Cantidad" />
                 <asp:BoundField DataField="Columna5" HeaderText="Tratamiento" />
             </Columns>
             <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
             <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
             <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
             <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
             <EditRowStyle BackColor="#2461BF" />
             <AlternatingRowStyle BackColor="White" />
         </asp:GridView>
    </div>  
  </asp:Panel>  
                  <asp:Panel ID="Panel9" runat="server" CssClass="style16" Height="53px" 
                        Width="970px">
                        <div style="text-align: left; width: 961px; height: 76px; margin-left: 0px;">
                            <table style="width: 870px; height: 50px">
                                <tr>
                                    <td style="width: 445px">                                      
                                    </td>  
                                    <td style="width: 445px">                                      
                                        <asp:Button ID="BtnGuardar" runat="server" style="margin-left: 70px" 
                                            Text="Guardar" Width="90px" />
                                    </td> 
                                    <td style="width: 445px">                                      
                                        <asp:Button ID="BtnSalir" runat="server" style="margin-left: 24px" Text="Salir" 
                                            Width="81px" />
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

