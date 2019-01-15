using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = System.DateTime.Now;
            Console.WriteLine(d1);

            d1 = d1.AddDays(10);
            Console.WriteLine(d1);

            d1 = d1.AddMinutes(20);
            Console.WriteLine(d1);

            d1 = d1.AddMonths(-1);
            Console.WriteLine(d1);

            DateTime d2 = new DateTime(1962, 05, 02);
            DateTime d3 = new DateTime(2019, 01, 14);

            TimeSpan t1 = d3.Subtract(d2);

            Console.WriteLine(t1);


            //double t4 = (System.Convert.ToDouble(t1) / 365);
            Console.WriteLine(t4);


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
