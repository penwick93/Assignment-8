using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PNFenwick_PetStore.Models
{
    public class AnimalContextInitializer : DropCreateDatabaseAlways<AnimalContext>
    {
        protected override void Seed(AnimalContext context)
        {
            context.Animals.Add(
                new Animal()
                {
                    Name = "Tucker",
                    Type = "Dog",
                    Price = 35
                }
            
                );
            context.SaveChanges();
        }
    }
}