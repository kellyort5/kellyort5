using System;

namespace Proyecto_Final
{
    public class ejemplar
    {
        
        public int id_ejemplar { get; set; }
        public  string nombre { get; set; }
        public  string editorial_empresa { get; set; }
        //public string fecha_publicacion { get; set; }
        public int id_coleccion { get; set; }
        public int id_formato { get; set; }

        public ejemplar()
        {
            this.id_ejemplar = 0;
            this.nombre = "";
            this.editorial_empresa = "";
            //this.fecha_publicacion = "";
            this.id_coleccion = 0;
            this.id_formato = 0;
            
        }

        public ejemplar(int idEjemplar, string nombre, string editorialEmpresa, int idColeccion, int idFormato)
        {
            id_ejemplar = idEjemplar;
            this.nombre = nombre;
            editorial_empresa = editorialEmpresa;
            //fecha_publicacion = fechaPublicacion;
            id_coleccion = idColeccion;
            id_formato = idFormato;
        }
    }
}