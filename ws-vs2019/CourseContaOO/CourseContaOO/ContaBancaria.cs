using System.Globalization;

namespace CourseContaOO
{
    class ContaBancaria
    {
        //Encapsulamento public, private, protect
        public int NumeroContaBancaria { get; private set; }
        public string NomeTitularContaBancaria { get; set; }

        public double SaldoContaBancaria { get; private set; }

        private double TarifaSaque = 5;

        //Sobre Carga
        public ContaBancaria(int numeroContaBancaria, string nomeTitularContaBancaria)
        {
            NumeroContaBancaria = numeroContaBancaria;
            NomeTitularContaBancaria = nomeTitularContaBancaria;
            SaldoContaBancaria = 0.00;
        }

        public ContaBancaria(int numeroContaBancaria, string nomeTitularContaBancaria, double depositoInicial) : this(numeroContaBancaria, nomeTitularContaBancaria)
        {
            Deposito(depositoInicial);
        }

        public void Deposito(double valor)
        {
            SaldoContaBancaria += valor;
            //SaldoContaBancaria = SaldoContaBancaria + valor;
        }

        public void Saque(double valor)
        {
            SaldoContaBancaria -= valor + TarifaSaque;
            //SaldoContaBancaria = (SaldoContaBancaria - valor) + TarifaSaque;
        }
    public override string ToString()
        {
            return "Conta: " + NumeroContaBancaria + " Titular: " + NomeTitularContaBancaria + " Saldo: R$" + SaldoContaBancaria.ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
