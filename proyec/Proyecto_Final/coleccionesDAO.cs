using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Proyecto_Final.Properties;

namespace Proyecto_Final
{
    public class coleccionesDAO
    {
         public static List<colecciones> ObtColeccion()
        {
            List<colecciones> lista = new List<colecciones>();
            string cadena = Resources.Cadena_Conexion;
            using (SqlConnection connection = new SqlConnection(cadena))
            {
                {
                    string query = "SELECT id_coleccion, nombre, genero FROM COLECCION ";
                    SqlCommand command = new SqlCommand(query, connection);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            colecciones col = new colecciones();
                            col.id_coleccion = Convert.ToInt32(reader["id_coleccion"].ToString());
                            col.nombre = reader["nombre"].ToString();
                            col.genero = reader["genero"].ToString();
                            
                            lista.Add(col);
                        }
                    }
                    connection.Close();
                }
            }
            return lista;
        }
        public static colecciones filNombre(string name)
        { 
            colecciones col = new colecciones();
            string cadena = Resources.Cadena_Conexion;
            using (SqlConnection connection = new SqlConnection(cadena))
            { 
                string query = "SELECT id_coleccion, nombre, genero FROM COLECCION WHERE nombre = @namebuscado";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@namebuscado", name);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                { 
                    while (reader.Read())
                    { 
                        col.id_coleccion = Convert.ToInt32(reader["id_coleccion"].ToString());
                        col.nombre = reader["nombre"].ToString();
                        col.genero = reader["genero"].ToString();
                    }
                }

                connection.Close();
            }
            return col;
        }
    }
}