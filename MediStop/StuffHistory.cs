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
    public partial class StuffHistory : UserControl
    {
        private DataAccess Da { get; set; }
        public StuffHistory()
        {
            this.Da = new DataAccess();
            InitializeComponent();
            PopulateSalesHistoryGrid();
        }

        private void StuffHistory_Load(object sender, EventArgs e)
        {
            this.dgvSalesHistory.ClearSelection();
            this.dgvSalesHistory.Columns[0].HeaderCell.Style.Font = new Font("Microsoft YaHei", 12, FontStyle.Regular);
            this.dgvSalesHistory.Columns[0].DefaultCellStyle.Font = new Font("Microsoft YaHei", 12, FontStyle.Regular);
            this.dgvSalesHistory.Columns[1].HeaderCell.Style.Font = new Font("Microsoft YaHei", 12, FontStyle.Regular);
            this.dgvSalesHistory.Columns[1].DefaultCellStyle.Font = new Font("Microsoft YaHei", 12, FontStyle.Regular);
            this.dgvSalesHistory.Columns[2].HeaderCell.Style.Font = new Font("Microsoft YaHei", 12, FontStyle.Regular);
            this.dgvSalesHistory.Columns[2].DefaultCellStyle.Font = new Font("Microsoft YaHei", 12, FontStyle.Regular);
            this.dgvSalesHistory.Columns[3].HeaderCell.Style.Font = new Font("Microsoft YaHei", 12, FontStyle.Regular);
            this.dgvSalesHistory.Columns[3].DefaultCellStyle.Font = new Font("Microsoft YaHei", 12, FontStyle.Regular);

        }

        private void PopulateSalesHistoryGrid(string sql = "select * from Customer;")
        {
            try
            {
                DataSet ds = this.Da.ExecuteQuery(sql);

                this.dgvSalesHistory.AutoGenerateColumns = false;
                this.dgvSalesHistory.DataSource = ds.Tables[0];
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }

        private void txtSearchByID_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from Customer where StuffID like '" + this.txtSearchByID.Text + "%';";
            PopulateSalesHistoryGrid(sql);

            TotalPriceAmount();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.txtSearchByID.Clear();
            this.dtpSearch.Text = "";
            this.txtTotalSell.Clear();

            PopulateSalesHistoryGrid();
        }

        private void dtpSearch_ValueChanged(object sender, EventArgs e)
        {
            string sql = "select * from Customer where StuffID ='" + this.txtSearchByID.Text + "' and  PurchaseDate ='" + this.dtpSearch.Text + "';";
            PopulateSalesHistoryGrid(sql);

            TotalPriceAmount();
        }

        private void TotalPriceAmount()
        {
            int sum = 0;
            for (int i = 0; i < this.dgvSalesHistory.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dgvSalesHistory.Rows[i].Cells["Sales"].Value);
            }
            this.txtTotalSell.Text = sum.ToString();
        }
    }
}
