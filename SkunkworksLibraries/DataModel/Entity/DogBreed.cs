using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Entity
{
    public class DogBreed : AbstractEntity
    {

        [Required]
        [StringLength(100)]
        public String Name { get; set; }

    }
}
