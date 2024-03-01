using NUnit.Framework;
using sedgewick_algorithms.Chapter_1.Topic_1_1_BasicProgrammingModel;

namespace Tests.Chapter_1.Topic_1_1_BasicProgrammingModel
{
    [TestFixture]
    public class Test_E_1_1_33_MatrixLibrary
    {
        [Test]
        public void DotSmoke()
        {
            var x = new[] { 2.0, 0.0 };
            var y = new[] { 0.0, 2.0 };

            Assert.AreEqual(0, E_1_1_33_MatrixLibrary.Dot(x, y));

            x = new[] { 1.0, 3.0, -5.0 };
            y = new[] { 4.0, -2.0, -1.0 };

            Assert.AreEqual(3.0, E_1_1_33_MatrixLibrary.Dot(x, y));
        }

        [Test]
        public void MatrixMatrixMultSmoke()
        {
            var a = new[]
            {
                new[] { 2.0, 2.0, 2.0 },
                new[] { 2.0, 2.0, 2.0 },
                new[] { 2.0, 2.0, 2.0 },
                new[] { 2.0, 2.0, 2.0 },
            };
            
            var b = new[]
            {
                new[] { 2.0, 2.0, 2.0, 2.0 },
                new[] { 2.0, 2.0, 2.0, 2.0 },
                new[] { 2.0, 2.0, 2.0, 2.0 },
            };

            var c = E_1_1_33_MatrixLibrary.Mult(a, b);

            var m = c.Length;
            var n = c[0].Length;
            
            Assert.AreEqual(a.Length, m);
            Assert.AreEqual(b[0].Length, n);

            for (var row = 0; row < m; row++)
            {
                for (var col = 0; col < n; col++)
                {
                    Assert.AreEqual(12, c[row][col]);
                }
            }
        }

        [Test]
        public void SmokeTranspose()
        {
            var a = new[]
            {
                new[] { 1.0, 2.0 },
                new[] { 3.0, 4.0 },
                new[] { 5.0, 6.0 },
            };

            var expected = new[]
            {
                new[] { 1.0, 3.0, 5.0 },
                new[] { 2.0, 4.0, 6.0 },
            };

            var m = expected.Length;
            var n = expected[0].Length;

            var c = E_1_1_33_MatrixLibrary.Transpose(a);
            
            Assert.AreEqual(m, c.Length);
            Assert.AreEqual(n, c[0].Length);

            for (var row = 0; row < m; row++)
            {
                for (var col = 0; col < n; col++)
                {
                    Assert.AreEqual(expected[row][col], c[row][col]);
                }
            }
        }

        [Test]
        public void MatrixVectorMultSmoke()
        {
            var a = new[]
            {
                new[] { 1.0, -1.0, 2.0 },
                new[] { 0.0, -3.0, 1.0 },
            };

            var x = new[] { 2.0, 1.0, 0.0 };

            var expected = new[] { 1.0, -3.0 };

            var result = E_1_1_33_MatrixLibrary.Mult(a, x);
            
            Assert.AreEqual(expected.Length, result.Length);

            for (var i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }
        
        [Test]
        public void VectorMatrixMultSmoke()
        {
            var x = new[] { 2.0, 1.0, 0.0 };
            
            var a = new[]
            {
                new[] { 1.0, -1.0, 2.0 },
                new[] { 0.0, -3.0, 1.0 },
            };

            var expected = new[] { 2.0, -4.0, 0.0 };

            var result = E_1_1_33_MatrixLibrary.Mult(x, a);
            
            Assert.AreEqual(expected.Length, result.Length);

            for (var i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }
    }
}