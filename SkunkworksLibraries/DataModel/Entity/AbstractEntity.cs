using System.ComponentModel.DataAnnotations;

namespace DataModel.Entity
{
    public abstract class AbstractEntity
    {

        [Key]
        public int Id { get; set; }

    }
}
