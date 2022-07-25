using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CoinageUI
{
    public class DBCreate
    {

        SqlConnection sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConexion"].ConnectionString);

    }
}