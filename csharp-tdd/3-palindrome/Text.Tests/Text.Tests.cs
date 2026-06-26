using NUnit.Framework;
using Text;

namespace Text.Tests
{
    [TestFixture]
    public class StrTests
    {
        // ─── Happy Path ────────────────────────────────────────────

        [Test]
        public void IsPalindrome_SimplePalindrome_ReturnsTrue()
        {
            bool result = Str.IsPalindrome("racecar");
            Assert.IsTrue(result);
        }

        [Test]
        public void IsPalindrome_SimplePalindromeWithCapital_ReturnsTrue()
        {
            bool result = Str.IsPalindrome("Racecar");
            Assert.IsTrue(result);
        }

        [Test]
        public void IsPalindrome_WithSpacesAndPunctuation_ReturnsTrue()
        {
            bool result = Str.IsPalindrome("A man, a plan, a canal: Panama.");
            Assert.IsTrue(result);
        }

        // ─── False Cases ───────────────────────────────────────────

        [Test]
        public void IsPalindrome_NotPalindrome_ReturnsFalse()
        {
            bool result = Str.IsPalindrome("hello");
            Assert.IsFalse(result);
        }

        [Test]
        public void IsPalindrome_NotPalindromeWithMix_ReturnsFalse()
        {
            bool result = Str.IsPalindrome("No 'x' in Nixon"); // Actually it's a palindrome! But for variety we use "abc"
            // We'll use a clear negative: "abc"
            result = Str.IsPalindrome("abc");
            Assert.IsFalse(result);
        }

        // ─── Edge Cases ────────────────────────────────────────────

        [Test]
        public void IsPalindrome_EmptyString_ReturnsTrue()
        {
            bool result = Str.IsPalindrome("");
            Assert.IsTrue(result);
        }

        [Test]
        public void IsPalindrome_NullString_ReturnsTrue()
        {
            bool result = Str.IsPalindrome(null);
            Assert.IsTrue(result);
        }

        [Test]
        public void IsPalindrome_OnlySpaces_ReturnsTrue()
        {
            bool result = Str.IsPalindrome("   ");
            Assert.IsTrue(result);
        }

        [Test]
        public void IsPalindrome_OnlyPunctuation_ReturnsTrue()
        {
            bool result = Str.IsPalindrome("!@#");
            Assert.IsTrue(result);
        }

        [Test]
        public void IsPalindrome_WithNumbers_ReturnsTrue()
        {
            bool result = Str.IsPalindrome("12321");
            Assert.IsTrue(result);
        }

        [Test]
        public void IsPalindrome_WithMixedAlphanumeric_ReturnsTrue()
        {
            bool result = Str.IsPalindrome("A1b2b1a");
            Assert.IsTrue(result);
        }

        // ─── Parameterized Tests ──────────────────────────────────

        [TestCase("level", true)]
        [TestCase("radar", true)]
        [TestCase("hello", false)]
        [TestCase("Never odd or even", true)]
        public void IsPalindrome_VariousInputs(string input, bool expected)
        {
            bool result = Str.IsPalindrome(input);
            Assert.AreEqual(expected, result);
        }
    }
}