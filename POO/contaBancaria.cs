using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class contaBancaria
    {
        private int Saldo { get; set; }

        public void Depositar(double valor)
        {
            if (valor < 0)
            {
                Console.WriteLine("Valor inválido para depósito.");

            }
            else
            {
                Saldo += (int)valor;
            }

        }
        public void SaldoAtual()
        {
            Console.WriteLine($"Saldo atual: {Saldo}");
        }
    }
}
