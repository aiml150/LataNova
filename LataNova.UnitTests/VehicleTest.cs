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
        public void WhenCreateVehicle_ThenICanReadItsProperties()
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
            var vehicle = Singleton.Vehicle.Create();
            
            // Assert
            Assert.AreEqual(vehicle.Id, id);
            Assert.AreEqual(vehicle.Brand, brand);
            Assert.AreEqual(vehicle.Color, color);
            Assert.AreEqual(vehicle.Model, model);
            Assert.AreEqual(vehicle.Plate, plate);
            Assert.AreEqual(vehicle.Year, year);
        }
    }
}
