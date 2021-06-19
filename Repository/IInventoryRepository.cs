using System.Collections.Generic;

namespace csharpcore.Repository
{
    public interface IInventoryRepository
    {
        IList<Item> GetInventory();
    }
}
