using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CoinageUI
{


    public partial class PAdminUsuario : System.Web.UI.Page
    {

        DBCreate registrarUsuario = new DBCreate();


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkMenuAdmin_Click(object sender, EventArgs e)
        {
            Response.Redirect("PPrincipalAdmin.aspx");
        }

        protected void BtnRegistroChofer_Click(object sender, EventArgs e)
        {

            //Registra tabla usuario
            registrarUsuario.insertRegistroUsuario(TxtBoxEmail.Text, TxtBoxPassword.Text, 2);
            
            
            
            //Registra tabla Chofer
            int choferID = Convert.ToInt32(TxtBoxID.Text);

            registrarUsuario.insertRegistroChofer(choferID, TxtBoxNombre.Text.Trim(), TxtBoxEmail.Text);

            LblMensajeConfirmacion.ForeColor = System.Drawing.Color.Green;
            LblMensajeConfirmacion.Visible = true;  
            LblMensajeConfirmacion.Text = "Usuario ingresado con exito";

        }
    }
}