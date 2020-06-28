using System;

namespace CourseMatrizExercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("informe a quantidade de linhas ");
            int lines = int.Parse(Console.ReadLine());
            Console.Write("informe a quantidade de Colunas ");
            int coluns = int.Parse(Console.ReadLine());

            int[,] matriz = new int[lines, coluns];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                String[] spritLines = Console.ReadLine().Split();
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = int.Parse(spritLines[j]);
                }
            }

            Console.Write("informe o valor a ser encontrado na Matriz: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < matriz.GetLength(0); i++)
            {
                for(int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (matriz[i, j] == n)
                    {
                        Console.WriteLine("Position " + i + "," + j + ":");
                        //Left
                        if ((j - 1) >= 0)
                        {
                            Console.WriteLine("Left: " + matriz[i, (j - 1)]);
                        }
                        //Right
                        if ((j + 1) < matriz.GetLength(0))
                        {
                            Console.WriteLine("Right: " + matriz[i, (j + 1)]);
                        }
                        //Up
                        if ((i - 1) >= 0)
                        {
                            Console.WriteLine("Up: " + matriz[(i - 1), j]);
                        }
                        //Down
                        if ((i + 1) < matriz.GetLength(0))
                        {
                            Console.WriteLine("Down: " + matriz[(i + 1), j]);
                        }

                    }
                }
            }
        }
    }
}
