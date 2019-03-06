using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kpo
{
    class Program
    {
        static void Main(string[] args)
        {   ///Program: Kő, papír, Olló játék
            ///Írta: Maglódi Gábor, 2019.03.04
            ///Számítógép véletlenszerűen választ k/p/o közül
            bool moreGame = true;
            Console.WriteLine("===============================================Kő,Papír, Olló játék====================================================");
            do
            {
                Console.Write("Akarsz még játszani? i/n");
                if (Console.ReadKey(true).KeyChar == 'n')
                {
                    moreGame = false;
                }

            } while (moreGame);
            Console.ReadKey();

            
        }
    }
}
