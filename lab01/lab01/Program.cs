using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Üdvözöllek a város rendszerező Programomban!");
            //City c1 = new City("Bgy", "Nograd", 15000);
            var Lista = new List<City>();
            Lista.Add(new City() { Town = "Balassagyarmat", County = "Nógrád", Population = 15000 });
            Lista.Add(new City() { Town = "Salgótarján", County = "Nógrád", Population = 25000 });
            Lista.Add(new City() { Town = "Budapest", County = "Pest", Population = 1200000 });
            Console.WriteLine("*************************");
            foreach ( City item in Lista)
            {
                Console.WriteLine("***************");
                Console.WriteLine(item.Town);
                Console.WriteLine(item.County);
                Console.WriteLine(item.Population);
            }
            Lista.Remove(Lista.Find(x => x.Town.Contains("Salgótarján")));
            Console.WriteLine("*************************");
            foreach (City item in Lista)
            {
                Console.WriteLine("***************");
                Console.WriteLine(item.Town);
                Console.WriteLine(item.County);
                Console.WriteLine(item.Population);
            }
            Console.WriteLine("*************************");
            Console.ReadKey();
        }
    }
}
