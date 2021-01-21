using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool3
{
    class Problema15
    {
        public static void AfiseazaMesaj()
        {
            Console.Clear();
            Console.WriteLine("Problema 15.");
            Console.WriteLine("Modificati un vector prin eliminarea elementelor care se repeta, fara a folosi un alt vector.");
        }


        public static void Rezolvare()
        {
            AfiseazaMesaj();

            int n, j,repetat=0,eliminari=0,i,nouaMarime;
            n = Helper.ReadPositiveInt("n");
            Console.WriteLine($"Introduceti {n} numere separate prin cate un enter. ");

            int[] v = new int[n];
            v = Helper.ReadIntArray(n);

            for( i = 0; i < n ; i++)
            {
                for(j=i+1; j<n; j++)
                {
                    if (v[i] > v[j])
                        Helper.Swap(ref v[i], ref v[j]);
                }
            }

            int nextPos = 1;
            for (i = 1; i < n; i++)
            {
                while (v[i] == v[i - 1] && i < n)
                {
                    if (i + 1 == n) break;
                    i++;
                }
                v[nextPos] = v[i];
                nextPos++;
            }
            nouaMarime = nextPos - 1;

            for ( i = 0; i <= nouaMarime; i++)
                Console.Write($"{v[i]} ");
        }
    }
}
