using System;
using System.Collections.Generic;

namespace Novemberprojekt
{
    class Program
    {
        static void Main(string[] args)
        {
            //Text som berättar vad spelet handlar om och vad man ska göra
            System.Console.WriteLine("This is a game where you are a chef taking part in a stew making competition.");
            System.Console.WriteLine("You are going to choose 3 ingredients for your stew and then present it to the judges.");
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
            //spelet är en while så att man ska kunna spela om(även om jag inte fått detta att funka)
            while(game == 1)
            {

                string input = "";
                //Mer information, en lista på ingredienserna och lite mer om hur spelet fungerar
                System.Console.WriteLine("Welcome to the show, today you will be making a stew that will be judged by our jury!");
                System.Console.WriteLine("To make the stew you will have to choose 3 ingredients.");
                Console.Clear();
                System.Console.WriteLine("The list of ingredients is as follows: Chicken, minced meat, sausage, pepper, lentils, beans, orange, mango and pineapple.");
                System.Console.WriteLine("The jury consists of three judges, every judge likes different things.");
                //Tre domarinstanser skapas, de får olika namn och gillar olika ingredienser
                Judge J1 = new Judge();
                Judge J2 = new Judge();
                Judge J3 = new Judge();
                //Om domarna får samma namn gör dessa if satser så att de får unika namn
                if(J1.name == J2.name){
                    J1.name = "George";
                }
                else if(J1.name == J3.name){
                    J1.name ="George";
                }
                else if(J2.name == J3.name){
                    J2.name = "Caitlyn";
                }
                //Domarnas namn skrivs ut och spelaren kan börja skriva vilka ingredienser den vill använda
                System.Console.WriteLine("Todays judges are " + J1.name + ", " + J2.name + " and " + J3.name + ".");
                System.Console.WriteLine("Press any button when you are ready.");
                Console.ReadKey();
                
                System.Console.WriteLine("Type what ingredient you want to use.");
                input = Console.ReadLine();
                    //Om spelaren inte skriver en ingrediens får den ett felmeddelande och måste skriva om
                    while(input.ToLower() != "chicken" && input.ToLower() != "minced meat" && input.ToLower() != "sausage" && input.ToLower() != "pepper" && input.ToLower() != "lentils" &&input.ToLower() != "beans" &&input.ToLower() != "orange"&& input.ToLower() != "mango"&&input.ToLower() != "pineapple"){
                    System.Console.WriteLine("Make sure you spell the ingredient correctly and that you aren't writing the same ingredient twice!");
                    System.Console.WriteLine("Type what ingredient you want to use.");
                    input = Console.ReadLine();
                    }
                    //En ingrediensinstans med namnet av det spelaren skrev in skapas
                    Ingredient I1 = new Ingredient(input);

                System.Console.WriteLine("You chose " + I1.name + " which is in the " + I1.category + " category.");
                
                System.Console.WriteLine("Type the next ingredient you want to use.");
                input = Console.ReadLine();

                while(input.ToLower() != "chicken" && input.ToLower() != "minced meat" && input.ToLower() != "sausage" && input.ToLower() != "pepper" && input.ToLower() != "lentils" &&input.ToLower() != "beans" &&input.ToLower() != "orange"&& input.ToLower() != "mango"&&input.ToLower() != "pineapple" && input == I1.name){
                    System.Console.WriteLine("Make sure you spell the ingredient correctly and that you aren't writing the same ingredient twitce!");
                    System.Console.WriteLine("Type what ingredient you want to use.");
                    input = Console.ReadLine();
                }

                Ingredient I2 = new Ingredient(input);

                System.Console.WriteLine("You chose " + I2.name + " which is in the " + I2.category + " category.");

                System.Console.WriteLine("Now type the last ingredient please.");
                input = Console.ReadLine();
                
                while(input.ToLower() != "chicken" && input.ToLower() != "minced meat" && input.ToLower() != "sausage" && input.ToLower() != "pepper" && input.ToLower() != "lentils" &&input.ToLower() != "beans" &&input.ToLower() != "orange"&& input.ToLower() != "mango"&&input.ToLower() != "pineapple" && input == I2.name){
                    System.Console.WriteLine("Make sure you spell the ingredient correctly and that you aren't writing the same ingredient twice!");
                    System.Console.WriteLine("Type what ingredient you want to use.");
                    input = Console.ReadLine();
                }

                Ingredient I3 = new Ingredient(input);

                System.Console.WriteLine("You chose " + I3.name + " which is in the " + I3.category + " category.");
                //När spelaren valt tre ingredienser går den vidare och domarna ska betygsätta maten
                System.Console.WriteLine("Ok! Now that you have chosen your three ingredients we will move on! Press any button when you are ready");

                Console.ReadKey();
                Console.Clear();

                System.Console.WriteLine("Now it's time for the chefs to taste your dish and give it a rating, their rating will be in between 1 and 5 stars and then you will get a total rating based on their ratings!");
                //Dessa if satser beräknar vilket betyg varje domare ger maten, den jämför värdena som domarinstanserna har, likesIngredient och likesCategory, med ingrediensernas namn och ger sedan betyg
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

                //Här lägger den samman deras betyg baserat på varje ingrediens och ger ett slutligt betyg för varje domare
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
                //Här läggs alla domarnas betyg ihops för att ge medelvärdet
                int soupRating = (J1.totalRating + J2.totalRating + J3.totalRating) / 3;
                //Varje individuell domares betyg ges och medelvärdet skrivs ut sen stängs spelet av
                System.Console.WriteLine("The judges are done! " + J1.name + " gives it a rating of " + J1.totalRating + " stars, " + J2.name + " gives it a rating of " + J2.totalRating + " stars and " + J3.name + " gives it a rating of " + J3.totalRating + " stars.");
                System.Console.WriteLine("That gives your dish a mean score of " + soupRating + " stars! Thank you for playing.");
                System.Console.WriteLine("Press any key to exit.");
                ConsoleKeyInfo answer2 = Console.ReadKey();
                game = 0;

                

                
            }
        }
    }
}
