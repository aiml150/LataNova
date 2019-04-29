﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models
{
    public class Owner
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string CPF { get; set; }
        public DateTime BirthDate { get; set; }
        public char Gender { get; set; }
    }
}