using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Proyecto_Final.Properties;

namespace Proyecto_Final
{
    public class EjemplaresDAO
    {
        public static List<Ejemplares> ObtEjemplaresList()
        {
            List<Ejemplares> lista = new List<Ejemplares>();
            string cadena = Resources.Cadena_Conexion;
            using (SqlConnection connection = new SqlConnection(cadena))
            {
                {
                    string query = "select id_ejemplar, nombre, editorial_empresa, idioma, id_coleccion, id_formato from EJEMPLAR ";
                    SqlCommand command = new SqlCommand(query, connection);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Ejemplares ej = new Ejemplares();
                            ej.id_ejemplar = Convert.ToInt32(reader["id_ejemplar"].ToString());
                            ej.nombre = reader["nombre"].ToString();
                            ej.editorial_empresa = reader["editorial_empresa"].ToString();
                            ej.idioma = reader["idioma"].ToString();
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
        public static Ejemplares filname(string name)
        {
            Ejemplares ej = new Ejemplares();
            string cadena = Resources.Cadena_Conexion;
            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query = "select id_ejemplar, nombre, editorial_empresa, idioma, id_coleccion, id_formato from EJEMPLAR WHERE nombre = @namebuscando";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@namebuscando", name);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ej.id_ejemplar = Convert.ToInt32(reader["id_ejemplar"].ToString());
                        ej.nombre = reader["nombre"].ToString();
                        ej.editorial_empresa = reader["editorial_empresa"].ToString();
                        ej.idioma = reader["idioma"].ToString();
                        ej.id_coleccion = Convert.ToInt32(reader["id_coleccion"].ToString());
                        ej.id_formato = Convert.ToInt32(reader["id_formato"].ToString());
                    }
                }
                connection.Close();
            }
            return ej;
        }
    }
}