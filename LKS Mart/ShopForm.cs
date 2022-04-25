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

            LoadData(0);
        }

        private void LoadData(int categoryID)
        {
            panelResult.Controls.Clear();
            panelCategory.Controls.Clear();

            var query = db.Products.Where(x => x.deleted_at == null).ToList();
            if(txtSearch.Text != "")
            {
                query = query.Where(x => x.name.ToLower().Contains(txtSearch.Text.ToLower())).ToList();
            }

            if(txtFromPrice.Value != 0 && txtToPrice.Value != 0)
            {
                query = query.Where(x => x.price >= txtFromPrice.Value && x.price <= txtToPrice.Value).ToList();
            }

            if(categoryID != 0)
            {
                query = query.Where(x => x.category_id == categoryID).ToList();
            }

            for (int i = query.Count - 1; i >= 0; i--)
            {
                var product = query[i];
                var shopItem = new ShopItemLayout(product, this)
                {
                    Dock = DockStyle.Top,
                    Margin = new Padding(0, 16, 0, 0)
                };

                shopItem.BringToFront();
                panelResult.Controls.Add(shopItem);
            }

            var linkAllCategory = new LinkLabel()
            {
                Name = "linkAllCategory-0",
                Text = "All Category",
                Location = new Point(0, 10),
                AutoSize = true
            };
            linkAllCategory.Click += linkCategory_Click;

            panelCategory.Controls.Add(linkAllCategory);

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
            else
            {
                var firstProduct = query[0];
                var spacing = 8;

                var lblNext = new Label()
                {
                    Name = "lblNext",
                    Text = ">",
                    AutoSize = true
                };

                lblNext.Location = new Point(linkAllCategory.Location.X + linkAllCategory.Width + spacing, 10);
                panelCategory.Controls.Add(lblNext);

                if (firstProduct.Category.parent_id == null || firstProduct.Category.parent_id == firstProduct.category_id)
                {
                    // End Category
                    var linkEndCategory = new LinkLabel()
                    {
                        Name = "linkEndCategory-" + firstProduct.category_id,
                        Text = firstProduct.Category.name,
                        Location = new Point(lblNext.Location.X + lblNext.Width + spacing, 10),
                        AutoSize = true
                    };
                    linkEndCategory.Click += linkCategory_Click;

                    panelCategory.Controls.Add(linkEndCategory);
                }
                else
                {
                    // Parent Category > End Category
                    var linkParentCategory = new LinkLabel()
                    {
                        Name = "linkParentCategory-" + firstProduct.Category.parent_id,
                        Text = db.Categories.Where(x => x.id == firstProduct.Category.parent_id).Select(x => x.name).ToArray()[0],
                        Location = new Point(lblNext.Location.X + lblNext.Width + spacing, 10),
                        AutoSize = true
                    };
                    linkParentCategory.Click += linkCategory_Click;

                    panelCategory.Controls.Add(linkParentCategory);

                    var lblNext2 = new Label()
                    {
                        Name = "lblNext",
                        Text = ">",
                        AutoSize = true
                    };
                    lblNext2.Location = new Point(linkParentCategory.Location.X + linkParentCategory.Width + spacing, 10);
                    panelCategory.Controls.Add(lblNext2);

                    var linkEndCategory = new LinkLabel()
                    {
                        Name = "linkEndCategory-" + firstProduct.category_id,
                        Text = firstProduct.Category.name,
                        Location = new Point(lblNext2.Location.X + lblNext2.Width + spacing, 10),
                        AutoSize = true
                    };
                    linkEndCategory.Click += linkCategory_Click;

                    panelCategory.Controls.Add(linkEndCategory);
                }
            }
        }

        private void linkCategory_Click(object sender, EventArgs e)
        {
            var linkLabel = (LinkLabel)sender;
            var categoryID = int.Parse(linkLabel.Name.Split('-')[1]);

            LoadData(categoryID);
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
            LoadData(0);
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
                LoadData(0);
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
                LoadData(0);
            }
            else
            {
                MessageBox.Show("Price range invalid ...", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtToPrice.Value = txtFromPrice.Value;
            }
        }
    }
}
