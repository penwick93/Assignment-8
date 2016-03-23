using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PNFenwick_PetStore.Models
{
    public class AnimalContext : DbContext
    {
        public DbSet<Animal> Animals {get; set;}
    }
}