using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Taller.Models;

namespace Taller.Context
{
    public class TallerDBContext : DbContext
    {
        public
       TallerDBContext(DbContextOptions<TallerDBContext> options)
       : base(options)
        {
        }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<AutoAReparar> AutosAReparar { get; set; }
        public DbSet<Novedades> Novedades { get; set; }
        
    }
}

