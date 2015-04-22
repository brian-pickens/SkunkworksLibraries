using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Entity
{
    public class Dog : AbstractEntity
    {

        [Required]
        [StringLength(25)]
        public string Name { get; set; }

        [ForeignKey("DogBreedId")]
        public DogBreed Breed { get; set; }

        [ForeignKey("PersonId")]
        public Person Owner { get; set; }

    }
}
