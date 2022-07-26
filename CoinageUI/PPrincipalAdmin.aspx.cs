using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CoinageUI
{
    public partial class PPrincipalAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnSalirAdmin_Click(object sender, EventArgs e)
        {

            Session.Abandon();
            Response.Redirect("Login.aspx");


        }

        protected void BtnAdminUsr_Click(object sender, EventArgs e)
        {
            Response.Redirect("PAdminUsuario.aspx");
        }

        protected void BtnDeshabilitaUsuario_Click(object sender, EventArgs e)
        {
            Response.Redirect("PDeshabilitaUsuario.aspx");
        }

        protected void BtnAdminRuta_Click(object sender, EventArgs e)
        {
            Response.Redirect("PAdminRuta.aspx");
        }
    }
}