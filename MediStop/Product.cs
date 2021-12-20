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
    public partial class Product : UserControl
    {
        private DataAccess Da { get; set; }
        public Product()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            string sql = "select * from Product;";
            this.PopulateProductGridView(sql);
            ProductIdGenerator();
        }

        internal void PopulateProductGridView(string sql = "select * from Product;")
        {
            DataSet ds = this.Da.ExecuteQuery(sql);

            this.dgvProductList.AutoGenerateColumns = false;
            this.dgvProductList.DataSource = ds.Tables[0];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from Product where ProductName like '" + this.txtAutoSearch.Text + "%' or ProductID like '" + this.txtAutoSearch.Text + "%' or Company like '" + this.txtAutoSearch.Text + "%';";
            PopulateProductGridView(sql);

           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.IsValidToSaveProduct())
            {
                MessageBox.Show("Missing Data");
                return;
            }

            string sqlUpdate = "select * from Product where ProductID = '" + this.txtProductID.Text + "';";
            var result = this.Da.ExecuteQueryTable(sqlUpdate);
            try 
            {
                if (result.Rows.Count == 1)
                {
                    string sql = @"update Product
                              set  ProductName = '" + this.txtProductName.Text + @"',
                                   Company = '" + this.txtCompany.Text + @"',
                                   Price = '" + this.txtPrice.Text + @"'
                                   where ProductID = '" + this.txtProductID.Text + "';";
                    int count = this.Da.ExecutiveDMLQuery(sql);
                    if (count == 1)
                    {
                        MessageBox.Show("Updated");
                        this.ClearProductContent();
                    }
                    else
                    {
                        MessageBox.Show("Operation Failed");
                    }
                }
                else
                {
                    string sql = "insert into Product values ('" + this.txtProductID.Text + "', '" + this.txtProductName.Text + "', '" +
                                            this.txtCompany.Text + "', " + this.txtPrice.Text + ");";
                    int count = this.Da.ExecutiveDMLQuery(sql);
                    if (count == 1)
                    {
                        MessageBox.Show("Inserted");
                        this.ClearProductContent();
                    }
                    else
                    {
                        MessageBox.Show("Operation Failed");
                    }
                }
            }
            catch(Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
            this.PopulateProductGridView();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearProductContent();
        }

        private void ClearProductContent()
        {
            this.txtProductID.Clear();
            this.txtProductName.Clear();
            this.txtCompany.Clear();
            this.txtPrice.Clear();

            ProductIdGenerator();
        }

        private void dgvProductList_DoubleClick(object sender, EventArgs e)
        {
            this.txtProductID.Text = this.dgvProductList.CurrentRow.Cells["ProductID"].Value.ToString();
            this.txtProductName.Text = this.dgvProductList.CurrentRow.Cells["MedicineName"].Value.ToString();
            this.txtCompany.Text = this.dgvProductList.CurrentRow.Cells["Company"].Value.ToString();
            this.txtPrice.Text = this.dgvProductList.CurrentRow.Cells["Price"].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvProductList.SelectedRows.Count < 1)
            {
                MessageBox.Show("Select a row first");
                return;
            }

            string ID = this.dgvProductList.CurrentRow.Cells["ProductID"].Value.ToString();
            try
            {
                string sql = "delete from Product where ProductID = '" + ID + "';";
                int result = this.Da.ExecutiveDMLQuery(sql);
                if (result == 1)
                {
                    MessageBox.Show(ID + " Removed");
                }
                else
                {
                    MessageBox.Show("Operation Failed");
                }

                this.PopulateProductGridView();
                this.ClearProductContent();
            }
            catch(Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }

        private void Product_Load(object sender, EventArgs e)
        {
            this.dgvProductList.ClearSelection();

            this.dgvProductList.Columns[0].HeaderCell.Style.Font = new Font("Microsoft YaHei", 12, FontStyle.Regular);
            this.dgvProductList.Columns[0].DefaultCellStyle.Font = new Font("Microsoft YaHei", 12, FontStyle.Regular);
            this.dgvProductList.Columns[1].HeaderCell.Style.Font = new Font("Microsoft YaHei", 12, FontStyle.Regular);
            this.dgvProductList.Columns[1].DefaultCellStyle.Font = new Font("Microsoft YaHei", 12, FontStyle.Regular);
            this.dgvProductList.Columns[2].HeaderCell.Style.Font = new Font("Microsoft YaHei", 12, FontStyle.Regular);
            this.dgvProductList.Columns[2].DefaultCellStyle.Font = new Font("Microsoft YaHei", 12, FontStyle.Regular);
            this.dgvProductList.Columns[3].HeaderCell.Style.Font = new Font("Microsoft YaHei", 12, FontStyle.Regular);
            this.dgvProductList.Columns[3].DefaultCellStyle.Font = new Font("Microsoft YaHei", 12, FontStyle.Regular);



        }

        bool IsValidToSaveProduct()
        {
            if(String.IsNullOrEmpty(this.txtProductID.Text) || String.IsNullOrWhiteSpace(this.txtProductID.Text) ||
               String.IsNullOrEmpty(this.txtProductName.Text) || String.IsNullOrWhiteSpace(this.txtProductName.Text) ||
               String.IsNullOrEmpty(this.txtPrice.Text) || String.IsNullOrWhiteSpace(this.txtPrice.Text) ||
               String.IsNullOrEmpty(this.txtCompany.Text) || String.IsNullOrWhiteSpace(this.txtCompany.Text)
                )
            {
                return false;
            }
            return true;
        }

        private void ProductIdGenerator()
        {
            string sql = "select ProductID from Product order by ProductID desc";
            var dt = this.Da.ExecuteQueryTable(sql);
            string lastId = dt.Rows[0]["ProductID"].ToString();
            string[] data = lastId.Split('-');
            int temp = Convert.ToInt32(data[1]);
            string newId = "P-" + (++temp).ToString("d3");
            this.txtProductID.Text = newId;
        }

    }
}
