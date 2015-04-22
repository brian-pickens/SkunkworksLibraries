using System.Data.Entity;
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
            _di.Register<DbContext,DataModel.JoesPetSupplies>();
            _di.Verify();

            _context = _di.GetInstance<EFGenericRepositoryContext>();
        }

        [Test]
        public void TestMethod1()
        {
            var personRepo = _context.Get<PersonRepository,Person>();

            Assert.That(personRepo, Is.InstanceOf<EFGenericRepository<Person>>());
            Assert.That(personRepo, Is.InstanceOf<PersonRepository>());
        }

    }
}
