using InventoryMS.Models.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryMS.DB
{
    public class InventoryMsDbContext: DbContext
    {
        public DbSet<Product> Product { get; set; }
        public DbSet<Unit> Unit { get; set; }
        public DbSet<LogRecord> Log { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            IConfiguration appConfig =
                new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", false, true).Build();
            string dbConnnString = appConfig.GetConnectionString("InventoryMsDB");
            optionsBuilder.UseSqlServer(dbConnnString);

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Unit>().HasData(
                new Unit { UnitID = 1, UnitName = "Шт." },
                new Unit { UnitID = 2, UnitName = "Кг." },
                new Unit { UnitID = 3, UnitName = "Гр." },
                new Unit { UnitID = 4, UnitName = "Кор." },
                new Unit { UnitID = 5, UnitName = "Ящ." }


                );
        }
    }
}
