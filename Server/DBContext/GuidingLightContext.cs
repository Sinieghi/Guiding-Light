using GuidingLight.Model;
using Microsoft.EntityFrameworkCore;

namespace Name;

class GuidingLightContext : DbContext
{
    public DbSet<User> User { get; internal set; }
    public DbSet<Company> Company { get; internal set; }
    public DbSet<Service> Service { get; internal set; }
    public DbSet<OS> OS { get; internal set; }
    public DbSet<PMOC> PMOC { get; internal set; }
    public DbSet<Equipment> Equipment { get; internal set; }

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
            entity.HasOne(x => x.MyRole);
        });
        modelBuilder.Entity<Company>(entity =>
        {
            entity.HasKey(x => x.Id);
            entity.Property(x => x.Name);
            entity.HasOne(x => x.Owner);
        }
        );
        modelBuilder.Entity<Equipment>(entity =>
        {
            entity.HasKey(x => x.Id);
            entity.Property(x => x.Tag);
            entity.Property(x => x.Type);
            entity.Property(x => x.ManualPDF);
            entity.Property(x => x.Image);
        }
        );
        modelBuilder.Entity<Service>(entity =>
        {
            entity.HasKey(x => x.Id);
            entity.Property(x => x.Risks);
            entity.Property(x => x.Security);
            entity.Property(x => x.Description);
            entity.Property(x => x.IsDone);
            entity.Property(x => x.DateOfService);
            entity.Property(x => x.EPIs);
            entity.HasOne(x => x.Client);
            entity.HasOne(x => x.Os);
            entity.HasOne(x => x.Company);
        }
        );
        modelBuilder.Entity<OS>(entity =>
        {
            entity.HasKey(x => x.Id);
            entity.HasOne(x => x.Creator);
            entity.HasOne(x => x.Client);
            entity.HasOne(x => x.Company);
            entity.HasMany(x => x.TeamSelected);
        }
        );
        modelBuilder.Entity<PMOC>(entity =>
        {
            entity.HasKey(x => x.Id);
            entity.HasOne(x => x.Company);
            entity.Property(x => x.FieldName);
            entity.Property(x => x.FiledDescription);
        });
    }
}