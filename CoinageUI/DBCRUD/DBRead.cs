using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CoinageUI
{
    public class DBRead
    {
        SqlConnection sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConexion"].ConnectionString);

        public int VerificaUsuarioRegistro(string email)
        {

            sqlCon.Open();

            string checkDB = "Select Count(1) FROM Usuario WHERE email=@username";
            SqlCommand sqlcom = new SqlCommand(checkDB, sqlCon);
            sqlcom.Parameters.AddWithValue("@username", email);
            int count = Convert.ToInt32(sqlcom.ExecuteScalar());

            return count;

        }

















    }
}