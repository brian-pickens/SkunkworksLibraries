using System.Collections.Generic;
using DataModel;
using DataModel.Entity;
using NUnit.Framework;

namespace UnitTest
{
    public class DataInitializer : System.Data.Entity.DropCreateDatabaseAlways<JoesPetSuppliesDataContext>
    {

        public DataInitializer(){ }

        public DataInitializer(JoesPetSuppliesDataContext context)
        {
            Seed(null);
            Seed(context);
        }

        protected override void Seed(JoesPetSuppliesDataContext context)
        {

            var bulldog = new DogBreed{Name = "Bulldog"};
            var labrador = new DogBreed {Name = "Labrador"};
            var poodle = new DogBreed {Name = "Poodle"};

            var people = new List<Person>
            {
                new Person {FirstName = "Brian", MiddleInitial = "M", LastName = "Pickens", Dog = new Dog{Name = "Bowser", Breed = bulldog}},
                new Person {FirstName = "Joe", MiddleInitial = "J", LastName = "Banken", Dog = new Dog{Name = "Cutie", Breed = poodle}},
                new Person {FirstName = "Nate", MiddleInitial = "G", LastName = "Lengkeek", Dog = new Dog{Name = "Sniffer", Breed = labrador}}
            };
            context.People.AddRange(people);
            context.SaveChanges();

        }

    }
}
