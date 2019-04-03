using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animaal
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat myCat = new Cat("Cirmi", true);
            Dog myDog = new Dog("Buksi", false);
            Cat myCat1 = new Cat("Kormos", false);
            myCat.Sleep();
            myCat.Hunt();
            myCat.Sound();
            myCat1.Born(5);
            myCat1.Child();

            myDog.Sleep();
            myDog.Hunt();
            myDog.Sound();
            myDog.Born(3);
            myDog.Child();
            

            Console.ReadLine();
        }
    }
}
