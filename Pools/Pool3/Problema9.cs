using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool3
{
    class Problema9
    {
        public static void AfiseazaMesaj()
        {
            Console.Clear();
            Console.WriteLine("Problema 9.");
            Console.WriteLine("Rotire k. Se da un vector cu n elemente. Rotiti elementele vectorului cu k pozitii spre stanga.");
        }

        public static void Rotire(int n, ref int[] v)
        {
            int aux;
            aux = v[0];
            for (int i = 0; i < n - 1; i++)
            {
                v[i] = v[i + 1];

            }
            v[n - 1] = aux;
        }

        public static void Rezolvare()
        {
            AfiseazaMesaj();
            
            int n, nr=0,k;
            n = Helper.ReadPositiveInt("n");
            int[] v = new int[n];
            int[] v2 = new int[n];
            Console.WriteLine($"Introduceti {n} numere separate prin cate un enter. ");

            
            v = Helper.ReadIntArray(n);
            k = Helper.ReadInt("k");
            while(nr!=k)
            {
                Rotire(n, ref v);
                nr++;
            }
            
            for (int i = 0; i < n; i++)
                Console.Write($"{v[i]} ");
        }
    }
}
