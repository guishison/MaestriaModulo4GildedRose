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
            List<Item> lista = new List<Item>();
            lista.Add(new Item("+5 Dexterity Vest", 10, 5));
            lista.Add(new Item("+5 Dexterity Vest", 5, 2));
            lista.Add(new Item("+5 Dexterity Vest", 20, 21));
            List<int> listaQuality = new List<int>();
            listaQuality.Add(5);
            listaQuality.Add(2);
            listaQuality.Add(21);

            GildedRose.GildedRose.items = new List<Item>();
            GildedRose.GildedRose.items = lista;
            GildedRose.GildedRose.updateQuality();
            for (int i = 0; i < lista.Count; i++)
            {
                int expectedQuality = listaQuality[i] - 1;
                Assert.AreEqual(expectedQuality, lista[i].Quality);
                
            }
        }
        [Test]
        public virtual void testNormalItemDoubleDecrementQuality()
        {
            List<Item> lista = new List<Item>();
            lista.Add(new Item("+5 Dexterity Vest", 0, 10));
            lista.Add(new Item("+5 Dexterity Vest", 0, 15));
            lista.Add(new Item("+5 Dexterity Vest", 0, 20));
            List<int> listaQuality = new List<int>();
            listaQuality.Add(10);
            listaQuality.Add(15);
            listaQuality.Add(20);

            GildedRose.GildedRose.items = new List<Item>();
            GildedRose.GildedRose.items = lista;
            GildedRose.GildedRose.updateQuality();
            for (int i = 0; i < lista.Count; i++)
            {
                int expectedQuality = listaQuality[i] - 2;
                Assert.AreEqual(expectedQuality, lista[i].Quality);
                
            }
        }
        [Test]
        public virtual void testNormalItemZeroQuality()
        {
            List<Item> lista = new List<Item>();
            lista.Add(new Item("+5 Dexterity Vest", 0, 0));
            lista.Add(new Item("+5 Dexterity Vest", -1, 0));
            lista.Add(new Item("+5 Dexterity Vest", -10, 0));
            List<int> listaQuality = new List<int>();
            listaQuality.Add(0);
            listaQuality.Add(0);
            listaQuality.Add(0);

            GildedRose.GildedRose.items = new List<Item>();
            GildedRose.GildedRose.items = lista;
            GildedRose.GildedRose.updateQuality();
            for (int i = 0; i < lista.Count; i++)
            {
                int expectedQuality = listaQuality[i];
                Assert.AreEqual(expectedQuality, lista[i].Quality);
                
            }
        }
        [Test]
        public virtual void testItemSufurasLegendary()
        {
            List<Item> lista = new List<Item>();
            lista.Add(new Item("Sulfuras, Hand of Ragnaros", 15, 80));
            lista.Add(new Item("Sulfuras, Hand of Ragnaros", 25, 80));
            lista.Add(new Item("Sulfuras, Hand of Ragnaros", 0, 80));
            List<int> listaQuality = new List<int>();
            listaQuality.Add(80);
            listaQuality.Add(80);
            listaQuality.Add(80);

            GildedRose.GildedRose.items = new List<Item>();
            GildedRose.GildedRose.items = lista;
            GildedRose.GildedRose.updateQuality();
            for (int i = 0; i < lista.Count; i++)
            {
                int expectedQuality = listaQuality[i];
                Assert.AreEqual(expectedQuality, lista[i].Quality);
                
            }
        }
        [Test]
        public virtual void testItemNoGreaterThan50()
        {
            List<Item> lista = new List<Item>();
            lista.Add(new Item("Sulfuras, Hand of Ragnaros", 15, 50));
            lista.Add(new Item("Aged Brie", 25, 50));
            lista.Add(new Item("Backstage passes to a TAFKAL80ETC concert", 10, 50));
            List<int> listaQuality = new List<int>();
            listaQuality.Add(50);
            listaQuality.Add(50);
            listaQuality.Add(50);

            GildedRose.GildedRose.items = new List<Item>();
            GildedRose.GildedRose.items = lista;
            GildedRose.GildedRose.updateQuality();
            for (int i = 0; i < lista.Count; i++)
            {
                int expectedQuality = listaQuality[i];
                Assert.AreEqual(expectedQuality, lista[i].Quality);
                
            }
        }
        [Test]
        public virtual void testItemIncreasesQualityEveryTimeThePriceReduced()
        {
            GildedRose.GildedRose.items = new List<Item>();
            int inputQuality = 40;
            Item item = new Item("Aged Brie", 20, inputQuality);

            GildedRose.GildedRose.items.Add(item);
            GildedRose.GildedRose.updateQuality();

            int expectedQuality = 41;

            Assert.AreEqual(expectedQuality, item.Quality);
            
        }
        //[Test]
        //public virtual void testbackstageIncrementsQuality()
        //{
        //    //GildedRose.GildedRose.items = new List<Item>();
        //    //int inputQuality = 20;
        //    //Item item = new Item("Backstage passes to a TAFKAL80ETC concert", 15, inputQuality);

        //    //GildedRose.GildedRose.items.Add(item);
        //    //GildedRose.GildedRose.updateQuality();

        //    //int expectedQuality = inputQuality + 1;

        //    //Assert.AreEqual(expectedQuality, item.Quality);
              
  
  
 
 
   
  
        //    List<Item> lista = new List<Item>();
        //    lista.Add(new Item("Backstage passes to a TAFKAL80ETC concert", 20, 10));
        //    lista.Add(new Item("Backstage passes to a TAFKAL80ETC concert", 17, 13));
        //    lista.Add(new Item("Backstage passes to a TAFKAL80ETC concert", 11, 19));
        //    lista.Add(new Item("Backstage passes to a TAFKAL80ETC concert", 7, 304));
        //    lista.Add(new Item("Backstage passes to a TAFKAL80ETC concert", 6, 608));
        //    lista.Add(new Item("Backstage passes to a TAFKAL80ETC concert", 3, 16416));
        //    lista.Add(new Item("Backstage passes to a TAFKAL80ETC concert", 0, 443232));
        //    List<int> listaQuality = new List<int>();
        //    listaQuality.Add(11);
        //    listaQuality.Add(14);
        //    listaQuality.Add(38);
        //    listaQuality.Add(608);
        //    listaQuality.Add(1824);
        //    listaQuality.Add(49248);
        //    listaQuality.Add(0);

        //    GildedRose.GildedRose.items = new List<Item>();
        //    GildedRose.GildedRose.items = lista;
        //    GildedRose.GildedRose.updateQuality();
        //    for (int i = 0; i < lista.Count; i++)
        //    {
        //        int expectedQuality = listaQuality[i];
        //        Assert.AreEqual(expectedQuality, lista[i].Quality);

        //    }
        //}
        [Test]
        public virtual void testbackstageDoubleIncrementQuality()
        {
            GildedRose.GildedRose.items = new List<Item>();
            int inputQuality = 20;
            Item item = new Item("Backstage passes to a TAFKAL80ETC concert", 10, inputQuality);

            GildedRose.GildedRose.items.Add(item);
            GildedRose.GildedRose.updateQuality();

            int expectedQuality = inputQuality * 2;

            Assert.AreEqual(expectedQuality, item.Quality);
            
        }
        [Test]
        public virtual void testBackstageTripleIncrementQuality()
        {
            GildedRose.GildedRose.items = new List<Item>();
            int inputQuality = 20;
            Item item = new Item("Backstage passes to a TAFKAL80ETC concert", 5, inputQuality);

            GildedRose.GildedRose.items.Add(item);
            GildedRose.GildedRose.updateQuality();

            int expectedQuality = inputQuality * 3;

            Assert.AreEqual(expectedQuality, item.Quality);
            
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
            
        }
    }
}