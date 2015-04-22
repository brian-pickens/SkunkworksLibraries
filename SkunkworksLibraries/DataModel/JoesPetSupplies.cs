using System.Security.Cryptography.X509Certificates;
using DataModel.Entity;

namespace DataModel
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class JoesPetSupplies : DbContext
    {
        // Your context has been configured to use a 'JoesPetSupplies' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'JoesPetSupplies.JoesPetSupplies' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'JoesPetSupplies' 
        // connection string in the application configuration file.
        public JoesPetSupplies()
            : base("name=JoesPetSupplies")
        {
        }

        public DbSet<Person> People { get; set; }
        public DbSet<Dog> Dogs { get; set; }
        public DbSet<DogBreed> DogBreeds { get; set; }

    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}