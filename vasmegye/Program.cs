using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace vasmegye
{
    class Program
    {

        static void Main(string[] args)
        {
            List<double> adat = new List<double>();
            Console.WriteLine("2.feladat: Adatok beolvasása, tárolása");
            Console.WriteLine("4.feladat: Ellenőrzés");
            Console.WriteLine($"5.feladat: Vas megyében a vizsgált évek alatt{adat.Count}csecsemő született.");
            Console.WriteLine("6.feladat: Fiúk száma:{}");
            Console.WriteLine("\nProgram vége.");
            Console.ReadKey();
        }
    }
}
