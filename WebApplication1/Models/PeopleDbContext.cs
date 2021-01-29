using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace WebApplication1.Models

{
    public class PeopleDbContext : DbContext
    {
        public DbSet<Medicament> Medicaments { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Person> People { get; set; }
        public PeopleDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            base.OnModelCreating(mb);
            var clist = new List<Client>();
            clist.Add(new Client
            {
                Id = 1,
                FirstName = "Joe",
                LastName = "Doe",
                Birthdate = DateTime.Now
            });
            clist.Add(new Client
            {
                Id = 2,
                FirstName = "Andrzej",
                LastName = "Chuda",
                Birthdate = DateTime.Now

            });
            clist.Add(new Client
            {
                Id = 5,
                FirstName = "Andrzej",
                LastName = "Łachuda",
                Birthdate = DateTime.Now

            });
            var dlist = new List<Doctor>();
            dlist.Add(new Doctor
            {
                Id = 3,
                FirstName = "Doktor",
                LastName = "Etker",
                Email = "doEtkter@dr.pl"

            });
            dlist.Add(new Doctor
            {
                Id = 4,
                FirstName = "Dok",
                LastName = "Tor",
                Email = "dtor@dr.pl"
            });
            dlist.Add(new Doctor
            {
                Id = 6,
                FirstName = "Grigory",
                LastName = "Haus",
                Email = "dr.hous@dr.pl"
            });
            var mlist = new List<Medicament>();
            mlist.Add(new Medicament
            {
                IdMedicament = 1,
                Name = "covid-19-vac",
                Description = "pfisier",
                Type = "vac"
            });
            mlist.Add(new Medicament
            {
                IdMedicament = 2,
                Name = "covid-21-vac",
                Description = "modena",
                Type = "antivac"
           });
            mb.Entity<Client>().HasData(clist);
            mb.Entity<Doctor>().HasData(dlist);
            mb.Entity<Medicament>().HasData(mlist);
        }
    }
}