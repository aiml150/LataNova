using Application.Factories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Factories
{
    public class AllMightyFactory
    {
        public dynamic Create(string factoryType)
        {
            switch(factoryType)
            {
                case "owner":
                    return new OwnerFactory();
                case "vehicle":
                    return new VehicleFactory();
                default:
                    return null;
            }
        }
    }
}
