using System;
using System.Collections.Generic;
using System.Text;

namespace Conversor_Dolar
    {
    class Conversor
        {

        

        public static double IOF = 6.0;      
        
        public static double Converter_Dolar(double cotacacao_dolar, double quant_dolar)
            {
            double ValorFinal = cotacacao_dolar * quant_dolar;        
            return ValorFinal + ValorFinal *IOF/100.0;
            }

        }
    }
