namespace Cafe.Environment.Ingredients
{
    public class Meat : Ingredient {}

    public class Beef : Meat
    {
        public Beef()
        {
            _maxCountOnStorage = 3;
        }

        public override string ToString()
        {
            return $"Beef";
        }
    }
    public class Hen : Meat
    {
        public Hen()
        {
            _maxCountOnStorage = 5;
        }

        public override string ToString()
        {
            return $"Hen";
        }
    }
    public class Pork : Meat
    {
        public Pork()
        {
            _maxCountOnStorage = 4;
        }

        public override string ToString()
        {
            return $"Pork";
        }
    }
}