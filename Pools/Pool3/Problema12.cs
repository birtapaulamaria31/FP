using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool3
{
    class Problema12
    {
        public static void AfiseazaMesaj()
        {
            Console.Clear();
            Console.WriteLine("Problema 12.");
            Console.WriteLine("Sortare selectie. Implementati algoritmul de sortare <Selection Sort>.");
        }


        public static void Rezolvare()
        {
            AfiseazaMesaj();

            int n;
            n = Helper.ReadPositiveInt("n");
            Console.WriteLine($"Introduceti {n} numere separate prin cate un enter. ");

            int[] v = new int[n];
            v = Helper.ReadIntArray(n);
            
            int i, j, i_min;
            for (i = 0; i < v.Length - 1; i++)
            {
                i_min = i;
                for (j = i + 1; j < v.Length; j++)
                {
                    if (v[i_min] > v[j])
                    {
                        i_min = j;
                    }
                }
                int aux = v[i_min];
                v[i_min] = v[i];
                v[i] = aux;
            }

            for (i = 0; i < v.Length; i++)
            {
                Console.Write(v[i] + " ");
            }
        }
    }
}
