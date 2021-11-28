using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Persa_PaulaDenisa_Lab8.Models;

namespace Persa_PaulaDenisa_Lab8.Data
{
    public class Persa_PaulaDenisa_Lab8Context : DbContext
    {
        public Persa_PaulaDenisa_Lab8Context (DbContextOptions<Persa_PaulaDenisa_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Persa_PaulaDenisa_Lab8.Models.Book> Book { get; set; }

        public DbSet<Persa_PaulaDenisa_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Persa_PaulaDenisa_Lab8.Models.Category> Category { get; set; }
    }
}
