using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevi
{
    class Program
    {
        static void Main(string[] args)
        {
            Elev e = new Elev("Alex");
            Elev x = new Elev("Lascu");

            e.GetName();
           
            
            Console.ReadKey();
        }
    }
}
