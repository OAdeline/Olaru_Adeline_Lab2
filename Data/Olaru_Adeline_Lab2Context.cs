using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Olaru_Adeline_Lab2.Models;

namespace Olaru_Adeline_Lab2.Data
{
    public class Olaru_Adeline_Lab2Context : DbContext
    {
        public Olaru_Adeline_Lab2Context (DbContextOptions<Olaru_Adeline_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Olaru_Adeline_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Olaru_Adeline_Lab2.Models.Publisher>? Publisher { get; set; }
    }
}
