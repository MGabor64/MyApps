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
            string s;
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
            //Beolvasás konzloról
            s= Console.ReadLine();
            ///Egy billentyű leütése
            ///Console.ReadKey(true).KeyChar
            ///integerré konvertálni a console számot(string)
            ///int.Parse(Console.ReadKey())
            
            //tömbök
            int[] szamok = new int[5];
            string[] szovegek = new string[10];
            //tömb inicializálás
            int[] iNums = new int[] { 1, 2, 3, 4, 5, 6 };
            string[] sFruit = new string[] { "alma", "körte", "narancs", "banán" };
            Console.WriteLine("iNums első eleme: {0}, sFruit első eleme: {1}", iNums[0], sFruit[0]);
            Console.WriteLine("iNums első eleme:"+ iNums[0] +" sFruit első eleme: "+sFruit[0]);
            Console.ReadKey();
        }
    }
}
