using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esf
{
    class Program
    {
        static void Main(string[] args)
        {
            exercise ex = new exercise("Maglódi Gábor");

            Console.WriteLine(ex.Name);

            Console.ReadKey();

        }
    }
}
