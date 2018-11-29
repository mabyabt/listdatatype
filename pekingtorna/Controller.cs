using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using dataC.cs;


namespace pekingtorna
{
    class Controller
    {
        List<dataC> olimpia;

        public Controller() {

            olimpia = new List<dataC>();

        }

       



        public static int  findNumber(int rajtnumber) {
             return dataC.rajtszam.FindIndex(x=>x==rajtnumber);
             }



        public static int tornaArany() {
            double elso=0;
            int indexelso=0;
            
            for (int i = 0; i < dataC.korlat.Count(); i++) {
                double a = dataC.korlat.ElementAt(i);
                if (elso < a) {
                    elso = a;
                    indexelso = i;
                }


            }
            return indexelso;
        }


        public static void readFromFile() {

            StreamReader torna = new StreamReader("torna.txt");

            while (!torna.EndOfStream)
            {

                string line = torna.ReadLine();
                //Console.WriteLine(line);

                splitter(line);

            }

        }

        public static void splitter(string input)
        {
            string[] data = input.Split(';');
            int all = data.Count();
            int i = 0;
          //  Console.WriteLine(data[i]);
             while (i != all)
              {
                string f = data[i];


               // Console.WriteLine(data[i]);

                
                dataC.rajtszam.Add(Convert.ToInt32(data[i]));
                i++;
                  dataC.nev.Add(data[i]);
                  i++;
                 dataC.orszag.Add(data[i]);
                  i++;
                  dataC.foldres.Add(data[i]);
                  i++;
                  dataC.talaj.Add(Convert.ToDouble(data[i]));
                  i++;
                  dataC.lenges.Add(Convert.ToDouble(data[i]));
                  i++;
                  dataC.gyuru.Add(Convert.ToDouble(data[i]));
                  i++;
                  dataC.nyujto.Add(Convert.ToDouble(data[i]));
                  i++;
                  dataC.korlat.Add(Convert.ToDouble(data[i]));
                  i++;
                  dataC.ugras.Add(Convert.ToDouble(data[i]));
                  i++;


              }
              


        }


    }
}
