using System;



namespace KryptographBibliothek
{
    public class Entfernen



    {
        public static string Zeichen_Entfernen(string str)



        {



            do
            {

               
               
                
               Console.WriteLine("Welcomme to my World");





                Console.WriteLine(" CHIFFRE");
                Console.WriteLine("_____________________________________________________________________________________________________________________________________________________________________________________________________________________________________________");
                Console.WriteLine(str);
                Console.WriteLine("_____________________________________________________________________________________________________________________________________________________________________________________________________________________________________________");



                Console.WriteLine("Entfernen Sie Ihr zeichen?");
                Console.WriteLine("Um den Programm zu beenden schreiben Sie ´exit`!");
                Console.Write("Eingabe:");
                




                string charsToRemove = Console.ReadLine();



                if (charsToRemove == "exit")
                {



                    Environment.Exit(0);



                }
                else
                {








                    str = str.Replace(charsToRemove.ToLower(), "");



                    str = str.Replace(charsToRemove.ToUpper(), "");



                }





                Console.Clear();


                Console.WriteLine("Möchten Sie nochmal wiederholen");
               
            } while (true);



            return str;
        }
       
    }
}
    
