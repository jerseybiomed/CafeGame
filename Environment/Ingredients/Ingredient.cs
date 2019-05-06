namespace Cafe.Environment.Ingredients
{
    public class Ingredient
    {
        private static int _maxCountOnStorage { get; }
        public int MaxCountOnStorage => _maxCountOnStorage;

        public override string ToString()
        {
            return $"Ingredient";
        }

        public bool Equals(Ingredient ingredient) =>
            ingredient != null && GetType() == ingredient.GetType();
    }
}