using System;
using System.Globalization;

namespace CourseAlunoOO
{
    class Aluno
    {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public void VerificaAprovacao()
        {
            Console.WriteLine("NOTA FINAL = " + (Nota1 + Nota2 + Nota3).ToString("F2", CultureInfo.InvariantCulture));

            if ((Nota1 + Nota2 + Nota3) > 60)
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " + (60 - (Nota1 + Nota2 + Nota3)).ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");
            }
        }
    }
}
