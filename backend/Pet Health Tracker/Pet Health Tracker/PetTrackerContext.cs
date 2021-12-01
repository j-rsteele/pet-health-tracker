using Microsoft.EntityFrameworkCore;
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
        // Add DB Sets    
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Pet> Pets { get; set; }

        public DbSet<MedicalRecord> MedicalRecords { get; set; }  
        public DbSet<MedicalItem> MedicalItems{ get; set; }
        public DbSet<Weight> Weights { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<AuthorizedUser> AuthorizedUsers { get; set; }

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
            modelbuilder.Entity<AuthorizedUser>().HasData(
               new AuthorizedUser() { Id = 1, Username = "dfairchild", Password = "password" },
               new AuthorizedUser() { Id = 2, Username = "ktousey", Password = "password" });

            modelbuilder.Entity<Owner>().HasData(
               new Owner() { Id = 1, FirstName = "Dan", LastName = "Fairchild" },
               new Owner() { Id = 2, FirstName = "Kevin", LastName = "Tousey" });

            modelbuilder.Entity<Pet>().HasData(
               new Pet() { Id = 1, Name = "Brewster", Age = 7, Species = "Dog", Breed = "Husky Mix", Gender = "Male", Photo = "", OwnerId = 1 },
               new Pet() { Id = 2, Name = "Princess Trudy", Age = 6, Species = "Dog", Breed = "Maltese", Gender = "Female", Photo = "", OwnerId = 2 },
               new Pet() { Id = 3, Name = "Slim Jim", Age = 2, Species = "Ferret", Breed = "Black Sable", Gender = "Male", Photo = "", OwnerId = 1 });

            modelbuilder.Entity<MedicalRecord>().HasData(
               new MedicalRecord() { Id = 1, Clinic = "Bedford Animal Hospital", PrimaryVet = "Dr. Doolittle", Phone = "440-555-1298", Street = "412 Oak Ln", City = "Bedford", State = "OH", Zip = "44123" , PetId = 1, },
               new MedicalRecord() { Id = 2, Clinic = "Gateway Animal Hospital", PrimaryVet = "Dr. Bob", Phone = "216-555-6728", Street = "Abbey Ave", City = "Cleveland", State = "OH", Zip = "44102" , PetId = 2 },
               new MedicalRecord() { Id = 3, Clinic = "Suburban Veterinarian Clinic", PrimaryVet = "Dr. Scott", Phone = "330-555-7263", Street = "58 Maple St", City = "Maple Heights", State = "OH", Zip = "44242", PetId = 3 });

            modelbuilder.Entity<MedicalItem>().HasData(
               new MedicalItem() { Id = 1, MedicalRecordId = 1, ItemType = MedicalItemType.Vaccination, TreatedOn = DateTime.Now, Description = "Cras eu malesuada lectus. Suspendisse vel mattis magna." },
               new MedicalItem() { Id = 2, MedicalRecordId = 3, ItemType = MedicalItemType.Surgery, TreatedOn = DateTime.Now, Description = "Cras eu malesuada lectus. Suspendisse vel mattis magna." },
               new MedicalItem() { Id = 3, MedicalRecordId = 2, ItemType = MedicalItemType.Treatments, TreatedOn = DateTime.Now, Description = "Cras eu malesuada lectus. Suspendisse vel mattis magna." },
               new MedicalItem() { Id = 4, MedicalRecordId = 1, ItemType = MedicalItemType.Fixed, TreatedOn = DateTime.Now, Description = "Cras eu malesuada lectus. Suspendisse vel mattis magna." },
               new MedicalItem() { Id = 5, MedicalRecordId = 2, ItemType = MedicalItemType.Allergies, TreatedOn = DateTime.Now, Description = "Cras eu malesuada lectus. Suspendisse vel mattis magna." },
               new MedicalItem() { Id = 6, MedicalRecordId = 3, ItemType = MedicalItemType.Medications, TreatedOn = DateTime.Now, Description = "Cras eu malesuada lectus. Suspendisse vel mattis magna." });

            modelbuilder.Entity<Weight>().HasData(
                new Weight() { Id = 1, CurrentWeight = 50, Date = DateTime.Now, PetId = 1 },
                new Weight() { Id = 2, CurrentWeight = 12, Date = DateTime.Now, PetId = 2 },
                new Weight() { Id = 3, CurrentWeight = 2, Date = DateTime.Now, PetId = 3 });

            modelbuilder.Entity<Appointment>().HasData(
                new Appointment() { Id = 1, PetId = 1, ApptDateTime = DateTime.Now, EmailAddress = "brewster@gmail.com", Caregiver = "Dr Doolittle", Description = "Annual Checkup", Notes = "Check lump on ribs, bring in stool sample" },
                new Appointment() { Id = 2, PetId = 2, ApptDateTime = DateTime.Now, EmailAddress = "princesstrudy@gmail.com", Caregiver = "Pet Smart Grooming", Description = "Hair Trim and Bath, Toenail trim", Notes = "Full spa treatment" });
            base.OnModelCreating(modelbuilder);
        }
    }
}
