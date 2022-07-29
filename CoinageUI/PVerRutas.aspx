<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PVerRutas.aspx.cs" Inherits="CoinageUI.PVerRutas" %>

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

           <div class="title" style="display:block;float:left;width: 50%;">Ver Rutas</div>
        
           <asp:LinkButton ID="LnkBtnMenuUsuarioRutas" runat="server"  style="display:block;margin-left:auto; text-align:right;width:50%;font-size: 17px; color: grey;" OnClick="LnkBtnMenuUsuarioRutas_Click">Ir a Menu</asp:LinkButton>
            
           
           <div class="user-details">


                <div class="input-box">
                     <span class="details">Aca podes ver todas las rutas disponibles</span>                     <%--<asp:DropDownList ID="DropDownList1" runat="server" >
                        <asp:ListItem>Pavas</asp:ListItem>
                        <asp:ListItem>San Jose</asp:ListItem>
                        <asp:ListItem>Montes de Oca</asp:ListItem>
                        <asp:ListItem>Curridabat</asp:ListItem>
                        <asp:ListItem>Guadalupe</asp:ListItem>
                     </asp:DropDownList>--%>
               </div>
               
               
              <div class="input-box">
               <asp:Button ID="BtnVerRutas" runat="server" Text="Ver Rutas" OnClick="BtnVerRutas_Click" />
               </div>


                <div class="input-box" style="width: 100%; height: 400px; overflow:scroll">
                    
                    <asp:GridView ID="GVVerRutas" runat="server" Visible="false"></asp:GridView>
               </div>


                



            </div>

    </form>

  </div>
    
</body>





















</html>
