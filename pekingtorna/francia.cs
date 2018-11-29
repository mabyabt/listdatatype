using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pekingtorna
{
    class francia
    {
       public static void Fra() {
            StreamWriter ki = new StreamWriter("francia.txt");


            for (int i = 0; i != dataC.orszag.Count();i++) {

                if (dataC.orszag.ElementAt(i) == "FRA") {
                    ki.WriteLine(dataC.rajtszam.ElementAt(i) + "   " + dataC.nev.ElementAt(i) + "   " + dataC.gyuru.ElementAt(i) + "   " + dataC.korlat.ElementAt(i) + "   " + dataC.lenges.ElementAt(i) + "   " + dataC.talaj.ElementAt(i) + "  " + dataC.ugras.ElementAt(i)+"\n");


                }


                    }

            ki.Close();



        }


    }
}
