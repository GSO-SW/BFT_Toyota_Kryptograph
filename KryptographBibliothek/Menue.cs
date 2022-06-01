using System;
using Figgle;
using System.IO;
using System.Collections;


namespace KryptographBibliothek
{
    public class Menue
    {
        public static void MainMenue()
        {


            string pfad;


            do
            {
                (int, int) cPosBM = Console.GetCursorPosition();

                Console.WriteLine();

                //ASCII art Logo wird erzeugt.
                Console.WriteLine
                    (FiggleFonts.Slant.Render("TOYOTA Kryptograph"));

                //Konsolentitel wird geändert.
                Console.Title = "TOYOTA Kryptograph";

                Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                  "                              >>> Texte entschlüsseln <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");

                Console.WriteLine("Eingabe: exit\t\t->\tbeendet das Programm");

                //Beschreibung der Software.
                Console.WriteLine("\n\nWilkommen in TOYOTA Krypptographie.Mit dieem Program können Sie Texte mit der Transpositionschiffre entschlüsseln \n\n");


                //Eingabeaufforderung 
                Console.WriteLine("Geben Sie bitte den Pfad ein:\n");
                Console.Write("Eingabe:");
                pfad = Console.ReadLine();




                switch (pfad)
                {
              

                    case "exit":
                        Environment.Exit(0);
                        break;
                        
                    default:

                        bool flag = Directory.Exists(pfad);

                        if(flag ==true)
                        {
                            //string chiffre = Auslesen.AuslesenChiffre(pfad);
                            ZeichenEntfernen.Zeichen_Entfernen();
                        }
                        else
                        {
                            Console.WriteLine("Fehler! Der Pfad wurde nicht gefunden");
                            Console.ReadKey();

                        }


                        (int, int) cPosAM = Console.GetCursorPosition();
                      

                        KonsolenExtrasBibliothek.ConsoleExtras.ClearCurrentConsoleLine(cPosBM.Item2, cPosAM.Item2);

                        break;
                }


            } while (true);


        }
    }
}
