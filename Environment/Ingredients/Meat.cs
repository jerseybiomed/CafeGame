namespace Cafe.Environment.Ingredients
{
    public class Meat : Ingredient {}

    public class Beef : Meat
    {
        public static new int MaxCountOnStorage = 3;
        public override string ToString()
        {
            return $"Beef";
        }
    }
    public class Hen : Meat
    {
        public static new int MaxCountOnStorage = 5;
        public override string ToString()
        {
            return $"Hen";
        }
    }
    public class Pork : Meat
    {
        public static new int MaxCountOnStorage = 4;
        public override string ToString()
        {
            return $"Pork";
        }
    }
}