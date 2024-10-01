using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoMvc.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace DemoMvc.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {}

        public DbSet <Person> Person { get; set; } = default!;
        

    }
}
