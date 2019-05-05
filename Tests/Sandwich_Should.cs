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
        [Test]
        public void CreationTest()
        {
            var sandwich = new Sandwich();
            sandwich.Add(new Bread());
            sandwich.Add(new Meat());
            sandwich.Add(new Vegetables());
        }
    }
}
