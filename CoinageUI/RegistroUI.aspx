<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistroUI.aspx.cs" Inherits="CoinageUI.RegistroUI" %>

<!DOCTYPE html>

<html lang="en" dir="ltr">
<head runat="server">

    <meta charset="UTF-8">
    <title>Registro</title>
    <link href="Style.css" rel="stylesheet" />
    <meta name="viewport" content="width=device-width,initial-scale=1.0"/>


</head>
<body>
    
    
    <div class="container" >
        
       <form action="#" runat="server">

           
           <div class="title" style="display:block;float:left;width: 50%;">Registro Usuario</div>
       
           
           <asp:LinkButton ID="LBGoBack" runat="server" style="display:block;margin-left:auto; text-align:right;width:50%;font-size: 17px; color: grey;" OnClick="LBGoBack_Click">Ir a Login</asp:LinkButton>
            


           <div class="user-details">
                <div class="input-box">
                <span class="details">Nombre Completo</span>
                    <input type="text" placeholder="Ingresa tu nombre completo" />
                </div>
                <div class="input-box">
                <span class="details">ID</span>
                <input type="text" placeholder="Ingresa tu cedula de identidad" />
                </div>
                <div class="input-box">
                <span class="details">Email</span>
                <input type="text" placeholder="Ingresa tu correo" />
                </div>
                <div class="input-box">
                <span class="details">Phone Number</span>
                <input type="text" placeholder="Ingresa tu numero de telefono" />
                </div>
                <div class="input-box">
                <span class="details">Password</span>
                <input type="text" placeholder="Ingresa tu contrasena" />
                </div>
                <div class="input-box">
                <span class="details">Confirm Password</span>
                <input type="text" placeholder="Confirma tu contrasena" />
                </div>
            </div>
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
               <asp:Button ID="BtnRegistrarse"  runat="server" Text="Registrarse"/>
        </div>


        </form>

    </div>
    

    
</body>
</html>

