using System;

namespace CourseMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int negativesNumber = 0;
            Console.Write("Informe o tamanho da Matriz: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, n];

            //le item por item
            //for(int i = 0; i < matriz.GetLength(0); i++)
            //{
            //    for(int j = 0; j < matriz.GetLength(1); j++)
            //    {
            //        matriz[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //le linha por linha
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                string[] values = Console.ReadLine().Split(' '); ;
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Main diagonal: ");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        Console.Write(matriz[i, j] + " ");
                    }
                    if (matriz[i, j] < 0)
                    {
                        negativesNumber++;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Negative numbers = " + negativesNumber);

        }
    }
}
