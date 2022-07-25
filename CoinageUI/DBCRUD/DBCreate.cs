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


        public void insertRegistroPasajero(string email, string password)
        {

            sqlCon.Open();
            string query = "Insert into Usuario (email,password,activo,idrol) Values(@email, @password, @activo, @idrol)";

            SqlCommand insertarCom = new SqlCommand(query, sqlCon);
            insertarCom.Parameters.AddWithValue("@email", email);
            insertarCom.Parameters.AddWithValue("@password", password);
            insertarCom.Parameters.AddWithValue("@activo", true);
            insertarCom.Parameters.AddWithValue("@idrol", 3);
            insertarCom.ExecuteNonQuery();
            sqlCon.Close();



        }








    }
}