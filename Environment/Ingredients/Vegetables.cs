namespace Cafe.Environment.Ingredients
{
    public class Vegetables : Ingredient { }

    public class Tomato : Vegetables
    {
        public static new int MaxCountOnStorage = 5;

        public override string ToString()
        {
            return $"Tomato";
        }
    }
    public class Cucumber : Vegetables
    {
        public static new int MaxCountOnStorage = 6;

        public override string ToString()
        {
            return $"Cucumber";
        }
    }
    public class Salad : Vegetables
    {
        public static new int MaxCountOnStorage = 4;

        public override string ToString()
        {
            return $"Salad";
        }
    }
}