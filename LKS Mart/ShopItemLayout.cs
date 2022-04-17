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
        private ShopForm shopForm;
        private Product product;
        private AppDataController appDataController = new AppDataController();

        public ShopItemLayout(Product productParam, ShopForm shopFormParam)
        {
            InitializeComponent();
            this.product = productParam;
            this.shopForm = shopFormParam;
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
            shopForm.Hide();
            new AddToCartForm()
            {
                cartItem = new CustomerCartItem
                {
                    ProductID = product.id,
                    //Qty = appData.CustomerCart.Where(x => x.ProductID == product.id).ToList().Count > 0 ? appData.CustomerCart.Where(x => x.ProductID == product.id).Select(x => x.Qty).ToArray()[0] : 1
                    Qty = 1
                },
                backTo = "ShopForm"
            }.Show();
        }
    }
}
