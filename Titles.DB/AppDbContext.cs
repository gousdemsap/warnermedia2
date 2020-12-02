using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Titles.DB
{
    public class AppDbContext : DbContext
    {
        
        
            public DbSet<Title> Titles { get; set; }
            

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(
                    @"Server=(localdb)\mssqllocaldb;Database=Titles;Integrated Security=True");
            }
        
    }
}
