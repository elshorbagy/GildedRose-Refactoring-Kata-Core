using csharpcore.Services.Interface;

namespace csharpcore.Services
{
    public class ConjureUpdateService : IInventoryUpdateService
    {
        public void UpdateInventoryItem(Item item)
        {
            //"Conjured" items degrade in Quality twice as fast as normal items
            item.Quality -= 2;

            if (item.SellIn > 0) item.SellIn--;

            if (item.SellIn <= 0) item.Quality -= 2;
        }
    }
}
