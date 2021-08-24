using NUnit.Framework;
using sedgewick_algorithms.Chapter_1.Topic_1_1_BasicProgrammingModel;

namespace Tests.Chapter_1.Topic_1_1_BasicProgrammingModel
{
    [TestFixture]
    public class Test_E_1_1_13_MatrixTransposition
    {
        [Test]
        public void Test1x2()
        {
            var input = new int[,]
            {
                { 1, 2 }
            };

            var result = new E_1_1_13_MatrixTransposition().TranspondMatrix(input);
            
            Assert.AreEqual(1, result[0,0]);
            Assert.AreEqual(2, result[1,0]);
        }
        
        [Test]
        public void Test2x2()
        {
            var input = new int[,]
            {
                { 1, 2 },
                { 3, 4 },
            };

            var result = new E_1_1_13_MatrixTransposition().TranspondMatrix(input);
            
            Assert.AreEqual(1, result[0,0]);
            Assert.AreEqual(3, result[0,1]);
            Assert.AreEqual(2, result[1,0]);
            Assert.AreEqual(4, result[1,1]);
        }
        
        [Test]
        public void Test2x3()
        {
            var input = new int[,]
            {
                { 1, 2 },
                { 3, 4 },
                { 5, 6 },
            };

            var result = new E_1_1_13_MatrixTransposition().TranspondMatrix(input);
            
            Assert.AreEqual(1, result[0,0]);
            Assert.AreEqual(3, result[0,1]);
            Assert.AreEqual(5, result[0,2]);
            Assert.AreEqual(2, result[1,0]);
            Assert.AreEqual(4, result[1,1]);
            Assert.AreEqual(6, result[1,2]);
        }
    }
}