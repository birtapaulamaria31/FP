using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool1
{
    class Problema19
    {
        public static void AfiseazaMesaj()
        {
            Console.WriteLine("Problema 19.");
            Console.WriteLine("Determinati daca un numar e format doar cu 2 cifre care se pot repeta. De ex. 23222 sau 9009000 sunt astfel de numere, pe cand 593 si 4022 nu sunt.");

        }

        public static void Rezolvare()
        {
            Console.Clear();

            AfiseazaMesaj();
            int n = Helper.ReadPositiveInt("n");
            int nr = 0;
            int[] v=new int [10];
            if(Helper.ok!=0)
            {
                while (n != 0)
                {
                    v[n % 10]++;
                    n /= 10;
                }
                for (int i = 0; i < 10; i++)
                {
                    if (v[i] != 0)
                        nr++;
                }

                if (nr == 2)
                    Console.WriteLine("DA.");
                else
                    Console.WriteLine("NU.");
            }
            



        }
    }
}
