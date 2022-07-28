using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CoinageUI
{
    public class DBUpdate
    {
        SqlConnection sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConexion"].ConnectionString);
       
        
        
        
        public string actualizaEstadoUsuario(string email)
        {

            sqlCon.Open();

            string checkDB = "Update Usuario set activo = 0 WHERE email=@username";
            SqlCommand sqlcom = new SqlCommand(checkDB, sqlCon);
            sqlcom.Parameters.AddWithValue("@username", email);
            string usuarioDatos = Convert.ToString(sqlcom.ExecuteScalar());
            sqlCon.Close();

            return usuarioDatos;

        }




















    }
}