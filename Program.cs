using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosRomanos.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ConversorRomano conversor = new ConversorRomano();
            Console.WriteLine(conversor.ConverterRomano(4000));

            ConversorArabico conversorRomano = new ConversorArabico();
            Console.WriteLine(conversorRomano.ConverterArabico());

            Console.ReadLine();
        }
    }
}
