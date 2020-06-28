using System;

namespace CourseAlunoOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            Console.WriteLine("INFORME OS DADOS DO ALUNO:");
            Console.Write("NOME: ");
            aluno.Nome = Console.ReadLine();
            Console.Write("Primeira Nota: ");
            aluno.Nota1 = double.Parse(Console.ReadLine());
            Console.Write("Segunda Nota: ");
            aluno.Nota2 = double.Parse(Console.ReadLine());
            Console.Write("Terceira Nota: ");
            aluno.Nota3 = double.Parse(Console.ReadLine());

            aluno.VerificaAprovacao();


        }
    }
}
