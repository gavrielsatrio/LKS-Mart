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
    public partial class TransactionHistoryForm : CoreForm
    {
        private LKSMartEntities db = new LKSMartEntities();
        private AppDataController appDataController = new AppDataController();

        public TransactionHistoryForm()
        {
            InitializeComponent();
        }

        private void TransactionHistoryForm_Load(object sender, EventArgs e)
        {
            lblTitle.Text = this.Text;
            btnClose.Click += btnClose_Click;

            var customerID = appDataController.GetAppData().LoginCustomerID;
            var query = db.PointHistories.ToList().Where(x => x.customer_id == customerID && x.deleted_at == null).OrderByDescending(x => x.HeaderTransaction.datetime).Select(x => new
            {
                ID = x.header_transaction_id,
                Date = x.HeaderTransaction.datetime.ToString("dd MMMM yyyy, HH:mm:ss"),
                TotalPayment = Convert.ToInt32(Convert.ToDouble(x.HeaderTransaction.sub_total) + (Convert.ToDouble(x.HeaderTransaction.sub_total) * 0.05)),
                PointGainedOrDeducted = x.point_gained > 0 ? x.point_gained : x.point_deducted,
                IsGain = x.point_gained > 0 ? "True" : "False",
                PaymentCode = x.HeaderTransaction.payment_code
            }).ToList();

            dgvTransaction.DataSource = query;
            dgvTransaction.Columns["ID"].Visible = false;
            dgvTransaction.Columns["IsGain"].Visible = false;
            dgvTransaction.Columns["Date"].Width = 200;
            dgvTransaction.Columns["TotalPayment"].HeaderText = "Total Payment";
            dgvTransaction.Columns["PointGainedOrDeducted"].HeaderText = "Point Gained Or Deducted";
            dgvTransaction.Columns["PaymentCode"].HeaderText = "Payment Code";

            //for (int i = 0; i < dgvTransaction.RowCount; i++)
            //{
            //    if(dgvTransaction["IsGain", i].Value.ToString() == "True")
            //    {
            //        dgvTransaction.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
            //    }
            //    else
            //    {
            //        dgvTransaction.Rows[i].DefaultCellStyle.BackColor = Color.LightCoral;
            //    }
            //}
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

        private void dgvTransaction_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvTransaction.CurrentRow.Cells;
            var headerTransactionID = int.Parse(row["ID"].Value.ToString());

            panelTransactionDetail.Controls.Clear();

            var detailTransactionList = db.DetailTransactions.Where(x => x.header_transaction_id == headerTransactionID && x.deleted_at == null).ToList();
            for (int i = 0; i < detailTransactionList.Count; i++)
            {
                panelTransactionDetail.Controls.Add(new TransactionHistoryItem(detailTransactionList[i])
                {
                    Dock = DockStyle.Top
                });
            }
        }
    }
}
