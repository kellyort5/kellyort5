namespace Proyecto_Final
{
    public class Areas
    {
        public int id { get; set; }
        public string nombre { get; set; }


        public Areas()
        {
            this.id = 0;
            this.nombre = "";
        }

        public Areas(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }
    }
    
}