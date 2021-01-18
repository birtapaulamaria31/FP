using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool1
{
    class Problema3
    {
        public static void AfiseazaMesaj()
        {
            Console.WriteLine("Problema 3.");
            Console.WriteLine("Determinati daca n se divide cu k, unde n si k sunt date de intrare.  ");

        }

        public static void Rezolvare()
        {
            Console.Clear();

            AfiseazaMesaj();
            int n = Helper.ReadInt("n");
            int k = Helper.ReadInt("k");
            if (n % k == 0)
                Console.WriteLine($"Numarul {n} se divide cu {k}.");
            else
                Console.WriteLine($"Numarul {n} NU se divide cu {k}.");
           

        }
    }
}
