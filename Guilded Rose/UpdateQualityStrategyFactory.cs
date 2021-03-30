namespace GildedRose
{
	public class UpdateQualityStrategyFactory
	{
		public static UpdateQualityStrategyInterface Create(Item item)
		{
			if (item.name.Contains("Sulfuras"))
			{
				return new SulfurasUpdateQualityStrategy();
			}
			else if (item.name.Contains("Aged Brie"))
			{
				return new AgedBrieUpdateQualityStrategy();
			}
			else if (item.name.Contains("Backstage pass"))
			{
				return new BackstagePassesUpdateQualityStrategy();
			}
			else if (item.name.Contains("Conjured"))
			{
				return new ConjuredUpdateQualityStrategy();
			}
			else
			{
				return new StandardUpdateQualityStrategy();
			}
		}
	}

}