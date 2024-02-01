<%@ Page Language="VB" MasterPageFile="~/WFPrincipal/PaginaMaestra.master" AutoEventWireup="false" CodeFile="Sistema.aspx.vb" Inherits="WFPrincipal_Sistema" title="Página sin título" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <table style="width: 934px; height: 35px; margin-left: 78px; margin-top: 8px;" 
            frame="box">
          <tr>
            <td style="height: 28px; font-size: 20px; width: 1027px;" align="center">
                <asp:Label ForeColor="#000099" ID="Label1" runat="server" 
                    Text="BIENVENIDO AL SISTEMA DE CONSULTAS Y HOSPITALIZACIÓN" 
                    Font-Bold="True" Font-Names="Arial" Font-Size="12pt"></asp:Label>
            </td>           
          </tr>
        </table> 
 <table style="height: 375px; width: 930px; margin-left: 81px;" bgcolor="White" 
        align="left">
 <tr>
 <script languaje="JavaScript">
function cambiar (flag,img) {
if (document.images) {
if (document.images[img].permitirloaded) {
if (flag==1) document.images[img].src = document.images[img].permitir.src
else document.images[img].src = document.images[img].permitir.oldsrc
}
}
}
function preloadcambiar (img,adresse) {
if (document.images) {
img.onload = null;
img.permitir = new Image ();
img.permitir.oldsrc = img.src;
img.permitir.src = adresse;
img.permitirloaded = true;
}
}
</script>
 
 
 
 
 
   <td style="width: 221px; height: 337px;">
   
   
       <a href="" target="_BLANK" onmouseover="cambiar(1,'IMG1');" onmouseout="cambiar(0,'IMG1');">
<img alt="" src="../Imagenes/C2.jpg" border="0" name="IMG1" 
           onload="preloadcambiar(this,'../Imagenes/H1.jpg');" 
           style="height: 325px; width: 275px; margin-left: 22px"/>
</a>

   
   
   </td>
   <td style="height: 337px; width: 571px">
     <table style="width: 602px; height: 108px; margin-left: 3px" bgcolor="White">
        <tr>
             <td align="center" bgcolor="White" style="height: 31px">
                 <asp:Label ID="Label4" runat="server" Font-Size="17pt" ForeColor="#0000CC" 
                     Text="Sistema web" Font-Bold="False"></asp:Label>             
            </td>
        </tr>
        <tr style="color: #000000; font-size: 15px; font-family: 'Times New Roman', Times, serif">
            <td style="height: 90px" align="left">
             <script type="text/jscript" language="javascript">
text = "Con el sistema web buscamos mejorar la calidad para su atención "
maximo = 50 
minimo = 10 
function initEffetLoupe(obj) {
document.getElementById(obj).innerHTML = "<TABLE><TR onMouseOver=effetLoupe('"+obj+"')><TD>" + text + "</TD></TR></TABLE>"
}
function effetLoupe(obj) {
aff = ""
increment = (maximo-minimo)/(text.length/2)
pos = 0
taille = minimo
for(a=0; a<text.length; a++) {
lettre = text.charAt(a)
if (pos+minimo >= maximo) { increment = -increment }
pos += increment
taille = minimo + pos
aff += "<TD><FONT style='font-size:" + taille + "'>"+lettre+"</FONT></TD>"
}
document.getElementById(obj).innerHTML = "<TABLE><TR onMouseOut=initEffetLoupe('"+obj+"')>" + aff + "</TR></TABLE>"
}
</script>
<div ID="txt1" 
                    style="width: 538px; color: #000000; font-size: 14px; font-family: 'Times New Roman', Times, serif; margin-left: 0px;" 
                    align="center" ></DIV>
<script type="text/jscript" languaje="javascript">
initEffetLoupe("txt1")
</script>
         
          
            
            
            
                   
         
          
            
            
            
             </td>
        </tr> 
        </tr>
       
          
     </table>
      <table style="width: 605px; height: 198px;">
               <tr>
                 <td align="center" style="width: 259px">
                 
                 
                 
                <asp:LinkButton ID="LinkButton1" runat="server" Font-Underline=false 
                         PostBackUrl="~/InicioSesion.aspx">Ingrese a nuestro sistema</asp:LinkButton>
                 
                 
                 
                 </td>
                 <td>
                 
                 
                 
                     <asp:ImageButton ID="ImageButton1" runat="server" Height="130px" 
                         ImageUrl="~/Imagenes/SISTE.jpg" PostBackUrl="~/InicioSesion.aspx" 
                         Width="192px" />
                 
                 
                 
                 </td>                             
               </tr>
            </table>    
   </td>
 </tr>
</table>

</asp:Content>

