using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TallerProgramacion_SL.Models;

namespace TallerProgramacion_SL.Data
{
    public class TallerProgramacion_SLContext : DbContext
    {
        public TallerProgramacion_SLContext (DbContextOptions<TallerProgramacion_SLContext> options)
            : base(options)
        {
        }

        public DbSet<TallerProgramacion_SL.Models.Jugador> Jugador { get; set; } = default!;
        public DbSet<TallerProgramacion_SL.Models.Equipo> Equipo { get; set; } = default!;
        public DbSet<TallerProgramacion_SL.Models.Estadio> Estadio { get; set; } = default!;
    }
}
