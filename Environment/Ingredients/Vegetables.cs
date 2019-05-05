namespace Cafe.Environment.Ingredients
{
    public class Vegetables : Ingredient { }

    public class Tomato : Vegetables { public static new int MaxCountOnStorage = 5; }
    public class Cucumber : Vegetables { public static new int MaxCountOnStorage = 6; }
    public class Salad : Vegetables { public static new int MaxCountOnStorage = 4; }
}