using GildedRoseKata.Interfaces;
using GildedRoseKata.Models;

namespace GildedRoseKata.Srs
{
    public class AgedBrie : IUpdateQuality
    {
        public void UpdateQuality(Items item)
        {
            item.Sellin--;
            if (item.Quality < 50)
            {
                item.Quality++;
            }
        }
    }
}
