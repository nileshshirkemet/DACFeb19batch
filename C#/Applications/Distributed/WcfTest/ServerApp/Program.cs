using System;

namespace ServerApp
{
    using Shopping;
    using System.ServiceModel;

    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class ShopKeeperService : IShopKeeper
    {
        public float GetBulkDiscount(int quantity)
        {
            return quantity < 6 ? 0 : 5;
        }

        public ItemInfo GetItemInfo(string item)
        {
            int id = Store.Find(item);

            if(id >= 0)
            {
                ItemInfo info = new ItemInfo();
                info.UnitPrice = 1.1 * Store.PriceOf(id);
                info.CurrentStock = Store.StockOf(id);
                return info;
            }

            return null;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(ShopKeeperService));
            host.AddServiceEndpoint(typeof(IShopKeeper), new NetHttpBinding(), "http://localhost:8010/shopping/shopkeeper");
            host.Open();
            Console.ReadKey();
            host.Close();
        }
    }
}
