using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicios
{
    public struct Pessoa
    {
        public int x;
        public int y;

        public override string ToString()
        {
            return "(" + x + ")" + "(" + y + ")";
        }
    }
}
