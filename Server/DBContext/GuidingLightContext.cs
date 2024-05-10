using GuidingLight.Model;
using Microsoft.EntityFrameworkCore;

namespace Name;

class GuidingLightContext : DbContext
{
    public DbSet<User> User { get; internal set; }
    public DbSet<Company> Company { get; internal set; }

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
        modelBuilder.Entity<Company>(entity =>
        {
            entity.HasKey(x => x.Id);
            entity.Property(x => x.Name);
            entity.HasOne(x => x.Owner);
            entity.HasMany(x => x.DDs);
            entity.HasMany(x => x.Services);
            entity.HasMany(x => x.PMOCs);
            entity.HasMany(x => x.OSList);
            entity.HasMany(x => x.WorkersRole);
            entity.HasMany(x => x.Workers);
        }
        );
    }
}