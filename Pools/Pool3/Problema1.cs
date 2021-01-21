using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool3
{
 
    class Problema1
    {
        public static void AfiseazaMesaj()
        {
            Console.Clear();
            Console.WriteLine("Problema 1.");
            Console.WriteLine("Calculati suma elementelor unui vector de n numere citite de la tastatura. Rezultatul se va afisa pe ecran.");
        }


        public static void Rezolvare()
        {
            AfiseazaMesaj();

            int n, s = 0;
            n = Helper.ReadPositiveInt("n");
            Console.WriteLine($"Introduceti {n} numere separate prin cate un enter. ");
            
            int[] v = new int[n];
       
            v = Helper.ReadIntArray(n);
            for(int i=0; i<n; i++)
            {
                s += v[i];
            }
            Console.WriteLine($"Suma elementelor vectorului este {s}");
            
        }
    }
}
