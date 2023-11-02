﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Stoia_Alina_Lab2.Models;

namespace Stoia_Alina_Lab2.Data
{
    public class Stoia_Alina_Lab2Context : DbContext
    {
        public Stoia_Alina_Lab2Context (DbContextOptions<Stoia_Alina_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Stoia_Alina_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Stoia_Alina_Lab2.Models.Publisher>? Publisher { get; set; }

        public DbSet<Stoia_Alina_Lab2.Models.Author>? Author { get; set; }

        public DbSet<Stoia_Alina_Lab2.Models.Category>? Category { get; set; }
    }
}
