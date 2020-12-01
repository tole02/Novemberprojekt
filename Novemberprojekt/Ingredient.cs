using System;
using System.Collections.Generic;

namespace Novemberprojekt
{
    public class Ingredient
    {
        private int rarity;

        private bool rotten;

        private string name = "";

        private string category = "";

        private int price;

        private Random generator = new Random();

        public Ingredient(string food){
            List<string> names = new List<string>() {"Chicken", "Beans", "Pepper", "Orange", "Lentils", "Mango", "Sausage", "Minced meat", "Pineapple"};
            
            List<string> Category = new List<string>() {"Meat", "Vegetable", "Fruit"};

            
        }
        
    }
}
