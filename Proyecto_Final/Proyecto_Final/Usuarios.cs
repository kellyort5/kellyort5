namespace Proyecto_Final
{
    public class Usuarios
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string telefono { get; set; }
        public string direccion { get; set; }
        public string institucion { get; set; }
        public string correo { get; set; }
        public string ocupacion { get; set; }

        public Usuarios()
        {
            this.id = 0;
            this.nombre = "";
            this.telefono = "";
            this.direccion = "";
            this.institucion = "";
            this.correo = "";
            this.ocupacion = "";
        }

        public Usuarios(int id, string nombre, string telefono, string direccion, string institucion, string correo, string ocupacion)
        {
            this.id = id;
            this.nombre = nombre;
            this.telefono = telefono;
            this.direccion = direccion;
            this.institucion = institucion;
            this.correo = correo;
            this.ocupacion = ocupacion;
        }
    }
}