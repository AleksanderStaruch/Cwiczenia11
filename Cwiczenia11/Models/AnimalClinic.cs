using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cwiczenia11.Models
{
    public class AnimalClinic
    {
        public int IdAnimalClinic { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int IdOwner { get; set; }

        [ForeignKey("IdOwner")]
        public virtual Owner Owner { get; set; }
    }
}
