using Cafe.Environment.Ingredients;

namespace Cafe.Environment
{
    public class Tray
    {
        public Sandwich Sandwich { get; private set; }

        public void GetNewSandwich()
        {
            Sandwich = new Sandwich();
        }

        public void Add(Ingredient ingredient)
        {
            Sandwich.Add(ingredient);
        }
    }
}