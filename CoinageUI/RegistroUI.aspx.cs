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
    public partial class RegistroUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LBGoBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void BtnRegistrarse_Click(object sender, EventArgs e)
        {
            //using (SqlConnection sqlCon = new SqlConnection(@"Data Source=.\sqlexpress; initial Catalog=ViajeFacil; Integrated Security=True;"))
            //{


            //    sqlCon.Open();

            //    string checkDB = "Select Count(1) FROM Usuario WHERE email=@username";
            //    SqlCommand sqlcom = new SqlCommand(checkDB, sqlCon);
            //    sqlcom.Parameters.AddWithValue("@username", TxtBoxEmail.Text);
            //    int count = Convert.ToInt32(sqlcom.ExecuteScalar());

                DBRead cnt = new DBRead();
            //cnt.VerificaUsuarioRegistro(TxtBoxEmail.Text);



                if (cnt.VerificaUsuarioRegistro(TxtBoxEmail.Text) == 1)
                {
                    string usuarioInvalido = "El usuario es invalido o ya existe";
                    LblUsuarioIncorrecto.Text = usuarioInvalido;
                    LblUsuarioIncorrecto.Visible = true;

                }
            //else
            //{

            //    string query = "Insert into Usuario (email,password,activo,idrol) Values(@email, @password, @activo, @idrol)";

            //    SqlCommand insertarCom = new SqlCommand(query, sqlCon);
            //    insertarCom.Parameters.AddWithValue("@email", TxtBoxEmail.Text);
            //    insertarCom.Parameters.AddWithValue("@password", TxtBoxPassword.Text);
            //    insertarCom.Parameters.AddWithValue("@activo", true);
            //    insertarCom.Parameters.AddWithValue("@idrol", 3);
            //    insertarCom.ExecuteNonQuery();
            //    sqlCon.Close();




            //}





            //sqlCon.Open();
            //string query = "Select Count(1) FROM Usuario WHERE email=@username AND password=@password";
            //SqlCommand sqlcom = new SqlCommand(query, sqlCon);
            //sqlcom.Parameters.AddWithValue("@username", TxtUsername.Text.Trim());
            //sqlcom.Parameters.AddWithValue("@password", TxtPassword.Text.Trim());
            //int count = Convert.ToInt32(sqlcom.ExecuteScalar());
            //if (count == 1)
            //{
            //    Session["username"] = TxtUsername.Text.Trim();
            //    Response.Redirect("PPrincipalUsuario.aspx");
            //}
            //else { LblLoginFailed.Visible = true; }
            //}
        }
    }
}