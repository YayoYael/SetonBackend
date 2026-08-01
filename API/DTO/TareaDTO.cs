namespace API.DTO
{
    public class TareaDTO
    {
        public string? Nombre { get; set; }
        public string? Actividad { get; set; }
        public DateOnly Fecha { get; set; }
        public bool Tiempo { get; set; }
        public TimeOnly HoraInicio { get; set; }
        public TimeOnly HoraFin { get; set; }
    }
}
