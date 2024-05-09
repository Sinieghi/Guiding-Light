using GuidingLight.Model;
using Microsoft.EntityFrameworkCore;

namespace Name;

class GuidingLightContext : DbContext
{
    public DbSet<User> User { get; internal set; }

    protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptions)
    {
        URL dbLink = new();
        dbContextOptions.UseMySQL(dbLink.url);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(x => x.Id);
            entity.Property(x => x.Email);
            entity.Property(x => x.Name);
            entity.Property(x => x.Password);
            entity.Property(x => x.Avatar);
            entity.HasMany(x => x.MySkills);
            entity.HasMany(x => x.ServicesDone);
            entity.HasOne(x => x.MyCompany);
        });
    }
}