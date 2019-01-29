using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Action
{
    //public delegate void MinDelegate1(string t);

    class Program
    {
        static void Main(string[] args)
        {
            Action<string> f1 = MinSkrivTilConsole;
            f1.Invoke("test nr 1");

            Action<string> f2 = MinSkrivTilConsole;
            f2("test nr 2");

            Action<string> f3 = MinSkrivTilConsole;
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
