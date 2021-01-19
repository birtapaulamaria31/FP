using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool2
{
    class Problema5
    {
        public static void AfiseazaMesaj()
        {
            Console.Clear();
            Console.WriteLine("Problema 5.");
            Console.WriteLine("Cate elemente dintr-o secventa de n numere sunt egale cu pozitia pe care apar in secventa. Se considera ca primul element din secventa este pe pozitia 0.");

        }

        public static void Rezolvare()
        {
            int n, x, nr=0;
            AfiseazaMesaj();
            n = Helper.ReadPositiveInt("n");
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                x = Helper.ReadInt("x");
                if (x == i)
                    nr++;

            }
   
                Console.WriteLine($"Numarul de elemente egale cu pozitia pe care se afla este {nr}.");
        

        }
    }
}
