using System;
using System.Collections.Generic;
namespace KryptographBibliothek
{
    public class ZeichenZaehlen
    {
        public static Dictionary<char, double> Zeichen(string args)
        {      

            Dictionary<char, double> dicList = new Dictionary<char, double>();
            string chiffre = args;


            foreach (var chr in chiffre)
            {
                double count = 0;
                if (dicList.ContainsKey(chr))
                {
                    count = dicList[chr];
                }
                dicList[chr] = count + 1;
            }

            foreach (KeyValuePair<char, double> pair in dicList)
            {
                Console.WriteLine(pair.Key  + " = " + pair.Value + " = " + (pair.Value /  chiffre.Length));
                
            }
            Console.ReadLine();


            return dicList;


        }
    }
}
