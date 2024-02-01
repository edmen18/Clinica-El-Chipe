<%@ Page Language="VB" MasterPageFile="~/WFPrincipal/PaginaMaestra.master" AutoEventWireup="false" CodeFile="ControlesVitales.aspx.vb" Inherits="Hospitalizacion_ControlesVitales" title="Página sin título" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<asp:Panel ID="Panel5" runat="server" Height="41px" BackColor="#5F94C9"
        style="margin-top: 0px" Width="1146px">   
    <table style="height: 33px; width: 1146px;" bgcolor="#5F94C9">                                    
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



<asp:Panel ID="Panel1" runat="server" Height="894px" Width="1143px"> 
 <table style="width: 907px; height: 10px; margin-left: 70px; margin-top: 8px;" 
            frame="box">
          <tr>
            <td style="height: 28px; font-size: 20px; width: 10830px;" align="center">
                <asp:Label ForeColor="#000099" ID="Label14" runat="server" 
                    Text="HOSPITALIZACIÓN"></asp:Label>
            </td> 
              <td style="height: 20px; font-size: 18px; width: 1901px;" align="left">                
                <asp:LinkButton ID="LinkButton1" runat="server">Volver al inicio</asp:LinkButton>                
            </td>          
          </tr>
 </table>
 <table bgcolor="White" 
        style="height: 0px; margin-bottom: 0px; width: 906px; margin-left: 70px;">
         <tr>
            <td style="height: 20px; font-size: 18px; width: 10813px;" align="left">
                 <asp:Label ForeColor="Blue" ID="Label15" runat="server" 
                     Text="Controles Vitales"></asp:Label>
            </td>
            <td style="height: 20px; font-size: 18px; width: 1901px;" align="left">                
                <asp:LinkButton ID="LinkButton2" runat="server">Volver a buscar</asp:LinkButton>                
            </td>     
         </tr>
 </table>
 
 
  <table border="1"                     
            style="background-color: #99CCFF; font-size: medium; width: 670px; margin-left: 68px;">
  <tr>
    <td>
 <table style="width:898px; margin-left: 4px;" bgcolor="White">        
        <tr>
            <td style="width: 158px" align="center">
                <asp:Label ID="Label1" runat="server" Text="Paciente"></asp:Label>
            </td>
            <td style="width: 1193px">
                <asp:Label ID="LblPaciente" runat="server"></asp:Label>
                &nbsp;</td>
            <td style="width: 203px" align="center">            
                <asp:ImageButton ID="ImageButton1" runat="server" Height="23px" 
                    ImageUrl="~/Iconos/47.png" />            
            </td>
        </tr> 
        <tr>
         <td style="width: 158px" align="center">
             <asp:Label ID="Label28" runat="server" Text="Día Hospitalizado"></asp:Label>
         </td>
         <td>
            <asp:Label ID="lbldiashospitalizado" runat="server"></asp:Label>
        
         </td>
         <td align="center" style="width: 203px">
         
             &nbsp;</td>
        </tr> 
        <tr>
         <td style="width: 158px" align="center">
             <asp:Label ID="Label29" runat="server" Text="Día de operado"></asp:Label>
         </td>
         <td>
            <asp:Label ID="lbldiasoperado" runat="server"></asp:Label>
         </td>
         <td style="width: 203px">
         
             &nbsp;</td>
        </tr> 
                
    </table>

   
   <table style="width:898px; margin-left: 4px; height: 132px;" bgcolor="White">   
    <tr>
      <td>
      <asp:Panel ID="Panel2" runat="server" Height="168px" Width="886px"  
       style="margin-left: 3px; margin-top: 0px;" BackColor="White">
        <table style="width: 884px">
         <tr>
          <td>
              <asp:Label ID="Label31" runat="server" Text="PA"></asp:Label>
          </td>
          <td>
              <asp:DropDownList ID="ddpresion" runat="server" Width="155px" Height="16px">
                  <asp:ListItem>5</asp:ListItem>
                  <asp:ListItem>10</asp:ListItem>
                  <asp:ListItem>15</asp:ListItem>
                  <asp:ListItem>20</asp:ListItem>
                  <asp:ListItem>25</asp:ListItem>
                  <asp:ListItem>30</asp:ListItem>
              </asp:DropDownList>
          </td>
          <td>
              <asp:Label ID="Label32" runat="server" Text="Pulso"></asp:Label>
          </td>
          <td>
              <asp:DropDownList ID="ddpulso" runat="server" Width="170px">
                  <asp:ListItem>5</asp:ListItem>
                  <asp:ListItem>10</asp:ListItem>
                  <asp:ListItem>15</asp:ListItem>
                  <asp:ListItem>20</asp:ListItem>
                  <asp:ListItem>25</asp:ListItem>
                  <asp:ListItem>30</asp:ListItem>
              </asp:DropDownList>
          </td>
          <td>
              <asp:Label ID="Label34" runat="server" Text="Temperatura"></asp:Label>
             </td>
          <td>
          
              <asp:DropDownList ID="ddtemp" runat="server" Width="123px">
                  <asp:ListItem>5</asp:ListItem>
                  <asp:ListItem>10</asp:ListItem>
                  <asp:ListItem>15</asp:ListItem>
                  <asp:ListItem>20</asp:ListItem>
                  <asp:ListItem>25</asp:ListItem>
                  <asp:ListItem>30</asp:ListItem>
                  <asp:ListItem>35</asp:ListItem>
                  <asp:ListItem>40</asp:ListItem>
                  <asp:ListItem>45</asp:ListItem>
              </asp:DropDownList>
             </td>
         </tr> 
         <tr>
          <td>
              <asp:Label ID="Label2" runat="server" Text="Peso"></asp:Label>
          </td>
          <td>
              <asp:TextBox ID="txtpeso" runat="server"></asp:TextBox>
          </td>
          <td>
              <asp:Label ID="Label4" runat="server">N° Deposiciones</asp:Label>
          </td>
          <td>
              <asp:TextBox ID="txtdeposiciones" runat="server"></asp:TextBox>
          </td>
          <td>
              <asp:Label ID="Label35" runat="server" Text="Orina"></asp:Label>
             </td>
          <td>
          
              <asp:TextBox ID="txtorina" runat="server"></asp:TextBox>
          
          </td>
         </tr>  
          <tr>
          <td>
              <asp:Label ID="Label9" runat="server" Text="N° Bal. Hídricos"></asp:Label>
          </td>
          <td>
              <asp:TextBox ID="txtbal" runat="server"></asp:TextBox>
          </td>
          <td>
              <asp:Label ID="Label11" runat="server">Menstruación</asp:Label>
          </td>
          <td>
              <asp:TextBox ID="txtmenstruacion" runat="server"></asp:TextBox>
          </td>
          <td>
              <asp:Label ID="Label36" runat="server" Text="Drenaje"></asp:Label>
              </td>
          <td>
          
              <asp:TextBox ID="txtdrenaje" runat="server"></asp:TextBox>
              </td>
         </tr> 
          <tr>
          <td>
              <asp:Label ID="Label16" runat="server" Text="Transfuciones"></asp:Label>
          </td>
          <td>
              <asp:TextBox ID="txttrans" runat="server"></asp:TextBox>
          </td>
          <td>
              <asp:Label ID="Label18" runat="server">Loquios</asp:Label>
          </td>
          <td>
              <asp:TextBox ID="txtloquios" runat="server"></asp:TextBox>
          </td>
          <td>
              &nbsp;</td>
          <td>
          
          </td>
         </tr>     
        </table>
        <table style="width: 886px; height: 50px; margin-left: 0px;" bgcolor="White">
                                <tr>
                                    <td style="width: 445px">                                      
                                        <asp:Label ID="LblHospitalizacion" runat="server"></asp:Label>
                                        <br />
                                        <asp:Label ID="lblcontrol" runat="server"></asp:Label>
                                        <br />
                                        <asp:Label ID="lbldetalle" runat="server"></asp:Label>
                                    </td>  
                                    <td style="width: 445px" align="center">                                      
                                        <asp:ImageButton ID="BtnRegistrar" runat="server" ImageUrl="~/Iconos/21.png" 
                                            Height="36px" Width="40px" />
                                        <br />
                                        <asp:Label ID="Label27" runat="server" Text="Registrar"></asp:Label>
                                    </td>                                    
                                    <td style="width: 445px">                                      
                                        &nbsp;</td>                                 
                                </tr>
                            </table> 
        
   </asp:Panel>
   </td>
   </tr>
    </table> 
    </td>
 </tr>
 </table>
 </asp:Panel>

</asp:Content>

