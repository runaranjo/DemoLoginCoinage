using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CoinageUI
{
    public partial class PPrincipalUsuario : System.Web.UI.Page
    {

        DBRead dbSaldoUsario = new DBRead();
        


        protected void Page_Load(object sender, EventArgs e)
        {

          string saldoUsuario = Convert.ToString(dbSaldoUsario.mostrarSaldo(Session["username"].ToString()));
          LblSaldoUsuario.Text = saldoUsuario;

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