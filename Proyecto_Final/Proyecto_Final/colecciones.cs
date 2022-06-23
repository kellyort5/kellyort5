namespace Proyecto_Final
{
    public class colecciones
    {
        public int id_coleccion { get; set; }
        public  string nombre { get; set; }
        public  string genero { get; set; }

        public colecciones()
        {
            this.id_coleccion = 0;
            this.nombre = "";
            this.genero = "";
        }

        public colecciones(int idColeccion, string nombre, string genero)
        {
            id_coleccion = idColeccion;
            this.nombre = nombre;
            this.genero = genero;
        }
    }
}