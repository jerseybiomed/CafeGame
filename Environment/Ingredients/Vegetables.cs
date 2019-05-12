namespace Cafe.Environment.Ingredients
{
    public class Vegetables : Ingredient { }

    public class Tomato : Vegetables
    {
        public Tomato()
        {
            _maxCountOnStorage = 5;
        }

        public override string ToString()
        {
            return $"Tomato";
        }
    }
    public class Cucumber : Vegetables
    {
        public Cucumber()
        {
            _maxCountOnStorage = 6;
        }

        public override string ToString()
        {
            return $"Cucumber";
        }
    }
    public class Salad : Vegetables
    {
        public Salad()
        {
            _maxCountOnStorage = 4;
        }

        public override string ToString()
        {
            return $"Salad";
        }
    }
}