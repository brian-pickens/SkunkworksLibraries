using System.Data.Entity;
using System.Linq;
using DataModel;
using DataModel.Entity;
using EFDataAccess;
using NUnit.Framework;
using SimpleInjector;


namespace UnitTest
{
    [TestFixture]
    public class UnitTest1
    {

        private EFGenericRepositoryContext _context;
        private Container _di;

        
        [SetUp]
        public void Setup()
        {
            _di = new Container();
            _di.Register<EFGenericRepositoryContext,EFGenericRepositoryContext>();
            _di.Register<DbContext,DataModel.JoesPetSuppliesDataContext>();
            _di.Verify();

            _context = _di.GetInstance<EFGenericRepositoryContext>();
        }

        [Test]
        public void Test_EFGenericRepositoryContext_Get_ReturnsCorrectInstance()
        {
            var personRepo = _context.Get<PersonRepository,Person>();

            Assert.That(personRepo, Is.InstanceOf<EFGenericRepository<Person>>());
            Assert.That(personRepo, Is.InstanceOf<PersonRepository>());
        }

        [Test]
        public void Test_DataConnection()
        {
            var personRepo = _context.Get<PersonRepository, Person>();
            var people = personRepo.GetAll().ToList();

            Assert.That(people, Has.Count);
        }

    }

    [SetUpFixture]
    public class SetupFixture
    {
        [SetUp]
        void RunBeforeAnyTests()
        {

            Database.SetInitializer(new DataInitializer(new JoesPetSuppliesDataContext()));
        }
    }

}
