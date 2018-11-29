using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using dataC.cs;


namespace pekingtorna
{
    class lolenges
    {
        public static void nemjutottovább() {
            double min= 14.5;
            int i = 0;
            Console.WriteLine("lolengesben nem jutotak tovabb nevsora: ");
            while (i != dataC.lenges.Count())
            {

                if (min >= dataC.lenges.ElementAt(i)) {
                    Console.WriteLine(dataC.nev.ElementAt(i));
                }
                
                i++;
            }
        }


    }
}
