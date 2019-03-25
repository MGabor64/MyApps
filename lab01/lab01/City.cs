using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab01
{
    class City
    {
        public string Town;

        public int Population;

        public string County;
        //Konstruktor
        public City(string sTown, string sCounty, int iPop)
        {
            Town = sTown;
            County = sCounty;
            Population = iPop;
        }
        public City()
        {

        }
    }
}
