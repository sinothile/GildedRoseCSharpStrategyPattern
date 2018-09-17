using GildedRoseKata.Interfaces;
using GildedRoseKata.Models;

namespace GildedRoseKata.Srs
{
    public class BackstagePasses : IUpdateQuality
    {
        public void UpdateQuality(Items item)
        {
            item.Sellin--;
            if (item.Sellin < 0)
            {
                item.Quality = 0;
            }
            else if (item.Sellin <= 5)
            {
                item.Quality = item.Quality + 3;
            }
            else if (item.Sellin <= 10)
            {
                item.Quality = item.Quality + 2;
            }
            else if (item.Quality < 50)
            {
                item.Quality++;
            }
        }
    }
}
