using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool1
{
    class Problema6
    {
        public static void AfiseazaMesaj()
        {
            Console.WriteLine("Problema 6.");
            Console.WriteLine("Determinati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi. ");

        }

        public static void Rezolvare()
        {
            Console.Clear();

            AfiseazaMesaj();
            int a = Helper.ReadPositiveInt("a");
            int b = Helper.ReadPositiveInt("b");
            int c = Helper.ReadPositiveInt("c");

            if (a + b > c && a + c > b && b + c > a)
                Console.WriteLine($"Numerele {a},{b} si {c} pot fi laturile unui triunghi.");
            else
                Console.WriteLine($"Numerele {a},{b} si {c} NU pot fi laturile unui triunghi.");


        }
    }
}
