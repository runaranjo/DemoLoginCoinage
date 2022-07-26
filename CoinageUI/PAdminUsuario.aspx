<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PAdminUsuario.aspx.cs" Inherits="CoinageUI.PAdminUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <meta charset="UTF-8">
    <title>Registro Chofer</title>
    <link href="Styles/Style.css" rel="stylesheet" />
    <meta name="viewport" content="width=device-width,initial-scale=1.0"/>


</head>
<body>
    
    
   <div class="container" >
        
       <form action="#" runat="server">

           
           <div class="title" style="display:block;float:left;width: 50%;">Registro Chofer</div>
       
           
         <%--  <asp:LinkButton ID="LBGoBack" runat="server" style="display:block;margin-left:auto; text-align:right;width:50%;font-size: 17px; color: grey;" OnClick="LBGoBack_Click">Ir a Login</asp:LinkButton>--%>
           <asp:LinkButton ID="LinkMenuAdmin" runat="server" style="display:block;margin-left:auto; text-align:right;width:50%;font-size: 17px; color: grey;" OnClick="LinkMenuAdmin_Click">Ir a Menu</asp:LinkButton>


           <div class="user-details">

                <div class="input-box">
                <span class="details">Nombre Completo</span>
                <asp:TextBox ID="TxtBoxNombre" runat="server" placeholder="Ingresa tu nombre completo"></asp:TextBox>
                </div>

                <div class="input-box">
                <span class="details">ID</span>
                <%--<input type="text" placeholder="Ingresa tu cedula de identidad" />--%>
                 <asp:TextBox ID="TxtBoxID" runat="server" placeholder="Ingresa tu cedula de identidad"></asp:TextBox>
                </div>

                <div class="input-box">
                <span class="details">Email</span>
                <asp:TextBox ID="TxtBoxEmail" runat="server" placeholder="Ingresa tu correo"></asp:TextBox>
                </div>

                <div class="input-box">
                <span class="details">Phone Number</span>
                <%--<input type="text" placeholder="Ingresa tu numero de telefono" />--%>
                <asp:TextBox ID="TxtBoxTelefono" runat="server" placeholder="Ingresa tu numero de telefono"></asp:TextBox>
                </div>

                <div class="input-box">
                <span class="details">Password</span>
                <%-- <input type="text" placeholder="Ingresa tu contrasena" />--%>
                <asp:TextBox ID="TxtBoxPassword" runat="server" placeholder="Ingresa tu contrasena"></asp:TextBox>
                </div>

                <div class="input-box">
                <span class="details">Confirm Password</span>
               <%-- <input type="text" placeholder="Confirma tu contrasena" />--%>
                <asp:TextBox ID="TxtBoxConfirmPass" runat="server" placeholder="Confirma tu contrasena"></asp:TextBox>
                </div>

            </div>

           <asp:RadioButton ID="Admin" runat="server" />
           <asp:RadioButton ID="Chofer" runat="server" />

          <%-- <div class="gender-details"">
               <input type="radio" name="gender" id="dot-1" >
               <input type="radio" name="gender" id="dot-2" >
               <input type="radio" name="gender" id="dot-3" >
               <span class="gender-title">Gender</span>
                <div class="category">
                    <label for="dot-1"> 
                        <span class="dot one"></span>
                        <span class="gender">Male</span>
                    </label>
                    <label for="dot-2"> 
                        <span class="dot two"></span>
                        <span class="gender">Female</span>
                    </label>
                    <label for="dot-3"> 
                        <span class="dot three"></span>
                        <span class="gender">Prefer not to say</span>
                    </label>
                </div>
           </div>--%>
          <div class="button">
               <%--<asp:Button ID="BtnRegistrarse"  runat="server" Text="Registrarse" OnClick="BtnRegistrarse_Click"/>--%>
              <%--<asp:Label ID="LblLoginFailed" runat="server" Text="Label" style="margin: 0 auto; color: #A72037" Visible="false">Usuario o Password incorrecto!</asp:Label>--%>

              <asp:Button ID="Button1" runat="server" Text="Crear Usuario" />


        </div>

           <asp:Label ID="LblUsuarioIncorrecto" runat="server" Text="Label" style="margin: 0 auto; margin-left: 30%; color: #A72037" Visible="false"></asp:Label>


        </form>

    </div>
    
    

    
</body>
</html>
