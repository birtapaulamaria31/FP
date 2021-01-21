using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool3
{
    class Problema13
    {
        public static void AfiseazaMesaj()
        {
            Console.Clear();
            Console.WriteLine("Problema 13.");
            Console.WriteLine("Sortare prin insertie. Implementati algoritmul de sortare <Insertion Sort>.");
        }


        public static void Rezolvare()
        {
            AfiseazaMesaj();

            int n;
            n = Helper.ReadPositiveInt("n");
            Console.WriteLine($"Introduceti {n} numere separate prin cate un enter. ");

            int[] arr = new int[n];
            arr = Helper.ReadIntArray(n);
            int i, j;
            for (i = 1; i < arr.Length; i++)
            {
                int key = arr[i];
                j = i - 1;
                while (j >= 0 && arr[j] >= key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
            for (i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
