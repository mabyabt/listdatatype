using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using dataC.cs;


namespace pekingtorna
{
    class Program
    {
        static void Main(string[] args)
        {
            Controller.readFromFile();
            Console.WriteLine(dataC.nev.Count()+"darabb versenyzö indult");
            var indexelsotornaarany =  Controller.tornaArany();
            Console.WriteLine("arany ermes a tonaban: " + dataC.nev.ElementAt(indexelsotornaarany)+" pont: "+dataC.korlat.ElementAt(indexelsotornaarany));

            Console.WriteLine(dataC.nev.ElementAt(8));
            // dataC.printAllnev();


            Console.WriteLine("adjon meg egy rajtszamot: ");
            int rajtsz= Convert.ToInt32(Console.ReadLine());
                var cordinate = Controller.findNumber(rajtsz);
            Console.WriteLine("aa rajtszamhoz tartozo nev: " + dataC.nev.ElementAt(cordinate) + " eredmeny  " + dataC.gyuru.ElementAt(cordinate));

            lolenges.nemjutottovább();

            foldreszrend.rend();
            Orszagversenyzo.print();

            francia.Fra();

            Console.ReadKey();
          
           

        }
    }
}
