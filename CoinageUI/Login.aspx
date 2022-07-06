<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CoinageUI.Login" %>

<!DOCTYPE html>

<html lang="en" dir="ltr">
<head runat="server">

    <meta charset="UTF-8">
    <title>Inicio Sesion</title>
    <link href="Style.css" rel="stylesheet" />
    <meta name="viewport" content="width=device-width,initial-scale=1.0"/>


</head>
<body>
    
    
    <div class="container">
        <div class="title">Inicia sesion</div>
       <form action="#" runat="server">
            <div class="user-details">
                <div class="input-box">
                <span class="details">Username</span>
                    <input type="text" placeholder="Ingresa tu usuario" />
                </div>
                <div class="input-box">
                <span class="details">Contrasena</span>
                <input type="text" placeholder="Ingresa tu contrasena" />
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

           <div class="float-container">

          <div class="button">
               <asp:Button ID="Button1"  runat="server" Text="Inicia Sesion" onClick="Button1_Click"/> 
          </div>

         <div class="button">
           <asp:Button ID="Button2" runat="server" Text="No tienes cuenta? Registrate" OnClick="Button2_Click" />
         </div>
         


        </div>
        </form>

    </div>
    

    
</body>
</html>
