using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool3
{
    class Problema28
    {
        public static void AfiseazaMesaj()
        {
            Console.Clear();
            Console.WriteLine("Problema 28.");
            Console.WriteLine("Quicksort. Sortati un vector folosind metoda QuickSort.");
        }



        public static void Rezolvare()
        {
            AfiseazaMesaj();
            int n, nrZero = 0;
            n = Helper.ReadPositiveInt("n");
            Console.WriteLine($"Introduceti {n} numere separate prin cate un enter. ");

            int[] v = new int[n];
            v = Helper.ReadIntArray(n);
            QuickSort(v, 0, n - 1);
            for (int i = 0; i < n; i++)
                Console.Write($"{v[i]} ");
        }


            public static void Swap(ref int a, ref int b)
        {
            int aux = a;
            a = b;
            b = aux;
        }
        public static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = low - 1;
            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    Swap(ref arr[i], ref arr[j]);
                }
            }
            Swap(ref arr[i + 1], ref arr[high]);
            return (i + 1);
        }
        public static void QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(arr, low, high);

                QuickSort(arr, low, pi - 1);
                QuickSort(arr, pi + 1, high);
            }
        }
    }
}
