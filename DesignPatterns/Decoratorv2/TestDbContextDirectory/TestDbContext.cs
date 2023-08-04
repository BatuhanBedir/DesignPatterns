using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Decoratorv2.TestDbContextDirectory;

public class TestDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=BATUHAN;Initial Catalog=DesignPatternDecoratorDbv2;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
    }
    public DbSet<UserEntity> Users { get; set; }

    //varolan fonksiyonun içeriğini değiştirmeden kapsamını genişletme
    public override int SaveChanges()
    {
        //audit logging
        return base.SaveChanges();
    }
}
