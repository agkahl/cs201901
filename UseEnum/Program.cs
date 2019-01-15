using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            // Til alle der læser koden...
            // Kulør 0 = Spar
            // Kulør 1 = Hjerter
            // Kulør 2 = Ruder
            // Kulør 3 = Klør

            int kort1Værdi = 2;
            int kort1Kulør = 1;

            int kort2Værdi = 2;
            int kort2Kulør = 2;

            enum KortKulør
            {
                Hjerter = 10, 
                Spar    = 20,
                Ruder   = 30,
                Klør    = 40
            }

        int kort1Værdi = 2;

        KortKulør kort1Kulør = KortKulør.Hjerter;



        // Skriver værdi og nummer ud

        Console.WriteLine(kortKulør.ToString());

            Console.WriteLine((int) kortKulør);



            int kort2Værdi = 2;

        KortKulør kort2Kulør = KortKulør.Ruder;





            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
