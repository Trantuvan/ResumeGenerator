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
            .ToTable("Person")
            .Property(p => p.Id)
            .HasDefaultValueSql("NEWID()");

        modelBuilder.Entity<Address>()
            .ToTable("Address")
            .Property(p => p.Id)
            .HasDefaultValueSql("NEWID()");

        modelBuilder.Entity<Education>()
            .ToTable("Education")
            .Property(p => p.Id)
            .HasDefaultValueSql("NEWID()");

        modelBuilder.Entity<Workplace>()
            .ToTable("Workplace")
            .Property(p => p.Id)
            .HasDefaultValueSql("NEWID()");

        modelBuilder.Entity<Certificate>()
            .ToTable("Certificate")
            .Property(p => p.Id)
            .HasDefaultValueSql("NEWID()");

        modelBuilder.Entity<Language>()
            .ToTable("Language")
            .Property(p => p.Id)
            .HasDefaultValueSql("NEWID()");

        modelBuilder.Entity<Skill>()
            .ToTable("Skill")
            .Property(p => p.Id)
            .HasDefaultValueSql("NEWID()");

        modelBuilder.Entity<Template>()
            .ToTable("Template")
            .Property(p => p.Id)
            .HasDefaultValueSql("NEWID()");

        //Many to Many with person table
        modelBuilder.Entity<Person>()
            .HasMany(p => p.Addresses)
            .WithMany(a => a.People)
            .UsingEntity<PersonAddress>("PersonAddress",
            r => r.HasOne<Address>().WithMany(a => a.PersonAddresses).HasForeignKey(pa => pa.AddressId),
            l => l.HasOne<Person>().WithMany(p => p.PersonAddresses).HasForeignKey(pa => pa.PersonId),
            j => j.Property(pa => pa.Id).HasDefaultValueSql("NEWID()"));

        modelBuilder.Entity<Person>()
                   .HasMany(p => p.Educations)
                   .WithMany(edu => edu.People)
                   .UsingEntity<PersonEducation>("PersonEducation",
                   r => r.HasOne<Education>().WithMany(e => e.PersonEducations).HasForeignKey(pe => pe.EducationId),
                   r => r.HasOne<Person>().WithMany(e => e.PersonEducations).HasForeignKey(pe => pe.PersonId),
                   j => j.Property(pa => pa.Id).HasDefaultValueSql("NEWID()"));

        modelBuilder.Entity<Person>()
                          .HasMany(p => p.Workplaces)
                          .WithMany(w => w.People)
                          .UsingEntity<PersonWorkplace>("PersonWorkplace",
                          r => r.HasOne<Workplace>().WithMany(w => w.PersonWorkplaces).HasForeignKey(pw => pw.WorkplaceId),
                          r => r.HasOne<Person>().WithMany(e => e.PersonWorkplaces).HasForeignKey(pw => pw.PersonId),
                          j => j.Property(pw => pw.Id).HasDefaultValueSql("NEWID()"));

    }
}
