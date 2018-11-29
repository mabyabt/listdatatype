using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pekingtorna
{
    class dataC
    {
        
        public static List<int> rajtszam = new List<int>();
        public static List<string> nev= new List<string>();
        public static List<string> orszag= new List<string>();
        public static List<string> foldres= new List<string>();
        public static List<double> talaj= new List<double>();
        public static List<double> lenges= new List<double>();
        public static List<double> gyuru= new List<double>();
        public static List<double> nyujto = new List<double>();
        public static List<double> korlat= new List<double>();
        public static List<double> ugras= new List<double>();


        /*

        public static void splitter (string input) {
            string[] data=input.Split(';');
            int i = 0;
            while (data[i]!=null) {
               rajtszam = Convert.ToInt32(data[i]);
                i++;
                nev = data[i];
                i++;
                orszag = data[i]; 
                i++;
                foldres = data[i];
                i++;
                talaj = Convert.ToDouble(data[i]);
                i++;
                lenges= Convert.ToDouble(data[i]);
                i++;
                gyuru= Convert.ToDouble(data[i]);
                i++;
                nyujto = Convert.ToDouble(data[i]);
                i++;
                korlat = Convert.ToDouble(data[i]);
                i++;
                ugras= Convert.ToDouble(data[i]);
                i++;
                
               
            }

    
        }
        */
        public static void printAllnev() {

            foreach (string g in nev)
            {
                Console.WriteLine(g + "//");
            }
        }




    }
}
