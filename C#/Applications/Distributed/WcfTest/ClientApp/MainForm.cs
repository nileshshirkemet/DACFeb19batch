using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApp
{
    using Shopping;
    using System.ServiceModel;

    public partial class MainForm : Form
    {
        NetHttpBinding binding = new NetHttpBinding();
        string address = "http://localhost:8010/shopping/shopkeeper";

        public MainForm()
        {
            InitializeComponent();
        }

        private void purchaseButton_Click(object sender, EventArgs e)
        {
            string item = itemTextBox.Text;
            int quantity = (int)quantityNumericUpDown.Value;

            using (var service = new ChannelFactory<IShopKeeper>(binding, address))
            {
                IShopKeeper client = service.CreateChannel();
                ItemInfo info = client.GetItemInfo(item);
                if (info == null || quantity > info.CurrentStock)
                    paymentTextBox.Text = "Not Available";
                else
                {
                    float discount = client.GetBulkDiscount(quantity);
                    double payment = quantity * info.UnitPrice * (1 - discount / 100);
                    paymentTextBox.Text = payment.ToString("0.00");
                }
            }
        }
    }
}
