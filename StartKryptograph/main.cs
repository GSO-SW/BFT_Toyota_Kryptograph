using System;

namespace StartKryptograph
{
    class main
    {
        static void Main(string[] args)
        {

            string pfad = @"C:\Users\dean.p\source\repos\BFT_Toyota_Kryptograph\Chiffre.txt";
            KryptographBibliothek.AuslesenDerChiffre.Auslesen(pfad);

            string pfad = @"C:\Users\semih.c14\source\repos\BFT_Toyota_Kryptograph\Deutsch_Wahrscheinlichkeiten.txt";
            KryptographBibliothek.AuslesenTabelle.getTable(pfad);

        }
    }
}
