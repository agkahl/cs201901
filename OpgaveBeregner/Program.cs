using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveBeregner
{
    class Program
    {
        static void Main(string[] args)
        {

            string tal1;
            string tal2;
            double t1;
            double t2;
            double sum;

            Console.WriteLine("Indtast tal1:");
            tal1 = Console.ReadLine();

            Console.WriteLine("Indtast tal2:");
            tal2 = Console.ReadLine();

            t1 = System.Convert.ToDouble(tal1);
            t2 = System.Convert.ToDouble(tal2);

            sum = t1 + t2;

            Console.WriteLine("Sum: ");
            Console.WriteLine(sum.ToString("N2"));


            Console.WriteLine("Indtast tal3:");
            string tal3 = Console.ReadLine();

            double t3 = System.Convert.ToDouble(tal3);

            Console.WriteLine("tal3: ");
            //Console.WriteLine(tal3.ToString("N2"));





            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
