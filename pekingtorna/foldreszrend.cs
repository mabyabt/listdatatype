using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace pekingtorna
{
    class foldreszrend
    {
        public static void rend() {
          
            List<string> foldr = new List<string>() ;

            int i = 0;

            while (i != dataC.foldres.Count()) {
                string a = dataC.foldres.ElementAt(i);
                if (!foldr.Exists(e=> e.EndsWith(a))) {

                    foldr.Add(dataC.foldres.ElementAt(i));
                    
                   
                }
                     i++;
                    // Console.WriteLine(i);
            }


            foldr.Sort();

            
            Console.WriteLine("foldreszek::::: ");
            Console.WriteLine(String.Join(",", foldr));



           

            }



        }


    }

