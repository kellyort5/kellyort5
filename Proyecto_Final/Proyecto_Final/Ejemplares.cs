using System;
using System.Globalization;

namespace Proyecto_Final
{
    public class Ejemplares
    {
        public int id_ejemplar { get; set; }
        public string nombre { get; set; }
        public string editorial_empresa { get; set; }
        //fecha
        public string idioma { get; set; }
        //imagen
        public int id_coleccion { get; set; }
        public int id_formato { get; set; }

        public Ejemplares()
        {
            this.id_ejemplar = 0;
            this.nombre = "";
            this.editorial_empresa = "";
            this.idioma = "";
            this.id_coleccion = 0;
            this.id_formato = 0;
        }

        public Ejemplares(int idEjemplar, string nombre, string editorialEmpresa, string idioma, int idColeccion, int idFormato)
        {
            id_ejemplar = idEjemplar;
            this.nombre = nombre;
            editorial_empresa = editorialEmpresa;
            this.idioma = idioma;
            id_coleccion = idColeccion;
            id_formato = idFormato;
        }
    }
    
    
}