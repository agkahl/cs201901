﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv_Simpel
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person() { Efternavn = "x", Fornavn = "y" };
            Elev e = new Elev() { Efternavn = "t", Fornavn = "g", KlasseLokale = "A" };
            Instruktør i = new Instruktør() { Efternavn = "2", Fornavn = "s", NøgleId = 1 };
            Console.WriteLine(p.FuldtNavn());
            Console.WriteLine(e.FuldtNavn() + " "+ e.KlasseLokale);
            Console.WriteLine(i.FuldtNavn() + " "+ i.NøgleId);

            // Hold console åben ved debug
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }

    public class Person
    {
        public string Fornavn { get; set; }
        public string Efternavn { get; set; }
        public string FuldtNavn()
        {
            return $"{Fornavn} {Efternavn}";
        }
    }

    public class Elev : Person
    {
        public string KlasseLokale { get; set; }
    }

    public class Instruktør : Person
    {
        public int NøgleId { get; set; }
    }
}
