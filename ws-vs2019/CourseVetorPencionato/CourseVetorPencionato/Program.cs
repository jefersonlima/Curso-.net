using System;

namespace CourseVetorPencionato
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a Quantidade de Quartos!: ");
            int QuantidadeQuartos = int.Parse(Console.ReadLine());

            Quartos[] quartos = new Quartos[QuantidadeQuartos];

            Boolean AlugaQuarto = true;
            while(AlugaQuarto == true) {
                Console.Write("Informe o Nome do Estudante: ");
                String NomeEstudante = Console.ReadLine();
                Console.Write("Informe o Email do Estudante: ");
                String EmailEstudante = Console.ReadLine();
                Console.Write("Informe o numero do Quarto: ");
                int NumeroQuarto = int.Parse(Console.ReadLine());

                quartos[NumeroQuarto] = new Quartos { Nome = NomeEstudante, Email = EmailEstudante };
               
                Console.WriteLine();
                Console.Write("deseja alugar um novo quarto? (S/N)");
                Char alugaOutro = char.Parse(Console.ReadLine());
                if (alugaOutro != 'S' && alugaOutro != 's')
                {
                    AlugaQuarto = false;
                }               
            }
            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < QuantidadeQuartos; i++)
            {
                if (quartos[i] != null)
                {    
                    Console.WriteLine(i + ": " + quartos[i].Nome + ", " + quartos[i].Email);
                }
            }
        }

        public static void AlugaQuartos()
        {

        }
    }
}
