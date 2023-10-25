using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JaverVarela_ExamenP1.Models;

    public class JaverVarela_ExamenP1Context : DbContext
    {
        public JaverVarela_ExamenP1Context (DbContextOptions<JaverVarela_ExamenP1Context> options)
            : base(options)
        {
        }

        public DbSet<JaverVarela_ExamenP1.Models.JavierVarela_tabla> JavierVarela_tabla { get; set; } = default!;
    }
