namespace Cafe.Environment.Ingredients
{
    public class Meat : Ingredient { }
    
    public class Beef : Meat { public static new int MaxCountOnStorage = 3; }
    public class Hen : Meat { public static new int MaxCountOnStorage = 5; }
    public class Pork : Meat { public static new int MaxCountOnStorage = 4; }
}
