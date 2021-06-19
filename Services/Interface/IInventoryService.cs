using System.Collections.Generic;

namespace csharpcore.Services.Interface
{
    public interface IInventoryService: IInventoryUpdateService
    {
        IList<Item> GetInventory();
    }
}
