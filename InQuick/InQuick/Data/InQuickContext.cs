using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace InQuick.Models
{
    public class InQuickContext : DbContext
    {
        public InQuickContext (DbContextOptions<InQuickContext> options)
            : base(options)
        {
        }

        public DbSet<InQuick.Models.NewPatient> NewPatient { get; set; }
    }
}
