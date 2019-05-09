namespace Shopping
{
    using System.ServiceModel;

    [ServiceContract]
    public interface IShopKeeper
    {
        [OperationContract]
        ItemInfo GetItemInfo(string item);

        [OperationContract]
        float GetBulkDiscount(int quantity);
    }
}
