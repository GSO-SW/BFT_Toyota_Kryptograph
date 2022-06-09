using System;

namespace KryptographBibliothek
{
    public class AuslesenDerChiffre
    {
        public static string Auslesen(string pfad)
        {


            //Wie wird ein Text aus einer Textdatei in c# ausgelesen und in einem string gespeichert


            string lines = System.IO.File.ReadAllText(pfad);


            return lines;
        }


    }
}
