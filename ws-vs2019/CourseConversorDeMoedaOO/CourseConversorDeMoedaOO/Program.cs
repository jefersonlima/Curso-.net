using System;
using System.Globalization;

namespace CourseConversorDeMoedaOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a cotação do Dolar? ");
            ConversorDeMoeda.CotacaoDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dolares voce vai comprar? ");
            ConversorDeMoeda.QuantidadeDolarComprar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Valor a ser pago em reais = " + ConversorDeMoeda.ValorPagoEmReais().ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
