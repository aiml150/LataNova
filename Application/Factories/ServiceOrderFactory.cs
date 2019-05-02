using Application.Factories.Interfaces;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Factories
{
    public class ServiceOrderFactory : IFactory<ServiceOrder>
    {
        public ServiceOrder Create()
        {
            return new ServiceOrder();
        }
    }
}
