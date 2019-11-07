using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Biblioteca
{
    public static class DAO
    {
        private static SqlConnection connection;
        private static SqlCommand command;
        private static string connectionString;
        static DAO()
        {
            DAO.connectionString = @"Server = .\SQLEXPRESS; Database= BDVet; Trusted_Connection = true;";
            connection = new SqlConnection(connectionString);
            command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
        }

        public static void InsertarCliente (string nombre, string apellido, string dni, DateTime? fechaNac)
        {
            try
            {
                connection.Open();
                string comando = String.Format("INSERT INTO CLIENTES (nombre,apellido, dni) " +
                  "VALUES ('{0}', '{1}', '{2}');", nombre, apellido, dni);
                command.CommandText = comando;
                command.ExecuteNonQuery();
            }
            finally
            {
                if(connection != null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public static void ModificarCliente(int id, string nombre, string apellido, string dni,
          DateTime? fechaNacimiento)
        {
          using (SqlConnection connection = new SqlConnection(DAO.connectionString))
          {
              
                string comando = "UPDATE CLIENTES SET nombre = @nombre, " +
                  "apellido = @apellido, dni = @dni, fecha_nacimiento = @fechaNacimiento " +
                  "WHERE id = @id;";
                SqlCommand command = new SqlCommand(comando, connection);
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@apellido", apellido);
                command.Parameters.AddWithValue("@dni", dni);
                command.Parameters.AddWithValue("@fechaNacimiento", fechaNacimiento);
                command.Parameters.AddWithValue("@id", id);
                connection.Open();
                command.ExecuteNonQuery();
          }
        }

        public static List<Cliente> LeerClientes()
        {
          using (SqlConnection connection = new SqlConnection(DAO.connectionString))
          {
            string comando = "SELECT id, nombre, apellido, dni, fecha_nacimiento FROM CLIENTES;";
            SqlCommand command = new SqlCommand(comando, connection);
            connection.Open();
            SqlDataReader dataReader = command.ExecuteReader();
            List<Cliente> clientes = new List<Cliente>();

            while (dataReader.Read())
            {
              int id = dataReader.GetInt32(0);
              string nombre = dataReader.GetString(1);
              string apellido = dataReader.GetString(2);
              string dni = dataReader.GetString(3);
              DateTime? fechaNacimiento = null;
              if (!dataReader.IsDBNull(4))
              {
                fechaNacimiento = dataReader.GetDateTime(4);
              }

              Cliente cliente = new Cliente(id, nombre, apellido, dni, fechaNacimiento);
              clientes.Add(cliente);
            }
            return clientes;
          }
        }


    }
}
