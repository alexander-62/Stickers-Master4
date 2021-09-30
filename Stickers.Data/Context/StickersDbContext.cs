using Microsoft.EntityFrameworkCore;
using Stickers.Data.Entities;
using Stickers.Data.EntityMappings;

namespace Stickers.Data.Context
{
    public class StickersDbContext : DbContext
    {
        public DbSet<BusinessClient> BusinessClients { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Cost> Costs { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Roll> Rolls { get; set; }
        public DbSet<Film> Films { get; set; }
        public DbSet<WorkReport> WorkReports { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Data Source=95.83.153.214,60495;Initial Catalog=Stickers;User Id=sa;Password=AW5rrxL;";
            //var connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=Stickers;Integrated Security=True";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(BusinessClientEntityMap).Assembly);
        }
    }
}