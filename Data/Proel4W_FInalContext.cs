using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Proel4W_FInal.Models;

namespace Proel4W_FInal.Data
{
    public class Proel4W_FInalContext : DbContext
    {
        public Proel4W_FInalContext (DbContextOptions<Proel4W_FInalContext> options)
            : base(options)
        {
        }

        public DbSet<Proel4W_FInal.Models.Coffee> Coffee { get; set; } = default!;
    }
}
