using System;
using static System.Console;

namespace Guessing_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("---- WELCOME TO THE GUESSING NUMBER GAME ----\n");

            Random r = new Random();
            int winNumber = r.Next(0, 100);
            bool win = false;

            do
            {
                Write("\nPlease enter the number between 0 and 100 : ");
                int num = Convert.ToInt32(Console.ReadLine());

                if (num>winNumber)
                {
                    WriteLine("Opps...! Number is Higher. Guess Lower .");
                 //  WriteLine("Your random number is {0}", winNumber);
                }
                else if (num < winNumber)
                {
                    WriteLine("\nOpps...! Number is Lower. Guess Higher .");
                }
                else if (num==winNumber)
                {
                    WriteLine("Bingooooo..... YOU WIN !!! \n");
                }
            }
            while (win==false);
            WriteLine("Thanks for using this program .");
            WriteLine("Please enter the key to exit .");
            ReadKey(true);

         }
    }
}
