using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CoinageUI
{
    public partial class PUsuarioAgregaSaldo : System.Web.UI.Page
    {
        DBUpdate ingresaSaldo = new DBUpdate();


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LnkBtnUsuarioMenuPSaldo_Click(object sender, EventArgs e)
        {
            Response.Redirect("PPrincipalUsuario.aspx");
        }

        protected void BtnAgregaSaldo_Click(object sender, EventArgs e)
        {



            //actualizaSaldo.actualizaSaldo(txt);

            int saldo = Convert.ToInt32(TxtBoxAcreditaSaldo.Text);

            ingresaSaldo.actualizaSaldo(Session["username"].ToString(), saldo);

            LblSaldoAcreditado.Text = "Saldo acreditado con exito";
            LblSaldoAcreditado.Visible = true;


        }
    }
}