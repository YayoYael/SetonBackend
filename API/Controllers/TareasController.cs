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
    }
}
