using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool2
{
    class Problema9
    {
        public static void AfiseazaMesaj()
        {
            Console.Clear();
            Console.WriteLine("Problema 9.");
            Console.WriteLine("Sa se determine daca o secventa de n numere este monotona. Secventa monotona = secventa monoton crescatoare sau monoton descrescatoare.");

        }

        public static void Rezolvare()
        {
            int n, x, cresc=0,descresc=0,y;
            AfiseazaMesaj();
            n = Helper.ReadPositiveInt("n");
            if (n == 0 || n == 1)
                Console.WriteLine("Ca sa putem determina monotonia unei secvente avem nevoie de minim 2 numere in secventa!!!");
            else
            {
                x = Helper.ReadInt("x");

                y = x;
                x = Helper.ReadInt("x");
                if(x>=y)
                {
                    cresc = 1;
                    y = x;
                    for (int i = 1; i <= n-2; i++)
                    {
                        x = Helper.ReadInt("x");
                        if (x < y)
                        {                           
                            cresc = 0;
                        }
                           

                    }
                }
                else if(x<=y)
                {
                    y = x;
                    descresc = 1;
                    for (int i = 1; i <= n - 2; i++)
                    {
                        x = Helper.ReadInt("x");
                        if (x > y)
                        {
                            descresc = 0;
                        }


                    }
                    
                }
                if(descresc == 0 && cresc==0)
                        Console.WriteLine("Secventa nu este monotona.");
                 else if (cresc==1 && descresc==0)
                    Console.WriteLine("Secventa este monoton crescatoare.");
                 else if (cresc == 0 &&descresc == 1)
                    Console.WriteLine("Secventa este monoton descrescatoare.");


            }
           
         

        }
    }
}
