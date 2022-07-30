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


        public void insertRegistroUsuario(string email, string password, int idRol)
        {

            sqlCon.Open();
            string query = "Insert into Usuario (email,password,activo,idrol) Values(@email, @password, @activo, @idrol)";

            SqlCommand insertarCom = new SqlCommand(query, sqlCon);
            insertarCom.Parameters.AddWithValue("@email", email);
            insertarCom.Parameters.AddWithValue("@password", password);
            insertarCom.Parameters.AddWithValue("@activo", true);
            insertarCom.Parameters.AddWithValue("@idrol", idRol);
            insertarCom.ExecuteNonQuery();
            sqlCon.Close();

        }


        public void insertRegistroPasajero(int pasajeroId, string nombre, string email, int saldo)
        {

            sqlCon.Open();
            string query = "Insert into Pasajeros (pasajeroId,nombre , email, saldo) Values(@pasajeroid, @nombre, @email, @saldo)";

            SqlCommand insertarCom = new SqlCommand(query, sqlCon);
            insertarCom.Parameters.AddWithValue("@pasajeroId", pasajeroId);
            insertarCom.Parameters.AddWithValue("@nombre", nombre);
            insertarCom.Parameters.AddWithValue("@email", email);
            insertarCom.Parameters.AddWithValue("@saldo", saldo);
            insertarCom.ExecuteNonQuery();
            sqlCon.Close();

        }





        public void insertRegistroChofer(int choferId, string nombre, string email)
        {

            sqlCon.Open();
            string query = "Insert into Chofer (choferId, nombre,email) Values(@ChoferId, @nombre, @Email)";

            SqlCommand insertarCom = new SqlCommand(query, sqlCon);
            insertarCom.Parameters.AddWithValue("@ChoferId", choferId);
            insertarCom.Parameters.AddWithValue("@Nombre", nombre);
            insertarCom.Parameters.AddWithValue("@email", email);
            insertarCom.ExecuteNonQuery();
            sqlCon.Close();

        }

        public void insertRegistroRuta(string nombreRuta, string codigoCTP, int costo, int idCanton)
        {

            sqlCon.Open();
            string query = "Insert into Rutas (Nombre,codigoCTP,Costo, CantonId) Values(@Nombre, @codigoCTP, @costo, @CantonId)";

            SqlCommand insertarCom = new SqlCommand(query, sqlCon);
            insertarCom.Parameters.AddWithValue("@Nombre", nombreRuta);
            insertarCom.Parameters.AddWithValue("@CodigoCTP", codigoCTP);
            insertarCom.Parameters.AddWithValue("@costo", costo);
            insertarCom.Parameters.AddWithValue("@CantonId", idCanton);
            insertarCom.ExecuteNonQuery();
            sqlCon.Close();

        }



    }
}