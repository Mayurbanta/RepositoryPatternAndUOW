using Engine.Models;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Linq;

namespace TestswithInMemoryEF
{
    [TestFixture]
    public class NorthwindContextTests
    {
        private NorthwindContext _context;

        private static DbContextOptions<NorthwindContext> dbContextOptions = new DbContextOptionsBuilder<NorthwindContext>()
            .UseInMemoryDatabase(databaseName: "NorthwindTest")
            .Options;


        [OneTimeSetUp]
        public void Setup()
        {
            _context = new NorthwindContext(dbContextOptions);
            _context.Database.EnsureCreated();

            SeedDatabase();
        }


        [OneTimeTearDown]
        public void CleanUp()
        {
            _context.Database.EnsureDeleted();
        }

        private void SeedDatabase()
        {
            var customer = new Customer()
            {
                CustomerId = "1-2-3",
                CompanyName = "Test Company 123"
            };

            _context.Customers.Add(customer);
            _context.SaveChanges();          

        }


        [Test]
        public void CheckCustomerId()
        {
            var cust = _context.Customers.FirstOrDefault();

            Assert.That(cust.CustomerId, Is.EqualTo("1-2-3"));
        }
    }
}
