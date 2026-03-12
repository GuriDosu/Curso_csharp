using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public void Falar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} esta falando.....");
        }
    }
}
