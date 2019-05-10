using Application.Factories;
using Core.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LataNova.IntegrationTests.Helpers
{
    public static class ServiceOrderHelper
    {
        public static ServiceOrder CreateRandomServiceOrder()
        {
            var vehicleId = new Guid("A4728FA1-C89B-474C-A945-01383D171CAB");
            var serviceId = new Guid("F6187F67-A4A1-408E-B6D8-08D6D542737E");
            var qnt = new Random().Next();
            return Factories.ServiceOrder.Create(serviceId, vehicleId, qnt);
        }

        public static void AssertService(ServiceOrder a, ServiceOrder b)
        {
            Assert.AreEqual(a.Id, b.Id);
            Assert.AreEqual(a.ServiceId, b.ServiceId);
            Assert.AreEqual(a.VehicleId, b.VehicleId);
            Assert.AreEqual(a.Quantity, b.Quantity);
        }
    }
}
