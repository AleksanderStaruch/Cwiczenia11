﻿// <auto-generated />
using System;
using Cwiczenia11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Cwiczenia11.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Cwiczenia11.Models.Animal", b =>
                {
                    b.Property<int>("IdAnimal")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age");

                    b.Property<string>("Descrition")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<int>("IdAnimalType");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.HasKey("IdAnimal");

                    b.HasIndex("IdAnimalType");

                    b.ToTable("Animals");
                });

            modelBuilder.Entity("Cwiczenia11.Models.Animal_Owner", b =>
                {
                    b.Property<int>("IdAnimal");

                    b.Property<int>("IdOwner");

                    b.Property<DateTime>("Created");

                    b.HasKey("IdAnimal", "IdOwner");

                    b.HasIndex("IdOwner");

                    b.ToTable("Animal_Owners");
                });

            modelBuilder.Entity("Cwiczenia11.Models.AnimalClinic", b =>
                {
                    b.Property<int>("IdAnimalClinic")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasMaxLength(255);

                    b.Property<int>("IdOwner");

                    b.Property<string>("Name")
                        .HasMaxLength(255);

                    b.HasKey("IdAnimalClinic");

                    b.HasIndex("IdOwner");

                    b.ToTable("AnimalClinics");
                });

            modelBuilder.Entity("Cwiczenia11.Models.AnimalType", b =>
                {
                    b.Property<int>("IdAnimalType")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.HasKey("IdAnimalType");

                    b.ToTable("AnimalTypes");
                });

            modelBuilder.Entity("Cwiczenia11.Models.Owner", b =>
                {
                    b.Property<int>("MyProperty")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("MyProperty");

                    b.ToTable("Owners");
                });

            modelBuilder.Entity("Cwiczenia11.Models.Animal", b =>
                {
                    b.HasOne("Cwiczenia11.Models.AnimalType", "AnimalType")
                        .WithMany("Animal")
                        .HasForeignKey("IdAnimalType")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Cwiczenia11.Models.Animal_Owner", b =>
                {
                    b.HasOne("Cwiczenia11.Models.Animal", "Animal")
                        .WithMany()
                        .HasForeignKey("IdAnimal")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Cwiczenia11.Models.Owner", "Owner")
                        .WithMany("Animal_Owner")
                        .HasForeignKey("IdOwner")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Cwiczenia11.Models.AnimalClinic", b =>
                {
                    b.HasOne("Cwiczenia11.Models.Owner", "Owner")
                        .WithMany("AnimalClinic")
                        .HasForeignKey("IdOwner")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
