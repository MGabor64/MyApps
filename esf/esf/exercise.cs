﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esf
{
    class exercise
    {
        public string Name;
        /// <summary>
        /// konstruktor initalizálja az osztály adattagjait
        /// </summary>
        /// <param name="aName"></param>
        public exercise(string aName)
        {
            Name = aName;
        }
        public void PrintName()
        {
             Console.WriteLine(Name);
        }
        public string getName()
        {
            return Name;
        }
    }
}
