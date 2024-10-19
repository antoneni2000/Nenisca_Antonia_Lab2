using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Nenisca_Antonia_Lab2.Models;

namespace Nenisca_Antonia_Lab2.Data
{
    public class Nenisca_Antonia_Lab2Context : DbContext
    {
        public Nenisca_Antonia_Lab2Context (DbContextOptions<Nenisca_Antonia_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Nenisca_Antonia_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Nenisca_Antonia_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Nenisca_Antonia_Lab2.Models.Author> Authors { get; set; } = default!;
    }
}
