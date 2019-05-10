namespace Cafe.Environment.Ingredients
{
    public class Meat : Ingredient {}

    public class Beef : Meat
    {
        protected static new int MaxCountOnStorage = 3;
        public override string ToString()
        {
            return $"Beef";
        }
    }
    public class Hen : Meat
    {
        protected static new int MaxCountOnStorage = 5;
        public override string ToString()
        {
            return $"Hen";
        }
    }
    public class Pork : Meat
    {
        protected static new int MaxCountOnStorage = 4;
        public override string ToString()
        {
            return $"Pork";
        }
    }
}