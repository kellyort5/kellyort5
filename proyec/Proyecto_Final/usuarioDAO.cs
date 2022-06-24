using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Proyecto_Final.Properties;

namespace Proyecto_Final
{
    public class usuarioDAO
    {
        public static List<usuario> Obtusuairio()
        {
            List<usuario> lista = new List<usuario>();
            string cadena = Resources.Cadena_Conexion;
            using (SqlConnection connection = new SqlConnection(cadena))
            {
                {
                    string query = "select id_usuario, nombre, telefono, direccion, correo from USUARIO ";
                    SqlCommand command = new SqlCommand(query, connection);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            usuario col = new usuario();
                            col.id_usuario = Convert.ToInt32(reader["id_usuario"].ToString());
                            col.nombre = reader["nombre"].ToString();
                            col.telefono = Convert.ToInt32(reader["telefono"].ToString());
                            col.direccion = reader["direccion"].ToString();
                            col.correo = reader["correo"].ToString();

                            lista.Add(col);
                        }
                    }
                    connection.Close();
                }
            }
            return lista;
        }
    }
}