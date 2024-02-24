using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPageMovie1.Models;

namespace RazorPageMovie1.Data
{
    public class RazorPageMovie1Context : DbContext
    {
        public RazorPageMovie1Context (DbContextOptions<RazorPageMovie1Context> options)
            : base(options)
        {
        }

        public DbSet<RazorPageMovie1.Models.Movie> Movie { get; set; } = default!;
    }
}
