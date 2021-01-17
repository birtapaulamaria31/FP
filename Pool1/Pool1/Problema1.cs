using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool1
{
    class Problema1
    {
        public static void AfiseazaMesaj()
        {
            Console.WriteLine("Problema 1.");
            Console.WriteLine("Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax+b = 0, unde a si b sunt date de intrare. ");

        }

        public static void Rezolvare()
        {
            Console.Clear();

           AfiseazaMesaj();
           int a = Helper.ReadInt("a");
           int b = Helper.ReadInt("b");
           float x = (float)-b /(float) a;
            Console.WriteLine($"Rezultatul ecuatiei {a}x+{b}=0 este x={x}");
            
        }
    }
}


  


