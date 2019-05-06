using Application.Factories.Interfaces;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Factories
{
    public class VehicleFactory : IFactory<Vehicle>
    {
        public Vehicle Create()
        {
            var vehicle = new Vehicle();
            vehicle.Brand = "Marca";
            vehicle.Color = "Cor";
            vehicle.Model = "Modelo";
            vehicle.Plate = "PLACA";
            vehicle.Year = 1234;
            //vehicle.Id = 
            //vehicle.Owner = 
            //    vehicle.OwnerId =


            return vehicle;
        }

        public Vehicle Create(string brand, string color, string model, string plate, int year, Guid ownerId)
        {
            var vehicle = new Vehicle();
            vehicle.Model = model;
            vehicle.Color = color;
            vehicle.Plate = plate;
            vehicle.Year = year;
            vehicle.OwnerId = ownerId;

            return vehicle;
        }

        public Vehicle Update(Vehicle vehicle, string brand, string color, string model, string plate, int year, Guid ownerId)
        {
            vehicle.Brand = brand;
            vehicle.Color = color;
            vehicle.Model = model;
            vehicle.Plate = plate;
            vehicle.Year = year;
            vehicle.OwnerId = ownerId;
            return vehicle;
        }
    }
}
