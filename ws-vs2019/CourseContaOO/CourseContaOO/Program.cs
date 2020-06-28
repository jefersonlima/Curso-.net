using System;
using System.Globalization;

namespace CourseContaOO
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria contaBancaria;

            Console.Write("Entre o Número da conta: ");
            int NumeroContaBancaria = int.Parse(Console.ReadLine());

            Console.Write("Entre o Titular da conta: ");
            string TitularContaBancaria = (Console.ReadLine());

            Console.Write("Haverá depósito inicial (s/n)?");
            char OpcaoDepositoInicial = char.Parse(Console.ReadLine());
            if (OpcaoDepositoInicial == 'n' || OpcaoDepositoInicial == 'N')
            {
                contaBancaria = new ContaBancaria(NumeroContaBancaria, TitularContaBancaria);
                           }
            else if(OpcaoDepositoInicial == 's' || OpcaoDepositoInicial == 'S')
            {
                Console.Write("Entre o Saldo da conta: ");
                double SaldoContaBancaria = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                contaBancaria = new ContaBancaria(NumeroContaBancaria, TitularContaBancaria, SaldoContaBancaria);
            }
            else
            {
                Console.WriteLine("Opção Inválida");
                contaBancaria = new ContaBancaria(0, "Conta não Criada ");
            }

            Console.WriteLine();
            Console.WriteLine("Dados da Conta: ");
            Console.WriteLine(contaBancaria);
            //parte 2

            Console.Write("Entre com um valor para depósito: ");
            double valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contaBancaria.Deposito(valorDeposito);

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(contaBancaria);

            Console.Write("Entre com um valor para Saque: ");
            double valorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contaBancaria.Saque(valorSaque);

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(contaBancaria);
        }
    }
}
