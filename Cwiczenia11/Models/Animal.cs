using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cwiczenia11.Models
{
    public class Animal
    {
        [Key]
        public int IdAnimal { get; set; }
        [Required]
        [MaxLength(150)]
        public string Name { get; set; }
        [Required]
        [MaxLength(150)]
        public string Descrition { get; set; }
        [Required]
        public int Age { get; set; }
        
        [Required]
        public int IdAnimalType { get; set; }

        [ForeignKey("IdAnimalType")]
        public virtual AnimalType AnimalType { get; set; }


    }
}
