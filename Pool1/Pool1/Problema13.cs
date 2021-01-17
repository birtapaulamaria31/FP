using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool1
{
    class Problema13
    {
        public static void AfiseazaMesaj()
        {
            Console.WriteLine("Problema 13.");
            Console.WriteLine("Determianti cati ani bisecti sunt intre anii y1 si y2. ");

        }

        public static void Rezolvare()
        {
            Console.Clear();

            AfiseazaMesaj();
            int y1 = Helper.ReadPositiveInt("y1");
            int y2 = Helper.ReadPositiveInt("y2");
            int nr = 0;
            for (int y = y1; y <= y2; y++)
                if ((y % 4 == 0 && y % 100 != 0) || y % 400 == 0)
                    nr++;
             Console.WriteLine($"Intre anii {y1} si {y2} sunt {nr} ani bisecti.");
        }
    }
}
