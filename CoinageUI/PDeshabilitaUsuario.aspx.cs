using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CoinageUI
{
    public partial class PDeshabilitaUsuario : System.Web.UI.Page
    {



        DBRead buscaUsuario = new DBRead();
        DBUpdate actualizaEstadoUsuario = new DBUpdate();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LnkBtnDUMenuAdmin_Click(object sender, EventArgs e)
        {
            Response.Redirect("PPrincipalAdmin.aspx");
        }

        protected void BtnBuscaUsuario_Click(object sender, EventArgs e)
        {

          string usuarioNombre =  buscaUsuario.buscaUsuarioNombre(TxtboxEmailUsuario.Text);
          int usuarioEstado = buscaUsuario.buscaUsuarioEstado(TxtboxEmailUsuario.Text);

            LblUsuarioEncontrado.Text = usuarioNombre;

            if (usuarioEstado == 1)
            {
                LblEstadoUsuario.Text = "Usuario Activo";
            }
            else { LblEstadoUsuario.Text = "Usuario Inactivo";
            }

        }

        protected void BtnDeshabilitarUsuario_Click(object sender, EventArgs e)
        {

            actualizaEstadoUsuario.actualizaEstadoUsuario(TxtboxEmailUsuario.Text);


            LblUsuarioIncorrecto.Visible = true;   
            LblUsuarioIncorrecto.Text = "Usuario " + TxtboxEmailUsuario.Text + " Inactivo";



        }
    }
}