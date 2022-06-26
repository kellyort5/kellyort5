using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Proyecto_Final.Properties;

namespace Proyecto_Final
{
    public class ColeccionesDAO
    {
        public static List<Colecciones> ObtColeccion()
        {
            List<Colecciones> lista = new List<Colecciones>();
            string cadena = Resources.Cadena_Conexion;
            using (SqlConnection connection = new SqlConnection(cadena))
            {
                {
                    string query = "SELECT id_coleccion, COLECCION.nombre, genero, TIPO_COLECCION.coleccion as 'Tipo coleccion', AREA.nombre as 'Area' " +
                                   "FROM COLECCION, TIPO_COLECCION, AREA "+
                                   "WHERE COLECCION.id_tipo_coleccion = TIPO_COLECCION.id_tipo_coleccion AND COLECCION.id_area = AREA.id_area";
                    SqlCommand command = new SqlCommand(query, connection);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Colecciones col = new Colecciones();
                            col.id_coleccion = Convert.ToInt32(reader["id_coleccion"].ToString());
                            col.nombre = reader["nombre"].ToString();
                            col.genero = reader["genero"].ToString();
                            col.coleccion = reader["Tipo Coleccion"].ToString();
                            col.area = reader["Area"].ToString();
                            lista.Add(col);
                        }
                    }
                    connection.Close();
                }
            }
            return lista;
        }
        
        public static List<Colecciones> filNombre(string name)
        { 
            List<Colecciones> coleccion = new List<Colecciones>(); 
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
                        Colecciones col = new Colecciones();
                        col.id_coleccion = Convert.ToInt32(reader["id_coleccion"].ToString());
                        col.nombre = reader["nombre"].ToString();
                        col.genero = reader["genero"].ToString();
                        coleccion.Add(col);
                    }
                }
                connection.Close();
            }
            return coleccion;
        }
        public static bool InsertarColecciones(string nombre, int coleccion, string genero, int area)
        {
            bool Respuesta = true;
            try
            {  
                string Cadena = Resources.Cadena_Conexion;
                using (SqlConnection connection = new SqlConnection(Cadena))
                {
                    String query = "INSERT INTO COLECCION(nombre, genero, id_tipo_coleccion, id_area)" +
                                   "VALUES (@nombre,@genero,@id_tipo_coleccion,@id_area)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@genero", genero);
                    command.Parameters.AddWithValue("@id_tipo_coleccion", coleccion);
                    command.Parameters.AddWithValue("@id_area", area);
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