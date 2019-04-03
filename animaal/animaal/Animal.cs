using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animaal
{
    abstract class Animal
    {
        public string Name;
        abstract public void Sleep();
        abstract public void Hunt();
        abstract public void Sound();
        


    }
    //feladat: próbáljunk kölyköket hozzáadni a 'Cat' osztályhoz
    class Cat : Animal
    {
        private List<Cat> Kids;
       



        public Cat(string aName)
        {
            Name = aName;
        }

        internal void Born(int v)
        {
            Kids = new List<Cat>();
            for(int i=0; i<v;i++)
            {
                Kids.Add(new Cat("cica" + i.ToString()));
            }

        }

        public override void Sleep()
        {
            Console.WriteLine(Name + " is sleeping....");
        }
        public override void Hunt()
        {
            Console.WriteLine(Name + " is hunting....");
        }
        public override void Sound()
        {
            Console.WriteLine(Name + " is meowing....");
        }

        internal void Child()
        {
            foreach (var item in Kids)
            {
                Console.WriteLine(Name + " " + item.Name);
            }
        }
    }
    class Dog : Animal
    {
        private List<Dog> dKids;
        //konstruktor
        public Dog(string aName)
        {
            Name = aName;
        }
        internal void Born(int v)
        {
            dKids = new List<Dog>();
            for (int i = 0; i < v; i++)
            {
                dKids.Add(new Dog("kisblöki" + i.ToString()));
            }

        }
        public override void Sleep()
        {
            Console.WriteLine(Name + " is sleeping....");
        }
        public override void Hunt()
        {
            Console.WriteLine(Name + " is hunting....");
        }
        public override void Sound()
        {
            Console.WriteLine(Name + " is barking....");
        }

        internal void Child()
        {
            foreach (var item in dKids)
            {
                Console.WriteLine(Name + " " + item.Name);
            }
        }

        
    }
}
