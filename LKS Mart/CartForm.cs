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
    public partial class CartForm : CoreForm
    {
        private LKSMartEntities db = new LKSMartEntities();
        private AppDataController appDataController = new AppDataController();

        public CartForm()
        {
            InitializeComponent();
        }

        private void CartForm_Load(object sender, EventArgs e)
        {
            lblTitle.Text = this.Text;
            btnClose.Click += btnClose_Click;

            LoadData();
        }

        public void LoadData()
        {
            panelCart.Controls.Clear();

            var customerCart = appDataController.GetAppData().CustomerCart;
            for (int i = 0; i < customerCart.Count; i++)
            {
                var cartItem = new CartItem(customerCart[i], this)
                {
                    Dock = DockStyle.Top,
                    Margin = new Padding(0, 16, 0, 0)
                };

                cartItem.SendToBack();

                panelCart.Controls.Add(cartItem);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainForm().Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainForm().Show();
        }
    }
}
