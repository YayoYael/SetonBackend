using API.DTO;
using Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models.Entidades;
using System.ComponentModel;

namespace API.Controllers
{
  
    public class TareasController : BaseController
    {
        private readonly AplicationDbContext _db;

        public TareasController(AplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet("ObtenerTareas")]
        public async Task<IEnumerable<Tarea>> ObtenerTareas() {
            var tareas= await _db.Tareas.ToListAsync();
            return tareas;
        }

        [HttpPost("AgregarTarea")]
        public async Task<IActionResult> AgregarTarea(TareaDTO tareaDTO)
        {
            var tarea = new Tarea
            {
                Nombre = tareaDTO.Nombre,
                Actividad = tareaDTO.Actividad,
                Fecha = tareaDTO.Fecha,
                Tiempo = tareaDTO.Tiempo,
                HoraInicio = tareaDTO.HoraInicio,
                HoraFin = tareaDTO.HoraFin
            };
            _db.Tareas.Add(tarea);
            await _db.SaveChangesAsync();
            return Ok("Tarea creada con exito");
        }
    }
}
