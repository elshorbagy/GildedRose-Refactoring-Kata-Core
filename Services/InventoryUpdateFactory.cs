using csharpcore.Services.Interface;

namespace csharpcore.Services
{
    public class InventoryUpdateFactory : IInventoryUpdateFactory
    {
        public IInventoryUpdateService CreateService(string itemName)
        {
            if(string.IsNullOrEmpty(itemName))
            {
                return new UnknownUpdateService();
            }

            switch (itemName)
            {
                case "Aged Brie":
                    return new AgedBrieUpdateService();
                case "Backstage passes to a TAFKAL80ETC concert":
                    return new BackstagePassesUpdateService();
                case "Sulfuras, Hand of Ragnaros":
                    return new SulfurasUpdateService();
                case "Conjured Mana Cake":
                    return new ConjureUpdateService();
                default:
                    return new CommonUpdateService();
            }
        }
    }
}
