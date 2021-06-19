using System.Collections.Generic;
using csharpcore.Repository;
using csharpcore.Services.Interface;

namespace csharpcore.Services
{
    internal class InventoryService : IInventoryService
    {
        private readonly IInventoryRepository _inventoryRepository;
        private readonly IInventoryUpdateFactory _inventoryUpdateFactory;

        public InventoryService(IInventoryRepository inventoryRepository,
            IInventoryUpdateFactory inventoryUpdateFactory)
        {
            _inventoryRepository = inventoryRepository;
            _inventoryUpdateFactory = inventoryUpdateFactory;
        }

        public IList<Item> GetInventory()
        {
           return _inventoryRepository.GetInventory();
        }

        public void UpdateInventoryItem(Item item)
        {
            _inventoryUpdateFactory.CreateService(item.Name).UpdateInventoryItem(item);
        }
    }
}
