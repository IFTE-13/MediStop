using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediStop
{
    public partial class SalesReport : UserControl
    {
        private DataAccess Da { get; set; }
        private string id { set; get; }
        public SalesReport()
        {
            InitializeComponent();
        }

        public SalesReport(string Id)
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.id = Id.ToString();
            this.txtStuffID.Text = this.id;
            string sql = "select * from Customer where StuffID ='" + this.id + "';";
            PopulateSalesGridVIew(sql);
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.dtpSearchByDate.Text = "";
            this.txtTotalSale.Clear();
            string sql = "select * from Customer where StuffID ='" + this.id + "';";
            PopulateSalesGridVIew(sql);
            this.txtTotalSale.Clear();
        }

        private void dtpSearchByDate_ValueChanged(object sender, EventArgs e)
        {
            string sql = "select * from Customer where StuffID ='" + this.id + "' and PurchaseDate ='" + this.dtpSearchByDate.Text + "';";
            PopulateSalesGridVIew(sql);

            TotalSellAmount();
        }

        private void PopulateSalesGridVIew(string sql = "selcet * from Customer;")
        {
            try
            {
                DataSet ds = this.Da.ExecuteQuery(sql);

                this.dgvSalesReport.AutoGenerateColumns = false;
                this.dgvSalesReport.DataSource = ds.Tables[0];
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }

        private void TotalSellAmount()
        {
            int sum = 0;
            for (int i = 0; i < this.dgvSalesReport.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dgvSalesReport.Rows[i].Cells["Amount"].Value);
            }
            this.txtTotalSale.Text = sum.ToString();
        }

        



    }
}
