using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_05_20
{
    class Program
    {
        static void Main(string[] args)
        {
            //15 tagú tömb
            int[] iArray = new int[15];
            //5 tagú szöveg tömb
            string[] sArray = new string[5];
            //adattagos tömb
            int[] iT = new int[] { 5, 8, 9 };
            //2 dimenziós tömb
            int[,] iT2 = new int[,] { { 4,5 },{ 2,3 },{ 6,8 } };
            try
            {
                Console.WriteLine(iT2[2, 1]);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            //3 dimenziós tömb
            int[,,] iT3 = new int[,,] { {{ 4, 5, 6 }, { 2, 3, 4 } } ,{ { 6, 8, 10 }, { 11, 12, 13 } } };
            try
            {
                Console.WriteLine(iT3[1,1,0]);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
