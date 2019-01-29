using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare
{
    class Program
    {
        static void Main(string[] args)
        {
            Hund[] hunde = new Hund[6];
            hunde[0] = new Hund() { Alder = 10, Navn = "Bulder" };
            hunde[1] = new Hund() { Alder = 5, Navn = "Lady" };
            hunde[2] = new Hund() { Alder = 1, Navn = "Rosa" };
            hunde[3] = new Hund() { Alder = 4, Navn = "Luna" };
            hunde[4] = new Hund() { Alder = 6, Navn = "Asta" };
            hunde[5] = new Hund() { Alder = 12, Navn = "Bine" };
            Array.Sort(hunde);
            foreach (var item in hunde)
            {
                Console.WriteLine(item.Navn);
            }

            // Hold console åben ved debug
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
    class Hund : IComparable<Hund>
    {
        public string Navn { get; set; }
        public int Alder { get; set; }

        public int CompareTo(Hund other)
        {
            if (other.Alder > this.Alder)
                return 1;
            if (other.Alder < this.Alder)
                return -1;
            return 0;
        }
    }
}
