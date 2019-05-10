using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerApp
{
    using Shopping;
    using System.ServiceModel;

    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
    public class CartService : ICart
    {
        private double payment;

        public bool AddItem(string item)
        {
            int id = Store.Find(item);

            if(id >= 0)
            {
                payment += 1.1 * Store.PriceOf(id);
                return true;
            }

            return false;
        }

        public double Checkout()
        {
            return payment;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var host = new ServiceHost(typeof(CartService));
            host.Open();
            Console.ReadKey();
            host.Close();
        }
    }
}
