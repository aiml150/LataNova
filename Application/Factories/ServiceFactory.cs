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

        public Service Create(string description, string name, float value)
        {
            return new Service
            {
                Id = new Guid(),
                Description = description,
                Name = name,
                Value = value
            };
        }
    }
}
