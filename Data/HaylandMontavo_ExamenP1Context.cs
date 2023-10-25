using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HaylandMontavo_ExamenP1.Models;

namespace HaylandMontavo_ExamenP1.Data
{
    public class HaylandMontavo_ExamenP1Context : DbContext
    {
        public HaylandMontavo_ExamenP1Context (DbContextOptions<HaylandMontavo_ExamenP1Context> options)
            : base(options)
        {
        }

        public DbSet<HaylandMontavo_ExamenP1.Models.HaylandMontalvo_tabla> HaylandMontalvo_tabla { get; set; } = default!;
    }
}
