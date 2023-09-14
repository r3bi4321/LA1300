using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numberguesser
{
    internal class Level1
    {
        public void LevelEins()
        {
            bool Neustart = false;
            bool Fang = false;
            bool korrekt = false;
            int Zähler = 0;
            Fang = false;

            do
            {


                int RandomNumber = new Random().Next(1, 100);
                Console.WriteLine("Errate die Zahl zwischen 1 und 100");


                do
                {
                    string Rateversuch = Console.ReadLine();
                    int Guess = Convert.ToInt32(Rateversuch);

                    if (Guess == RandomNumber)
                    {
                        Console.WriteLine("Gratuliere! Du hast die Zahl erraten.");
                        Zähler = +1;
                        Console.WriteLine("Du hast " +Zähler+ " Versuche gebraucht.");
                        Console.WriteLine("Möchtest du noch eine Runde spielen?(y/n)");
                        korrekt = true;
                        string Wiederholung = Console.ReadLine();
                        if (Wiederholung == "y")
                        {
                            korrekt=true;
                            Neustart = true;
                        }
                    
                    }

                    else if (Guess > RandomNumber)
                    {
                        Console.WriteLine("Die gesuchte Zahl ist kleiner.");
                        Zähler = +1;
                        korrekt = false;
                    }
                    else if (Guess < RandomNumber)
                    {
                        Console.WriteLine("Die gesuchte Zahl ist grösser.");
                        korrekt = false;
                    }
                    else
                    {
                        Console.WriteLine("ungültige Eingabe");
                        korrekt = false;
                    }
                } while (korrekt == false);
            } while (Neustart == true); 
          }

    }
}
