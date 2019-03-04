using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    class Fruit
    {
        public string Neve;
        public string Szarmazasihely;
        public int Mennyisege;
        public Fruit(string aNeve, string aSzhelye, int aMenny)
        {
            Neve = aNeve;
            Szarmazasihely = aSzhelye;
            Mennyisege = aMenny;
            Console.WriteLine("DEBUG: fruit() konstruktor meghívás");
        }
    }
}