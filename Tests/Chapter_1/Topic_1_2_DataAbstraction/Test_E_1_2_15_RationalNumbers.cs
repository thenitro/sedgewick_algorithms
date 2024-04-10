using NUnit.Framework;
using sedgewick_algorithms.Chapter_1.Topic_1_2_DataAbstraction;

namespace Tests.Chapter_1.Topic_1_2_DataAbstraction
{
    [TestFixture]
    public class Test_E_1_2_15_RationalNumbers
    {
        [Test]
        public void SmokeGcd()
        {
            Assert.AreEqual(1, Rational.Gdc(1, 15));
            Assert.AreEqual(1, Rational.Gdc(2, 15));
            Assert.AreEqual(3, Rational.Gdc(3, 15));
            Assert.AreEqual(1, Rational.Gdc(4, 15));
            Assert.AreEqual(5, Rational.Gdc(5, 15));
        }

        [Test]
        public void SmokeEquals()
        {
            Assert.AreEqual(
                new Rational(1, 10),
                new Rational(1, 10));
            Assert.AreEqual(
                new Rational(-1, -10),
                new Rational(-1, -10));
        }

        [Test]
        public void SmokeToString()
        {
            Assert.AreEqual("[ Rational num=1, den=1 ]", new Rational(1, 1).ToString());
        }

        [Test]
        public void SmokeAddition()
        {
            Assert.AreEqual(new Rational(1, 15),
                new Rational(-3, 5) + new Rational(2, 3));
            
            Assert.AreEqual(new Rational(2, 3),
                new Rational(1, 3) + new Rational(1, 3));
            
            Assert.AreEqual(new Rational(0, 0),
                new Rational(1, -3) + new Rational(1, 3));
            
            Assert.AreEqual(new Rational(1, 2),
                new Rational(3, 10) + new Rational(2, 10));
        }
        
        [Test]
        public void SmokeSubtraction()
        {
            Assert.AreEqual(new Rational(19, -15),
                new Rational(-3, 5) - new Rational(2, 3));
            
            Assert.AreEqual(new Rational(0, 0),
                new Rational(1, 3) - new Rational(1, 3));
            
            Assert.AreEqual(new Rational(-2, 3),
                new Rational(1, -3) - new Rational(1, 3));
            
            Assert.AreEqual(new Rational(1, 10),
                new Rational(3, 10) - new Rational(2, 10));
        }
        
        [Test]
        public void SmokeMultiplication()
        {
            Assert.AreEqual(new Rational(-6, 15),
                new Rational(-3, 5) * new Rational(2, 3));
            
            Assert.AreEqual(new Rational(1, 9),
                new Rational(1, 3) * new Rational(1, 3));
            
            Assert.AreEqual(new Rational(1,  -9),
                new Rational(1, -3) * new Rational(1, 3));
            
            Assert.AreEqual(new Rational(6, 100),
                new Rational(3, 10) * new Rational(2, 10));
        }
        
        [Test]
        public void SmokeDivision()
        {
            Assert.AreEqual(new Rational(-9, 10),
                new Rational(-3, 5) / new Rational(2, 3));
            
            Assert.AreEqual(new Rational(1, 1),
                new Rational(1, 3) / new Rational(1, 3));
            
            Assert.AreEqual(new Rational(-1,  1),
                new Rational(1, -3) / new Rational(1, 3));
            
            Assert.AreEqual(new Rational(3, 2),
                new Rational(3, 10) / new Rational(2, 10));
        }
    }
}