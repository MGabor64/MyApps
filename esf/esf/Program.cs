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
            
            ///elágazások
            ///
            if (v==2)
            {
                Console.WriteLine("A 'v' értéke 2");
                
            }
            else if (v==3)
            {
                Console.WriteLine("A 'v' értéke 3");
            }
            else
            {
                Console.WriteLine("V nem 2 és nem 3, hanem"+v);
            }
            //elágazások
            v = 0;
            switch (v)
            {
                case 0:
                    Console.WriteLine("Szvics:" + v);
                    break;
                case 3:
                    Console.WriteLine("Szvics:" + v);
                    break;
            }
            Console.ReadKey();
        }
    }
}
