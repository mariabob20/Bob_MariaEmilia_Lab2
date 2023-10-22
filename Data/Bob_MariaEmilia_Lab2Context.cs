using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Bob_MariaEmilia_Lab2.Models;

namespace Bob_MariaEmilia_Lab2.Data
{
    public class Bob_MariaEmilia_Lab2Context : DbContext
    {
        public Bob_MariaEmilia_Lab2Context (DbContextOptions<Bob_MariaEmilia_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Bob_MariaEmilia_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Bob_MariaEmilia_Lab2.Models.Publisher>? Publisher { get; set; }

        public DbSet<Bob_MariaEmilia_Lab2.Models.Author>? Author { get; set; }
    }
}
