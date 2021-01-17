using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevi
{
    class Elev : Persoana
    {
        public Elev(string nume)
        {
            this.nume = nume;
        }
       
        public void GetName()
        {
            Console.WriteLine(this.nume);
        }
    }
}
