using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Proyecto_Final.Properties;

namespace Proyecto_Final
{
    public class AreasADO
    {
        public static List<Areas> MostrarAreas()
        {
            List<Areas> areas = new List<Areas>();
            
            string Cadena = Resources.Cadena_Conexion;
            using (SqlConnection connection = new SqlConnection(Cadena))
            {
                String query = "SELECT id_area, nombre FROM AREA";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Areas are = new Areas();
                        are.id = Convert.ToInt32(reader["id_area"].ToString());
                        are.nombre = reader["nombre"].ToString();
                        areas.Add(are);
                    }
                }
                connection.Close();
            }
            return areas;
        }
    }
}