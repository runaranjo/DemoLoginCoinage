<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PPrincipalUsuario.aspx.cs" Inherits="CoinageUI.PPrincipalUsuario" %>

<!DOCTYPE html>

<html lang="en" dir="ltr">
<head runat="server">

    <meta charset="UTF-8">
    <title>Principal</title>
    <link href="Style.css" rel="stylesheet" />
    <meta name="viewport" content="width=device-width,initial-scale=1.0"/>


</head>
<body>
    
    
    <div class="container">
        <div class="title">Bienvenido, Pasajero</div>
        <table></table>
       <form action="#" runat="server">
            <div class="user-details">

                <div class="input-box">
                    <input type="submit" Value="Rutas" style=" color: #fff; background:linear-gradient(-135deg, #71b7e6, #9b59b6);"/>
                </div>

                <div class="input-box">
                <span class="details">Mi Saldo: 4,350.00 </span>
               
                </div>

                <div class="input-box">
                    <input type="submit" Value="Agregar saldo" style=" color: #fff; background:linear-gradient(-135deg, #71b7e6, #9b59b6);"/>
                </div>

                <div class="input-box">
                
                </div>

                <div class="input-box">
                    <input type="submit" Value="Mis metodos de pago" style=" color: #fff; background:linear-gradient(-135deg, #71b7e6, #9b59b6);"/>
                </div>

                <div class="input-box">
              
                </div>

            </div>
        

        <div class="button">
            <%--<input type="submit" Value="Salir" style="background: #71b7e6;"/>--%>
            <asp:Button ID="BtnSalirUsuario" runat="server" Text="Salir" style=" color: #fff; background: #71b7e6;" OnClick="BtnSalirUsuario_Click" />
        </div>



        </form>

    </div>
    

    
</body>
</html>