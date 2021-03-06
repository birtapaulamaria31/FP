﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool3
{
    class Helper
    {
        public static int ReadInt(string n)
        {
            Console.Write($"Introdu numarul intreg {n}: ");
            string input = Console.ReadLine();
            int numar = 0;
            try
            {
                numar = Int32.Parse(input);
            }
            catch (Exception e)
            {
                Console.WriteLine("E gresit, nu ai introdus un numar intreg.");
                Console.WriteLine();
                Console.WriteLine("Apasa orice tasta ca sa te intorci la meniul cu toate problemele.");
                Console.ReadKey();
                Program.Intro();
            }
            return numar;

        }

        public static int ReadPositiveInt(string n)
        {
            Console.Write($"Introdu numarul natural {n}: ");
            string input = Console.ReadLine();
            int numar = 0;
            try
            {
                numar = Int32.Parse(input);
                if (numar < 0)
                {
                    throw (new Exception());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("E gresit, nu ai introdus un numar natural.");
                Console.WriteLine();
                Console.WriteLine("Apasa orice tasta ca sa te intorci la meniul cu toate problemele.");
                Console.ReadKey();
                Program.Intro();
            }
            return numar;
        }
        public static float ReadFloat(string n)
        {
            Console.Write($"Introdu numarul rational {n}: ");
            string input = Console.ReadLine();
            float numar = 0.0f;
            try
            {
                numar = float.Parse(input);
            }
            catch (Exception e)
            {
                Console.WriteLine("E gresit, nu ai introdus un numar rational.");
                Console.WriteLine();
                Console.WriteLine("Apasa orice tasta ca sa te intorci la meniul cu toate problemele.");
                Console.ReadKey();
                Program.Intro();
            }
            return numar;

        }

        public static int[] ReadIntArray(int n)
        {
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
            {
                v[i] = ReadInt($"v[{i}]");
            }
            return v;
        }

        public static void Swap(ref int a, ref int b)
        {
            int aux;
            aux = a;
            a = b;
            b = aux;
        }
    }
}
