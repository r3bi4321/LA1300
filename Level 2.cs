using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numberguesser
{
    internal class Level2
    {
        public void LevelZwei()
        {

           bool Fang = false;
            bool Neustart=false;
            bool korrekt=false;
            int Zähler=0;

            do { 
            
                double RandomNumber = new Random().Next(1, 1000);
            Console.WriteLine("Errate die Zahl zwischen 1 und 1000.");

            
               
                do
                {
                    string Rateversuch = Console.ReadLine();
                    int Guess = Convert.ToInt32(Rateversuch);

                    if (Guess < RandomNumber)
                    {

                        Console.WriteLine("Die gesuchte Zahl ist grösser als " + Guess);
                        Zähler = +1;
                        korrekt = false; 

                    }

                    else if (Guess > RandomNumber)
                    {
                        Console.WriteLine("Die gesuchte Zahl ist kleiner als " + Guess);
                        Zähler = +1;
                        korrekt = false;
                    }
                    else if (Guess == RandomNumber)
                    {

                        Console.WriteLine("Gratuliere! Du hast die Zahl erraten.");
                        Zähler = +1;
                        Console.WriteLine("Du hast" + Zähler + "Versuche gebraucht.");
                        Console.WriteLine("Möchtest du noch eine Runde spielen?(y/n)");
                        korrekt = true;
                        string Wiederholung = Console.ReadLine();
                        if (Wiederholung == "n")
                        {
                            Neustart = false;
                        }
                    }

                    else
                    {
                        Console.WriteLine("Dies ist keine gültige Eingabe.");
                        korrekt=false;
                    }
                } while (korrekt == false);

            } while (Neustart == true); 

        }
    }
}
