using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cwiczenia11.Models
{
    public class Context : DbContext
    {


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=db-mssql;Initial Catalog=s16964;Integrated Security=True");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Animal_Owner>().HasKey(t => new { t.IdAnimal, t.IdOwner });
            modelBuilder.Entity<AnimalClinic>().Property(t => t.Address).HasMaxLength(255);
            modelBuilder.Entity<AnimalClinic>().Property(t => t.Name).HasMaxLength(255);
            modelBuilder.Entity<AnimalClinic>().HasKey(t => t.IdAnimalClinic);
            modelBuilder.Entity<AnimalClinic>().HasOne(ac => ac.Owner).WithMany(o => o.AnimalClinic).HasForeignKey(ac=>ac.IdOwner);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Animal> Animals { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Animal_Owner> Animal_Owners { get; set; }
        public DbSet<AnimalType> AnimalTypes { get; set; }
        public DbSet<AnimalClinic> AnimalClinics { get; set; }


    }
}
