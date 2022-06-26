using System;
using System.Security.Cryptography;

namespace Proyecto_Final
{
    public class Ejemplar
    {
        public int id_ejemplar { get; set; }
        public  string nombre { get; set; }
        public  string editorial_empresa { get; set; }
        public DateTime fecha_publicacion { get; set; }
        public string idioma { get; set; }
        public string coleccion { get; set; }
        public string formato { get; set; }
        public string palabras_clave { get; set; }

        public Ejemplar()
        {
            this.id_ejemplar = 0;
            this.nombre = "";
            this.editorial_empresa = "";
            this.fecha_publicacion = DateTime.Today;
            this.idioma = "";
            this.coleccion = "";
            this.formato = "";
            this.palabras_clave = "";
        }

        public Ejemplar(int idEjemplar, string nombre, string editorialEmpresa, DateTime fechaPublicacion, string idioma, string coleccion, string formato, string palabrasClave)
        {
            id_ejemplar = idEjemplar;
            this.nombre = nombre;
            editorial_empresa = editorialEmpresa;
            fecha_publicacion = fechaPublicacion;
            this.idioma = idioma;
            this.coleccion = coleccion;
            this.formato = formato;
            palabras_clave = palabrasClave;
        }
    }
}