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
            System.Console.WriteLine("Are you ready to play? Press Y/N button (N exits the game)");

            ConsoleKeyInfo answer = Console.ReadKey();

            int game = 0;

            if(answer.Key == ConsoleKey.Y){
                game = 1;
                Console.Clear();
            }
            else if(answer.Key == ConsoleKey.N){
                return;
            }

            while(game == 1)
            {

                string input = "";

                System.Console.WriteLine("Welcome to the show, today you will be making a stew that will be judged by our jury!");
                System.Console.WriteLine("To make the stew you will have to choose 3 ingredients.");
                Console.Clear();
                System.Console.WriteLine("The list of ingredients is as follows: Chicken, minced meat, sausage, pepper, lentils, beans, orange, mango and pineapple.");
                System.Console.WriteLine("The jury consists of three judges, every judge likes different things.");
                
                Judge J1 = new Judge();
                Judge J2 = new Judge();
                Judge J3 = new Judge();

                if(J1.name == J2.name){
                    J1.name = "George";
                }
                else if(J1.name == J3.name){
                    J1.name ="George";
                }
                else if(J2.name == J3.name){
                    J2.name = "Caitlyn";
                }

                System.Console.WriteLine("Todays judges are " + J1.name + ", " + J2.name + " and" + J3.name + ".");
                System.Console.WriteLine("Press any button when you are ready.");
                Console.ReadKey();
                
                System.Console.WriteLine("Type what ingredient you want to use.");
                input = Console.ReadLine();

                    // while(input != "chicken") {

                    while(input.ToLower() != "chicken" && input.ToLower() != "minced meat" && input.ToLower() != "sausage" && input.ToLower() != "pepper" && input.ToLower() != "lentils" &&input.ToLower() != "beans" &&input.ToLower() != "orange"&& input.ToLower() != "mango"&&input.ToLower() != "pineapple"){
                    System.Console.WriteLine("Make sure you spell the ingredient correctly!");
                    System.Console.WriteLine("Type what ingredient you want to use.");
                    input = Console.ReadLine();
                    }

                    Console.WriteLine("input", input);
                    Ingredient I1 = new Ingredient(input);

                System.Console.WriteLine("You chose " + I1.name + " which is in the " + I1.category + " category.");
                
                System.Console.WriteLine("Type the next ingredient you want to use.");
                input = Console.ReadLine();

                while(input.ToLower() != "chicken" && input.ToLower() != "minced meat" && input.ToLower() != "sausage" && input.ToLower() != "pepper" && input.ToLower() != "lentils" &&input.ToLower() != "beans" &&input.ToLower() != "orange"&& input.ToLower() != "mango"&&input.ToLower() != "pineapple"){
                    System.Console.WriteLine("Make sure you spell the ingredient correctly!");
                    System.Console.WriteLine("Type what ingredient you want to use.");
                    input = Console.ReadLine();
                }

                Ingredient I2 = new Ingredient(input);

                System.Console.WriteLine("You chose " + I2.name + " which is in the " + I2.category + " category.");

                System.Console.WriteLine("Now type the last ingredient please.");
                input = Console.ReadLine();
                
                while(input.ToLower() != "chicken" && input.ToLower() != "minced meat" && input.ToLower() != "sausage" && input.ToLower() != "pepper" && input.ToLower() != "lentils" &&input.ToLower() != "beans" &&input.ToLower() != "orange"&& input.ToLower() != "mango"&&input.ToLower() == "pineapple"){
                    System.Console.WriteLine("Make sure you spell the ingredient correctly!");
                    System.Console.WriteLine("Type what ingredient you want to use.");
                    input = Console.ReadLine();
                }

                Ingredient I3 = new Ingredient(input);

                System.Console.WriteLine("You chose " + I3.name + " which is in the " + I3.category + " category.");

                System.Console.WriteLine("Ok! Now that you have chosen your three ingredients we will move on! Press any button when you are ready");

                Console.ReadKey();
                Console.Clear();

                System.Console.WriteLine("Now it's time for the chefs to taste your dish and give it a rating, their rating will be in between 1 and 5 stars and the michelin chef's rating counts twice!");

                if(I1.name == J1.likesIngredient){
                    J1.rating1 = 5;
                }
                else if(I1.category == J1.likesCategory){
                    J1.rating1 = 4;
                }
                else if(I1.name != J1.likesIngredient && I1.category != J1.likesCategory){
                    J1.rating1 = 1;
                }

                if(I2.name == J1.likesIngredient){
                    J1.rating2 = 5;
                }
                else if(I2.category == J1.likesCategory){
                    J1.rating2 = 4;
                }
                else if(I2.name != J1.likesIngredient && I2.category != J1.likesCategory){
                    J1.rating2 = 1;
                }

                if(I3.name == J1.likesIngredient){
                    J1.rating3 = 5;
                }
                else if(I3.category == J1.likesCategory){
                    J1.rating3 = 4;
                }
                else if(I3.name != J1.likesIngredient && I3.category != J1.likesCategory){
                    J1.rating3 = 1;
                }

                if(J1.rating1 == 5 && J1.rating2 == 4 && J1.rating3 == 4){
                    J1.totalRating = 5;
                }
                else if(J1.rating1 == 4 && J1.rating2 == 5 && J1.rating3 == 4){
                    J1.totalRating= 5;
                }
                else if(J1.rating1 == 4 && J1.rating2 == 4 && J1.rating3 == 5){
                    J1.totalRating = 5;
                }
                else if(J1.rating1 == 5 && J1.rating2 == 4 && J1.rating3 == 1){
                    J1.totalRating= 4;
                }
                else if(J1.rating1 == 5 && J1.rating2 == 1 && J1.rating3 == 4){
                    J1.totalRating = 4;
                }
                else if(J1.rating1 == 1 && J1.rating2 == 5 && J1.rating3 == 4){
                    J1.totalRating= 4;
                }
                else if(J1.rating1 == 1 && J1.rating2 == 4 && J1.rating3 == 5){
                    J1.totalRating = 4;
                }
                else if(J1.rating1 == 5 && J1.rating2 == 1 && J1.rating3 == 1){
                    J1.totalRating= 3;
                }
                else if(J1.rating1 == 1 && J1.rating2 == 5 && J1.rating3 == 1){
                    J1.totalRating = 3;
                }
                else if(J1.rating1 == 1 && J1.rating2 == 1 && J1.rating3 == 5){
                    J1.totalRating= 3;
                }
                else if(J1.rating1 == 4 && J1.rating2 == 4 && J1.rating3 == 4){
                    J1.totalRating = 4;
                }
                else if(J1.rating1 == 1 && J1.rating2 == 1 && J1.rating3 == 1){
                    J1.totalRating= 1;
                }
                else if(J1.rating1 == 4 && J1.rating2 == 1 && J1.rating3 == 1){
                    J1.totalRating = 2;
                }
                else if(J1.rating1 == 1 && J1.rating2 == 4 && J1.rating3 == 1){
                    J1.totalRating=2;
                }
                else if(J1.rating1 == 1 && J1.rating2 == 1 && J1.rating3 == 4){
                    J1.totalRating = 3;
                }
                else if(J1.rating1 == 4 && J1.rating2 == 4 && J1.rating3 == 1){
                    J1.totalRating= 3;
                }
                else if(J1.rating1 == 4 && J1.rating2 == 1 && J1.rating3 == 4){
                    J1.totalRating = 3;
                }
                else if(J1.rating1 == 1 && J1.rating2 == 4 && J1.rating3 == 4){
                    J1.totalRating= 3;
                }


                 if(I1.name == J2.likesIngredient){
                    J2.rating1 = 5;
                }
                else if(I1.category == J2.likesCategory){
                    J2.rating1 = 4;
                }
                else if(I1.name != J2.likesIngredient && I1.category != J2.likesCategory){
                    J2.rating1 = 1;
                }

                if(I2.name == J2.likesIngredient){
                    J2.rating2 = 5;
                }
                else if(I2.category == J2.likesCategory){
                    J2.rating2 = 4;
                }
                else if(I2.name != J2.likesIngredient && I2.category != J2.likesCategory){
                    J2.rating2 = 1;
                }

                if(I3.name == J2.likesIngredient){
                    J2.rating3 = 5;
                }
                else if(I3.category == J2.likesCategory){
                    J2.rating3 = 4;
                }
                else if(I3.name != J2.likesIngredient && I3.category != J2.likesCategory){
                    J2.rating3 = 1;
                }


                if(J2.rating1 == 5 && J2.rating2 == 4 && J2.rating3 == 4){
                    J2.totalRating = 5;
                }
                else if(J2.rating1 == 4 && J2.rating2 == 5 && J2.rating3 == 4){
                    J2.totalRating= 5;
                }
                else if(J2.rating1 == 4 && J2.rating2 == 4 && J2.rating3 == 5){
                    J2.totalRating = 5;
                }
                else if(J2.rating1 == 5 && J2.rating2 == 4 && J2.rating3 == 1){
                    J2.totalRating= 4;
                }
                else if(J2.rating1 == 5 && J2.rating2 == 1 && J2.rating3 == 4){
                    J2.totalRating = 4;
                }
                else if(J2.rating1 == 1 && J2.rating2 == 5 && J2.rating3 == 4){
                    J2.totalRating= 4;
                }
                else if(J2.rating1 == 1 && J2.rating2 == 4 && J2.rating3 == 5){
                    J2.totalRating = 4;
                }
                else if(J2.rating1 == 5 && J2.rating2 == 1 && J2.rating3 == 1){
                    J2.totalRating= 3;
                }
                else if(J2.rating1 == 1 && J2.rating2 == 5 && J2.rating3 == 1){
                    J2.totalRating = 3;
                }
                else if(J2.rating1 == 1 && J2.rating2 == 1 && J2.rating3 == 5){
                    J2.totalRating= 3;
                }
                else if(J2.rating1 == 4 && J2.rating2 == 4 && J2.rating3 == 4){
                    J2.totalRating = 4;
                }
                else if(J2.rating1 == 1 && J2.rating2 == 1 && J2.rating3 == 1){
                    J2.totalRating= 1;
                }
                else if(J2.rating1 == 4 && J2.rating2 == 1 && J2.rating3 == 1){
                    J2.totalRating = 2;
                }
                else if(J2.rating1 == 1 && J2.rating2 == 4 && J2.rating3 == 1){
                    J2.totalRating=2;
                }
                else if(J2.rating1 == 1 && J2.rating2 == 1 && J2.rating3 == 4){
                    J2.totalRating = 3;
                }
                else if(J2.rating1 == 4 && J2.rating2 == 4 && J2.rating3 == 1){
                    J2.totalRating= 3;
                }
                else if(J2.rating1 == 4 && J2.rating2 == 1 && J2.rating3 == 4){
                    J2.totalRating = 3;
                }
                else if(J2.rating1 == 1 && J2.rating2 == 4 && J2.rating3 == 4){
                    J2.totalRating= 3;
                }
        

                 if(I1.name == J3.likesIngredient){
                    J3.rating1 = 5;
                }
                else if(I1.category == J3.likesCategory){
                    J3.rating1 = 4;
                }
                else if(I1.name != J3.likesIngredient && I1.category != J3.likesCategory){
                    J3.rating1 = 1;
                }

                if(I2.name == J3.likesIngredient){
                    J3.rating2 = 5;
                }
                else if(I2.category == J3.likesCategory){
                    J3.rating2 = 4;
                }
                else if(I2.name != J3.likesIngredient && I2.category != J3.likesCategory){
                    J3.rating2 = 1;
                }

                if(I3.name == J3.likesIngredient){
                    J3.rating3 = 5;
                }
                else if(I3.category == J3.likesCategory){
                    J3.rating3 = 4;
                }
                else if(I3.name != J3.likesIngredient && I3.category != J3.likesCategory){
                    J3.rating3 = 1;
                }
                
                if(J2.rating1 == 5 && J3.rating2 == 4 && J3.rating3 == 4){
                    J3.totalRating = 5;
                }
                else if(J3.rating1 == 4 && J3.rating2 == 5 && J3.rating3 == 4){
                    J3.totalRating= 5;
                }
                else if(J3.rating1 == 4 && J3.rating2 == 4 && J3.rating3 == 5){
                    J3.totalRating = 5;
                }
                else if(J3.rating1 == 5 && J3.rating2 == 4 && J3.rating3 == 1){
                    J3.totalRating= 4;
                }
                else if(J3.rating1 == 5 && J3.rating2 == 1 && J3.rating3 == 4){
                    J3.totalRating = 4;
                }
                else if(J3.rating1 == 1 && J3.rating2 == 5 && J3.rating3 == 4){
                    J3.totalRating= 4;
                }
                else if(J3.rating1 == 1 && J3.rating2 == 4 && J3.rating3 == 5){
                    J3.totalRating = 4;
                }
                else if(J3.rating1 == 5 && J3.rating2 == 1 && J3.rating3 == 1){
                    J3.totalRating= 3;
                }
                else if(J3.rating1 == 1 && J3.rating2 == 5 && J3.rating3 == 1){
                    J3.totalRating = 3;
                }
                else if(J3.rating1 == 1 && J3.rating2 == 1 && J3.rating3 == 5){
                    J3.totalRating= 3;
                }
                else if(J3.rating1 == 4 && J3.rating2 == 4 && J3.rating3 == 4){
                    J3.totalRating = 4;
                }
                else if(J3.rating1 == 1 && J3.rating2 == 1 && J3.rating3 == 1){
                    J3.totalRating= 1;
                }
                else if(J3.rating1 == 4 && J3.rating2 == 1 && J3.rating3 == 1){
                    J3.totalRating = 2;
                }
                else if(J3.rating1 == 1 && J3.rating2 == 4 && J3.rating3 == 1){
                    J3.totalRating=2;
                }
                else if(J3.rating1 == 1 && J3.rating2 == 1 && J3.rating3 == 4){
                    J3.totalRating = 3;
                }
                else if(J3.rating1 == 4 && J3.rating2 == 4 && J3.rating3 == 1){
                    J3.totalRating= 3;
                }
                else if(J3.rating1 == 4 && J3.rating2 == 1 && J3.rating3 == 4){
                    J3.totalRating = 3;
                }
                else if(J3.rating1 == 1 && J3.rating2 == 4 && J3.rating3 == 4){
                    J3.totalRating= 3;
                }
                
                int soupRating = (J1.totalRating + J2.totalRating + J3.totalRating) / 3;

                System.Console.WriteLine("The judges are done! Your median score is " + soupRating +". Well done and thank you for playing.");
                System.Console.WriteLine("Press any key.");
                ConsoleKeyInfo answer2 = Console.ReadKey();
                game = 0;

                

                
            }
        }
    }
}
