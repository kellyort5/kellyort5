using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Proyecto_Final.Properties;

namespace Proyecto_Final
{
    public class EjemplarDAO
    {
        public static List<Ejemplar> ObtEjemplar()
        {
            List<Ejemplar> lista = new List<Ejemplar>();
            string cadena = Resources.Cadena_Conexion;
            using (SqlConnection connection = new SqlConnection(cadena))
            {
                {
                    string query =

                        "SELECT id_ejemplar, EJEMPLAR.nombre, editorial_empresa, fecha_publicacion, idioma, COLECCION.nombre as 'Coleccion', FORMATO.formato " +
                        "FROM EJEMPLAR, COLECCION,FORMATO " +
                        "WHERE EJEMPLAR.id_coleccion = COLECCION.id_coleccion and EJEMPLAR.id_formato = FORMATO.id_formato";
                    SqlCommand command = new SqlCommand(query, connection);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Ejemplar ej = new Ejemplar();
                            ej.id_ejemplar = Convert.ToInt32(reader["id_ejemplar"].ToString());
                            ej.nombre = reader["nombre"].ToString();
                            ej.editorial_empresa = reader["editorial_empresa"].ToString();
                            ej.fecha_publicacion = Convert.ToDateTime (reader["fecha_publicacion"].ToString());
                            ej.idioma = reader["idioma"].ToString();
                            ej.coleccion = reader["Coleccion"].ToString();
                            ej.formato = reader["formato"].ToString();
                            lista.Add(ej);
                        }
                    }

                    connection.Close();
                }
            }

            return lista;
        }

        public static List<Ejemplar> filNombre(string name)
        {
            List<Ejemplar> lista = new List<Ejemplar>();
            string cadena = Resources.Cadena_Conexion;
            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query =

                    "SELECT id_ejemplar, EJEMPLAR.nombre, editorial_empresa, fecha_publicacion, idioma, COLECCION.nombre as 'Coleccion', FORMATO.formato " +
                    "FROM EJEMPLAR, COLECCION,FORMATO " +
                    "WHERE EJEMPLAR.id_coleccion = COLECCION.id_coleccion and EJEMPLAR.id_formato = FORMATO.id_formato and EJEMPLAR.nombre = @namebuscado";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@namebuscado", name);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Ejemplar eje = new Ejemplar();
                        eje.id_ejemplar = Convert.ToInt32(reader["id_ejemplar"].ToString());
                        eje.nombre = reader["nombre"].ToString();
                        eje.editorial_empresa = reader["editorial_empresa"].ToString();
                        eje.fecha_publicacion = Convert.ToDateTime (reader["fecha_publicacion"].ToString());
                        eje.idioma = reader["idioma"].ToString();
                        eje.coleccion = reader["coleccion"].ToString();
                        eje.formato = reader["formato"].ToString();
                        lista.Add(eje);
                    }
                }

                connection.Close();
            }

            return lista;
        }

        public static bool InsertarEjemplar(string nombre, string editorial_empresa, string fecha_publicacion,
            string idioma, int coleccion, string formato)
        {
            bool Respuesta = true;
            try
            {
                string Cadena = Resources.Cadena_Conexion;
                using (SqlConnection connection = new SqlConnection(Cadena))
                {
                    String query =
                        "INSERT INTO EJEMPLAR(nombre, editorial_empresa, fecha_publicacion, idioma, id_coleccion, formato)" +
                        "VALUES (@nombre, @editorialEmpresa, @fechaPublicacion, @idioma, @idColeccion, @formato)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@editorialEmpresa", editorial_empresa);
                    command.Parameters.AddWithValue("@fechaPublicacion", fecha_publicacion);
                    command.Parameters.AddWithValue("@idioma", idioma);
                    command.Parameters.AddWithValue("@idColeccion", coleccion);
                    command.Parameters.AddWithValue("@formato", coleccion);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception e)
            {
                Respuesta = false;
            }

            return Respuesta;
        }

    }
}