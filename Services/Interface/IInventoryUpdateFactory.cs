
namespace csharpcore.Services.Interface
{
    public interface IInventoryUpdateFactory
    {
       IInventoryUpdateService CreateService(string itemName);
    }
}
