using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        { var fruits = new List<Fruit>();
            string nev;
            string orszag;
            int mennyiseg, gyszam;
            int összmenny = 0;
            Console.WriteLine("Kérem a gyümölcsök számát:");
            gyszam = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < gyszam; i++)
            {
                Console.Write("Kérem a(z) {0}. gyümölcs nevét: ",i+1);
                nev = Console.ReadLine();
                Console.Write("Kérem a(z) {0}. gyümölcs származási helyét: ",i+1);
                orszag = Console.ReadLine();
                Console.Write("Kérem a(z) {0}. gyümölcs mennyiségét: ",i+1);
                mennyiseg = int.Parse(Console.ReadLine());
                összmenny += mennyiseg;
                
                /*
                 * 
                 */
                //Tömbfeltöltés

                fruits.Add (new Fruit(nev, orszag, mennyiseg));

            }
            Console.WriteLine("A gyümulcsök mennyisége:",összmenny);
            Console.ReadKey();
        }
       
    }
}
