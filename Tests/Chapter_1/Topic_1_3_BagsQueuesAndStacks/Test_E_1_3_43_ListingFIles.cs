using System;
using NUnit.Framework;
using sedgewick_algorithms.Chapter_1.Topic_1_3_BagsQueuesAndStacks;

namespace Tests.Chapter_1.Topic_1_3_BagsQueuesAndStacks
{
    [TestFixture]
    public class Test_E_1_3_43_ListingFIles
    {
        [Test]
        public void Smoke()
        {
            var result = new E_1_3_43_ListingFiles().Solution("./../");
            Console.WriteLine(result);
        }
    }
}