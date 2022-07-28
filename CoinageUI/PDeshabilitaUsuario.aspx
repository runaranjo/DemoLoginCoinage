<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PDeshabilitaUsuario.aspx.cs" Inherits="CoinageUI.PDeshabilitaUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <meta charset="UTF-8">
    <title>Deshabilitar Usuario</title>
    <link href="Styles/Style.css" rel="stylesheet" />
    <meta name="viewport" content="width=device-width,initial-scale=1.0"/>


</head>
<body>
    
    
   <div class="container" >
        
       <form action="#" runat="server">

           
           <div class="title" style="display:block;float:left;width: 50%;">Deshabilitar Usuario</div>
       
           <asp:LinkButton ID="LnkBtnDUMenuAdmin" runat="server" style="display:block;margin-left:auto; text-align:right;width:50%;font-size: 17px; color: grey;" OnClick="LnkBtnDUMenuAdmin_Click">Ir a Menu</asp:LinkButton>

           <div class="user-details">

                <div class="input-box">
                    <span class="details">Ingrese el correo del usuario</span>
                    <asp:TextBox ID="TxtboxEmailUsuario" runat="server"></asp:TextBox>
                </div>
               </div>

               <div class="user-details">

                 <div class="input-box">
                     <asp:Button ID="BtnBuscaUsuario" runat="server" Text="Buscar" OnClick="BtnBuscaUsuario_Click" />
                </div>


                <div class="input-box">
                   <span class="details">Nombre del Usuario</span>
                    <%--<asp:TextBox ID="TxtboxResultadoUsuario" runat="server" style="width:50%"></asp:TextBox>--%>
                    <asp:Label ID="LblUsuarioEncontrado" runat="server" Text="N/A" style="width:50%"></asp:Label>
                </div>

                <div class="input-box">
                   <span class="details">Estado del Usuario:</span>
                    <asp:Label ID="LblEstadoUsuario" runat="server" Text="N/A"></asp:Label>
                </div>


          </div>

              <div class="input-box">
                   
                </div>


          <div class="button">
              <asp:Button ID="BtnDeshabilitarUsuario" runat="server" Text="Deshabilitar" OnClick="BtnDeshabilitarUsuario_Click" />
           </div>

           <asp:Label ID="LblUsuarioIncorrecto" runat="server" Text="Usuario Deshabilitado" style="margin: 0 auto; margin-left: 30%; color: #A72037" Visible="False"></asp:Label>


        </form>

    </div>
    
    

    
</body>
</html>
