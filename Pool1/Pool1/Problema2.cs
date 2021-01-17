using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool1
{
    class Problema2
    {
        public static void AfiseazaMesaj()
        {
            Console.WriteLine("Problema 2.");
            Console.WriteLine("Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0, unde a, b si c sunt date de intrare. Tratati toate cazurile posibile. ");

        }

        public static void Rezolvare()
        {
            Console.Clear();

            AfiseazaMesaj();
            int a = Helper.ReadInt("a");
            int b = Helper.ReadInt("b");
            int c = Helper.ReadInt("c");
            float delta, x1, x2;
            delta = b * b - 4 * a * c;
            if(delta==0)
            {
                x1 = (float)-b / (float)2 * a;
                Console.WriteLine($"Unica solutie a ecuatiei {a}x^2+{b}x+{c}=0 este  x={x1}");
            }
            else if(delta>0)
            {
                x1 = (float)(-b+ Math.Sqrt(delta)) / (float)2 * a;
                x2 = (float)(-b- Math.Sqrt(delta)) / (float)2 * a;
                Console.WriteLine($"Ecuatia {a}x^2+{b}x+{c}=0 are ca solutii x1={x1} si x2={x2}");
            }
            else if(delta<0)
            {
              
                Console.WriteLine(delta);
                x1 = (float)(-b + Math.Sqrt(-delta)) / (float)2 * a;
                x2 = (float)(-b - Math.Sqrt(-delta)) / (float)2 * a;
                Console.WriteLine($"Ecuatia {a}x^2+{b}x+{c}=0 are ca solutii x1={x1}i si x2={x2}i");
            }

        }
    }
}
