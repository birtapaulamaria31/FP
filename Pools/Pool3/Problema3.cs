using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool3
{
    class Problema3
    {
        public static void AfiseazaMesaj()
        {
            Console.Clear();
            Console.WriteLine("Problema 3.");
            Console.WriteLine("Sa se determine pozitiile dintr-un vector pe care apar cel mai mic si cel mai mare element al vectorului. Pentru extra-credit realizati programul efectuand 3n/2 comparatii (in cel mai rau caz).");
        }


        public static void Rezolvare()
        {
            AfiseazaMesaj();

            int n, s = 0, min = 10000000, max = -10000000,pozMin=0,pozMax=0;
            n = Helper.ReadPositiveInt("n");
            Console.WriteLine($"Introduceti {n} numere separate prin cate un enter. ");

            int[] v = new int[n];

            v = Helper.ReadIntArray(n);
            for (int i = 0; i < n; i++)
            {
                if(v[i]<min)
                {
                    min = v[i];
                    pozMin = i;
                }
                if (v[i] > max)
                {
                    max = v[i];
                    pozMax = i;
                }
            }
            Console.WriteLine($"Pozitia pe care se afla minimul este {pozMin}, iar cea pe care se afla maximul este {pozMax}.");

        }
    }
}
