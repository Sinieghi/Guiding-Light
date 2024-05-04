using Microsoft.EntityFrameworkCore;

namespace Name;

class GuidingLightContext : DbContext
{

    protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptions)
    {
        URL dbLink = new();
        dbContextOptions.UseMySQL(dbLink.url);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        // modelBuilder.Entity<>(entity =>
        // {
        //     entity.HasKey(x => x.Id); 
        // });
    }
}