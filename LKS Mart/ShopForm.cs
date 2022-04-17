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
    public partial class ShopForm : CoreForm
    {
        private AppDataController appDataController = new AppDataController();
        private LKSMartEntities db = new LKSMartEntities();

        public ShopForm()
        {
            InitializeComponent();
        }

        private void ShopForm_Load(object sender, EventArgs e)
        {
            lblTitle.Text = this.Text;
            btnClose.Click += btnClose_Click;

            LoadData();
        }

        private void LoadData()
        {
            panelResult.Controls.Clear();

            var query = db.Products.Where(x => x.deleted_at == null).ToList();
            if(txtSearch.Text != "")
            {
                query = query.Where(x => x.name.ToLower().Contains(txtSearch.Text.ToLower())).ToList();
            }

            if(txtFromPrice.Value != 0 && txtToPrice.Value != 0)
            {
                query = query.Where(x => x.price >= txtFromPrice.Value && x.price <= txtToPrice.Value).ToList();
            }

            for (int i = 0; i < query.Count; i++)
            {
                var product = query[i];
                var shopItem = new ShopItemLayout(product, this)
                {
                    Dock = DockStyle.Top,
                    Margin = new Padding(0, 16, 0, 0)
                };

                shopItem.SendToBack();
                panelResult.Controls.Add(shopItem);
            }

            if(query.Count == 0)
            {
                panelResult.Controls.Add(new Label()
                {
                    AutoSize = false,
                    Text = "No results matches with the filter applied",
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Open Sans", 16F, FontStyle.Bold, GraphicsUnit.Point)
                });
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

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            LoadData();
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            lblSearchPlaceholder.Visible = false;
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if(txtSearch.Text == "")
            {
                lblSearchPlaceholder.Visible = true;
            }
        }

        private void lblSearchPlaceholder_Click(object sender, EventArgs e)
        {
            txtSearch.Focus();
        }

        private void txtFromPrice_ValueChanged(object sender, EventArgs e)
        {
            if(txtFromPrice.Value <= txtToPrice.Value)
            {
                LoadData();
            }
            else
            {
                MessageBox.Show("Price range invalid ...", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFromPrice.Value = txtToPrice.Value;
            }
        }

        private void txtToPrice_ValueChanged(object sender, EventArgs e)
        {
            if(txtToPrice.Value >= txtFromPrice.Value)
            {
                LoadData();
            }
            else
            {
                MessageBox.Show("Price range invalid ...", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtToPrice.Value = txtFromPrice.Value;
            }
        }
    }
}
