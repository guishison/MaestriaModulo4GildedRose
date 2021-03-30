using System;
using System.Collections.Generic;

namespace GildedRose
{

	public class GildedRose
	{

	  public static IList<Item> items = new List<Item>();

	  public static void Main(string[] args)
	  {


		items.Add(new Item("+5 Dexterity Vest", 10, 20));
		items.Add(new Item("Aged Brie", 2, 0));
		items.Add(new Item("Elixir of the Mongoose", 5, 7));
		items.Add(new Item("Sulfuras, Hand of Ragnaros", 0, 80));
		items.Add(new Item("Backstage passes to a TAFKAL80ETC concert", 15, 20));
		items.Add(new Item("Conjured Mana Cake", 3, 6));

		updateQuality();

		Console.WriteLine(items);
	  }

	  public static void updateQuality()
	  {
		foreach (Item item in items)
		{
		  UpdateQualityStrategyInterface strategy = UpdateQualityStrategyFactory.Create(item);
		  strategy.Update(item);
				Console.WriteLine(item);
			}
	//    for (int i = 0; i < items.size(); i++) {
	//      if ((!"Aged Brie".equals(items.get(i).getName()))
	//          && !"Backstage passes to a TAFKAL80ETC concert".equals(items.get(i).getName())) {
	//        if (items.get(i).getQuality() > 0) {
	//          if (!"Sulfuras, Hand of Ragnaros".equals(items.get(i).getName())) {
	//            items.get(i).setQuality(items.get(i).getQuality() - 1);
	//          }
	//        }
	//      } else {
	//        if (items.get(i).getQuality() < 50) {
	//          items.get(i).setQuality(items.get(i).getQuality() + 1);
	//
	//          if ("Backstage passes to a TAFKAL80ETC concert".equals(items.get(i).getName())) {
	//            if (items.get(i).getSellIn() < 11) {
	//              if (items.get(i).getQuality() < 50) {
	//                items.get(i).setQuality(items.get(i).getQuality() + 1);
	//              }
	//            }
	//
	//            if (items.get(i).getSellIn() < 6) {
	//              if (items.get(i).getQuality() < 50) {
	//                items.get(i).setQuality(items.get(i).getQuality() + 1);
	//              }
	//            }
	//          }
	//        }
	//      }
	//
	//      if (!"Sulfuras, Hand of Ragnaros".equals(items.get(i).getName())) {
	//        items.get(i).setSellIn(items.get(i).getSellIn() - 1);
	//      }
	//
	//      if (items.get(i).getSellIn() < 0) {
	//        if (!"Aged Brie".equals(items.get(i).getName())) {
	//          if (!"Backstage passes to a TAFKAL80ETC concert".equals(items.get(i).getName())) {
	//            if (items.get(i).getQuality() > 0) {
	//              if (!"Sulfuras, Hand of Ragnaros".equals(items.get(i).getName())) {
	//                items.get(i).setQuality(items.get(i).getQuality() - 1);
	//              }
	//            }
	//          } else {
	//            items.get(i).setQuality(items.get(i).getQuality() - items.get(i).getQuality());
	//          }
	//        } else {
	//          if (items.get(i).getQuality() < 50) {
	//            items.get(i).setQuality(items.get(i).getQuality() + 1);
	//          }
	//        }
	//      }
	//    }
	  }
	}

}