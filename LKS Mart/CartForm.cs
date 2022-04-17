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
        private int subTotal = 0;
        private int platformFee = 0;
        private int total = 0;
        private int availablePoint = 0;
        private int amountToPay = 0;

        public CartForm()
        {
            InitializeComponent();
        }

        private void CartForm_Load(object sender, EventArgs e)
        {
            lblTitle.Text = this.Text;
            btnClose.Click += btnClose_Click;

            LoadData();
            LoadPaymentType();
        }

        public void LoadData()
        {
            subTotal = 0;
            panelCart.Controls.Clear();

            var customerCart = appDataController.GetAppData().CustomerCart;
            for (int i = 0; i < customerCart.Count; i++)
            {
                var cartItem = new CartItem(customerCart[i], this)
                {
                    Dock = DockStyle.Top
                };

                cartItem.BringToFront();

                var productID = customerCart[i].ProductID;
                var productPrice = db.Products.Where(x => x.id == productID).Select(x => x.price).ToArray()[0];

                subTotal += Convert.ToInt32(customerCart[i].Qty * productPrice);

                panelCart.Controls.Add(cartItem);
            }

            platformFee = Convert.ToInt32(subTotal * 0.05);
            total = subTotal + platformFee;
            amountToPay = total;

            LoadAvailablePoint();
            LoadAllPaymentDetails();
        }

        private void LoadPaymentType()
        {
            var query = db.PaymentTypes.Where(x => x.deleted_at == null).ToList();
            comboPaymentType.ValueMember = "id";
            comboPaymentType.DisplayMember = "name";
            comboPaymentType.DataSource = query;
        }

        private void LoadAllPaymentDetails()
        {
            lblSubtotalValue.Text = subTotal.ToString();
            lblFeeValue.Text = platformFee.ToString();
            lblTotalValue.Text = total.ToString();
            lblAvailablePointValue.Text = availablePoint.ToString();
            lblAmountToPayValue.Text = amountToPay.ToString();
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

        private void checkPayUsingPoint_CheckedChanged(object sender, EventArgs e)
        {
            LoadAvailablePoint();
            LoadAllPaymentDetails();
        }

        private void LoadAvailablePoint()
        {
            if(checkPayUsingPoint.Checked == false)
            {
                availablePoint = 0;
            }
            else
            {
                var customerID = appDataController.GetAppData().LoginCustomerID;
                var customerPoint = db.Customers.Where(x => x.id == customerID).Select(x => x.point).ToArray()[0];

                availablePoint = customerPoint >= total ? total : customerPoint;
            }

            lblAvailablePoint.Visible = checkPayUsingPoint.Checked;
            lblAvailablePointValue.Visible = checkPayUsingPoint.Checked;

            amountToPay = total - availablePoint;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var productsInCart = appDataController.GetAppData().CustomerCart;
            if(productsInCart.Count > 0)
            {
                var alphaNum = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
                var paymentCode = "";

                while (paymentCode.Length < 12)
                {
                    var randomIndex = new Random().Next(0, alphaNum.Length);
                    var randomAlphaNum = alphaNum[randomIndex];

                    if (!paymentCode.Contains(randomAlphaNum))
                    {
                        paymentCode += randomAlphaNum;
                    }
                }

                var customerID = appDataController.GetAppData().LoginCustomerID;
                var queryCustomer = db.Customers.Find(customerID);

                db.HeaderTransactions.Add(new HeaderTransaction
                {
                    customer_id = customerID,
                    payment_type_id = int.Parse(comboPaymentType.SelectedValue.ToString()),
                    datetime = DateTime.Now,
                    sub_total = subTotal,
                    point_used = availablePoint,
                    payment_code = paymentCode,
                    created_at = DateTime.Now
                });
                db.SaveChanges();

                var headerTransactionID = db.HeaderTransactions.OrderByDescending(x => x.id).Select(x => x.id).ToArray()[0];

                db.PointHistories.Add(new PointHistory
                {
                    customer_id = customerID,
                    header_transaction_id = headerTransactionID,
                    point_gained = checkPayUsingPoint.Checked == true ? 0 : Convert.ToInt32(Math.Round(subTotal * 0.2)),
                    point_deducted = availablePoint,
                    point_before = queryCustomer.point,
                    point_after = checkPayUsingPoint.Checked == true ? queryCustomer.point - availablePoint : queryCustomer.point + Convert.ToInt32(Math.Round(subTotal * 0.2)),
                    created_at = DateTime.Now
                });
                db.SaveChanges();

                if(checkPayUsingPoint.Checked == true)
                {
                    queryCustomer.point = queryCustomer.point - availablePoint;
                }
                else
                {
                    queryCustomer.point = queryCustomer.point + Convert.ToInt32(Math.Round(subTotal * 0.2));
                }
                queryCustomer.last_updated_at = DateTime.Now;
                db.SaveChanges();

                for (int i = 0; i < productsInCart.Count; i++)
                {
                    var productID = productsInCart[i].ProductID;
                    var product = db.Products.Where(x => x.id == productID).ToArray()[0];

                    db.DetailTransactions.Add(new DetailTransaction
                    {
                        header_transaction_id = headerTransactionID,
                        product_id = productID,
                        price = product.price,
                        quantity = productsInCart[i].Qty,
                        created_at = DateTime.Now
                    });
                    db.SaveChanges();

                    var queryProduct = db.Products.Find(productID);
                    queryProduct.stock -= productsInCart[i].Qty;
                    queryProduct.last_updated_at = DateTime.Now;

                    db.SaveChanges();
                }

                appDataController.ClearCart();

                this.Hide();
                new NotificationForm(comboPaymentType.Text, paymentCode).Show();
            }
            else
            {
                MessageBox.Show("You must add at least one product into your cart ...", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
