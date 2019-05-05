using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cafe.Environment;
using Cafe.Environment.Ingredients;

namespace Cafe.Tests
{
    [TestFixture]
    class Sandwich_Should
    {
        private readonly Sandwich sandwich = new Sandwich();
        private readonly BrownBread brown = new BrownBread();
        private readonly RyeBread rye = new RyeBread();
        private readonly WhiteBread white = new WhiteBread();
        private readonly Beef beef = new Beef();
        private readonly Hen hen = new Hen();
        private readonly Pork pork = new Pork();
        private readonly Tomato tomato = new Tomato();
        private readonly Cucumber cucumber = new Cucumber();
        private readonly Salad salad = new Salad();

        [Test]
        public void FirstAddBread()
        {
            sandwich.Add(rye);
            Assert.AreEqual(sandwich.Bread, rye);
        }

        [Test]
        public void SecondAddMeat()
        {
            sandwich.Add(beef);
            Assert.AreEqual(sandwich.Meat, beef);
        }

        [Test]
        public void ThirdAddVegetables()
        {
            sandwich.Add(tomato);
            Assert.AreEqual(sandwich.Vegetables, tomato);
        }

        [Test]
        public void WrongIngredientsOrder1()
        {
            var sandwich = new Sandwich();
            sandwich.Add(salad);
            Assert.AreEqual(sandwich.Vegetables, null);
        }

        [Test]
        public void WrongIngredientsOrder2()
        {
            var sandwich = new Sandwich();
            sandwich.Add(pork);
            Assert.AreEqual(sandwich.Meat, null);
        }

        [Test]
        public void WrongIngredientsOrder3()
        {
            var sandwich = new Sandwich();
            sandwich.Add(brown);
            sandwich.Add(salad);
            Assert.AreEqual(sandwich.Vegetables, null);
        }

        [Test]
        public void CanNotAddSecondBread()
        {
            var sandwich = new Sandwich();
            sandwich.Add(brown);
            sandwich.Add(white);
            Assert.AreNotEqual(sandwich.Bread, null);
            Assert.AreNotEqual(sandwich.Bread, white);
        }

        [Test]
        public void CanNotAddSecondMeat()
        {
            var sandwich = new Sandwich();
            sandwich.Add(rye);
            sandwich.Add(pork);
            sandwich.Add(hen);
            Assert.AreNotEqual(sandwich.Meat, null);
            Assert.AreNotEqual(sandwich.Meat, hen);
        }

        [Test]
        public void CanNotAddSecondVegetables()
        {
            var sandwich = new Sandwich();
            sandwich.Add(white);
            sandwich.Add(hen);
            sandwich.Add(salad);
            sandwich.Add(cucumber);
            Assert.AreNotEqual(sandwich.Vegetables, null);
            Assert.AreNotEqual(sandwich.Vegetables, cucumber);
        }
    }
}
