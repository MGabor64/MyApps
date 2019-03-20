using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esf
{
    class Program
    {
        private static string sName;
        private static string sAuthor;
        private static int iPage;

        static void Main(string[] args)
        {
            int v = 0;
            string s;
            Exercise ex = new Exercise("Maglódi Gábor");

            Console.WriteLine(ex.Name);
            ex.PrintName();

            Console.WriteLine(ex.getName());
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Ciklusváltozó hivaatkozás I.>0" + i);
                Console.WriteLine("Ciklusváltozó hivaatkozás II.>0");
            }
            v = 2;
            while (v > 0)
            {
                Console.WriteLine("While ciklus");
                v--;
            }
            do
            {
                Console.WriteLine("Do while ciklus");
                v--;
            } while (v > 0);

            ///elágazások
            ///
            if (v == 2)
            {
                Console.WriteLine("A 'v' értéke 2");

            }
            else if (v == 3)
            {
                Console.WriteLine("A 'v' értéke 3");
            }
            else
            {
                Console.WriteLine("V nem 2 és nem 3, hanem" + v);
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
            s = Console.ReadLine();
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
            Console.WriteLine("iNums első eleme:" + iNums[0] + " sFruit első eleme: " + sFruit[0]);

            //típusos lista List<T>

            var Lista = new List<Book>();

            //elemek hozzáadása

            //Ctrl "pont"-ot hívhatjuk segítségül
            Lista.Add(new Book() { Name = "Oroszlánkölykök", Author = "Irwin Shaw", Page = 100 });
            Lista.Add(new Book() { Name = "Megkergetve", Author = "Margó István", Page = 200 });
            Lista.Add(new Book() { Name = "Egri csillgok", Author = "Gárdonyi Géza", Page = 450 });
          
            foreach (Book book in Lista)
            {
                Console.WriteLine(book.Name + " " + book.Author + " " + book.Page);
            }
            Console.WriteLine("************************************************************************************************************");
            //   Lista.Remove(new Book() { Name = "Megkergetve", Author = "Margó István", Page = 200 });
            Lista.Remove(Lista.Find(x => x.Name.Contains("Megkergetve")));
            foreach (Book book in Lista)
            {
                Console.WriteLine(book.Name + " " + book.Author + " " + book.Page);
            }
            Console.WriteLine("Keressük az Oroszlánkölykök könyvet: " + Lista.Find(x => x.Name.Contains("Oroszlánkölykök")).Name);
            //feladat: egészítsük ki úgy a programot, hogy a felhasználó lehetőséget kapjon a könyvtár mógosítására
            //ha u: könyvet felvisz a könyvtárba
            //ha t:kérdezze meg, hogy mejiket akarod kitörölni
            //ha l: listázza a könyveket
            bool morebook=true;
           
           
            do
            {
                Console.WriteLine("Üdvözöllek a könyv-rendszerezőben! Mit szeretnél csinálni? bekérni( u )/törölni( t )/listázni( l )/kilépni( k )");
                switch (Console.ReadKey(true).KeyChar)
                {
                    case 'u':
                        Console.Write("Kérem a könyv címét:");
                        sName = Console.ReadLine();
                        Console.Write("Kérem a könyv szerzőjét:");
                        sAuthor = Console.ReadLine();
                        Console.Write("Kérem a könyv lapjainak számát:");
                        iPage = int.Parse( Console.ReadLine());
                        Lista.Add(new Book { Name = sName, Author = sAuthor, Page = iPage });
                        break;
                    case 'k':
                        morebook = false;
                        break;
                    case 't':
                        Console.WriteLine("Kérem a könyv címét:");
                        sName = Console.ReadLine();
                        Lista.Remove(Lista.Find(x => x.Name.Contains(sName)));

                        break;
                    case 'l':
                        Console.WriteLine("Könyvtár tartlma:");
                        foreach (Book book in Lista)
                        {
                            Console.WriteLine(book.Name + " " + book.Author + " " + book.Page);
                        }
                        break;
                    
                 


                }
                
            } while (morebook);
            Console.ReadKey();
        }
    }
}
