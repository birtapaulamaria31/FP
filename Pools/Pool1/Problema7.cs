using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool1
{
    class Problema7
    {
        public static void AfiseazaMesaj()
        {
            Console.WriteLine("Problema 7.");
            Console.WriteLine("(Swap) Se dau doua variabile numerice a si b ale caror valori sunt date de intrare. Se cere sa se inverseze valorile lor. ");

        }

        public static void Rezolvare()
        {
            Console.Clear();

            AfiseazaMesaj();
            int a = Helper.ReadPositiveInt("a");
            int b = Helper.ReadPositiveInt("b");

            int aux;
            aux = a;
            a = b;
            b = aux;
            Console.WriteLine($"Dupa interschimbare, numerele sunt a={a} si b={b}.");


        }
    }
}
