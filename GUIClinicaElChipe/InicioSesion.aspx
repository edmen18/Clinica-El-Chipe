<%@ Page Language="VB" MasterPageFile="~/WFPrincipal/PaginaMaestra.master" AutoEventWireup="false" CodeFile="InicioSesion.aspx.vb" Inherits="InicioSesion" title="Página sin título" %>
<%@ outputcache Location="None" %>  

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="height: 357px; width: 972px; margin-left: 70px;" bgcolor="White">
 <tr>
   <td style="width: 1977px; height: 388px;" bgcolor="White">     
       <img alt="" src="Flash/Fondo.gif" 
           style="width: 510px; height: 314px; margin-left: 65px;" /></td>
   <td style="height: 388px; width: 571px" bgcolor="White">
     <table style="width: 234px; height: 175px; margin-left: 3px" bgcolor="#6699FF">
       <tr>
             <td align="center" bgcolor="#D7EDF4">
                 <asp:Label ID="Label4" runat="server" Font-Size="17pt" ForeColor="#0000CC" 
                     Text="Iniciar Sesión" Font-Bold="False"></asp:Label>
                 <br />
            </td>
        </tr>
        <tr>
            <td>
                <table style="width: 225px">
                    <tr>
                        <td style="width: 102px">
                            &nbsp;<asp:Label ID="Label5" runat="server" Font-Bold="True" ForeColor="White" 
                                Text="Usuario"></asp:Label>
                        </td>
                        <td class="style5" style="width: 10px">
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 102px">
                            <asp:TextBox ID="TxtUsuario" runat="server" Width="217px" CssClass="Mayuscula"></asp:TextBox>
                        </td>
                        <td style="width: 10px; height: 27px; color: #FF0000;">
                                *
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 102px">
                            &nbsp;<asp:Label ID="Label6" runat="server" Font-Bold="True" ForeColor="White" 
                                Text="Contraseña"></asp:Label>
                        </td>
                        <td class="style5" style="width: 10px">
                        
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 102px">
                            <asp:TextBox ID="TxtClave" runat="server" Width="214px" TextMode="Password"></asp:TextBox>
                        </td>
                        <td style="width: 10px; height: 27px; color: #FF0000;">
                                *
                        </td>
                    </tr>
                </table>
            </td>
        </tr> 
        <tr>
            <td align="center">
                <asp:Button ID="BtnInicioSesion" runat="server" Text="Iniciar Sesión" 
                    ForeColor="Blue" Height="34px" />
            </td>
        </tr>
         <tr>
            <td>
               
                <asp:Label ID="Label1" runat="server" Text="Le quedan"></asp:Label>
&nbsp;
                <asp:Label ID="LblContador" runat="server" Text="LblContador"></asp:Label>
&nbsp;<asp:Label ID="Label3" runat="server" Text="intentos para ingresar"></asp:Label>
               
            </td>
        </tr>
         <tr>
            <td>
                
                <asp:LinkButton ID="LinkButton1" Font-Underline="false" runat="server">¿No puedes acceder a tu cuenta?</asp:LinkButton>
                
            </td>
        </tr>
        <tr>
            <td>
                <br />
                <span class="style9">¿No tienes cuenta? Regístrate
                <asp:HyperLink ID="HyperLink1" runat="server" Font-Underline="False" 
                    ForeColor="#0066FF" NavigateUrl="~/RegistroClientes.aspx" 
                    style="color: #3333FF">Aquí</asp:HyperLink>
                </span>
            </td>
        </tr>    
     </table>
   </td>
 </tr>
</table>
<body>
</body>
</asp:Content>

