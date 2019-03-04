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
        {
            string nev;
            string orszag;
            int mennyiseg, gyszam;
            
            Console.WriteLine("Kérem a gyümölcsök számát:");
            gyszam = int.Parse(Console.ReadLine());
            Fruit[] fruits = new Fruit[15];
            for (int i = 0; i < gyszam; i++)
            {
                Console.Write("Kérem a(z) {0}. gyümölcs nevét: "+1);
                nev = Console.ReadLine();
                Console.Write("Kérem a(z) {0}. gyümölcs származási helyét: "+1);
                orszag = Console.ReadLine();
                Console.Write("Kérem a(z) {0}. gyümölcs mennyiségét: "+1);
                mennyiseg = int.Parse(Console.ReadLine());
                /*
                 * 
                 */
                //Tömbfeltöltés
                fruits[i] = new Fruit(nev, orszag, mennyiseg);
            }
            Console.ReadKey();
        }
       
    }
}
