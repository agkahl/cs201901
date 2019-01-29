using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Grunlæggende
{
    public delegate void MinDelegate1(string t);
    
    class Program
    {
        static void Main(string[] args)
        {
            MinDelegate1 f1 = new MinDelegate1(MinSkrivTilConsole);
            f1.Invoke("test nr 1");

            MinDelegate1 f2 = MinSkrivTilConsole;
            f2("test nr 2");

            MinDelegate1 f3 = MinSkrivTilConsole;
            f3 += Console.WriteLine;
            f3("test nr 3");

            f1 -= MinSkrivTilConsole;
            f2 -= MinSkrivTilConsole;
            f3 -= MinSkrivTilConsole;
            f3 -= Console.WriteLine;

            // Hold console åben ved debug
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        static void MinSkrivTilConsole(string txt)
        {
            Console.WriteLine("**** " + txt + " ****");
        }
    }
   
}
