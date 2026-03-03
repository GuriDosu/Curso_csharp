namespace EstruturaDe_Repeticao
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /// Console.WriteLine("Digitite o Status do Aluno:");
            ///  Console.WriteLine("1 - Aprovado");
            ///Console.WriteLine("2 - Recuperação");
            /// Console.WriteLine("3 - Reprovado");

            ///int status = Convert.ToInt32(Console.ReadLine());

            ///switch (status)

            ///case 1:
            /// Console.WriteLine("Aluno Aprovado");
            /// break;
            /// case 2:
            ///Console.WriteLine("Aluno Recuperação");
            /// break;
            ///case 3:
            ///  Console.WriteLine("Aluno Reprovado");
            ///break;

            ///for (int i = 1; i <= 5; i++)
            ///{
                ///Console.WriteLine($"Repetição número: {i}");
            ///}

            Console.WriteLine($"Sistema de Vendas");

            double total = 0;

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"Digite o valor {i}:");

                Console.WriteLine($"Nome do produto: ");
                string nomeProduto = Console.ReadLine();

                Console.WriteLine($"Quantidade: ");
                int quantidade = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Preço do Produto: ");
                double preco = Convert.ToDouble(Console.ReadLine());

                double subTotal = quantidade * preco;
                total = total + subTotal;

                Console.WriteLine($"Valor da compra: R${subTotal}");
            }

            if (total >= 200)
            {
                double desconto = total * 0.10;
                total = total - desconto;
                Console.WriteLine($"Valor total com desconto: R${total}");

            }

            Console.WriteLine($"formas de pagamento:");
            Console.WriteLine($"1 - Dinheiro");
            Console.WriteLine($"2 - Cartão de Crédito");
            Console.WriteLine($"3 - Pix");

            int opcaoDepagamento = Convert.ToInt32(Console.ReadLine());

            switch (opcaoDepagamento)
            {
                case 1:
                    Console.WriteLine($"Pagamento em dinheiro selecionado: R${total}");
                    break;

                case 2:
                    Console.WriteLine($"Pagamento no cartâo: R${total}");
                    break;

                case 3:
                    Console.WriteLine($"Pagamento via Pix: R${total}");
                    break;
            }

        }

    }
}
