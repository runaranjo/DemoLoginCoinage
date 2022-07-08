using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


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

            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=.\sqlexpress; initial Catalog=ViajeFacil; Integrated Security=True;"))
            {

                sqlCon.Open();
                string query = "Select Count(1) FROM Usuario WHERE email=@username AND password=@password";
                SqlCommand sqlcom = new SqlCommand(query, sqlCon);
                sqlcom.Parameters.AddWithValue("@username", TxtUsername.Text.Trim());
                sqlcom.Parameters.AddWithValue("@password", TxtPassword.Text.Trim());
                int count = Convert.ToInt32(sqlcom.ExecuteScalar());
                if (count == 1)
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