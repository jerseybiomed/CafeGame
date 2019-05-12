namespace Cafe.Environment.Ingredients
{
    public class Bread : Ingredient { }

    public class BrownBread : Bread
    {
        public BrownBread()
        {
            _maxCountOnStorage = 3;
        }

        public override string ToString()
        {
            return $"Brown";
        }
    }
    public class RyeBread : Bread
    {
        public RyeBread()
        {
            _maxCountOnStorage = 3;
        }

        public override string ToString()
        {
            return $"Rye";
        }
    }
    public class WhiteBread : Bread
    {
        public WhiteBread()
        {
            _maxCountOnStorage = 3;
        }

        public override string ToString()
        {
            return $"White";
        }
    }
}