﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CoinageUI
{
    public partial class PAdminUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkMenuAdmin_Click(object sender, EventArgs e)
        {
            Response.Redirect("PPrincipalAdmin.aspx");
        }
    }
}