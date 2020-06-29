using System;
using System.Globalization;

namespace Conversor_Dolar
    {
    class Program
        {
        static void Main(string[] args)
            {

            Conversor Conv = new Conversor();

            Console.Write("Qual é a cotação do dólar? ");
            double Cotacao_Dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            double Quantidade_Dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Valor a ser pago em reais = {Conversor.Converter_Dolar(Cotacao_Dolar, Quantidade_Dolar).ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
