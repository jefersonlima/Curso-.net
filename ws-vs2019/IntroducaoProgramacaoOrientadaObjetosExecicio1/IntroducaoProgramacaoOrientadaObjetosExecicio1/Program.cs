using System;

namespace IntroducaoProgramacaoOrientadaObjetosExecicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa primeiraPessoa, segundaPessoa;

            primeiraPessoa = new Pessoa();

            segundaPessoa = new Pessoa();

            Console.WriteLine("Informe os dados da primeira pessoa.");

            primeiraPessoa.nome = Console.ReadLine();
            primeiraPessoa.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe os dados da segunda pessoa.");

            segundaPessoa.nome = Console.ReadLine();
            segundaPessoa.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da primeira pessoa:");
            Console.WriteLine("Nome: " + primeiraPessoa.nome);
            Console.WriteLine("Idade: " + primeiraPessoa.idade);

            Console.WriteLine("Dados da segunda pessoa:");
            Console.WriteLine("Nome: " + segundaPessoa.nome);
            Console.WriteLine("Idade: " + segundaPessoa.idade);

            if (primeiraPessoa.idade > segundaPessoa.idade)
            {
                Console.WriteLine("Pessoa mais Velha é: " + primeiraPessoa.nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais Velha é: " + segundaPessoa.nome);
            }




        }
    }
}
