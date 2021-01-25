using System;
using System.Collections.Generic;

namespace Novemberprojekt
{
    public class Ingredient
    {
        //Boolen ska säga om varje ingrediens är rutten eller inte, stringsen ska innehålla ingrediensens namn och vilken kategori den tillhör, price bestämmer hur mycket den kostar
        private bool rotten;

        public string name = "";

        public string category = "";

        private Random generator = new Random();

        //Den här konstruktorn ska ge ingrediensen sitt namn och kategori, den ska även räkna ut med hjälp av slump om ingrediensen är rutten eller inte
        public Ingredient(string input){
            List<string> names = new List<string>() {"Chicken", "Beans", "Pepper", "Orange", "Lentils", "Mango", "Sausage", "Minced meat", "Pineapple"};
            
            List<string> Category = new List<string>() {"Meat", "Vegetable", "Fruit"};
            
            Console.WriteLine("In ingerefaf", input);
            if(input == "chicken"){
                name = names[0];

                category = Category[0];

            }
            else if(input == "beans"){
                name = names[1];

                category = Category[1];
            }
            else if(input == "pepper"){
                name = names[2];

                category = Category[1];

            }
            else if(input == "orange"){
                name = names[3];

                category = Category[2];
            }
            else if(input == "lentils"){
                name = names[4];

                category = Category[1];


            }
            else if(input == "mango"){
                name = names[5];

                category = Category[2];

            }
            else if(input == "sausage"){
                name = names[6];

                category = Category[0];

            }
            else if(input == "minced meat"){
                name = names[7];

                category = Category[0];


            }
            else if(input == "pineapple"){
                name = names[8];

                category = Category[2];

            }

             int a = generator.Next(1,5);

            if(a <= 4){
                rotten = false; 
            }
            else if(a == 5){
                rotten = true;
            }


            
            

            

        }
        
    }
}
