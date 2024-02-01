<%@ Page Language="VB" MasterPageFile="~/WFPrincipal/PaginaMaestra.master" AutoEventWireup="false" CodeFile="BusquedaParaConsultorio.aspx.vb" Inherits="ModuloConsultorio_BusquedaParaConsultorio" title="Página sin título" MaintainScrollPositionOnPostback="true" %>

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


 <table style="width: 959px; height: 35px; margin-left: 14px; margin-top: 8px;" 
            frame="box">
          <tr>
            <td style="height: 28px; font-size: 20px; width: 849px;" align="center">
                <asp:Label ForeColor="#000099" ID="Label2" runat="server" 
                    Text="Módulo de Consultorio"></asp:Label>
            </td>  
            <td>
                <asp:LinkButton ID="LinkButton1" runat="server">Volver al inicio</asp:LinkButton>
            </td>           
          </tr>
 </table>
 <table class="style14">
         <tr>
            <td style="height: 28px; font-size: 18px; width: 1027px;" align="left">
                <asp:Label ForeColor="Blue" ID="Label1" runat="server" Text="Búsqueda de Paciente"></asp:Label>
            </td>
         </tr>
 </table> 
<asp:Panel ID="Panel1" runat="server" Height="83px" Width="953px" 
        CssClass="style14">
       <div style="text-align: left; width: 955px; height: 76px; margin-left: 0px;">
          <table style="width: 950px; height: 82px">
               <tr>              
                  <td style="width: 445px">                                    
                     <asp:Panel ID="Panel2" runat="server" Height="63px" Width="761px" 
                      CssClass="style14"
                      
                            
                          GroupingText="Búsqueda por Apellidos, Nombres, N° de Historia Clínica o DNI">
                       <table style="height: 38px; width: 720px; font-size: 15px;">                                                                                                       
                        <tr>
                            <td style="width: 55px; font-size: inherit; height: 30px;">
                                Dato</td>
                            <td style="width: 114px; height: 30px;">
                                <asp:TextBox ID="TxtBuscar" runat="server" Width="562px" 
                                    style="margin-left: 0px"></asp:TextBox>
                                <br />
                            </td>
                        </tr>                                                             
                      </table>                  
                    </asp:Panel>
                   </td>                             
                  <td rowspan="3">
                       <table style="width: 82px; margin-left: 46px; height: 27px;">                            
                             <tr>                                                            
                                   <td style="height: 26px">
                                         <asp:ImageButton ID="BtnBuscar" runat="server" Height="37px" 
                                             ImageUrl="~/Iconos/94.png" Width="46px" />
                                   </td>  
                              </tr>                                                             
                        </table>
                    </td>                 
               </tr>                 
          </table>       
     </div>    
  </asp:Panel>
 
 
  <asp:Panel ID="Panel3" runat="server" Height="291px" Width="953px" 
        CssClass="style14" ScrollBars="Vertical">
     <div style="height: 395px; width: 943px;">  
         <asp:GridView ID="GvListadoMovimientos" runat="server" AutoGenerateColumns="False" 
             AutoGenerateSelectButton="True" CellPadding="3" ForeColor="#333333" 
             style="margin-left: 16px" CellSpacing="2" Width="2135px">
             <RowStyle BackColor="#EFF3FB" BorderWidth="1px" />
             <Columns>
                 <asp:BoundField DataField="NHC" HeaderText="NHC" />
                 <asp:BoundField DataField="CODIGOSOLICITUDATENCION" 
                     HeaderText="CODIGO SOLICITUD ATENCION" />
                 <asp:BoundField DataField="NUMSOLICITUDATENCION" 
                     HeaderText="NUM. SOLICITUD ATENCION" />
                 <asp:BoundField DataField="CODVENTA" HeaderText="COD. VENTA" />
                 <asp:BoundField DataField="PACIENTE" HeaderText="PACIENTE" />
                 <asp:BoundField DataField="AREA" HeaderText="AREA" />
                 <asp:BoundField DataField="NOMESPECIALIDAD" HeaderText="ESPECIALIDAD" />
                 <asp:BoundField DataField="CODESPECIALIDAD" HeaderText="COD. ESPECIALIDAD" />
                 <asp:BoundField DataField="CODMEDICO" HeaderText="COD. MEDICO" />   
                 <asp:BoundField DataField="MEDICO" HeaderText="MEDICO" />
                 <asp:BoundField DataField="ANTECEDENTES" HeaderText="ANTECEDENTES" />
                 <asp:BoundField DataField="CODTRIAJE" HeaderText="COD. TRIAJE" />
                 <asp:BoundField DataField="TEMPERATURA" HeaderText="TEMPERATURA" />
                 <asp:BoundField DataField="FR" HeaderText="FR" />
                 <asp:BoundField DataField="PA" HeaderText="PA" />
                 <asp:BoundField DataField="PESO" HeaderText="PESO" />
                 <asp:BoundField DataField="TALLA" HeaderText="TALLA" />
                 <asp:BoundField DataField="FECHATRIAJE" HeaderText="FECHA TRIAJE" />
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
</asp:Content>

