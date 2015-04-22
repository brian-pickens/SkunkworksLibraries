using System.ComponentModel.DataAnnotations;

namespace DataModel.Entity
{
    public class Person
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

    }
}
