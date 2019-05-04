using Cafe.Environment.Ingredients;

namespace Cafe.Environment
{
    public class Sandwich
    {
        public Bread Bread { get; private set; }
        public Meat Meat { get; private set; }
        public Vegetables Vegetables { get; private set; }
    }
}