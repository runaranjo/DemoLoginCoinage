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

        
        protected void Page_Load(object sender, EventArgs e)
        {
            LblLoginFailed.Visible = false;
        }

        protected void  BtnLogin_Click(object sender, EventArgs e)
        {


            

            using (SqlConnection sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConexion"].ConnectionString))
            {

                sqlCon.Open();
                string query = "Select Count(1) FROM Usuario WHERE email=@username AND password=@password";
                string queryIdRol = "Select idRol FROM Usuario WHERE email=@username";
                SqlCommand sqlcom = new SqlCommand(query, sqlCon);
                SqlCommand sqlcom2 = new SqlCommand(queryIdRol, sqlCon);
                sqlcom.Parameters.AddWithValue("@username", TxtUsername.Text.Trim());
                sqlcom.Parameters.AddWithValue("@password", TxtPassword.Text.Trim());

                sqlcom2.Parameters.AddWithValue("@username", TxtUsername.Text.Trim());
                int count = Convert.ToInt32(sqlcom.ExecuteScalar());

                int idRole = Convert.ToInt32(sqlcom2.ExecuteScalar());


                if (count == 1 && idRole == 1)
                {
                    Session["username"] = TxtUsername.Text.Trim();
                    Response.Redirect("PPrincipalAdmin.aspx");
                }
                if (count == 1 && idRole == 2)
                {
                    Session["username"] = TxtUsername.Text.Trim();
                    Response.Redirect("PPrincipalChofer.aspx");
                }

                if (count == 1 && idRole == 3)
                {
                    Session["username"] = TxtUsername.Text.Trim();
                    Response.Redirect("PPrincipalUsuario.aspx");
                }
                else { LblLoginFailed.Visible = true; }
            }



        }


        protected void LBGoToRegistrarse_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegistroUI.aspx");
            
        }
    }
}