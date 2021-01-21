using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool3
{
    class Problema14
    {
        public static void AfiseazaMesaj()
        {
            Console.Clear();
            Console.WriteLine("Problema 14.");
            Console.WriteLine("Interschimbati elementele unui vector in asa fel incat la final toate valorile egale cu zero sa ajunga la sfarsit. (nu se vor folosi vectori suplimentari - operatia se va realiza inplace cu un algoritm eficient - se va face o singura parcugere a vectorului).");
        }

      

        public static void Rezolvare()
        {
            AfiseazaMesaj();

            int n,nrZero=0;
            n = Helper.ReadPositiveInt("n");
            Console.WriteLine($"Introduceti {n} numere separate prin cate un enter. ");

            int[] v = new int[n];
            v = Helper.ReadIntArray(n);

            int urmZero = n - 1;
            while (v[urmZero] == 0) urmZero--;
            int i;
            for (i = 0; i <= urmZero; i++)
            {
                if (v[i] == 0)
                {
                    v[i] = v[urmZero];
                    v[urmZero] = 0;
                    urmZero--;
                }
            }

            for ( i = 0; i < n; i++)
                Console.Write($"{v[i]} ");
        }
    }
}
