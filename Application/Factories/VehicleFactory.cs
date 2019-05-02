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

        //public Vehicle Create(string name, string cpf, char gender, DateTime birthdate)
        //{
        //    var vehicle = new Vehicle();
        //    vehicle.CPF = cpf;
        //    vehicle.Name = name;
        //    vehicle.Gender = gender;
        //    vehicle.BirthDate = birthdate;

        //    return vehicle;
        //}
    }
}
