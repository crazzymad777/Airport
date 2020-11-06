using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Airport
{
    class DatabaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=airport.db");
        }
        public DbSet<TicketModel> Tickets { get; set; }
        public DbSet<TokenModel> Tokens { get; set; }
    }
}
