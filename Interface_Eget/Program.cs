using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Eget
{
    class Program
    {
        static void Main(string[] args)
        {
            //Anvendelse af array
            IDbFunktioner[] array = new IDbFunktioner[4];
            array[0] = new Hund();
            array[1] = new Ubåd();
            array[2] = new Hund();
            array[3] = new Ubåd();

            foreach (var item in array)
            {
                item.Gem();
            }

            //Anvendelse af list
            List<IDbFunktioner> lst1 = new List<IDbFunktioner>();
            lst1.Add(new Hund());
            lst1.Add(new Ubåd());
            lst1.Add(new Hund());
            lst1.Add(new Ubåd());

            foreach (var item in lst1)
            {
                item.Gem();
            }

            // Hold console åben ved debug
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
    
    interface IDbFunktioner
    {
        void Gem();
    }

    class Hund : IDbFunktioner
    {
        public string Navn { get; set; }
        void IDbFunktioner.Gem()
        {
            Console.WriteLine("Gemmer hund...");
        }
    }

    class Ubåd : IDbFunktioner
    {
        public int Nummer { get; set; }
        public double Tubine { get; set; }
        public void Gem()
        {
            Console.WriteLine("Gemmer ubåd...");
        }
    }
}
