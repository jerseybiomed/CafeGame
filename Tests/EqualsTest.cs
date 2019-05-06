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
    class EqualsTest
    {
        [Test]
        public void BreadEquals()
        {
            Assert.AreEqual(true, new WhiteBread().Equals(new WhiteBread()));
        }
    }
}
