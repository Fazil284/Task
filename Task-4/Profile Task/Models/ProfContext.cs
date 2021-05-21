using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task4.Models
{
    public class ProfContext:DbContext
    {
        public ProfContext():base()
        {

        }
        public ProfContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Prof> Profs { get; set; }
    }
}
