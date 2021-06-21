using csharpcore.Services.Interface;

namespace csharpcore.Services
{
    public class UnknownUpdateService : IInventoryUpdateService
    {
        public void UpdateInventoryItem(Item item)
        {
            item.Name = "Item Not Found";
            item.Quality = 0;
            item.SellIn = 0;
        }
    }
}
