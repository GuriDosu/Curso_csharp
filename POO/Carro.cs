using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Carro
    {
        public string Cor { get; set; }
        public string Modelo { get; set; }
        public Double velocidade { get; set; }

        public void Acelerar()
        {
            velocidade += 10;
            Console.WriteLine($"{Modelo} estava correnco a {velocidade} km/h");

        }
    }
}
//Carro carro = new Carro()
//{
//Cor = "Vermelho",
//Modelo = "Fusca",
//velocidade = 100
//};
// carro.Acelerar();
