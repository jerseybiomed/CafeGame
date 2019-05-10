using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cafe.Environment;
using Cafe.Environment.Deal;
using Cafe.Environment.Ingredients;

namespace Cafe.Tests
{
    [TestFixture]
    class GameplayTest
    {
        private static readonly Seller seller = new Seller();
        private static readonly BrownBread brown = new BrownBread();
        private static readonly RyeBread rye = new RyeBread();
        private static readonly WhiteBread white = new WhiteBread();
        private static readonly Beef beef = new Beef();
        private static readonly Hen hen = new Hen();
        private static readonly Pork pork = new Pork();
        private static readonly Tomato tomato = new Tomato();
        private static readonly Cucumber cucumber = new Cucumber();
        private static readonly Salad salad = new Salad();
        private static readonly Storage[,] storages = { 
            { new Storage(rye), new Storage(brown), new Storage(white) }, 
            { new Storage(beef), new Storage(hen), new Storage(pork) }, 
            { new Storage(tomato), new Storage(cucumber), new Storage(salad) } };

        [Test]
        public void SimpleTest()
        {
            var respect = 10;
            var firstCustomer = new Customer(new Order(rye, beef, tomato));
            var secondCustomer = new Customer(new Order(white, hen, salad));
            seller.GetNewOrder();
            seller.TakeIngredient(storages[0, 0]);
            seller.TakeIngredient(storages[1, 0]);
            seller.TakeIngredient(storages[2, 0]);
            Assert.AreEqual(rye, seller.Tray.Sandwich.Bread);
            Assert.AreEqual(beef, seller.Tray.Sandwich.Meat);
            Assert.AreEqual(tomato, seller.Tray.Sandwich.Vegetables);
            var firstResult = seller.Complete(firstCustomer);
            Assert.AreEqual(3, firstResult.ChangeRespect);
            seller.GetNewOrder();
            seller.TakeIngredient(storages[0, 2]);
            seller.TakeIngredient(storages[1, 1]);
            seller.TakeIngredient(storages[2, 1]);
            var secondResult = seller.Complete(secondCustomer);
            Assert.AreEqual(-10, secondResult.ChangeRespect);
            Assert.AreEqual(3, respect + firstResult.ChangeRespect + secondResult.ChangeRespect);
        }
    }
}
