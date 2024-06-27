using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

#pragma warning disable CS8618

namespace cadastro
{
    public class Registro
    {
        private string _nome;
        private string _cpf;
        public DateTime Nascimento;
        public string Rua;
        public string Bairro;
        public string Cidade;

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 6)
                {
                    _nome = value;
                }
            }
        }
        public string Cpf
        {
            get { return _cpf; }
            set
            {
                if (value.Length == 11 && long.TryParse(value, out _))
                {
                    _cpf = value;
                }
                else
                {
                    throw new ArgumentException("O CPF deve conter 11 dígitos.");
                }
            }
        }

        public override string ToString()
        {
            return "Nome: "
                + _nome
                + " CPF: "
                + _cpf
                + " Nascimento: "
                + Nascimento.ToString("dd/MM/yyyy")
                + $" Endereço: {Rua}, {Bairro}, {Cidade}";
        }
    }
}

#pragma warning restore CS8618
