namespace Cafe.Environment.Ingredients
{
    public class Vegetables : Ingredient { }

    public class Tomato : Vegetables
    {
        protected static new int MaxCountOnStorage = 5;
        public override string ToString()
        {
            return $"Tomato";
        }
    }
    public class Cucumber : Vegetables
    {
        protected static new int MaxCountOnStorage = 6;
        public override string ToString()
        {
            return $"Cucumber";
        }
    }
    public class Salad : Vegetables
    {
        protected static new int MaxCountOnStorage = 4;
        public override string ToString()
        {
            return $"Salad";
        }
    }
}