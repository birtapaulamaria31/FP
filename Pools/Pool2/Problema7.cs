using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool2
{
    class Problema7
    {
        public static void AfiseazaMesaj()
        {
            Console.Clear();
            Console.WriteLine("Problema 7.");
            Console.WriteLine("Se da o secventa de n numere. Sa se determine cea mai mare si cea mai mica valoare din secventa.");

        }

        public static void Rezolvare()
        {
            int n, x, min,max;
            AfiseazaMesaj();
            n = Helper.ReadPositiveInt("n");
            Console.WriteLine();
            x = Helper.ReadInt("x");
            min = max = x;
            for (int i = 1; i < n; i++)
            {
                x = Helper.ReadInt("x");
                if (x > max)
                    max = x;
                if (x < min)
                    min = x;

            }

            Console.WriteLine($"Minimul din secventa este {min} iar maximul este {max}.");


        }
    }
}
