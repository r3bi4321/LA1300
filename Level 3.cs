using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Numberguesser
{
    internal class Level3
    {
        public void LevelDrei()
        {

            bool Fang = false;
            bool Neustart = false;
            bool korrekt = false;
            int Zähler = 0;
            do
            {
                {
                    Console.WriteLine("Gebe die Zahlen ein, zwischen welchen du die Zahlen erraten möchtest.");
                    string Tiefezahl = Console.ReadLine();
                    string Hohezahle = Console.ReadLine();
                    int Lownumber = Convert.ToInt32(Tiefezahl);
                    int Highnumber = Convert.ToInt32(Hohezahle);
                    double RandomNumber = new Random().Next(Lownumber, Highnumber);
                    Console.WriteLine("OK! Errate die Zahl welche sich zwischen " + Lownumber + " und " + Highnumber + " befindet.");

                    do
                    {
                        string Rateversuch = Console.ReadLine();
                        int Guess = Convert.ToInt32(Rateversuch);


                        if (Guess == RandomNumber)
                        {
                            Console.WriteLine("Gratuliere! Du hast die Zahl erraten.");
                            Zähler = +1;
                            Console.WriteLine("Du hast " + Zähler + "Versuche gebraucht.");
                            Console.WriteLine("Möchtest du noch eine Runde spielen?(y/n)");
                            korrekt = true;
                            string Wiederholung = Console.ReadLine();
                            if (Wiederholung == "n")
                            {
                                Neustart = true;
                            }
                        }
                        else if (Guess < RandomNumber)
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

                        else
                        {
                            Console.WriteLine("Dies ist keine gültige Eingabe.");
                            korrekt = false;
                        }

                    } while (korrekt == false);
                }
            } while (Neustart == true);
        }

    }
}
