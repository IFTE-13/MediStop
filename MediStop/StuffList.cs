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
    public partial class StuffList : UserControl
    {
        private DataAccess Da { get; set; }
        public StuffList()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            string sql = "select * from Stuff;";
            this.PopulateStuffGridView(sql); 
            this.lblPassword.Text = "0000";
            ProductIdGenerator();
        }

        internal void PopulateStuffGridView(string sql = "select * from Stuff where Role = 'Stuff';")
        {
            DataSet ds = this.Da.ExecuteQuery(sql);

            this.dgvStuffList.AutoGenerateColumns = false;
            this.dgvStuffList.DataSource = ds.Tables[0];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from stuff where Name like '" + this.txtAutoSearch.Text + "%' or ID like '" + this.txtAutoSearch.Text + "%';";
            PopulateStuffGridView(sql);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.IsValidToSaveStuff())
            {
                MessageBox.Show("Missing Data");
                return;
            }

            string sqlUpdate = "select * from stuff where ID = '" + this.txtEmployeeID.Text + "';";
            var result = this.Da.ExecuteQueryTable(sqlUpdate);
            try
            {
                if (result.Rows.Count == 1)
                {
                    string sql = @"update Stuff
                              set  Name = '" + this.txtEmployeeName.Text + @"',
                                   PhoneNo = '" + this.txtPhone.Text + @"',
                                   Salary = '" + this.txtSalary.Text + @"',
                                   Address = '" + this.txtAddress.Text + @"'
                                   where ID = '" + this.txtEmployeeID.Text + "';";
                    int count = this.Da.ExecutiveDMLQuery(sql);
                    if (count == 1)
                    {
                        MessageBox.Show("Updated");
                        this.ClearStuffContent();
                    }
                    else
                    {
                        MessageBox.Show("Operation Failed");
                    }
                }
                else
                {
                    string sql = "insert into stuff values('" + this.txtEmployeeID.Text + "', '" + this.txtEmployeeName.Text + "', '" + this.dtpDateOfBirth.Text + "', " + this.txtPhone.Text + ", '" + this.dtpJoiningDate.Text + "', '" + this.txtAddress.Text + "', " + this.txtSalary.Text + ", 'Stuff', '" + this.lblPassword.Text + "');";
                    int count = this.Da.ExecutiveDMLQuery(sql);
                    if (count == 1)
                    {
                        MessageBox.Show("Inserted");
                    }
                    else
                    {
                        MessageBox.Show("Operation Failed");
                    }
                }
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
            this.PopulateStuffGridView();
            ClearStuffContent();
        }

        private void dgvStuffList_DoubleClick(object sender, EventArgs e)
        {
            this.txtEmployeeID.Text = this.dgvStuffList.CurrentRow.Cells["ID"].Value.ToString();
            this.txtEmployeeName.Text = this.dgvStuffList.CurrentRow.Cells["EmployeeName"].Value.ToString();
            this.txtPhone.Text = this.dgvStuffList.CurrentRow.Cells["PhoneNo"].Value.ToString();
            this.txtSalary.Text = this.dgvStuffList.CurrentRow.Cells["Salary"].Value.ToString();
            this.txtAddress.Text = this.dgvStuffList.CurrentRow.Cells["Address"].Value.ToString();
            this.dtpDateOfBirth.Text = this.dgvStuffList.CurrentRow.Cells["DateOfBirth"].Value.ToString();
            this.dtpJoiningDate.Text = this.dgvStuffList.CurrentRow.Cells["JoiningDate"].Value.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearStuffContent();
        }

        private void ClearStuffContent()
        {
            this.txtEmployeeID.Clear();
            this.txtEmployeeName.Clear();
            this.txtSalary.Clear();
            this.txtPhone.Clear();
            this.txtAddress.Clear();
            this.dtpDateOfBirth.Text = "";
            this.dtpJoiningDate.Text = "";

            ProductIdGenerator();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvStuffList.SelectedRows.Count < 1)
            {
                MessageBox.Show("Select a row first");
                return;
            }
            string ID = this.dgvStuffList.CurrentRow.Cells["ID"].Value.ToString();
            try
            {
                string sql = "delete from stuff where ID = '" + ID + "';";
                int result = this.Da.ExecutiveDMLQuery(sql);
                if (result == 1)
                {
                    MessageBox.Show(ID + " Removed");
                }
                else
                {
                    MessageBox.Show("Operation Failed");
                }

                this.PopulateStuffGridView();
                this.ClearStuffContent();
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }

        bool IsValidToSaveStuff()
        {
            if(String.IsNullOrEmpty(this.txtEmployeeID.Text)||String.IsNullOrWhiteSpace(this.txtEmployeeID.Text) ||
                String.IsNullOrEmpty(this.txtEmployeeName.Text) || String.IsNullOrWhiteSpace(this.txtEmployeeName.Text) ||
                String.IsNullOrEmpty(this.txtPhone.Text) || String.IsNullOrWhiteSpace(this.txtPhone.Text)||
                String.IsNullOrEmpty(this.txtAddress.Text) || String.IsNullOrWhiteSpace(this.txtAddress.Text) ||
                String.IsNullOrEmpty(this.txtSalary.Text) || String.IsNullOrWhiteSpace(this.txtSalary.Text)
                )
            {
                return false;
            }
            return true;
        }

        private void ProductIdGenerator()
        {
            string sql = "select ID from stuff order by ID desc";
            var dt = this.Da.ExecuteQueryTable(sql);
            string lastId = dt.Rows[0]["ID"].ToString();
            string[] data = lastId.Split('-');
            int temp = Convert.ToInt32(data[1]);
            string newId = "S-" + (++temp).ToString("d3");
            this.txtEmployeeID.Text = newId;
        }
    }
}
