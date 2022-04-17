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
    public partial class PointHistoryForm : CoreForm
    {
        private LKSMartEntities db = new LKSMartEntities();
        private AppDataController appDataController = new AppDataController();

        public PointHistoryForm()
        {
            InitializeComponent();
        }

        private void PointHistoryForm_Load(object sender, EventArgs e)
        {
            lblTitle.Text = this.Text;
            btnClose.Click += btnClose_Click;

            var customerID = appDataController.GetAppData().LoginCustomerID;
            lblCurrentPointValue.Text = db.Customers.Where(x => x.id == customerID).Select(x => x.point).ToArray()[0].ToString();

            var query = db.PointHistories.ToList().Where(x => x.customer_id == customerID && x.deleted_at == null).Select(x => new
            {
                Date = x.HeaderTransaction.datetime.ToString("dd MMMM yyyy, HH:mm:ss"),
                PaymentCode = x.HeaderTransaction.payment_code,
                PointGain = x.point_gained,
                PointBefore = x.point_before,
                PointAfter = x.point_after,
                IsGain = x.point_gained > 0 ? "True" : "False"
            }).ToList();

            dgvPoint.DataSource = query;
            dgvPoint.Columns["IsGain"].Visible = false;
            dgvPoint.Columns["Date"].Width = 150;

            for (int i = 0; i < dgvPoint.RowCount; i++)
            {
                if(dgvPoint["IsGain", i].Value.ToString() == "True")
                {
                    dgvPoint.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                }
                else
                {
                    dgvPoint.Rows[i].DefaultCellStyle.BackColor = Color.LightCoral;
                }
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
