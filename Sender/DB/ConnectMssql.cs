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

    }
}
