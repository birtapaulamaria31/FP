using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool1
{
    static class Helper
    {
        public static int ok = 1;
        public static int ReadInt(string n)
        {
            Console.Write($"Introdu numarul intreg {n}: ");
            string input = Console.ReadLine();
            int numar = 0;
            try
            {
                numar = Int32.Parse(input);
            } catch (Exception e)
            {
                Console.WriteLine("E gresit, nu ai introdus un numar intreg.");
                ok = 0;
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
                ok = 0;
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
            }
            return numar;

        }

        public static int Oglindit(int x)
        {
            int og = 0;
            while (x != 0)
            {
                og = og * 10 + x % 10;
                x = x / 10;
            }
            return og;
        }
    }
}
