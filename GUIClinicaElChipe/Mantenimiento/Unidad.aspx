<%@ Page Language="VB" MasterPageFile="~/WFPrincipal/PaginaMaestra.master" AutoEventWireup="false" CodeFile="Unidad.aspx.vb" Inherits="Mantenimiento_Unidad" title="Página sin título" MaintainScrollPositionOnPostback="true" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Panel ID="Panel1" runat="server" Height="194px" Width="607px" 
        CssClass="style11">
       <div style="text-align: left; width: 607px; height: 187px; margin-left: 0px;">
          <table style="width: 600px; height: 194px">
               <tr>              
                  <td class="style2" style="width: 334px">  
                     <table style="width: 461px; height: 35px; margin-left: 13px;" frame="box">
                      <tr>
                            <td style="height: 21px; font-size: 20px; width: 460px;" align="center">
                                <span style="color: #000099; font-family: Bodoni MT Black; font-size: 20px;">Unidad</span></td>
                        </tr>
                     </table>               
                     <asp:Panel ID="Panel2" runat="server" Height="136px" Width="466px" 
                      CssClass="style11" GroupingText="Datos">
                       <table style="height: 114px; width: 457px; font-size: 15px;">
                                                                                              
                        <tr>
                            <td style="width: 128px; height: 24px;">
                                Código</td>
                            <td style="height: 24px;">
                                <asp:Label ID="LblCodigo" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 128px; font-size: inherit; height: 27px;">
                                Nombre</td>
                            <td style="height: 27px;">
                                <asp:TextBox ID="TxtNombre" runat="server" Width="370px" Enabled="False"></asp:TextBox></td>
                            <td style="width: 112px; height: 27px; color: #FF0000;">
                                *
                            </td>
                        </tr>                                                             
                      </table>                  
                    </asp:Panel>
                   </td>                             
                   <td rowspan="3" style="width: 62px">
                       <table style="height: 173px; width: 69px">
                              <tr>
                                  <td style="width: 100px">
                                      <asp:Button ID="BtnNuevo" runat="server" BackColor="#99CCFF"
                                          Font-Bold="True" Text="Nuevo" Width="90px" />
                                  </td>
                              </tr>
                              <tr>
                                  <td style="width: 100px">
                                      <asp:Button ID="BtnGuardar" runat="server" BackColor="#99CCFF" 
                                          Font-Bold="True" Text="Guardar" Width="90px" Enabled="False" />
                                  </td>
                              </tr>
                              <tr>
                                  <td style="width: 100px; height: 26px">
                                      <asp:Button ID="BtnEditar" runat="server" BackColor="#99CCFF" 
                                          Font-Bold="True" Text="Editar" Width="90px" />
                                  </td>
                              </tr>                             
                              <tr>
                                  <td style="width: 100px; height: 21px">
                                      <asp:Button ID="BtnReporte" runat="server" BackColor="#99CCFF" 
                                          Font-Bold="True" Text="Cancelar" Width="90px" />
                                  </td>
                              </tr>
                              <tr>
                                  <td style="width: 100px">
                                      <asp:Button ID="BtnEliminar" runat="server" BackColor="#99CCFF" 
                                          Font-Bold="True" Text="Eliminar" Width="90px" Height="26px" />
                                  </td>
                              </tr>
                              <tr>
                                  <td style="width: 100px">
                                      <asp:Button ID="BtnTerminar" runat="server" BackColor="#99CCFF" 
                                          Font-Bold="True" Text="Salir" Width="90px" />
                                  </td>
                              </tr>
                        </table>
                    </td>                 
               </tr>                 
          </table>       
     </div>    
  </asp:Panel>
 <asp:Panel ID="Panel4" runat="server" Height="74px" Width="607px" 
        CssClass="style11">
       <div style="text-align: left; width: 607px; height: 76px; margin-left: 0px;">
          <table style="width: 607px; height: 50px">
               <tr>              
                  <td style="width: 445px">                                    
                     <asp:Panel ID="Panel5" runat="server" Height="63px" Width="465px" 
                      CssClass="style11" GroupingText="Dato a buscar">
                       <table style="height: 38px; width: 455px; font-size: 15px;">                                                                                                       
                        <tr>
                            <td style="width: 55px; font-size: inherit; height: 30px;">
                                Unidad</td>
                            <td style="width: 114px; height: 30px;">
                                <asp:TextBox ID="TxtBuscar" runat="server" Width="381px" 
                                    style="margin-left: 0px"></asp:TextBox>
                            </td>
                            <td style="width: 112px; height: 27px; color: #FF0000;">
                                &nbsp;*
                            </td>
                        </tr>                                                             
                      </table>                  
                    </asp:Panel>
                   </td>                             
                   <td rowspan="3">
                       <table style="width: 99px; margin-left: 15px;">                            
                             <tr>
                                  <td style="width: 25px; height: 26px">
                                         <asp:Button ID="BtnBuscar" runat="server" BackColor="#99CCFF" 
                                          Font-Bold="True" Text="Buscar" Width="90px"/>                                                                          
                                  </td>
                              </tr>                                   
                        </table>
                    </td>                 
               </tr>                 
          </table>       
     </div>    
  </asp:Panel>
 
 
  <asp:Panel ID="Panel3" runat="server" Height="185px" Width="607px" 
        CssClass="style11" ScrollBars="Vertical">
     <div style="height: 180px; width: 583px;">  
         <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
             AutoGenerateSelectButton="True" BackColor="#99CCFF" CellPadding="4" 
             ForeColor="#333333" GridLines="None" Height="160px" 
             style="margin-left: 12px; margin-top: 6px" Width="574px">
             <RowStyle BackColor="#EFF3FB" />
             <Columns>
                 <asp:BoundField DataField="codunidad" HeaderText="Codigo" />
                 <asp:BoundField DataField="nomunidad" HeaderText="Unidad" />
                 <asp:BoundField DataField="estado" HeaderText="Estado" />
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
</asp:Content>

