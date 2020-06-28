using System;
using System.Collections.Generic;
using System.Text;

namespace CourseConversorDeMoedaOO
{
    class ConversorDeMoeda
    {
        public static double IOF = 6;
        public static double CotacaoDolar;
        public static double QuantidadeDolarComprar;

        public static double ValorPagoEmReais()
        {
            return (((CotacaoDolar * QuantidadeDolarComprar) / 100) * IOF) + (CotacaoDolar * QuantidadeDolarComprar);
        }
    }
}
