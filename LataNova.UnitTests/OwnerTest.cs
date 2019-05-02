using Application.Factories;
using Core.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LataNova.UnitTests
{
    public class OwnerTest
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void WhenCreateOwner_ThenICanReadItsProperties()
        {
            // Arrange
            var factory = new OwnerFactory();
            var id = Guid.Empty;
            var gender = 'M';
            var name = "Nome";
            //var birthdate = DateTime.Now;
            var cpf = "123456789";
            
            // Act
            var singleton = Singleton.Owner.Create();
            var owner = factory.Create();
            
            // Assert
            //Assert.AreEqual(owner.Id, id);
            Assert.AreEqual(owner.Name, name);
            //Assert.AreEqual(owner.BirthDate, birthdate);
            Assert.AreEqual(owner.CPF, cpf);
            Assert.AreEqual(owner.Gender, gender);
        }
    }
}
