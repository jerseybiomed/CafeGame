namespace Cafe.Environment.Ingredients
{
    public class Bread : Ingredient { }

    public class BrownBread : Bread
    {
        public static new int MaxCountOnStorage = 3;

        public override string ToString()
        {
            return $"Brown";
        }
    }
    public class RyeBread : Bread
    {
        public static new int MaxCountOnStorage = 3;

        public override string ToString()
        {
            return $"Rye";
        }
    }
    public class WhiteBread : Bread
    {
        public static new int MaxCountOnStorage = 3;

        public override string ToString()
        {
            return $"White";
        }
    }
}