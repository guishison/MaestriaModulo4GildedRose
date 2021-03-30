namespace GildedRose
{
	public class AgedBrieUpdateQualityStrategy : UpdateQualityStrategyInterface
	{
		public virtual void Update(Item item)
		{
			if (item.quality < 50)
			{
				item.quality++;
			}
			item.sellIn--;
		}
	}

}