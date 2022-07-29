using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace CoinageUI
{
    public partial class PAdminRuta : System.Web.UI.Page
    {


        
        DBCreate dbCreaRuta = new DBCreate();
     

        protected void Page_Load(object sender, EventArgs e)
        {

           

        }

        protected void LnkBtnRutasMenuAdmin_Click(object sender, EventArgs e)
        {
            Response.Redirect("PPrincipalAdmin.aspx");
        }

        protected void BtnAgregarRuta_Click(object sender, EventArgs e)
        {


            int rutaId = Convert.ToInt32(TxtBoxRutaId.Text);
            int rutaCosto = Convert.ToInt32(TxtBoxCosto.Text);



            dbCreaRuta.insertRegistroRuta(TxtBoxNombreRuta.Text, rutaId, rutaCosto, 2);


            LblRutaAgregada.Visible = true;
            LblRutaAgregada.Text = "Ruta agregada con exito";



        }
    }
}