namespace API.DTO
{
    public class TareaRespuestaDTO
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Actividad { get; set; }
        public DateOnly Fecha { get; set; }
        public string Estado { get; set; } = string.Empty;
    }
}
