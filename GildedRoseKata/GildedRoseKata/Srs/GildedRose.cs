using GildedRoseKata.Interfaces;

namespace GildedRoseKata.Srs
{
    public class GildedRose : IUpdateStrategy
    {
        public IUpdateQuality Create(string name)
        {
            if (name == "Sulfuras, Hand of Ragnaros")
            {
                return new DoNothing();
            }
            else if (name == "Aged Brie")
            {
                return new AgedBrie();
            }
            else if (name == "Backstage passes to a TAFKAL80ETC concert")
            {
                return new BackstagePasses();
            }
            else if (name.Contains("Conjured"))
            {
                return new Standard(2);
            }
            else
            {
                return new Standard();
            }
        }
    }
}
