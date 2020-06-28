using System;
using System.Globalization;

namespace CourseProduto
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Entre os dados do Produto: ");
            Console.Write("Nome: ");
            String Nome = Console.ReadLine();
            Console.Write("Preço: ");
            double Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.Write("Quantidade no estoque: ");
            //int Quantidade = int.Parse(Console.ReadLine());

            //Produto p = new Produto(Nome, Preco);

            Produto p2 = new Produto();

            Produto p3 = new Produto
            {
                Nome = "TV",
                Preco = 500,
                Quantidade = 20
            };

            Console.WriteLine();
            Console.WriteLine("Dados do Produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qtd = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qtd);

            Console.WriteLine("Dados do Produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser Removido do estoque: ");
            qtd = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qtd);

            Console.WriteLine("Dados do Produto: " + p);

        }
    }
}
