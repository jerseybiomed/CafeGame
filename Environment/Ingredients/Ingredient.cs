namespace Cafe.Environment.Ingredients
{
    public class Ingredient
    {
        protected int _maxCountOnStorage { get; set; }
        public int MaxCountOnStorage => _maxCountOnStorage;

        public override string ToString()
        {
            return $"Ingredient";
        }

        public bool Equals(Ingredient ingredient) =>
            ingredient != null && GetType() == ingredient.GetType();
    }
}