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
            return Ok(tarea);
        }

        [HttpPut("EditarTarea/{id}")]
        public async Task<IActionResult> EditarTarea(int id, TareaDTO tareaDTO)
        {
            var tarea = await _db.Tareas.FindAsync(id);

            if (tarea == null)
            {
                return NotFound();
            }

            tarea.Nombre = tareaDTO.Nombre;
            tarea.Actividad = tareaDTO.Actividad;
            tarea.Fecha = tareaDTO.Fecha;
            tarea.Tiempo = tareaDTO.Tiempo;
            tarea.HoraInicio = tareaDTO.HoraInicio;
            tarea.HoraFin = tareaDTO.HoraFin;

            await _db.SaveChangesAsync();
            return Ok(tarea);
        }

        [HttpDelete("EliminarTarea/{id}")]
        public async Task<IActionResult> EliminarTarea(int id)
        {
            var tarea = await _db.Tareas.FindAsync(id);

            if (tarea == null)
            {
                return NotFound();
            }

            _db.Tareas.Remove(tarea);
            await _db.SaveChangesAsync();
            return NoContent();
        }
    }
}
