using NUnit.Framework;
using sedgewick_algorithms.Chapter_1.Topic_1_3_BagsQueuesAndStacks;

namespace Tests.Chapter_1.Topic_1_3_BagsQueuesAndStacks
{
    [TestFixture]
    public class Test_E_1_3_35_BridgeDeck
    {
        [Test]
        public void Smoke()
        {
            var deck = new E_1_3_35_BridgeDeck();
            Assert.AreEqual(52, deck.Deck.Count);
            Assert.AreEqual(13, deck.DealHand().Count);
            Assert.AreEqual(13, deck.DealHand().Count);
            Assert.AreEqual(13, deck.DealHand().Count);
            Assert.AreEqual(13, deck.DealHand().Count);
            Assert.Zero(deck.Deck.Count);
        }
    }
}