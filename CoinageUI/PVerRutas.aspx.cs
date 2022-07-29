using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CoinageUI
{
    public partial class PVerRutas : System.Web.UI.Page
    {
        SqlConnection sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConexion"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void LnkBtnMenuUsuarioRutas_Click(object sender, EventArgs e)
        {
            Response.Redirect("PPrincipalUsuario.aspx");
        }

        protected void GVVerRutas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void BtnVerRutas_Click(object sender, EventArgs e)
        {


            SqlCommand sqlcmd = new SqlCommand("Select Nombre, Costo from Rutas", sqlCon);
            sqlCon.Open();
            DataTable table = new DataTable();
            table.Load(sqlcmd.ExecuteReader());
            GVVerRutas.DataSource = table;
            GVVerRutas.DataBind();

            sqlCon.Close();

            GVVerRutas.Visible = true;


        }
    }
}