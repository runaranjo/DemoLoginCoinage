using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace CoinageUI
{
    public partial class Login : System.Web.UI.Page
    {

        //TO-DO
        public static string role;

        
        protected void Page_Load(object sender, EventArgs e)
        {
            LblLoginFailed.Visible = false;
        }

        protected void  BtnLogin_Click(object sender, EventArgs e)
        {

                DBRead loginUsuario = new DBRead();
                int count  = loginUsuario.verificarUsuarioLogin(TxtUsername.Text.Trim(), TxtPassword.Text.Trim());
                int idRole = loginUsuario.verificarUsuarioRol(TxtUsername.Text.Trim());
                Session["username"] = TxtUsername.Text.Trim();


            if (count == 1 && idRole == 1)
                {
                    Response.Redirect("PPrincipalAdmin.aspx");
                }
                if (count == 1 && idRole == 2)
                {   
                    Response.Redirect("PPrincipalChofer.aspx");
                }

                if (count == 1 && idRole == 3)
                {
                    Response.Redirect("PPrincipalUsuario.aspx");
                }
                else { LblLoginFailed.Visible = true; }

        }


        protected void LBGoToRegistrarse_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegistroUI.aspx");
            
        }
    }
}