using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeOne_Repository
{
    public class CafeContent
    {
        // Meal Number
        public int Number { get; set; }

        // Meal Name
        public string Name { get; set; }

        // Meal Description
        public string Description { get; set; }

        // LIST of ingredients
        public string Ingredients { get; set; }

        // Price
        public double Price { get; set; }

        public CafeContent(int number, string name, string description, string ingredients, double price)
        {
            Number = number;
            Name = name;
            Description = description;
            Ingredients = ingredients;
            Price = price;
        }
    }
}
