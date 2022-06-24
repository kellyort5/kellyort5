using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Proyecto_Final.Properties;

namespace Proyecto_Final
{
    public class ejemplarDAO
    {
        public static List<ejemplar> Obtejemplar()
        {
            List<ejemplar> lista = new List<ejemplar>();
            string cadena = Resources.Cadena_Conexion;
            using (SqlConnection connection = new SqlConnection(cadena))
            {
                {
                    string query = "SELECT id_ejemplar, nombre, editorial_empresa, idioma, id_coleccion, id_formato FROM EJEMPLAR";
                    SqlCommand command = new SqlCommand(query, connection);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ejemplar ej = new ejemplar();
                            ej.id_ejemplar = Convert.ToInt32(reader["id_ejemplar"].ToString());
                            ej.nombre = reader["nombre"].ToString();
                            ej.nombre = reader["editorial_empresa"].ToString();
                            ej.id_coleccion = Convert.ToInt32(reader["id_coleccion"].ToString());
                            ej.id_formato = Convert.ToInt32(reader["id_formato"].ToString());
                            lista.Add(ej);
                        }
                    }
                    connection.Close();
                }
            }

            return lista;
        }
        public static ejemplar filNeje(string nombre)
        { 
            ejemplar col = new ejemplar();
            string cadena = Resources.Cadena_Conexion;
            using (SqlConnection connection = new SqlConnection(cadena))
            { 
                string query = "SELECT id_ejemplar, nombre, editorial_empresa, idioma, id_coleccion, id_formato FROM EJEMPLAR WHERE nombre = @namebuscado";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@namebuscado", nombre);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                { 
                    while (reader.Read())
                    { 
                        col.id_ejemplar = Convert.ToInt32(reader["id_ejemplar"].ToString());
                        col.nombre = reader["nombre"].ToString();
                        col.editorial_empresa = reader["editorial_empresa"].ToString();
                        //col.fecha_publicacion = reader["fecha_publicacion"].ToString();
                        col.id_coleccion = Convert.ToInt32(reader["id_coleccion"].ToString());
                        col.id_formato = Convert.ToInt32(reader["id_formato"].ToString());
                    }
                }
                connection.Close();
            }
            return col;
        }
    }
}