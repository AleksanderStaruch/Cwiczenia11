using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cwiczenia11.Models
{
    public class AnimalType
    {
        [Key]
        public int IdAnimalType { get; set; }
        [Required]
        [MaxLength(150)]
        public string Name { get; set; }

        public virtual ICollection<Animal> Animal { get; set; }

    }
}
