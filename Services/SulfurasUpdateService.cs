using csharpcore.Services.Interface;

namespace csharpcore.Services
{
    public class SulfurasUpdateService : IInventoryUpdateService
    {
        public void UpdateInventoryItem(Item item)
        {
            //"Sulfuras", being a legendary item, never has to be sold or decreases in Quality
            item.SellIn = item.SellIn;
            item.Quality = item.Quality;
        }
    }
}
