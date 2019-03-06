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
            ///Írta: Maglódi Gábor, 2019.03.06
            ///Számítógép véletlenszerűen választ k/p/o közül
            /// változók létrehozása
            string compChoice="";
            string myChoice="";
            int compScore = 0, myScore = 0;

            bool moreGame = true;
            Console.WriteLine("===============================================Kő,Papír, Olló játék====================================================");
            do
            {
                ///játékos választásának bekérése és tárolása
                Console.WriteLine("Mit választasz? k/p/o");
                
                switch(Console.ReadKey(true).KeyChar)
                {
                    case 'k':
                        myChoice = "kő";
                        break;
                    case 'p':
                        myChoice = "papír";
                        break;
                    case 'o':
                        myChoice = "olló";
                        break;

                }

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
