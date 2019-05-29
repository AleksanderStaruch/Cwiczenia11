using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cwiczenia11.Models
{
    public class Animal_Owner
    {
        public int IdAnimal { get; set; }
        public int IdOwner { get; set; }
        [Required]
        public DateTime Created { get; set; }

        [ForeignKey("IdAnimal")]
        public virtual Animal Animal { get; set; }
        [ForeignKey("IdOwner")]
        public virtual Owner Owner { get; set; }
        



    }
}