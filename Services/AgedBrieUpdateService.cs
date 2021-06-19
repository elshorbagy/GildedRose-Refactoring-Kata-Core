using csharpcore.Services.Interface;

namespace csharpcore.Services
{
    public class AgedBrieUpdateService : IInventoryUpdateService
    {
        public void UpdateInventoryItem(Item item)
        {
            if (item.Quality < 50)
            {
                item.Quality += 1;
            }
            item.SellIn -= 1;
        }
    }
}
