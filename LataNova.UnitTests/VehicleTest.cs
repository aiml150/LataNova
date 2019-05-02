using Application.Factories;
using Core.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LataNova.UnitTests
{
    public class VehicleTest
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void WhenCreateOwner_ThenICanReadItsProperties()
        {
            // Arrange
            var factory = new VehicleFactory();
            var id = Guid.Empty;
            var brand = "Marca";
            var color = "Cor";
            var model = "Modelo";
            var plate = "PLACA";
            var year = 1234;

            // Act
            var owner = factory.Create();
            
            // Assert
            Assert.AreEqual(owner.Id, id);
            Assert.AreEqual(owner.Brand, brand);
            Assert.AreEqual(owner.Color, color);
            Assert.AreEqual(owner.Model, model);
            Assert.AreEqual(owner.Plate, plate);
            Assert.AreEqual(owner.Year, year);
        }
    }
}
