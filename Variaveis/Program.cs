namespace Variaveis
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            // Tipos Numericos.
            // int
            // float
            // double
            // decimal

            int idade = 25;
            float altura = 1.75f;
            double preco = 19.99;
            decimal salario = 1500;

            Console.WriteLine($"Tipo int: {idade}");
            Console.WriteLine($"tipo Float: {altura}");
            Console.WriteLine($"Tipo Double: {preco}");
            Console.WriteLine($"Tipo Decimal: {salario}");

            // Tipo Texto
            // char
            // string

            char letra = 'A';
            string formaçao = "Curso de C#";

            Console.WriteLine($"Tipo char: {letra}");
            Console.WriteLine($"Tipo string: {formaçao}");

            // Tipo Boolean
            // bool
            // false / true

            bool maiorDeIdade = true;

            Console.WriteLine($"Tipo boolean: {maiorDeIdade}");

            //Tipo Implicito
            // var

            var carro = "Fusca";

            //operadores aritmeticos

            int nota1 = 10;
            int nota2 = 5;

            Console.WriteLine(nota1 + nota2);
            Console.WriteLine(nota1 - nota2);
            Console.WriteLine(nota1 * nota2);
            Console.WriteLine(nota1 / nota2);


            string produto = "Livro";
            int quantidade = 3;
            double valor = 10.50;
            double total = quantidade * valor;

            Console.WriteLine($"o produto:{produto}");
            Console.WriteLine($"custa: R${total}");
        }
    }
}
