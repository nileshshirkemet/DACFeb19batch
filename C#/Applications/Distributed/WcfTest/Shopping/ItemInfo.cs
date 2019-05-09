namespace Shopping
{
    using System.Runtime.Serialization;

    [DataContract]
    public class ItemInfo
    {
        [DataMember]
        public double UnitPrice { get; set; }

        [DataMember]
        public int CurrentStock { get; set; }

    }
}
