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
            int v = 0;
            exercise ex = new exercise("Maglódi Gábor");

            Console.WriteLine(ex.Name);
            ex.PrintName();

            Console.WriteLine(ex.getName());
            for(int i= 0; i< 2; i++)
            {
                Console.WriteLine("Ciklusváltozó hivaatkozás I.>0"+i);
                Console.WriteLine("Ciklusváltozó hivaatkozás II.>0");
            }
            v = 2;
            while (v>0)
            {
                Console.WriteLine("While ciklus");
                v--;
            }
            do
            {
                Console.WriteLine("Do while ciklus");
                v--;
            } while (v>0);
            Console.ReadKey();


        }
    }
}
