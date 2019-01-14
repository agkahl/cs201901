using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave_variablertal
{
    class Program
    {
        static void Main(string[] args)
        {
            //Heltal skrevet linie for linie
            int qty = 10;
            Console.WriteLine(qty);

            qty++;
            Console.WriteLine(qty);

            qty--;
            Console.WriteLine(qty);

            qty += 20;
            Console.WriteLine(qty);

            //Kommatal
            double weight = 12.5;
            Console.WriteLine(weight);

            weight++;
            Console.WriteLine(weight);

            weight--;
            Console.WriteLine(weight);

            weight *= 2;
            Console.WriteLine(weight);
            

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
