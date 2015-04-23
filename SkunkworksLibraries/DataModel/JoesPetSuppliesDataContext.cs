using System.Data.Entity.ModelConfiguration.Conventions;
using DataModel.Entity;

namespace DataModel
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class JoesPetSuppliesDataContext : DbContext
    {

        public JoesPetSuppliesDataContext()
            : base("name=JoesPetSuppliesDataContext")
        {
        }

        public DbSet<Person> People { get; set; }
        public DbSet<Dog> Dogs { get; set; }
        public DbSet<DogBreed> DogBreeds { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Configure Code First to ignore PluralizingTableName convention 
            // If you keep this convention then the generated tables will have pluralized names. 
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }

}