using NUnit.Framework;
using MyMath;
using System.IO;

namespace MyMath.Tests
{
    [TestFixture]
    public class MatrixTests
    {
        // ─── Happy Path ────────────────────────────────────────────

        [Test]
        public void Divide_ValidMatrixAndPositiveNum_ReturnsDividedMatrix()
        {
            int[,] input = { { 10, 20 }, { 30, 40 } };
            int divisor = 2;
            int[,] expected = { { 5, 10 }, { 15, 20 } };

            int[,] result = Matrix.Divide(input, divisor);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Divide_ValidMatrixAndNegativeNum_ReturnsDividedMatrix()
        {
            int[,] input = { { 10, -20 }, { 30, -40 } };
            int divisor = -2;
            int[,] expected = { { -5, 10 }, { -15, 20 } };

            int[,] result = Matrix.Divide(input, divisor);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Divide_WithTruncation_ReturnsTruncatedIntegers()
        {
            int[,] input = { { 5, -5 } };
            int divisor = 2;
            int[,] expected = { { 2, -2 } };

            int[,] result = Matrix.Divide(input, divisor);

            Assert.AreEqual(expected, result);
        }

        // ─── Division by Zero ─────────────────────────────────────

        [Test]
        public void Divide_DivisorZero_PrintsMessageAndReturnsNull()
        {
            int[,] input = { { 1, 2 }, { 3, 4 } };
            int divisor = 0;

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                int[,] result = Matrix.Divide(input, divisor);

                Assert.IsNull(result);
                string consoleOutput = sw.ToString().Trim();
                Assert.AreEqual("Num cannot be 0", consoleOutput);
            }
        }

        // ─── Null Matrix ──────────────────────────────────────────

        [Test]
        public void Divide_MatrixNull_ReturnsNull()
        {
            int[,] result = Matrix.Divide(null, 5);
            Assert.IsNull(result);
        }

        // ─── Edge Cases ────────────────────────────────────────────

        [Test]
        public void Divide_EmptyMatrix_ReturnsEmptyMatrix()
        {
            int[,] input = new int[0, 0];
            int divisor = 3;
            int[,] expected = new int[0, 0];

            int[,] result = Matrix.Divide(input, divisor);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Divide_MatrixWithZeroElements_ReturnsZeroMatrix()
        {
            int[,] input = { { 0, 0 }, { 0, 0 } };
            int divisor = 5;
            int[,] expected = { { 0, 0 }, { 0, 0 } };

            int[,] result = Matrix.Divide(input, divisor);

            Assert.AreEqual(expected, result);
        }
    }
}
