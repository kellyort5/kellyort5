using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using Proyecto_Final.Properties;

namespace Proyecto_Final
{
    public class OcupacionDAO
    {
        public static List<Ocupacion> MostrarOcupaciones()
        {
            List<Ocupacion> ocupaciones = new List<Ocupacion>();
            
            string Cadena = Resources.Cadena_Conexion;
            using (SqlConnection connection = new SqlConnection(Cadena))
            {
                String query = "SELECT id_ocupacion ,ocupacion FROM OCUPACION";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Ocupacion Ocu = new Ocupacion();
                        Ocu.id = Convert.ToInt32(reader["id_ocupacion"].ToString());
                        Ocu.ocupacion = reader["ocupacion"].ToString();
                        ocupaciones.Add(Ocu);
                    }
                }
                connection.Close();
            }
            return ocupaciones;
        }
    }
}