using System.Threading.Tasks;

namespace ClientApp
{
    using Shopping;
    using System.ServiceModel;

    class CartClient : ClientBase<ICart>
    {
        public CartClient() : base("CartTcp")
        {
        }

        public Task<bool> AddItemAsync(string item)
        {
            return Task<bool>.Run(() => Channel.AddItem(item));
        }

        public Task<double> CheckoutAsync()
        {
            return Task<double>.Run(() => Channel.Checkout());
        }
    }
}
