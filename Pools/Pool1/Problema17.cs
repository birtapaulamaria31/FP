using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool1
{
    class Problema17
    {
      
        public static void AfiseazaMesaj()
        {
            Console.WriteLine("Problema 17.");
            Console.WriteLine("Determianti cel mai mare divizor comun si cel mai mic multiplu comun a doua numere. Folositi algoritmul lui Euclid. ");

        }

        public static int Cmmdc(int a, int b)
        {
            int r = 0;
            while(b!=0)
            {
                r = a % b;
                a = b;
                b = r;
            }
            return a;
        }

        public static void Rezolvare()
        {
            Console.Clear();

            AfiseazaMesaj();
            int a = Helper.ReadPositiveInt("a");
            int b = Helper.ReadPositiveInt("b");
            int cmmdc = 1;
            cmmdc = Cmmdc(a, b);
           
            Console.Write($"Cmmdc pentru numerele {a} si {b} este {cmmdc} si cmmmc este {(a*b)/cmmdc} . ");


        }
    }
}
