using Cafe.Environment.Ingredients;

namespace Cafe.Environment
{
    public class Tray
    {
        public Sandwich Sandwich { get; private set; }

        public void Add(Ingredient ingredient)
        {
            Sandwich.Add(ingredient);
        }
    }
}