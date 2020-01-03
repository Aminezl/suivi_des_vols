using DevisMutuelle.Models;
using System;
using System.Data.Entity;

namespace DevisMutuelle.DAL
{
    public class DevisMutuelleContext :DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Conjoint> Conjoints { get; set; }
        public DbSet<Enfant> Enfants { get; set; }
    }
}