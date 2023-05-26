﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ResumeGenerator.Core;

#nullable disable

namespace ResumeGenerator.Core.Migrations
{
    [DbContext(typeof(ResumeDbContext))]
    partial class ResumeDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AddressPerson", b =>
                {
                    b.Property<Guid>("AddressesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PeopleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("AddressesId", "PeopleId");

                    b.HasIndex("PeopleId");

                    b.ToTable("AddressPerson");
                });

            modelBuilder.Entity("EducationPerson", b =>
                {
                    b.Property<Guid>("EducationsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PersonId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("EducationsId", "PersonId");

                    b.HasIndex("PersonId");

                    b.ToTable("EducationPerson");
                });

            modelBuilder.Entity("PersonWorkplace", b =>
                {
                    b.Property<Guid>("PeopleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("WorkplacesId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("PeopleId", "WorkplacesId");

                    b.HasIndex("WorkplacesId");

                    b.ToTable("PersonWorkplace");
                });

            modelBuilder.Entity("ResumeGenerator.Core.Address", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("EducationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("WorkplaceId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("EducationId");

                    b.HasIndex("WorkplaceId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("ResumeGenerator.Core.Certificate", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<bool>("IsPresent")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Period")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("PersonId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("Certificates");
                });

            modelBuilder.Entity("ResumeGenerator.Core.Education", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsPresent")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("School")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Educations");
                });

            modelBuilder.Entity("ResumeGenerator.Core.Language", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("PersonId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("ResumeGenerator.Core.Person", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<DateTime?>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("HeadLine")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("People");
                });

            modelBuilder.Entity("ResumeGenerator.Core.Skill", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("PersonId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("ResumeGenerator.Core.Template", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<int?>("Font")
                        .HasColumnType("int");

                    b.Property<int?>("FontSize")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("PersonId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Theme")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("Templates");
                });

            modelBuilder.Entity("ResumeGenerator.Core.Workplace", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Employer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsInternship")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPresent")
                        .HasColumnType("bit");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Workplaces");
                });

            modelBuilder.Entity("AddressPerson", b =>
                {
                    b.HasOne("ResumeGenerator.Core.Address", null)
                        .WithMany()
                        .HasForeignKey("AddressesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ResumeGenerator.Core.Person", null)
                        .WithMany()
                        .HasForeignKey("PeopleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EducationPerson", b =>
                {
                    b.HasOne("ResumeGenerator.Core.Education", null)
                        .WithMany()
                        .HasForeignKey("EducationsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ResumeGenerator.Core.Person", null)
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PersonWorkplace", b =>
                {
                    b.HasOne("ResumeGenerator.Core.Person", null)
                        .WithMany()
                        .HasForeignKey("PeopleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ResumeGenerator.Core.Workplace", null)
                        .WithMany()
                        .HasForeignKey("WorkplacesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ResumeGenerator.Core.Address", b =>
                {
                    b.HasOne("ResumeGenerator.Core.Education", "Education")
                        .WithMany("Addresses")
                        .HasForeignKey("EducationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ResumeGenerator.Core.Workplace", "Workplace")
                        .WithMany("Addresses")
                        .HasForeignKey("WorkplaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Education");

                    b.Navigation("Workplace");
                });

            modelBuilder.Entity("ResumeGenerator.Core.Certificate", b =>
                {
                    b.HasOne("ResumeGenerator.Core.Person", "Person")
                        .WithMany("Certificates")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("ResumeGenerator.Core.Language", b =>
                {
                    b.HasOne("ResumeGenerator.Core.Person", null)
                        .WithMany("Languages")
                        .HasForeignKey("PersonId");
                });

            modelBuilder.Entity("ResumeGenerator.Core.Skill", b =>
                {
                    b.HasOne("ResumeGenerator.Core.Person", "Person")
                        .WithMany("Skills")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("ResumeGenerator.Core.Template", b =>
                {
                    b.HasOne("ResumeGenerator.Core.Person", "Person")
                        .WithMany("Templates")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("ResumeGenerator.Core.Education", b =>
                {
                    b.Navigation("Addresses");
                });

            modelBuilder.Entity("ResumeGenerator.Core.Person", b =>
                {
                    b.Navigation("Certificates");

                    b.Navigation("Languages");

                    b.Navigation("Skills");

                    b.Navigation("Templates");
                });

            modelBuilder.Entity("ResumeGenerator.Core.Workplace", b =>
                {
                    b.Navigation("Addresses");
                });
#pragma warning restore 612, 618
        }
    }
}
