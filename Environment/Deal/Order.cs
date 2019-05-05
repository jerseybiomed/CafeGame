using Cafe.Environment.Ingredients;

namespace Cafe.Environment.Deal
{
    public class Order
    {
        public Sandwich Sandwich { get; }

        public Order(Bread bread, Meat meat, Vegetables vegetables)
        {
            Sandwich = new Sandwich();
            Sandwich.Add(bread);
            Sandwich.Add(meat);
            Sandwich.Add(vegetables);
        }

        public static Order CreateRandomOrder()
        {
            return new Order(
                new Bread(),
                new Meat(),
                new Vegetables());
        }

        public bool Equals(Tray tray)
        {
            return Sandwich.Equals(tray?.Sandwich);
        }
    }
}