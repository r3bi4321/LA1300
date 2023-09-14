using System.Globalization;
using System.Runtime.InteropServices;
using System.Security.Cryptography;


namespace Numberguesser
{
    internal class Program
    {

        static void Main(string[] args)

        {
            Level1 Erstens = new Level1();
            Level2 Zweitens = new Level2();
            Level3 Drittens=new Level3();   

            bool Neustart = false;
            do
            {

                Console.WriteLine("Willkommen!");
                Console.WriteLine("Welches Level möchten sie spielen? (1,2 oder 3)");
                bool Fang = false;
                bool korrekt = false;
                string Levelchoice = Console.ReadLine();
                int Level = Convert.ToInt32(Levelchoice);

                do
                {

                  

                    if (Level == 1)
                    {
                        Erstens.LevelEins(); 
                    }
                    else if (Level == 2)
                    {
                        Zweitens.LevelZwei();
                    }
                    else if (Level == 3)
                    {
                        Drittens.LevelDrei();
                    }
                    else
                    {
                        Console.WriteLine("Falsche Eingabe versuche es noch einmal. ");
                        Fang = true;
                    }

                } while (Fang = true || korrekt == false);



            } while (Neustart = true);
        }
    }
}
  
