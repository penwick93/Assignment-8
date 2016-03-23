using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PNFenwick_PetStore.Models
{
    public class Animal
    {
        [Key]
        [Required(ErrorMessage = "Animal is required")]
        [Display(Name = "Animal")]
        public string Name { get; set;}

        
        [Required(ErrorMessage = "Type is required")]
        public string Type { get; set; }

        
        [Required(ErrorMessage ="Price is Required")]
        public Int64 Price { get; set; }

    }
}