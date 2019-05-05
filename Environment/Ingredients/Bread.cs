namespace Cafe.Environment.Ingredients
{
    public class Bread : Ingredient { }

    public class BrownBread : Bread { public static new int MaxCountOnStorage = 3; }
    public class RyeBread : Bread { public static new int MaxCountOnStorage = 3; }
    public class WhiteBread : Bread{ public static new int MaxCountOnStorage = 3; }
}