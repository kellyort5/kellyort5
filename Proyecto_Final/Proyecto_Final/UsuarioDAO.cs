using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using Proyecto_Final.Properties;

namespace Proyecto_Final
{
    public static class UsuariosDAO
    {
        public static List<Usuarios> MostrarUsuarios()
        {
            List<Usuarios> usuario = new List<Usuarios>();

            string Cadena = Resources.Cadena_Conexion;
            using (SqlConnection connection = new SqlConnection(Cadena))
            {
                String query = "SELECT id_usuario, nombre, telefono, direccion, institucion, correo, ocupacion FROM USUARIO, OCUPACION WHERE USUARIO.id_ocupacion = OCUPACION.id_ocupacion";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Usuarios Usu = new Usuarios();
                        Usu.id = Convert.ToInt32(reader["id_usuario"].ToString());
                        Usu.nombre = reader["nombre"].ToString();
                        Usu.telefono = reader["telefono"].ToString();
                        Usu.direccion = reader["direccion"].ToString();
                        Usu.institucion = reader["institucion"].ToString();
                        Usu.correo = reader["correo"].ToString();
                        Usu.ocupacion = reader["ocupacion"].ToString();
                        usuario.Add(Usu);
                    }
                }

                connection.Close();
            }

            return usuario;
        }

        public static bool InsertarUsuario(string nombre, string telefono, string direccion, string institucion,string correo, int ocupacion)
        {
            bool Respuesta = true;
            try
            {  
                string Cadena = Resources.Cadena_Conexion;
                using (SqlConnection connection = new SqlConnection(Cadena))
                {
                    String query = "INSERT INTO USUARIO(nombre, telefono, direccion, institucion, correo, id_ocupacion)" +
                                   "VALUES (@nombre, @telefono, @direccion, @institucion, @correo, @idOcupacion)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@telefono", telefono);
                    command.Parameters.AddWithValue("@direccion", direccion);
                    command.Parameters.AddWithValue("@institucion", institucion);
                    command.Parameters.AddWithValue("@correo", correo);
                    command.Parameters.AddWithValue("@idOcupacion", ocupacion);
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
    
        public static bool EliminarUser(int id_user)
        {
            bool Respuesta = true;
            try
            {  
                string Cadena = Resources.Cadena_Conexion;
                using (SqlConnection connection = new SqlConnection(Cadena))
                {
                    String query = "DELETE FROM USUARIO WHERE id_usuario = @idusuario";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@idusuario", id_user);
                    //abrir conexion 
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