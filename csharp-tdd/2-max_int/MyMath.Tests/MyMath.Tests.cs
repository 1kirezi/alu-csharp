using NUnit.Framework;
using MyMath;
using System.Collections.Generic;

namespace MyMath.Tests
{
    [TestFixture]
    public class OperationsTests
    {
        // ─── Happy Path ────────────────────────────────────────────

        [Test]
        public void Max_PositiveNumbers_ReturnsMaximum()
        {
            var list = new List<int> { 3, 7, 2, 9, 5 };
            int result = Operations.Max(list);
            Assert.AreEqual(9, result);
        }

        [Test]
        public void Max_NegativeNumbers_ReturnsMaximum()
        {
            var list = new List<int> { -3, -7, -2, -9, -5 };
            int result = Operations.Max(list);
            Assert.AreEqual(-2, result);
        }

        [Test]
        public void Max_MixedNumbers_ReturnsMaximum()
        {
            var list = new List<int> { -5, 10, 0, -3, 8 };
            int result = Operations.Max(list);
            Assert.AreEqual(10, result);
        }

        [Test]
        public void Max_ListWithSingleElement_ReturnsThatElement()
        {
            var list = new List<int> { 42 };
            int result = Operations.Max(list);
            Assert.AreEqual(42, result);
        }

        // ─── Edge Cases ────────────────────────────────────────────

        [Test]
        public void Max_EmptyList_ReturnsZero()
        {
            var list = new List<int>();
            int result = Operations.Max(list);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Max_NullList_ReturnsZero()
        {
            int result = Operations.Max(null);
            Assert.AreEqual(0, result);
        }

        // ─── Using TestCase attribute ─────────────────────────────

        [TestCase(new int[] { 1, 2, 3, 4 }, 4)]
        [TestCase(new int[] { -1, -2, -3 }, -1)]
        [TestCase(new int[] { 0, 0, 0 }, 0)]
        [TestCase(new int[] { 100, 99, 101 }, 101)]
        public void Max_VariousLists_ReturnsExpected(int[] input, int expected)
        {
            var list = new List<int>(input);
            int result = Operations.Max(list);
            Assert.AreEqual(expected, result);
        }
    }
}