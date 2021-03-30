using NUnit.Framework;
using System.Collections.Generic;
using GildedRose;
namespace TestGildedRose
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public virtual void testNormalItemDecrementQuality()
        {
            GildedRose.GildedRose.items = new List<Item>();
            int inputQuality = 20;
            Item item = new Item("+5 Dexterity Vest", 10, inputQuality);

            GildedRose.GildedRose.items.Add(item);
            GildedRose.GildedRose.updateQuality();

            int expectedQuality = inputQuality - 1;

            Assert.AreEqual(expectedQuality, item.Quality);
            Assert.Pass("Prueba Exitosa!");
        }
        [Test]
        public virtual void testNormalItemDoubleDecrementQuality()
        {
            GildedRose.GildedRose.items = new List<Item>();
            int inputQuality = 20;
            Item item = new Item("+5 Dexterity Vest", 0, inputQuality);

            GildedRose.GildedRose.items.Add(item);
            GildedRose.GildedRose.updateQuality();

            int expectedQuality = inputQuality - 2;

            Assert.AreEqual(expectedQuality, item.Quality);
            Assert.Pass("Prueba Exitosa!");
        }
        [Test]
        public virtual void testNormalItemZeroQuality()
        {
            GildedRose.GildedRose.items = new List<Item>();
            int inputQuality = 0;
            Item item = new Item("+5 Dexterity Vest", 0, inputQuality);

            GildedRose.GildedRose.items.Add(item);
            GildedRose.GildedRose.updateQuality();

            int expectedQuality = 0;

            Assert.AreEqual(expectedQuality, item.Quality);
            Assert.Pass("Prueba Exitosa!");
        }
        [Test]
        public virtual void testItemSufurasLegendary()
        {
            GildedRose.GildedRose.items = new List<Item>();
            int inputQuality = 80;
            Item item = new Item("Sulfuras, Hand of Ragnaros", 15, inputQuality);

            GildedRose.GildedRose.items.Add(item);
            GildedRose.GildedRose.updateQuality();

            int expectedQuality = 80;

           Assert.AreEqual(expectedQuality, item.Quality);
            Assert.Pass("Prueba Exitosa!");
        }
        [Test]
        public virtual void testItemNoGreaterThan50()
        {
            GildedRose.GildedRose.items = new List<Item>();
            int inputQuality = 50;
            Item item = new Item("Aged Brie", 20, inputQuality);

            GildedRose.GildedRose.items.Add(item);
            GildedRose.GildedRose.updateQuality();

            int expectedQuality = 50;

            Assert.AreEqual(expectedQuality, item.Quality);
            Assert.Pass("Prueba Exitosa!");
        }
        [Test]
        public virtual void testbackstageIncrementsQuality()
        {
            GildedRose.GildedRose.items = new List<Item>();
            int inputQuality = 20;
            Item item = new Item("Backstage passes to a TAFKAL80ETC concert", 15, inputQuality);

            GildedRose.GildedRose.items.Add(item);
            GildedRose.GildedRose.updateQuality();

            int expectedQuality = inputQuality + 1;

            Assert.AreEqual(expectedQuality, item.Quality);
            Assert.Pass("Prueba Exitosa!");
        }
        [Test]
        public virtual void testbackstageDoubleIncrementQuality()
        {
            GildedRose.GildedRose.items = new List<Item>();
            int inputQuality = 20;
            Item item = new Item("Backstage passes to a TAFKAL80ETC concert", 10, inputQuality);

            GildedRose.GildedRose.items.Add(item);
            GildedRose.GildedRose.updateQuality();

            int expectedQuality = inputQuality + 2;

            Assert.AreEqual(expectedQuality, item.Quality);
            Assert.Pass("Prueba Exitosa!");
        }
        [Test]
        public virtual void testBackstageTripleIncrementQuality()
        {
            GildedRose.GildedRose.items = new List<Item>();
            int inputQuality = 20;
            Item item = new Item("Backstage passes to a TAFKAL80ETC concert", 5, inputQuality);

            GildedRose.GildedRose.items.Add(item);
            GildedRose.GildedRose.updateQuality();

            int expectedQuality = inputQuality + 3;

            Assert.AreEqual(expectedQuality, item.Quality);
            Assert.Pass("Prueba Exitosa!");
        }
        [Test]
        public virtual void testBackstageZeroQuality()
        {
            GildedRose.GildedRose.items = new List<Item>();
            int inputQuality = 20;
            Item item = new Item("Backstage passes to a TAFKAL80ETC concert", 0, inputQuality);

            GildedRose.GildedRose.items.Add(item);
            GildedRose.GildedRose.updateQuality();

            int expectedQuality = 0;

            Assert.AreEqual(expectedQuality, item.Quality);
            Assert.Pass("Prueba Exitosa!");
        }
        [Test]
        public virtual void testConjuredDecrementQuality()
        {
            GildedRose.GildedRose.items = new List<Item>();
            int inputQuality = 20;
            Item item = new Item("Conjured Mana Cake", 15, inputQuality);

            GildedRose.GildedRose.items.Add(item);
            GildedRose.GildedRose.updateQuality();

            int expectedQuality = inputQuality - 2;

            Assert.AreEqual(expectedQuality, item.Quality);
            Assert.Pass("Prueba Exitosa!");
        }
        [Test]
        public virtual void testConjuredNonZeroQuality()
        {
            GildedRose.GildedRose.items = new List<Item>();
            int inputQuality = 0;
            Item item = new Item("Conjured Mana Cake", 15, inputQuality);

            GildedRose.GildedRose.items.Add(item);
            GildedRose.GildedRose.updateQuality();

            int expectedQuality = 0;

            Assert.AreEqual(expectedQuality, item.Quality);
            Assert.Pass("Prueba Exitosa!");
        }
        [Test]
        public virtual void testConjuredAlternativeNonZeroQuality()
        {
            GildedRose.GildedRose.items = new List<Item>();
            int inputQuality = 1;
            Item item = new Item("Conjured Mana Cake", 15, inputQuality);

            GildedRose.GildedRose.items.Add(item);
            GildedRose.GildedRose.updateQuality();

            int expectedQuality = 0;

            Assert.AreEqual(expectedQuality, item.Quality);
            Assert.Pass("Prueba Exitosa!");
        }
    }
}