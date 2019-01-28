using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv_Terning
{
    class Program
    {
        static void Main(string[] args)
        {
            Terning t = new Terning();
            t.Skriv();
            t.Ryst();
            t.Skriv();

            LudoTerning l = new LudoTerning();
            l.Skriv();
            Console.WriteLine(l.ErGlobus());
            Console.WriteLine(l.ErStjerne());

            // Hold console åben ved debug
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
    public class Terning
    {
        private static System.Random rnd;
        private int værdi;
        public int Værdi
        {
            get
            {
                //Console.WriteLine("Terning aflæses som " + this.værdi);
                return this.værdi;
            }
            set
            {
                if (value < 0 || value > 6)
                    value = 1;
                //Console.WriteLine("Terning tildeles " + value);
                this.værdi = value;
            }
        }

        public virtual void Skriv()
        {
            Console.WriteLine("[" + this.Værdi + "]");
        }

        public void Ryst()
        {
            this.Værdi = rnd.Next(1, 7);
        }

        public Terning()
        {
            this.Ryst();
        }

        public Terning(int værdi)
        {
            this.Værdi = værdi;
        }
        static Terning()
        {
            rnd = new Random();
        }
    }

    public class LudoTerning : Terning
    {
        public bool ErGlobus()
        {
            return this.Værdi == 3;
        }

        public bool ErStjerne()
        {
            return this.Værdi == 5;
        }

        public LudoTerning() : base()
        { }

        public LudoTerning(int værdi) : base(værdi)
        { }

/*
        public override void Skriv()
        {
            if (this.Værdi == 3)
            {
                Console.WriteLine("[" + "G" + "]");
            }
            else
            if (this.Værdi == 5)
            {
                Console.WriteLine("[" + "S" + "]");
            }
            else
                base.Skriv();
            //      Console.WriteLine("[" + this.Værdi + "]");
        }
 */
   
        public override void Skriv()
        {
            switch (this.Værdi)
            {
                case 3:
                    Console.WriteLine("[G]");
                    break;
                case 5:
                    Console.WriteLine("[S]");
                    break;
                default:
                    base.Skriv();
                    break;
            }
        }
    }
}