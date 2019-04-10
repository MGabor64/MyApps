using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tipuskonverzio
{
    class Program
    {
        private static int iPrev;

        static void Main(string[] args)
        {
            int x = 10;
            // az 'is' operátort fogjuk használni 
            if(x is int)
            {
                Console.WriteLine("x típusa int");
            }
            //az 'as' operátort fogjuk használni
            object a = "123";
            object b = "HELLO";
            object c = 10;
            string aa = a as string;
            Console.WriteLine(aa == null ? "NULL" : aa);//123

            string bb = b as string;
            Console.WriteLine(bb == null ? "NULL" : bb);//HELLO

            string cc = c as string;
            Console.WriteLine(cc == null ? "NULL" : cc);//NULL

            //karakterkonverziók
            for (char ch = 'A'; ch <= 'Z'; ++ch)
            {
                Console.Write((int)ch);
            }
            //tömbök
            int[] iTömb = new int[10];
            Console.WriteLine("");
            Random r = new Random();
            for (int i = 0; i < iTömb.Length; ++i)
            {
                //iTömb[i] = r.Next(0, 100);
                Console.Write("Kérem a(z) " + i + ". számot: ");
                try
                {
                    iTömb[i] = int.Parse(Console.ReadLine());
                    iPrev = i;
                }
                catch ( Exception e)
                {
                    Console.WriteLine("Hiba! " + e.Message);
                    i = iPrev;
                }
            }

            
            for(int i = 0; i < iTömb.Length; i++)
            {
                Console.Write(iTömb[i] + " ");
            }
            int[] iArr = new int[] { 1, 2, 3, 4 };
            string[] sArr = new string[] { "alma", "körte","banán", "mangó" };
            Array.Sort(sArr);
            for (int i = 0; i < sArr.Length; i++)
            {
                Console.Write(sArr+" ");

            }
            //többdimenziós tömb
            int[,] matrix = new int[3, 3];
            Console.ReadKey();


        }

    }
}
