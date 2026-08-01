using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entidades
{
    public class Tarea
    {
        public  int Id { get; set; }
        public  string? Nombre { get; set; }
        public string? Actividad { get; set; }
        public  DateOnly Fecha { get; set; }
        public  bool Tiempo { get; set; }
        public TimeOnly HoraInicio { get; set; }
        public TimeOnly HoraFin { get; set; }
    }
}
