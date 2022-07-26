using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CoinageUI
{
    public partial class PPrincipalUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void BtnSalirUsuario_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Login.aspx");
        }

        protected void BtnAgregarSaldo_Click(object sender, EventArgs e)
        {
            Response.Redirect("PUsuarioAgregaSaldo.aspx");
        }

        protected void BtnVerRutas_Click(object sender, EventArgs e)
        {
            Response.Redirect("PVerRutas.aspx");
        }
    }
}