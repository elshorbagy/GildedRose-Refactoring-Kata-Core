using csharpcore.Services.Interface;

namespace csharpcore.Services
{
    public class CommonUpdateService : IInventoryUpdateService
    {
        public void UpdateInventoryItem(Item item)
        {
            item.SellIn -= 1;
            if (item.Quality > 0) item.Quality--;
        }
    }
}
