using System.Reflection.PortableExecutable;

namespace POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            contaBancaria contaBancaria = new contaBancaria();
            contaBancaria.Depositar(-100);
            contaBancaria.SaldoAtual();
        }
    }
}
