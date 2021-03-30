namespace GildedRose
{
	public class Item
	{

	  public string name;
	  public int sellIn;
	  public int quality;

	  public Item(string name, int sellIn, int quality)
	  {
		this.Name = name;
		this.SellIn = sellIn;
		this.Quality = quality;
	  }

	  /* Generated getter and setter code */
	  public virtual string Name
	  {
		  get
		  {
			return name;
		  }
		  set
		  {
			this.name = value;
		  }
	  }


	  public virtual int SellIn
	  {
		  get
		  {
			return sellIn;
		  }
		  set
		  {
			this.sellIn = value;
		  }
	  }


	  public virtual int Quality
	  {
		  get
		  {
			return quality;
		  }
		  set
		  {
			this.quality = value;
		  }
	  }


	  public override string ToString()
	  {
		return "Item{" + "name='" + name + '\'' + ", sellIn=" + sellIn + ", quality=" + quality + '}';
	  }
	}

}