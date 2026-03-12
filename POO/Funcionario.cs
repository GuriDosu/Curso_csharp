using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Funcionario : Pessoa
    {
        public string Cargo { get; set; }
        public Double Salario { get; set; }
        public void Trabalho()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e eu sou um {Cargo} e estou trabalhando, e ganho:R${Salario}");
        }
    }
}
