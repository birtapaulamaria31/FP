using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool1
{
    class Problema14
    {
        public static void AfiseazaMesaj()
        {
            Console.WriteLine("Problema 14.");
            Console.WriteLine("Determinati daca un numar n este palindrom. (un numar este palindrom daca citit invers obtinem un numar egal cu el, de ex. 121 sau 12321.  ");

        }

        public static void Rezolvare()
        {
            Console.Clear();

            AfiseazaMesaj();
            int n = Helper.ReadPositiveInt("n");
            if (n == Helper.Oglindit(n))
                Console.WriteLine($"Numarul {n} este palindrom.");
            else
                Console.WriteLine($"Numarul {n} nu este palindrom.");
            
           
        }
    }
}
