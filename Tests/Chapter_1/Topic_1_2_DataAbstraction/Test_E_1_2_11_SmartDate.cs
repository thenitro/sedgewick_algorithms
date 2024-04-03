using System;
using NUnit.Framework;
using sedgewick_algorithms.Chapter_1.Topic_1_2_DataAbstraction;

namespace Tests.Chapter_1.Topic_1_2_DataAbstraction
{
    [TestFixture]
    public class Test_E_1_2_11_SmartDate
    {
        [Test]
        [TestCase(-1, 1, 2024)]
        [TestCase(0, 1, 2024)]
        [TestCase(13, 1, 2024)]
        [TestCase(99, 1, 2024)]
        [TestCase(10000,  1, 2024)]
        public void WrongMonth(int month, int day, int year)
        {
            var exception = false;
            
            try
            {
                new SmartDate(month, day, year);
            }
            catch (Exception e)
            {
                exception = true;
            }
            
            Assert.True(exception);
        }
        
        [Test]
        [TestCase(1, -1, 2024)]
        [TestCase(1, 0, 2024)]
        [TestCase(2, 29, 2023)]
        [TestCase(1, 32, 2024)]
        public void WrongDay(int month, int day, int year)
        {
            var exception = false;
            
            try
            {
                new SmartDate(month, day, year);
            }
            catch (Exception e)
            {
                exception = true;
            }
            
            Assert.True(exception);
        }
    }
}