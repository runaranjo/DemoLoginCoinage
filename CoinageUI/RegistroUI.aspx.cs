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


        DBCreate registraUsuario = new DBCreate();
        DBCreate registraPasajero = new DBCreate();

   

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LBGoBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void BtnRegistrarse_Click(object sender, EventArgs e)
        {

                DBRead count = new DBRead();
 
                if (count.verificaUsuarioRegistro(TxtBoxEmail.Text) == 1)
                {
                    string usuarioInvalido = "El usuario es invalido o ya existe";
                    LblUsuarioIncorrecto.Text = usuarioInvalido;
                    LblUsuarioIncorrecto.Visible = true;

                }
                else
                {

                int pasajeroId = Convert.ToInt32(TxtBoxID.Text);

                registraUsuario.insertRegistroUsuario(TxtBoxEmail.Text, TxtBoxPassword.Text, 3);
                registraPasajero.insertRegistroPasajero(pasajeroId, TxtBoxNombre.Text, TxtBoxEmail.Text, 0);

                    TxtBoxNombre.Text = "";
                    TxtBoxID.Text = "";
                    TxtBoxEmail.Text = "";
                    TxtBoxTelefono.Text = "";
                    TxtBoxPassword.Text = "";
                    TxtBoxConfirmPass.Text = "";

                LblUsuarioIncorrecto.Text = "Te has registrado con exito!!";
                }

        }
    }
}