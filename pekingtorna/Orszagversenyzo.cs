using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pekingtorna
{
    class Orszagversenyzo
    {
        public static void print()
        {

            // string findjpn = "JPN";
            dataC.orszag.Sort();
            int i = 0;

            Console.Write("CHN ");

            Console.WriteLine(dataC.orszag.FindAll(s => s.Equals("CHN")).Count());

            Console.Write("GER ");

            Console.Write(dataC.orszag.FindAll(s => s.Equals("GER")).Count());


            Console.Write("KOR ");

            Console.WriteLine(dataC.orszag.FindAll(s => s.Equals("KOR")).Count());

            Console.Write("JPN ");

            Console.WriteLine(dataC.orszag.FindAll(s => s.Equals("JPN")).Count());

            Console.Write("RUS ");

            Console.WriteLine(dataC.orszag.FindAll(s => s.Equals("RUS")).Count());

            Console.WriteLine("USA");

            Console.WriteLine(dataC.orszag.FindAll(s => s.Equals("USA")).Count());

            Console.WriteLine("CAN");

            Console.WriteLine(dataC.orszag.FindAll(s => s.Equals("CAN")).Count());

            Console.WriteLine("UZB");

            Console.WriteLine(dataC.orszag.FindAll(s => s.Equals("UZB")).Count());


            Console.WriteLine("GBR");

            Console.WriteLine(dataC.orszag.FindAll(s => s.Equals("GBR")).Count());

            Console.WriteLine("ITA");

            Console.WriteLine(dataC.orszag.FindAll(s => s.Equals("ITA")).Count());



            Console.WriteLine("FRA");

            Console.WriteLine(dataC.orszag.FindAll(s => s.Equals("FRA")).Count());



            Console.WriteLine("ISR");

            Console.WriteLine(dataC.orszag.FindAll(s => s.Equals("ISR")).Count());


            Console.WriteLine("ROU");

            Console.WriteLine(dataC.orszag.FindAll(s => s.Equals("ROU")).Count());



            // Console.WriteLine(jap);


            /*
            while (i !=dataC.orszag.Count()) { 
            var t = dataC.orszag.ElementAt(i);
            var jap = dataC.orszag.FindAll(s => s.Equals(t)).Count();

                Console.WriteLine(t);

                Console.WriteLine(jap);
        } }*/


        }
    }
}
