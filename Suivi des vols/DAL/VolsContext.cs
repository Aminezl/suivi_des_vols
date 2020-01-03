using Suivi_des_vols.Models;
using System;
using System.Data.Entity;

namespace Suivi_des_vols.DAL
{
    public class VolsContext : DbContext
    {
        
        public DbSet<Vols> Vols { get; set; }


    }
}