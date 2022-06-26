using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Proyecto_Final.Properties;

namespace Proyecto_Final
{
    public class EventosDAO
    {
        public static List<Eventos> ObtEvento()
        {
            List<Eventos> lista = new List<Eventos>();
            string cadena = Resources.Cadena_Conexion;
            using (SqlConnection connection = new SqlConnection(cadena))
            {
                {
                    string query = 
                        "SELECT EVENTO.id_evento, titulo, hora_fecha_inicio, hora_fecha_fin, cantidad_asistentes, area.nombre as 'Area reservada'"+
                        "FROM EVENTO, AREA, EMPLEA " + 
                        "WHERE	EVENTO.id_evento = EMPLEA.id_evento and AREA.id_area = EMPLEA.id_area";
                    SqlCommand command = new SqlCommand(query, connection);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Eventos eventos = new Eventos();
                            eventos.id_evento = Convert.ToInt32(reader["id_evento"].ToString());
                            eventos.titulo = reader["titulo"].ToString();
                            eventos.hora_fecha_inicio = reader["hora_fecha_inicio"].ToString();
                            eventos.hora_fecha_fin = reader["hora_fecha_fin"].ToString();
                            eventos.cantidad_asistentes = Convert.ToInt32(reader["cantidad_asistentes"].ToString());
                            eventos.area = reader["Area reservada"].ToString();
                            lista.Add(eventos);
                        }
                    }
                    connection.Close();
                }
            }
            return lista;
        }

        public static List<Eventos> filNombre(string name)
        {
            List<Eventos> eventos = new List<Eventos>();
            string cadena = Resources.Cadena_Conexion;
            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query =
                    "SELECT id_evento, titulo, hora_fecha_inicio, hora_fecha_fin, cantidad_asistentes FROM EVENTO WHERE titulo = @namebuscado";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@namebuscado", name);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Eventos eve = new Eventos();
                        eve.id_evento = Convert.ToInt32(reader["id_evento"].ToString());
                        eve.titulo = reader["titulo"].ToString();
                        eve.hora_fecha_inicio = reader["hora_fecha_inicio"].ToString();
                        eve.hora_fecha_fin = reader["hora_fecha_fin"].ToString();
                        eve.cantidad_asistentes = Convert.ToInt32(reader["cantidad_asistentes"].ToString());
                        eventos.Add(eve);
                    }
                }
                connection.Close();
            }
            return eventos;
        }
    }
}