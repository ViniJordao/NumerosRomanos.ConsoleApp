using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosRomanos.ConsoleApp
{

    public class ConversorRomano
    {
        public string ConverterRomano(int numero)
        {
            int[] Valores = { 10000, 9000, 8000, 7000, 6000, 5000, 4000, 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string[] Romanos = { "X̄", "ĪX̄", "V̄ĪĪĪ", "V̄ĪĪ", "V̄Ī", "V̄", "ĪV̄", "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
           
            int numeroArabico = numero;
            string Resultado = "";
            int i = 0;
            while (numeroArabico > 0)
            {
                while (numeroArabico >= Valores[i]) {
                    Resultado = Resultado + Romanos[i];
                    numeroArabico = numeroArabico - Valores[i];
                }
                i++;
            }
            return Resultado;
        }
    }
}
