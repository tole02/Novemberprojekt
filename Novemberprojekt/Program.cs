using System;
using System.Collections.Generic;

namespace Novemberprojekt
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("This is a game where you are a chef taking part in a stew making competition.");
            System.Console.WriteLine("You are going to choose 3 ingredients for your stew and then present it to the judges.");
            System.Console.WriteLine("You only have a specific amount of money to buy the ingredients for and the ingredients can be rotten.");
            System.Console.WriteLine("The judges also have a specific taste and will rate your dish differently based upon what ingredients you use.");
            System.Console.WriteLine("Are you ready to play? Press Y/N button");

            ConsoleKeyInfo answer = Console.ReadKey();

            int game = 0;

            if(answer.Key == ConsoleKey.Y){
                game = 1;
            }
            else if(answer.Key == ConsoleKey.N){
                return;
            }

            while(game == 1)
            {
                
            }
            

            







            Console.ReadLine();
        }
    }
}
