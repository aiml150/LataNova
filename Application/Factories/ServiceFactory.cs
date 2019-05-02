using Application.Factories.Interfaces;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Factories
{
    public class ServiceFactory : IFactory<Service>
    {
        public Service Create()
        {
            return new Service();
        }
    }
}
