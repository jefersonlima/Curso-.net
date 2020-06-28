﻿using System;
using System.Globalization;

namespace CourseFuncionarioOO
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto = ((SalarioBruto / 100) * porcentagem) + SalarioBruto;
        }

        public override string ToString()
        {
            return Nome
                + ", R$: "
                + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
