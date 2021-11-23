﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Pet_Health_Tracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pet_Health_Tracker
{
    public class PetTrackerContext : DbContext
    {
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<MedicalRecord> MedicalRecords { get; set; }

        public IConfiguration Configuration;

        public PetTrackerContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = Configuration.GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlServer(connectionString).UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);

            modelbuilder.Entity<Owner>().HasData(
                            new Owner() { Id = 1, FirstName = "Dan", LastName = "Fairchild" },
                            new Owner() { Id = 2, FirstName = "Kevin", LastName = "Tousey" });

            modelbuilder.Entity<Pet>().HasData(
                            new Pet() { Id = 1, Name = "Brewster", Age = 7, Species = "Dog", Breed = "Husky Mix", Gender = "Male", Photo = "", OwnerId = 1 },
                            new Pet() { Id = 2, Name = "Princess Trudy", Age = 6, Species = "Dog", Breed = "Maltese", Gender = "Female", Photo = "", OwnerId = 2 },
                            new Pet() { Id = 3, Name = "Slim Jim", Age = 2, Species = "Ferret", Breed = "Black Sable", Gender = "Male", Photo = "", OwnerId = 1 });

            modelbuilder.Entity<MedicalRecord>().HasData(
                                new MedicalRecord() { Id = 1, PetId = 1 },
                                new MedicalRecord() { Id = 2, PetId = 2 },
                                new MedicalRecord() { Id = 3, PetId = 3 });

            modelbuilder.Entity<MedicalItem>().HasData(
                                new MedicalItem() { Id = 1, MedicalRecordId = 1, RecordType = MedicalRecordType.Vaccination, TreatedOn = DateTime.Now, Description = "Cras eu malesuada lectus. Suspendisse vel mattis magna." },
                                new MedicalItem() { Id = 2, MedicalRecordId = 2, RecordType = MedicalRecordType.Surgery, TreatedOn = DateTime.Now, Description = "Cras eu malesuada lectus. Suspendisse vel mattis magna." },
                                new MedicalItem() { Id = 3, MedicalRecordId = 3, RecordType = MedicalRecordType.Treatments, TreatedOn = DateTime.Now, Description = "Cras eu malesuada lectus. Suspendisse vel mattis magna." },
                                new MedicalItem() { Id = 4, MedicalRecordId = 1, RecordType = MedicalRecordType.Fixed, TreatedOn = DateTime.Now, Description = "Cras eu malesuada lectus. Suspendisse vel mattis magna." },
                                new MedicalItem() { Id = 5, MedicalRecordId = 2, RecordType = MedicalRecordType.Allergies, TreatedOn = DateTime.Now, Description = "Cras eu malesuada lectus. Suspendisse vel mattis magna." },
                                new MedicalItem() { Id = 6, MedicalRecordId = 3, RecordType = MedicalRecordType.Medications, TreatedOn = DateTime.Now, Description = "Cras eu malesuada lectus. Suspendisse vel mattis magna." });

            modelbuilder.Entity<Weight>().HasData(
                            new Weight() { Id = 1, CurrentWeight = 50, DateTime = DateTime.Now, PetId = 1 },
                            new Weight() { Id = 2, CurrentWeight = 12, DateTime = DateTime.Now, PetId = 2 },
                            new Weight() { Id = 3, CurrentWeight = 2, DateTime = DateTime.Now, PetId = 3 });

        }

    }
}