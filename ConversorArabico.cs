using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosRomanos.ConsoleApp
{
    public class ConversorArabico
    {
        public int ConverterArabico()
        {   
          string[] romano = { "ĪX̄" };

            Dictionary<string, int> numerosRomanos = new Dictionary<string, int>();
            numerosRomanos.Add("X̄", 10000);
            numerosRomanos.Add("ĪX̄", 9000);
            numerosRomanos.Add("V̄ĪĪĪ", 8000);
            numerosRomanos.Add("V̄ĪĪ", 7000);
            numerosRomanos.Add("V̄Ī", 6000);
            numerosRomanos.Add("V̄", 5000);

            numerosRomanos.Add("M", 1000);
            numerosRomanos.Add("C", 100);
            numerosRomanos.Add("L", 50);
            numerosRomanos.Add("X", 10);
            numerosRomanos.Add("V", 5);
            numerosRomanos.Add("I", 1);

            numerosRomanos.Add("m", 1000);
            numerosRomanos.Add("c", 100);
            numerosRomanos.Add("l", 50);
            numerosRomanos.Add("x", 10);
            numerosRomanos.Add("v", 5);
            numerosRomanos.Add("i", 1);

            int arabico = 0;

            for (int i = 0; i < romano.Count(); i++)
            {
                if (!numerosRomanos.ContainsKey(romano[i]))
                    return 0;

                if (i == romano.Count() - 1){
                    arabico += numerosRomanos[romano[i]];
                }
                else{
                    if (numerosRomanos[romano[i + 1]] > numerosRomanos[romano[i]]) arabico -= numerosRomanos[romano[i]];
                    else arabico += numerosRomanos[romano[i]];
                }
            }
            return arabico;
        }

    }
}
