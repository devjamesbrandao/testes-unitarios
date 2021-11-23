using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Customer : Entity
    {
        public Customer(string name, string email)
        {
            Name = name;
            Email = email;
        }
        public string Name { get; private set; }
        public string Email { get; private set; }
    }
}