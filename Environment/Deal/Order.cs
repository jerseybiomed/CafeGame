using Cafe.Environment.Ingredients;
using System;

namespace Cafe.Environment.Deal
{
    public class Order
    {
        private Bread[] bread = new Bread[] { new WhiteBread(), new GreyBread(), new RyeBread() };
        private Meat[] meat = new Meat[] { new Beef(), new Pork(), new Hen() };
        private Vegetable[] vegetables = new Vegetable[] { new Tomato(), new Cucumber(), new Salad() };
        public Recipe Sandwich { get; }

        public Order(Bread bread, Meat meat, Vegetable vegetables)
        {
            Sandwich = new Recipe(
                bread,
                meat,
                vegetables);
        }

        public Order CreateRandomOrder()
        {
            var rnd = new Random();
            int breadNumber = rnd.Next(3);
            int meatNumber = rnd.Next(3);
            int vegetableNumber = rnd.Next(3);
            return new Order(
                bread[breadNumber], 
                meat[meatNumber], 
                vegetables[vegetableNumber]);
        }

        public bool Equals(Tray tray)
        {
            return Sandwich.Equals(tray.Sandwich);
        }
    }
}