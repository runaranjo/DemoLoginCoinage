<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PPrincipalChofer.aspx.cs" Inherits="CoinageUI.PPrincipalChofer" %>

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
        <div class="title">Bienvenido, Chofer</div>
        <table></table>
       <form action="#" runat="server">
            <div class="user-details">

               

              <table class="input-box">
                    <tr>
                    <th>ID Pasajero</th>
                    <th>Precio</th>
                    </tr>
                    <tr>
                     <td><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>  </td>
                     <td><asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>  </td>
                    </tr>
                </table>

            <%--    <div class="input-box">
                <span class="details">Cobro realizado con exito!</span>
                </div>--%>

               <div class="input-box">
                    <input type="submit" " Value="Cobrar a Pasajero" style="margin-top: 25px; color: #fff; background:linear-gradient(-135deg, #71b7e6, #9b59b6);"/>
                </div>


                <div class="input-box">
                    <input type="submit" Value="Generar Reportes" style=" color: #fff; background:linear-gradient(-135deg, #71b7e6, #9b59b6);"/>
                </div>

                <div class="input-box">
                
                </div>

                <div class="input-box">
                    <input type="submit" Value="Usuarios Rechazados" style=" color: #fff; background:linear-gradient(-135deg, #71b7e6, #9b59b6);"/>
                </div>

                <div class="input-box">
            <%--  <input type="submit" Value="Usuarios Rechazados" style=" color: #fff; background:linear-gradient(-135deg, #71b7e6, #9b59b6);"/>--%>
                </div>

            </div>
        

        <div class="button">
            <%--<input type="submit" Value="Salir" style="background: #71b7e6;"/>--%>

            <asp:Button ID="BtnSalirChofer" runat="server" Text="Salir" style=" color: #fff; background: #71b7e6;" OnClick="BtnSalirChofer_Click"/>

        </div>



        </form>

    </div>
    

    
</body>
</html>