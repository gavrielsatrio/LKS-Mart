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
    public partial class AddToCartForm : CoreForm
    {
        private LKSMartEntities db = new LKSMartEntities();
        private AppDataController appDataController = new AppDataController();
        public CustomerCartItem cartItem;
        public string backTo = "";

        public AddToCartForm()
        {
            InitializeComponent();
        }

        private void AddToCartForm_Load(object sender, EventArgs e)
        {
            lblTitle.Text = this.Text;
            btnClose.Click += btnClose_Click;

            var productSelected = db.Products.Where(x => x.id == cartItem.ProductID).ToList()[0];

            if(productSelected.image_name == null || productSelected.image_name == "null" || productSelected.image_name == "")
            {
                picBoxImage.ImageLocation = Application.StartupPath + "/images/products/not_available.png";
            }
            else
            {
                picBoxImage.ImageLocation = Application.StartupPath + "/images/products/" + productSelected.image_name;
            }

            lblName.Text = productSelected.name;
            lblPrice.Text = productSelected.price.ToString();
            lblDesc.Text = productSelected.Category.name;
            lblQty.Text = cartItem.Qty.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if(backTo == "ShopForm")
            {
                this.Hide();
                new ShopForm().Show();
            }
            else
            {
                this.Hide();
                new CartForm().Show();
            }
        }

        private void btnPlusQty_Click(object sender, EventArgs e)
        {
            cartItem.Qty++;
            lblQty.Text = cartItem.Qty.ToString();
        }

        private void btnMinQty_Click(object sender, EventArgs e)
        {
            if(cartItem.Qty == 1)
            {
                MessageBox.Show("Quantity must be more than or equals to one ...", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                cartItem.Qty--;
                lblQty.Text = cartItem.Qty.ToString();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var productStock = db.Products.Where(x => x.id == cartItem.ProductID).Select(x => x.stock).ToArray()[0];
            var appData = appDataController.GetAppData();
            var checkProductInCart = appData.CustomerCart.Where(x => x.ProductID == cartItem.ProductID).Select(x => x.Qty).ToArray();

            if(backTo == "ShopForm")
            {
                var inCartQty = 0;

                if(checkProductInCart.Length > 0)
                {
                    inCartQty = checkProductInCart[0];
                }

                if(productStock - (cartItem.Qty + inCartQty) >= 0)
                {
                    if(inCartQty == 0)
                    {
                        appData.CustomerCart.Add(new CustomerCartItem
                        {
                            ProductID = cartItem.ProductID,
                            Qty = cartItem.Qty
                        });
                    }
                    else
                    {
                        var queryUpdate = appData.CustomerCart.Find(x => x.ProductID == cartItem.ProductID);
                        queryUpdate.Qty = inCartQty + cartItem.Qty;
                    }

                    appDataController.SaveAppData(appData);

                    this.Hide();
                    new ShopForm().Show();
                }
                else
                {
                    MessageBox.Show("Product's stock insufficient ...", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if(productStock - cartItem.Qty >= 0)
                {
                    var queryUpdate = appData.CustomerCart.Find(x => x.ProductID == cartItem.ProductID);
                    queryUpdate.Qty = cartItem.Qty;

                    appDataController.SaveAppData(appData);

                    this.Hide();
                    new CartForm().Show();
                }
                else
                {
                    MessageBox.Show("Product's stock insufficient ...", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
