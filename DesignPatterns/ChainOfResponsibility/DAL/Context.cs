using Microsoft.EntityFrameworkCore;

namespace ChainOfResponsibility.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=BATUHAN;Initial Catalog=DesignPattern1Db;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
        public DbSet<CustomerProcess> CustomerProcesseses { get; set; }
    }
}
