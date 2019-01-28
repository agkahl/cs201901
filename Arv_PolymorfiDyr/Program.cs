using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv_PolymorfiDyr
{
    class Program
    {
        static void Main(string[] args)
        {
            Hund h = new Hund(){Navn = "Rosa"};
            h.SigNoget();

            Kat k = new Kat() { Navn = "Atlas" };
            k.SigNoget();
            k.Navn = "Kahleesi";
            k.SigNoget();

            Fugl f = new Fugl() { Navn = "Hans" };
            f.SigNoget();


            List<Dyr> art = new List<Dyr>();
            

            // Hold console åben ved debug
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
    abstract class Dyr
    {
        public string Navn { get; set; }

        public virtual void SigNoget()
        {
            Console.WriteLine("Jeg er et dyr og hedder + Navn");
        }
    }

    class Hund : Dyr
    {
        public override void SigNoget()
        {
            Console.WriteLine("Jeg er en hund og hedder " + Navn + ",jeg siger vov");
        }
    }

    class Kat : Dyr
    {
        public override void SigNoget()
        {
            Console.WriteLine("Jeg er en kat og hedder " + Navn + " ,jeg siger miav." );
        }
    }
    class Fugl : Dyr
    {
        public override void SigNoget()
        {
            Console.WriteLine("Jeg er en fugl og hedder Hans" + " ,jeg siger pip.");
        }
    }

    //List<Dyr> art ();
}
