using Microsoft.EntityFrameworkCore;
using Sender.DTO;

namespace Sender.DB
{
    public class ConnectMssql : DbContext
    {
        public ConnectMssql(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Box> boxes { get; set; }
        public DbSet<Customer> customers {get; set;}
        public DbSet<Pos> Pos { get; set; }
        public DbSet<Consignor> consignors { get; set;}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Customer>().HasIndex(x => x.Name).IsUnique();
            modelBuilder.Entity<Consignor>().HasIndex(x => x.Name).IsUnique();
            modelBuilder.Entity<Pos>().HasIndex(x => x.Name).IsUnique();
            modelBuilder.Entity<Box>().Property(x => x.Received).IsRequired();

        }
    }
}
