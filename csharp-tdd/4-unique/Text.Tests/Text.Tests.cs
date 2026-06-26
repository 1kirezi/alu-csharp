using NUnit.Framework;
using Text;

namespace Text.Tests
{
    [TestFixture]
    public class StrTests
    {
        // ─── Happy Path ────────────────────────────────────────────

        [Test]
        public void UniqueChar_AllUnique_ReturnsFirstIndex()
        {
            int result = Str.UniqueChar("abc");
            Assert.AreEqual(0, result); // 'a' appears only once
        }

        [Test]
        public void UniqueChar_RepeatedAtStart_ReturnsFirstUnique()
        {
            int result = Str.UniqueChar("aabc");
            Assert.AreEqual(2, result); // 'b' is first unique, index 2
        }

        [Test]
        public void UniqueChar_RepeatedAtEnd_ReturnsFirstUnique()
        {
            int result = Str.UniqueChar("abcc");
            Assert.AreEqual(0, result); // 'a' is unique at index 0
        }

        [Test]
        public void UniqueChar_MultipleRepeats_ReturnsCorrect()
        {
            int result = Str.UniqueChar("loveleetcode");
            Assert.AreEqual(2, result); // 'v' at index 2 is the first non‑repeating
        }

        // ─── No Unique Character ──────────────────────────────────

        [Test]
        public void UniqueChar_AllRepeated_ReturnsMinusOne()
        {
            int result = Str.UniqueChar("aabbcc");
            Assert.AreEqual(-1, result);
        }

        [Test]
        public void UniqueChar_EmptyString_ReturnsMinusOne()
        {
            int result = Str.UniqueChar("");
            Assert.AreEqual(-1, result);
        }

        [Test]
        public void UniqueChar_NullString_ReturnsMinusOne()
        {
            int result = Str.UniqueChar(null);
            Assert.AreEqual(-1, result);
        }

        // ─── Parameterized Tests ──────────────────────────────────

        [TestCase("abc", 0)]
        [TestCase("aabc", 2)]
        [TestCase("abcc", 0)]
        [TestCase("leetcode", 0)] // 'l' is first unique
        [TestCase("aabb", -1)]
        [TestCase("z", 0)]
        [TestCase("aa", -1)]
        public void UniqueChar_VariousInputs(string input, int expected)
        {
            int result = Str.UniqueChar(input);
            Assert.AreEqual(expected, result);
        }
    }
}