namespace Proyecto_Final
{
    public class Ocupacion
    {
        public int id { get; set; }
        public string ocupacion { get; set; }

        public Ocupacion()
        {
            this.id = 0;
            this.ocupacion = "";
        }

        public Ocupacion(int id, string ocupacion)
        {
            this.id = id;
            this.ocupacion = ocupacion;
        }
    }
}