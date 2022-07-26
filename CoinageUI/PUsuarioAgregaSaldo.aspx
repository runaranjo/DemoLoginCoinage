<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PUsuarioAgregaSaldo.aspx.cs" Inherits="CoinageUI.PUsuarioAgregaSaldo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">


<head runat="server">

    <meta charset="UTF-8">
    <title>Agregar Saldo</title>
    <link href="Styles/Style.css" rel="stylesheet" />
    <meta name="viewport" content="width=device-width,initial-scale=1.0"/>


</head>
<body>
    
    
    <div class="container">
       <form action="#" runat="server">

           <div class="title" style="display:block;float:left;width: 50%;">Agregar Saldo</div>
           <asp:LinkButton ID="LnkBtnUsuarioMenuPSaldo" runat="server" style="display:block;margin-left:auto; text-align:right;width:50%;font-size: 17px; color: grey;" OnClick="LnkBtnUsuarioMenuPSaldo_Click">Ir a Menu</asp:LinkButton>

            
           
           <div class="user-details">


                <div class="input-box">
                    <span class="details">Nombre en la Tarjeta</span>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </div>

                <div class="input-box">
                    <span class="details">Numero de Tarjeta</span>
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </div>


                <div class="input-box">
                <table class="input-box">
                    <tr>
                    <th>Fecha Expiracion</th>
                    <th>Codigo Seguridad</th>
                    </tr>
                    <tr>
                     <td><asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>  </td>
                     <td><asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>  </td>
                    </tr>
                </table>
            </div>


                 <div class="input-box">
                   <span class="details">Ingrese el monto a acreditar</span>
                   <asp:TextBox ID="TextBox1" runat="server" style="width:50%"></asp:TextBox>
                </div>


                <div class="input-box">
                    <asp:Button ID="Button1" runat="server" Text="Acreditar" style="width:70%; color: #fff; background:linear-gradient(-135deg, #71b7e6, #9b59b6);" />

                </div>


            </div>

    </form>

  </div>
    
</body>

</html>
