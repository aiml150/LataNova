using Application.Factories;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LataNova.UnitTests
{
    public class ServiceTest
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test()
        {
            // Arrange
            // Act
            var service = Singleton.Service.Create();
            // Assert
        }
    }
}
