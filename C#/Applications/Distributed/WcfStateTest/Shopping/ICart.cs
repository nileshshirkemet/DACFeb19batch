namespace Shopping
{
    using System.ServiceModel;

    [ServiceContract(SessionMode = SessionMode.Required)]
    public interface ICart
    {
        [OperationContract]
        bool AddItem(string item);

        [OperationContract(IsTerminating = true)]
        double Checkout();
    }
}
