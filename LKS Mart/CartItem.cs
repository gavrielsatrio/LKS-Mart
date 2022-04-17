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
    public partial class CartItem : UserControl
    {
        private CartForm cartForm;
        private CustomerCartItem customerCartItem;
        private AppDataController appDataController = new AppDataController();
        private LKSMartEntities db = new LKSMartEntities();

        public CartItem(CustomerCartItem customerCartItemParam, CartForm cartFormParam)
        {
            InitializeComponent();
            this.customerCartItem = customerCartItemParam;
            this.cartForm = cartFormParam;
        }

        private void CartItem_Load(object sender, EventArgs e)
        {
            var product = db.Products.Where(x => x.id == customerCartItem.ProductID).ToList()[0];

            if (product.image_name == null || product.image_name == "null" || product.image_name == "")
            {
                picBoxImage.ImageLocation = Application.StartupPath + "/images/products/not_available.png";
            }
            else
            {
                picBoxImage.ImageLocation = Application.StartupPath + "/images/products/" + product.image_name;
            }
            lblName.Text = product.name;
            lblPrice.Text = product.price.ToString();
            lblQty.Text = customerCartItem.Qty.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            cartForm.Hide();
            new AddToCartForm()
            {
                cartItem = customerCartItem,
                backTo = "CartForm"
            }.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var confirmationDialog = MessageBox.Show("Are you sure want to remove this product from your cart ?", "Remove Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if(confirmationDialog == DialogResult.Yes)
            {
                appDataController.DeleteProductFromCart(customerCartItem.ProductID);
                cartForm.LoadData();
            }
        }
    }
}
