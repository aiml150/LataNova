using Application.Factories;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LataNova.UnitTests
{
    public class ServiceOrderTest
    {
        [SetUp]
        public void Setup() { }

        [Test]
        public void Test()
        {
            // Arrange
            // Act
            var serviceOrder = Factories.ServiceOrder.Create();
            // Assert
        }
    }
}
