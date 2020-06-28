using System;
using System.Globalization;


namespace IntroducaoProgramacaoOrientadaObjetosExecicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario primeiroFuncionario, segundoFuncionario;//cria 2 objetos do tipo Funcionarios

            primeiroFuncionario = new Funcionario();//instancia o Objeto
            segundoFuncionario = new Funcionario();//instancia o Objeto

            Console.WriteLine("Informe os dados do primeiro Funcionário:");

            primeiroFuncionario.nome = Console.ReadLine();
            primeiroFuncionario.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("Informe os dados do segundo Funcionário:");

            segundoFuncionario.nome = Console.ReadLine();
            segundoFuncionario.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do primeiro Funcionario:");
            Console.WriteLine("Nome: " + primeiroFuncionario.nome);
            Console.WriteLine("Sálario: " + primeiroFuncionario.salario.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Dados do segundo Funcionario:");
            Console.WriteLine("Nome: " + segundoFuncionario.nome);
            Console.WriteLine("Sálario: " + segundoFuncionario.salario.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Salario médio: " + ((primeiroFuncionario.salario + segundoFuncionario.salario) / 2).ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
