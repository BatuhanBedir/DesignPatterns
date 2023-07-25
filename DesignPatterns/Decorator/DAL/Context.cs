using Microsoft.EntityFrameworkCore;

namespace Decorator.DAL;

public class Context:DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=BATUHAN;Initial Catalog=DesignPatternDecoratorDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
    }
    public DbSet<Message> Messages { get; set; }
    public DbSet<Notifier> Notifiers { get; set; }
}
