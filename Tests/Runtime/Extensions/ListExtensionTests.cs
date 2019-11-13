using NUnit.Framework;
using System.Collections.Generic;

namespace DapperDino.DapperTools.Tests.Extensions
{
    public class ListExtensionsTests
    {
        [Test]
        [TestCase(7)]
        [TestCase(1)]
        [TestCase(13)]
        public void FirstGetsFirstElementInList(int firstElement)
        {
            var list = new List<int> { firstElement, 2, 5 };

            var fetch = list.First();

            Assert.AreEqual(firstElement, fetch);
        }

        [Test]
        [TestCase(3)]
        [TestCase(15)]
        [TestCase(8)]
        public void LastGetsLastElementInList(int lastElement)
        {
            var list = new List<int> { 5, 2, lastElement };

            var fetch = list.Last();

            Assert.AreEqual(lastElement, fetch);
        }
    }
}
