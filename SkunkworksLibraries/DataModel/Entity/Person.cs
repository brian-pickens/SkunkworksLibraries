using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.Entity
{
    public class Person : AbstractEntity
    {

        [Required]
        [StringLength(25)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [StringLength(1)]
        public string MiddleInitial { get; set; }

        [ForeignKey("Id")]
        public virtual Dog Dog { get; set; }

    }
}
