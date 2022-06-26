namespace Proyecto_Final
{
    public class Colecciones
    {
        public int id_coleccion { get; set; }
        public  string nombre { get; set; }
        public  string genero { get; set; }
        public string  coleccion{ get; set; }
        public string area { get; set; }

        public Colecciones()
        {
            id_coleccion = 0;
            nombre = "";
            genero = "";
            coleccion = "";
            area = "";
        }

        public Colecciones(int idColeccion, string nombre, string genero, string coleccion, string area)
        {
            id_coleccion = idColeccion;
            this.nombre = nombre;
            this.genero = genero;
            this.coleccion = coleccion;
            this.area = area;
        }
    }
}