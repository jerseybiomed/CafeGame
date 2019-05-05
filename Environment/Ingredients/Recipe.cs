using Cafe.Environment.Ingredients;
using System.Collections.Generic;
using System.Linq;

namespace Cafe.Environment
{
    public class Recipe
    {
        public IEnumerable<Ingredient> Ingredients { get; }

        public Recipe(params Ingredient[] ingredients)
        {
            Ingredients = ingredients;
        }
        
        public bool Equals(Sandwich sandwich)
        {
            return Ingredients.SequenceEqual(new Ingredient[] {
                sandwich.Bread,
                sandwich.Meat,
                sandwich.Vegetables });
        }
    }
}