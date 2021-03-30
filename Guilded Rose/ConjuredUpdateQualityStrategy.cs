namespace GildedRose
{
	public class ConjuredUpdateQualityStrategy : UpdateQualityStrategyInterface
	{
		public virtual void Update(Item item)
		{
			if (item.sellIn > 0)
			{
				item.quality -= 2;
			}
			else
			{
				item.quality -= 4;
			}
			if (item.quality < 0)
			{
				item.quality = 0;
			}
			item.sellIn--;
		}
	}

}