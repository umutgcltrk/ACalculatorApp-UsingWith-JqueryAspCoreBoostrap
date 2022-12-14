using Microsoft.EntityFrameworkCore;

namespace Calculator.Models.DbConnection
{
    public class DatabaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=SERVERISMI;database=CalculateDb;integrated security=true");
        }

        public DbSet<Calculator> Calculators { get; set; }
    }
}
