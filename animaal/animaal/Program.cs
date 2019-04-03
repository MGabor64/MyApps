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
            Cat myCat = new Cat("Cirmi");
            Dog myDog = new Dog("Buksi");
            Cat myCat1 = new Cat("Kormos");
            myCat.Sleep();
            myCat.Hunt();
            myCat.Sound();
            myCat1.Born(5);
            myCat1.Child();

            myDog.Sleep();
            myDog.Hunt();
            myDog.Sound();

            

            Console.ReadLine();
        }
    }
}
