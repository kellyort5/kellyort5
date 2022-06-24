namespace Proyecto_Final
{
    public class usuario
    {
        public int id_usuario { get; set; }
        public  string nombre { get; set; }
        public  int telefono { get; set; }
        public string direccion { get; set; }
        public string correo { get; set; }

        public usuario()
        {
            this.id_usuario = 0;
            this.nombre = "";
            this.telefono = 0;
            this.direccion = "";
            this.correo = "";

        }
        public usuario(int idUsuario, string nombre, int telefono, string direccion, string correo)
        {
            id_usuario = idUsuario;
            this.nombre = nombre;
            this.telefono = telefono;
            this.direccion = direccion;
            this.correo = correo;
        }
    }
}
