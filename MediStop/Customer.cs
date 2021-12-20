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
    public partial class Customer : UserControl
    {
        private DataAccess Da { get; set; }
        public Customer()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            string sql = "select * from Customer;";
            this.PopulateCustomerGridView(sql);
        }

        internal void PopulateCustomerGridView(string sql = "select * from Customer;")
        {
            DataSet ds = this.Da.ExecuteQuery(sql);

            this.dgvCustomerList.AutoGenerateColumns = false;
            this.dgvCustomerList.DataSource = ds.Tables[0];
        }

        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from Customer where CustomerName like '" + this.txtAutoSearch.Text + "%' or CustomerID like '" + this.txtAutoSearch.Text + "%' or BillAmount like '" + this.txtAutoSearch.Text + "%' or CustomerPhoneNumber like '" + this.txtAutoSearch.Text + "%';";
            PopulateCustomerGridView(sql);
        }

        private void dgvCustomerList_DoubleClick(object sender, EventArgs e)
        {
            this.txtCustomerID.Text = this.dgvCustomerList.CurrentRow.Cells["CustomerID"].Value.ToString();
            this.txtCustomerName.Text = this.dgvCustomerList.CurrentRow.Cells["CustomerName"].Value.ToString();
            this.txtCustomerPhone.Text = this.dgvCustomerList.CurrentRow.Cells["CustomerPhoneNumber"].Value.ToString();
            this.dtpDateOfBirth.Text = this.dgvCustomerList.CurrentRow.Cells["PurchaseDate"].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!this.IsValidToUpdateCustomer())
            {
                MessageBox.Show("Missing Data");
                return;
            }
            string sqlUpdate = "select * from Customer where CustomerID = '" + this.txtCustomerID.Text + "';";
            var result = this.Da.ExecuteQueryTable(sqlUpdate);
            try
            {
                if (result.Rows.Count == 1)
                {
                    string sql = @"update Customer
                              set  CustomerName = '" + this.txtCustomerName.Text + @"',
                                   CustomerPhoneNumber = '" + this.txtCustomerPhone.Text + @"'
                                   where CustomerID = '" + this.txtCustomerID.Text + "';";
                    int count = this.Da.ExecutiveDMLQuery(sql);
                    if (count == 1)
                    {
                        MessageBox.Show("Updated");
                        ClearCustomerContent();
                    }
                    else
                    {
                        MessageBox.Show("Operation Failed");
                    }
                }/*
                else
                {
                    string sql = "insert into Customer values('" + this.txtCustomerID.Text + "', '" + this.txtCustomerName.Text + "', '" + this.txtCustomerPhone.Text + "', '" + this.dtpDateOfBirth.Text + "', 5646);";
                    int count = this.Da.ExecutiveDMLQuery(sql);
                    if (count == 1)
                    {
                        MessageBox.Show("Inserted");
                    }
                    else
                    {
                        MessageBox.Show("Operation Failed");
                    }
                }*/
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
            PopulateCustomerGridView();
        }
        
        bool IsValidToUpdateCustomer()
        {
            if (String.IsNullOrEmpty(this.txtCustomerName.Text) || String.IsNullOrWhiteSpace(this.txtCustomerName.Text) ||
                String.IsNullOrEmpty(this.txtCustomerID.Text) || String.IsNullOrWhiteSpace(this.txtCustomerID.Text) ||
                String.IsNullOrEmpty(this.txtCustomerPhone.Text) || String.IsNullOrWhiteSpace(this.txtCustomerPhone.Text)
                )
            {
                return false;
            }
            return true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearCustomerContent();
        }

        private void ClearCustomerContent()
        {
            this.txtCustomerID.Clear();
            this.txtCustomerName.Clear();
            this.txtCustomerPhone.Clear();
            this.dtpDateOfBirth.Text = "";
        }
    }
}
