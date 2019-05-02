using Application.Factories.Interfaces;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Factories
{
    public class OwnerFactory : IFactory<Owner>
    {
        public Owner Create()
        {
            var owner = new Owner();
            owner.CPF = "123456789";
            owner.Name = "Nome";
            owner.Gender = 'M';
            owner.BirthDate = DateTime.Now;

            return owner;
        }

        public Owner Create(string name, string cpf, char gender, DateTime birthdate)
        {
            var owner = new Owner();
            owner.CPF = cpf;
            owner.Name = name;
            owner.Gender = gender;
            owner.BirthDate = birthdate;

            return owner;
        }
    }
}
