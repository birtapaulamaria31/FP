using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool3
{
    class Problema4
    {
        public static void AfiseazaMesaj()
        {
            Console.Clear();
            Console.WriteLine("Problema 4.");
            Console.WriteLine("Deteminati printr-o singura parcurgere, cea mai mica si cea mai mare valoare dintr-un vector si de cate ori apar acestea.");
        }


        public static void Rezolvare()
        {
            AfiseazaMesaj();

            int n, s = 0, min = 10000000, max = -10000000, nrMin = 0, nrMax = 0;
            n = Helper.ReadPositiveInt("n");
            Console.WriteLine($"Introduceti {n} numere separate prin cate un enter. ");

            int[] v = new int[n];

            v = Helper.ReadIntArray(n);
            for (int i = 0; i < n; i++)
            {
                if (v[i] < min)
                {
                    min = v[i];
                    nrMin = 1;
                }
                else if (v[i] == min)
                {
                   
                    nrMin ++;
                }
                if (v[i] > max)
                {
                    max = v[i];
                    nrMax = 1;
                }
                else if(v[i]==max)
                {
                    nrMax++;
                }
            }
            Console.WriteLine($"Minimul este {min} si apare de {nrMin} ori, iar maximul este {max} si apare de {nrMax} ori.");

        }
    }
}
