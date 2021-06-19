using System;
using csharpcore.Services.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace csharpcore
{
    public class Program
    {
        private static IInventoryService _inventoryService;

        public static void Main()
        {
            Console.WriteLine("OMGHAI!");

            _inventoryService = Ioc.GetServiceProvider().GetService<IInventoryService>();

            if (_inventoryService != null)
            {
                var items = _inventoryService.GetInventory();
            
                for (var i = 0; i < 31; i++)
                {
                    Console.WriteLine("-------- day " + i + " --------");
                    Console.WriteLine("name, sellIn, quality");
                    foreach (var item in items)
                    {
                        Console.WriteLine(item.Name + ", " + item.SellIn + ", " + item.Quality);
                        _inventoryService.UpdateInventoryItem(item);
                    }
                    Console.WriteLine("");
                }
            }

            Console.ReadLine();
        }
    }
}
