﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CoinageUI
{
    public partial class PUsuarioAgregaSaldo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LnkBtnUsuarioMenuPSaldo_Click(object sender, EventArgs e)
        {
            Response.Redirect("PPrincipalUsuario.aspx");
        }
    }
}