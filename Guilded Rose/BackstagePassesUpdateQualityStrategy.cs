namespace GildedRose
{
	public class BackstagePassesUpdateQualityStrategy : UpdateQualityStrategyInterface
	{
		public virtual void Update(Item item)
		{
			if (isAfterTheConcert(item))
			{
				item.quality = 0;
			}
			else if (item.quality < 50)
			{
				int qualityIncrease = item.quality * qualityIncreaseBy(item.sellIn);
				item.quality = (item.quality>10)?qualityIncrease:(qualityIncrease + 1);
            }
            else
            {
				item.quality = 50;
			}
			item.sellIn--;
		}

		// Depende de los parametros dados este va a aumentar el precio
		private int qualityIncreaseBy(int remainingDaysBeforeConcert)
		{
			if (remainingDaysBeforeConcert <= 5)
			{
				return 3;
			}
			else if (remainingDaysBeforeConcert <= 10)
			{
				return 2;
			}
			else
			{
				return 1;
			}
		}
		// Si la fecha es despues del vencimiento, el item se volvera 0
		private bool isAfterTheConcert(Item item)
		{
			return item.sellIn <= 0;
		}
	}

}