using Microsoft.EntityFrameworkCore;

namespace ResumeGenerator.Core;

public class ResumeDbContext : DbContext
{
    public virtual DbSet<Person> People { get; set; } = default!;
    public virtual DbSet<Address> Addresses { get; set; } = default!;
    public virtual DbSet<Education> Educations { get; set; } = default!;
    public virtual DbSet<Workplace> Workplaces { get; set; } = default!;
    public virtual DbSet<Certificate> Certificates { get; set; } = default!;
    public virtual DbSet<Language> Languages { get; set; } = default!;
    public virtual DbSet<Skill> Skills { get; set; } = default!;
    public virtual DbSet<Template> Templates { get; set; } = default!;

    public ResumeDbContext(DbContextOptions<ResumeDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Person>()
            .Property(p => p.Id)
            .HasDefaultValueSql("NEWID()");

        modelBuilder.Entity<Address>()
          .Property(p => p.Id)
          .HasDefaultValueSql("NEWID()");

        modelBuilder.Entity<Education>()
          .Property(p => p.Id)
          .HasDefaultValueSql("NEWID()");

        modelBuilder.Entity<Workplace>()
          .Property(p => p.Id)
          .HasDefaultValueSql("NEWID()");

        modelBuilder.Entity<Certificate>()
          .Property(p => p.Id)
          .HasDefaultValueSql("NEWID()");

        modelBuilder.Entity<Language>()
          .Property(p => p.Id)
          .HasDefaultValueSql("NEWID()");

        modelBuilder.Entity<Skill>()
          .Property(p => p.Id)
          .HasDefaultValueSql("NEWID()");

        modelBuilder.Entity<Template>()
          .Property(p => p.Id)
          .HasDefaultValueSql("NEWID()");
    }
}
