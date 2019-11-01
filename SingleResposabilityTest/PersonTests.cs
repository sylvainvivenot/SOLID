using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Moq;
using NFluent;
using NUnit.Framework;
using SingleResponsability;

namespace SingleResponsabilityTest
{
    public class Tests
    {
        [Test]
        public void Should_add_person_in_database_When_person_has_name()
        {
            Mock<DatabaseContext> mockContext = new Mock<DatabaseContext>();
            Mock<DbSet<Person>> personsMock = new Mock<DbSet<Person>>();
            mockContext.Setup(c => c.Persons).Returns(personsMock.Object);
            Person person = new Person(mockContext.Object) { Name = "Toto"};
            person.AddToDatabase();
            personsMock.Verify(p => p.Add(It.IsAny<Person>()), Times.Once);
            mockContext.Verify(c => c.SaveChanges(), Times.Once);
        }
    }
}