namespace Cafe.Environment.Ingredients
{
    public class Meat : Ingredient { }
    
    public class Beef : Meat { protected static new int _maxCountOnStorage = 3; }
    public class Hen : Meat { protected static new int _maxCountOnStorage = 5; }
    public class Pork : Meat { protected static new int _maxCountOnStorage = 4; }
}
