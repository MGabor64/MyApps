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
            Random r = new Random();

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
                ///számítógép választásának kérése
                ///
                switch (r.Next(0, 3))
                {
                    
                    case 0:
                        compChoice = "kő";
                        break;
                    case 1:
                        compChoice = "papír";
                        break;
                    case 2:
                        compChoice = "olló";
                        break;

                }
                ///Értékeljük ki a compChoice és a myChoice változókat
                ///
                if((myChoice=="kő"&&compChoice=="papír")||(myChoice=="papír"&&compChoice=="olló")||(myChoice=="olló"&& compChoice=="kő"))
                {
                    Console.WriteLine("Számítógép: " + compChoice + "Te: " + myChoice);
                    Console.WriteLine("Vesztettél! Állás:Számítógép:{0} Játékos:{1}", ++compScore, myScore);
                }
                else if ((myChoice == compChoice ))
                {
                    Console.WriteLine("Számítógép: " + compChoice + "Te: " + myChoice);
                    Console.WriteLine("Döntetlen! Állás:Számítógép:{0} Játékos:{1}", compScore, myScore);
                }
                else
                {
                    Console.WriteLine("Számítógép: " + compChoice + "Te: " + myChoice);
                    Console.WriteLine("Nyertél! Állás:Számítógép:{0} Játékos:{1}", compScore, ++myScore);
                }
                Console.WriteLine("Akarsz még játszani? i/n");
                if (Console.ReadKey(true).KeyChar == 'n')
                {
                    moreGame = false;
                }

            } while (moreGame);
            Console.ReadKey();

            
        }
    }
}