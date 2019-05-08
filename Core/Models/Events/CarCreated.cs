using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models.Events
{
    public class CarCreated
    {
        public CarCreated(Vehicle car)
        {
            Car = car;
        }

        public Vehicle Car { get; set; }
    }
}
