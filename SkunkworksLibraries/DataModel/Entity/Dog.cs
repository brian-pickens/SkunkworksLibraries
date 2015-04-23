using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.Entity
{
    public class Dog : AbstractEntity
    {

        [Key, ForeignKey("Owner")]
        public override int Id { get; set; }

        [Required]
        [StringLength(25)]
        public string Name { get; set; }

        public virtual DogBreed Breed { get; set; }

        public virtual Person Owner { get; set; }

    }
}
