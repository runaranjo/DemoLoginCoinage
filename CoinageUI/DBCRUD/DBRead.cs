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

        public int verificaUsuarioRegistro(string email)
        {

            sqlCon.Open();

            string checkDB = "Select Count(1) FROM Usuario WHERE email=@username";
            SqlCommand sqlcom = new SqlCommand(checkDB, sqlCon);
            sqlcom.Parameters.AddWithValue("@username", email);
            int count = Convert.ToInt32(sqlcom.ExecuteScalar());

            return count;

        }


        public int verificarUsuarioLogin(string email,string password)
        {

            sqlCon.Open();
            string query = "Select Count(1) FROM Usuario WHERE email=@username AND password=@password";
            SqlCommand sqlcom = new SqlCommand(query, sqlCon);
            sqlcom.Parameters.AddWithValue("@username", email);
            sqlcom.Parameters.AddWithValue("@password", password);
            int count = Convert.ToInt32(sqlcom.ExecuteScalar());
            sqlCon.Close();
            return count;
        }

        public int verificarUsuarioRol(string email)
        {

            sqlCon.Open();
            string queryIdRol = "Select idRol FROM Usuario WHERE email=@username";
            SqlCommand sqlcom = new SqlCommand(queryIdRol, sqlCon);
            sqlcom.Parameters.AddWithValue("@username", email);
            int idRole = Convert.ToInt32(sqlcom.ExecuteScalar());
            sqlCon.Close();

            return idRole;
        }
















    }
}