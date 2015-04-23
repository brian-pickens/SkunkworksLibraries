using System.ComponentModel.DataAnnotations;

namespace DataModel.Entity
{
    public abstract class AbstractEntity
    {

        [Key]
        public virtual int Id { get; set; }

    }
}
