namespace Cafe.Environment.Ingredients
{
    public class Vegetable : Ingredient { }

    public class Tomato : Vegetable
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
    public class Cucumber : Vegetable
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
    public class Salad : Vegetable
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