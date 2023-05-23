using Microsoft.EntityFrameworkCore;
using ResumeGenerator.Core.Entities;

namespace ResumeGenerator.Core.Database;

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
    }
}
