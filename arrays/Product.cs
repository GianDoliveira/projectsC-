using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace arrays
{
    public class Product
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public Product(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public override string ToString()
        {
            return Nome + ", " + Email;
        }
    }
}
