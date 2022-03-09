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
    public partial class ShopItemLayout : UserControl
    {
        private Product product;

        public ShopItemLayout(Product productParam)
        {
            InitializeComponent();
            this.product = productParam;
        }

        private void ShopItemLayout_Load(object sender, EventArgs e)
        {
            if(product.image_name == null || product.image_name == "null" || product.image_name == "")
            {
                picBoxImage.ImageLocation = Application.StartupPath + "/images/products/not_available.png";
            }
            else
            {
                picBoxImage.ImageLocation = Application.StartupPath + "/images/products/" + product.image_name;
            }
            lblName.Text = product.name;
            lblPrice.Text = product.price.ToString();
            lblStock.Text = product.stock.ToString();
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {

        }
    }
}
