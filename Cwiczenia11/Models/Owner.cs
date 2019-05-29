using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cwiczenia11.Models
{
    public class Owner
    {
        [Key]
        public int MyProperty { get; set; }
        [Required]
        [MaxLength(255)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(255)]
        public string LastName { get; set; }

        public virtual ICollection<Animal_Owner> Animal_Owner{ get; set; }
        public virtual ICollection<AnimalClinic> AnimalClinic{ get; set; }


    }
}
