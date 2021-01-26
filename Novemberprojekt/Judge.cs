using System;
using System.Collections.Generic;

namespace Novemberprojekt
{
    public class Judge
    {
        //Name ska innehålla domarens namn, likesingredient och likescategory bestämmer vilken kategori av ingrediens domaren gillar och vilken specifik ingrediens, rating variablerna är till för att räkna ut domarens betyg
        public string name = "";

        public string likesIngredient = "";

        public string likesCategory = "";

        public int rating1;

        public int rating2;

        public int rating3;

        public int totalRating;

        private Random generator = new Random();
        //Konstruktorn ska ge domaren ett namn, säga vilken ingrediens och kategori den gillar
        public Judge(){
            List<string> Names = new List<string>() {"James", "Anna", "Erik", "Simon", "Kim", "Robin"};

            List<string> Ingredients = new List<string>() {"Chicken", "Beans", "Pepper", "Orange", "Lentils", "Mango", "Sausage", "Minced meat", "Pineapple"};
            
            List<string> Category = new List<string>() {"Meat", "Vegetable", "Fruit"};
            //Slump används för att få ett random namn
            int d = generator.Next(1,7);

            if(d == 1){
                name = Names[0];
            }
            else if(d == 2){
                name = Names[1];
            }
            else if(d == 3){
                name = Names[2];
            }
            else if(d == 4){
                name = Names[3];
            }
            else if(d == 5){
                name = Names[4];
            }
            else if(d == 6){
                name = Names[5];
            }
            //Slump används även för att beräkna vilken kategori och ingrediens domaren gillar
            int a = generator.Next(1,4);

            if(a == 1){
                likesCategory = Category[0];

                int b = generator.Next(1,4);

                if(b == 1){
                    likesIngredient = Ingredients[0];
                }
                else if(b == 2){
                    likesIngredient = Ingredients[6];
                }
                else if(b == 3){
                    likesIngredient = Ingredients[7];
                }

            
            }
            else if(a == 2){
                likesCategory = Category[1];
                
                int b = generator.Next(1,4);

                if(b == 1){
                    likesIngredient = Ingredients[1];
                }
                else if(b == 2){
                    likesIngredient = Ingredients[2];
                }
                else if(b == 3){
                    likesIngredient = Ingredients[4];
                }
            }
            else if(a == 3){
                likesCategory = Category[2];

                int b = generator.Next(1,4);

                if(b == 1){
                    likesIngredient = Ingredients[3];
                }
                else if(b == 2){
                    likesIngredient = Ingredients[5];
                }
                else if(b == 3){
                    likesIngredient = Ingredients[8];
                }
            }

            





        
        }
    }
}
