<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PAdminRuta.aspx.cs" Inherits="CoinageUI.PAdminRuta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <meta charset="UTF-8">
    <title>Ingresar Ruta</title>
    <link href="Styles/Style.css" rel="stylesheet" />
    <meta name="viewport" content="width=device-width,initial-scale=1.0"/>


</head>
<body>
    
    
    <div class="container" >
        
       <form action="#" runat="server">

           
           <div class="title" style="display:block;float:left;width: 50%;">Ingresar una Ruta</div>
       
           
           
           <asp:LinkButton ID="LnkBtnRutasMenuAdmin" runat="server" style="display:block;margin-left:auto; text-align:right;width:50%;font-size: 17px; color: grey;" OnClick="LnkBtnRutasMenuAdmin_Click">Ir a Menu</asp:LinkButton>


           <div class="user-details">

                <div class="input-box">
                <span class="details">Nombre Ruta</span>
                <asp:TextBox ID="TxtBoxNombreRuta" runat="server" placeholder="Ingresa nombre Ruta"></asp:TextBox>
                </div>

                <div class="input-box">
                <span class="details">ID Ruta</span>
                    <%--<input type="text" placeholder="Ingresa tu cedula de identidad" />--%>
                 <asp:TextBox ID="TxtBoxRutaId" runat="server" placeholder="Ingresa Ruta ID"></asp:TextBox>
                </div>

                <div class="input-box">
                <span class="details">Costo</span>
                <asp:TextBox ID="TxtBoxCosto" runat="server" placeholder="Ingresa el costo de la ruta"></asp:TextBox>
                </div>

                <div class="input-box">
                <span class="details">Agregar Canton de la Ruta</span>                <%--<input type="text" placeholder="Ingresa tu numero de telefono" />--%>
                <asp:TextBox ID="TxtBoxRutaCanton" runat="server" placeholder="Ingresa el canton de la ruta"></asp:TextBox>
                </div>

            <%--    <div class="input-box">
                <span class="details">Password</span>
                
                <asp:TextBox ID="TxtBoxPassword" runat="server" placeholder="Ingresa tu contrasena"></asp:TextBox>
                </div>

                <div class="input-box">
                <span class="details">Confirm Password</span>
               
                <asp:TextBox ID="TxtBoxConfirmPass" runat="server" placeholder="Confirma tu contrasena"></asp:TextBox>
                </div>--%>

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
               
              <asp:Button ID="BtnAgregarRuta" runat="server" Text="Agregar Ruta" OnClick="BtnAgregarRuta_Click" />
              <%--<asp:Label ID="LblLoginFailed" runat="server" Text="Label" style="margin: 0 auto; color: #A72037" Visible="false">Usuario o Password incorrecto!</asp:Label>--%>
        </div>

           <asp:Label ID="LblRutaAgregada" runat="server" Text="Label" style="margin: 0 auto; margin-left: 30%; color: #A72037" Visible="False"></asp:Label>


        </form>

    </div>
    

    
</body>
</html>
