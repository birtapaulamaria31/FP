using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool2
{
    class Problema15
    {
        public static void AfiseazaMesaj()
        {
            Console.Clear();
            Console.WriteLine("Problema 15");
            Console.WriteLine("O secventa bitonica este o secventa de numere care incepe monoton crescator si continua monoton descrecator. De ex. 1,2,2,3,5,4,4,3 este o secventa bitonica. Se da o secventa de n numere. Sa se determine daca este bitonica.");
        }
        public static void Rezolvare()
        {
            int n, x, y, first, schimbatMono=0, last = 1000000;
            AfiseazaMesaj();
            n = Helper.ReadPositiveInt("n");
            Console.WriteLine();
            if (n > 0)
            {

                x = Helper.ReadInt("x");
                y = x;
                
                for (int i = 1; i < n; i++)
                {
                    x = Helper.ReadInt("x");
                    if (x < y)
                    {
                        schimbatMono++;
                    }
                    
                    y = x;

                }
                if (schimbatMono==1)
                    Console.WriteLine("Secventa de numere este bitonica");
                else
                    Console.WriteLine("Secventa de numere NU ESTE bitonica");

            }
            else Console.WriteLine("Secventa ta nu are niciun numar");

        }
    }
}
