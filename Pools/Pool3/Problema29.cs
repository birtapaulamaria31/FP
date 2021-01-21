using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool3
{
    class Problema29
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
            MergeSort(v, 0, v.Length - 1);
            for (int i = 0; i < n; i++)
                Console.Write($"{v[i]} ");
        }

            public static void Interclasare(int[] arr, int low, int mid, int high)
        {
            int n = mid - low + 1;
            int m = high - mid;

            int[] L, R;

            L = new int[n];
            R = new int[m];

            int i, j, k;
            for (i = 0; i < n; i++)
            {
                L[i] = arr[low + i];
            }
            for (i = 0; i < m; i++)
            {
                R[i] = arr[mid + i + 1];
            }

            i = 0; j = 0; k = low;

            while (i < n && j < m)
            {
                if (L[i] < R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }

            while (i < n)
            {
                arr[k] = L[i];
                i++;
                k++;
            }

            while (j < m)
            {
                arr[k] = R[j];
                j++;
                k++;

            }

        }

        public static void MergeSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int m = (low + high) / 2;
                MergeSort(arr, low, m);
                MergeSort(arr, m + 1, high);
                Interclasare(arr, low, m, high);
            }
        }
    }
}
