using Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Adapters
{
    public class VehicleHistoryAdapter
    {
        public Vehicle vehicle;
        public List<Service> services = new List<Service>();
    }
}
