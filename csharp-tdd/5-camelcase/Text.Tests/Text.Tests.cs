using NUnit.Framework;
using Text;

namespace Text.Tests
{
    [TestFixture]
    public class StrTests
    {
        // ─── Happy Path ────────────────────────────────────────────

        [Test]
        public void CamelCase_TwoWords_ReturnsTwo()
        {
            int result = Str.CamelCase("helloWorld");
            Assert.AreEqual(2, result);
        }

        [Test]
        public void CamelCase_ThreeWords_ReturnsThree()
        {
            int result = Str.CamelCase("helloWorldHow");
            Assert.AreEqual(3, result);
        }

        [Test]
        public void CamelCase_SingleWord_ReturnsOne()
        {
            int result = Str.CamelCase("hello");
            Assert.AreEqual(1, result);
        }

        [Test]
        public void CamelCase_WithMultipleCapitals_ReturnsCorrect()
        {
            int result = Str.CamelCase("thisIsATest");
            Assert.AreEqual(4, result); // this, Is, A, Test
        }

        [Test]
        public void CamelCase_AllUppercase_ReturnsLength()
        {
            int result = Str.CamelCase("HELLO");
            // Each letter is uppercase, so each is a new word
            Assert.AreEqual(5, result);
        }

        // ─── Edge Cases ────────────────────────────────────────────

        [Test]
        public void CamelCase_EmptyString_ReturnsZero()
        {
            int result = Str.CamelCase("");
            Assert.AreEqual(0, result);
        }

        [Test]
        public void CamelCase_NullString_ReturnsZero()
        {
            int result = Str.CamelCase(null);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void CamelCase_StringWithDigits_CountsOnlyLetters()
        {
            int result = Str.CamelCase("hello123World");
            // 'W' is a capital letter, so +1 word
            Assert.AreEqual(2, result);
        }

        [Test]
        public void CamelCase_StringWithSpecialChars_CountsOnlyLetters()
        {
            int result = Str.CamelCase("hello@World");
            Assert.AreEqual(2, result);
        }

        // ─── Parameterized Tests ──────────────────────────────────

        [TestCase("helloWorld", 2)]
        [TestCase("thisIsATest", 4)]
        [TestCase("one", 1)]
        [TestCase("camelCaseString", 3)]
        [TestCase("ABC", 3)]
        [TestCase("", 0)]
        [TestCase(null, 0)]
        public void CamelCase_VariousInputs(string input, int expected)
        {
            int result = Str.CamelCase(input);
            Assert.AreEqual(expected, result);
        }
    }
}