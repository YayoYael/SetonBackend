using Microsoft.EntityFrameworkCore;
using Models.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions options): base(options)
        {
        }
        public DbSet<Tarea> Tareas { get; set; }

    }
}
