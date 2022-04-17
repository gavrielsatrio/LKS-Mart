using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LKS_Mart
{
    public partial class TransactionHistoryItem : UserControl
    {
        private AppDataController appDataController = new AppDataController();
        private LKSMartEntities db = new LKSMartEntities();
        private DetailTransaction detailTransaction;

        public TransactionHistoryItem(DetailTransaction detailTransactionParam)
        {
            InitializeComponent();

            this.detailTransaction = detailTransactionParam;
        }

        private void TransactionHistoryItem_Load(object sender, EventArgs e)
        {
            var productID = detailTransaction.product_id;
            var product = db.Products.Where(x => x.id == productID).ToArray()[0];

            lblName.Text = product.name;
            lblPrice.Text = detailTransaction.price.ToString();
            lblQty.Text = detailTransaction.quantity.ToString();

            if(product.image_name == null || product.image_name == "null" || product.image_name == "")
            {
                picBoxImage.ImageLocation = Application.StartupPath + "/images/products/not_available.png";
            }
            else
            {
                picBoxImage.ImageLocation = Application.StartupPath + "/images/products/" + product.image_name;
            }
        }
    }
}
