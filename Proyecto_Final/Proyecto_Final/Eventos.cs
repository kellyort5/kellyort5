namespace Proyecto_Final
{
    public class Eventos
    {
        public int id_evento { get; set; }
        public string titulo { get; set; }
        public string hora_fecha_inicio { get; set; }
        public string hora_fecha_fin { get; set; }
        public int cantidad_asistentes { get; set; }

        public string area { get; set; }

        public Eventos()
        {
            this.id_evento = 0;
            this.titulo = "";
            this.hora_fecha_inicio = "";
            this.hora_fecha_fin = "";
            this.cantidad_asistentes = 0;
            this.area = "";
        }

        public Eventos(int idEvento, string titulo, string horaFechaInicio, string horaFechaFin, int cantidadAsistentes, string area)
        {
            id_evento = idEvento;
            this.titulo = titulo;
            hora_fecha_inicio = horaFechaInicio;
            hora_fecha_fin = horaFechaFin;
            cantidad_asistentes = cantidadAsistentes;
            area = area;
        }
    }
}