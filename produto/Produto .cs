using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace produto
{
    public class Produto
    {
#pragma warning disable CS8618
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public override string ToString()
        {
            return Nome
            + ", $"
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $"
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

#pragma warning restore CS8618
    }
}