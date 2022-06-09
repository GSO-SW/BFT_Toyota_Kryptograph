using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.IO;

namespace KryptographBibliothek
{

    public static class AuslesenTabelle
    {

        public static Dictionary<string,double> getTable(string pfad)

        public static Dictionary<string, double> getTable(string pfad)

        {
            Dictionary<string, double> tabelle = new Dictionary<string, double>();

            string[] zeilen = File.ReadAllLines(pfad);

            foreach (string zeile in zeilen)
            {

                string[] data = zeile.Split('\t','%',' ');

                string[] data = zeile.Split('\t', '%', ' ');


                tabelle.Add(data[0], Convert.ToDouble(data[1]));

                //c# wie fügt man einträge in ein dictonary hinzu

            }
            return tabelle;
        }
    }

}


}

