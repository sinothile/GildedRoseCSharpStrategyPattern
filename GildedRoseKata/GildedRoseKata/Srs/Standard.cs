using GildedRoseKata.Interfaces;
using GildedRoseKata.Models;

namespace GildedRoseKata.Srs
{
    public class Standard : IUpdateQuality
    {
        private readonly int _factor;

        public Standard(int factor = 1)
        {
            _factor = factor;
        }

        public void UpdateQuality(Items item)
        {
            item.Sellin--;
            if (item.Quality > 0)
            {
                item.Quality -= _factor * (item.Sellin < 0 ? 2 : 1);
            }
            if (item.Quality < 0)
            {
                item.Quality = 0;
            }
        }
    }
}
