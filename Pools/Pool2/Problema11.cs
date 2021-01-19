using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool2
{
    class Problema11
    {
        public static void AfiseazaMesaj()
        {
            Console.Clear();
            Console.WriteLine("Problema 11.");
            Console.WriteLine("Se da o secventa de n numere. Se cere sa se caculeze suma inverselor acestor numere.");

        }

        public static void Rezolvare()
        {
            int n, x, s = 0;
            AfiseazaMesaj();
            n = Helper.ReadPositiveInt("n");
            Console.WriteLine();

            for (int i = 1; i <=n; i++)
            {
                x = Helper.ReadPositiveInt($"x{i}");
                s = s + Helper.Oglindit(x);

            }

            Console.WriteLine($"Suma inverselor numerelor din secventa este {s}");


        }
    }
}
