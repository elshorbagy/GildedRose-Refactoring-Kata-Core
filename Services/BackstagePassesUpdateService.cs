using csharpcore.Services.Interface;

namespace csharpcore.Services
{
    public class BackstagePassesUpdateService : IInventoryUpdateService
    {
        public void UpdateInventoryItem(Item item)
        {
            if (item.SellIn < 11 && item.Quality < 50)
            { 
                item.Quality++;
            }

            if (item.SellIn < 6 && item.Quality < 50)
            { 
                item.Quality++;
            }

            if (item.Quality < 50)
            {
                item.Quality += 1;
            }

            if (item.SellIn < 0)
            {
                item.Quality = 0;
            }

            item.SellIn -= 1;
        }
    }
}