using DGVPrinterHelper;
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
    public partial class Order : UserControl
    {
        private DataAccess Da { get; set; }
        private string id { set; get; }
        public Order()
        {
            InitializeComponent();
        }

        public Order(string Id)
        {
            InitializeComponent();
            this.id = Id.ToString();
            this.Da = new DataAccess();
            string sql = "select * from Customer;";
            this.PopulateCustomerOrderGridView(sql);
            ProductIdGenerator();
            ClearOrderContent();

        }

        private void PopulateProductGridView(string sql = "select * from OrderPlace;")
        {
            string sql1 = "select * from OrderPlace";

            DataSet ds = this.Da.ExecuteQuery(sql1);

            this.dgvOrder.AutoGenerateColumns = false;
            this.dgvOrder.DataSource = ds.Tables[0];
        }


        internal void PopulateCustomerOrderGridView(string sql = "select * from Product;")
        {
            DataSet ds = this.Da.ExecuteQuery(sql);

            this.dgvProductOrder.AutoGenerateColumns = false;
            this.dgvProductOrder.DataSource = ds.Tables[0];
        }

        private void ProductIdGenerator()
        {
            string sql = "select CustomerID from Customer order by CustomerID desc";
            var dt = this.Da.ExecuteQueryTable(sql);
            string lastId = dt.Rows[0]["CustomerID"].ToString();
            string[] data = lastId.Split('-');
            int temp = Convert.ToInt32(data[1]);
            string newId = "C-" + (++temp).ToString("d3");
            this.txtCustomerID.Text = newId;
        }

        private void dgvProductOrder_DoubleClick(object sender, EventArgs e)
        {
            string ProductID = this.dgvProductOrder.CurrentRow.Cells["ProductID"].Value.ToString();
            string MedicineName = this.dgvProductOrder.CurrentRow.Cells["ProductName"].Value.ToString();
            string Company = this.dgvProductOrder.CurrentRow.Cells["Company"].Value.ToString();
            string Price = this.dgvProductOrder.CurrentRow.Cells["Price"].Value.ToString();

            try
            {
                string sqlSearch = "select * from OrderPlace where ID ='" + ProductID + "';";
                var search = this.Da.ExecuteQueryTable(sqlSearch);
                if (search.Rows.Count == 1)
                {
                    MessageBox.Show("Alrady Added");
                }
                else
                {
                    string sql = "insert into OrderPlace values ('" + ProductID + "', '" + MedicineName + "', '" + Company + "', '" + Price + "', 1, '" + Price + "');";
                    this.Da.ExecutiveDMLQuery(sql);
                }
            }
            catch(Exception exe)
            {
                MessageBox.Show(exe.Message);
            }

            PopulateProductGridView();

            TotalPriceAmount();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            this.dgvProductOrder.ClearSelection();
            MessageBox.Show(this.id);
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            if (!this.IsValidToPlaceOrder())
            {
                MessageBox.Show("Missing Data");
                return;
            }

            try
            {
                if(Convert.ToInt32(this.txtPrice.Text) == 0)
                {
                    MessageBox.Show("Select a product for placing order");
                    return;
                }
                else
                {
                    string sqlInsert = "insert into Customer values('" + this.txtCustomerID.Text + "', '" + this.txtCustomerName.Text + "', '" + this.txtCustomerPhone.Text + "', '" + this.dtpPlaceOrder.Text + "', '" + this.txtPrice.Text + "', '" + this.id + "');";
                    int count = this.Da.ExecutiveDMLQuery(sqlInsert);
                    if (count == 1)
                    {
                        // Print Bill
                        DGVPrinter printer = new DGVPrinter();
                        printer.Title = "\r\n\r\n MediStop";
                        printer.SubTitle = "\r\r\r Customer ID:" + this.txtCustomerID.Text + "\r\r\r Name: " +this.txtCustomerName.Text + "\r\r\r Phone: " +this.txtCustomerPhone.Text+ "";
                        printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                        printer.PageNumbers = true;
                        printer.PageNumberInHeader = false;
                        printer.PorportionalColumns = true;
                        printer.HeaderCellAlignment = StringAlignment.Near;
                        printer.Footer = "Total price: " + this.txtPrice.Text + "";
                        printer.FooterSpacing = 5;
                        printer.PrintDataGridView(dgvOrder);


                        MessageBox.Show("Order Placed");
                        ClearOrderContent();
                        string sql = "delete from OrderPlace";
                        this.Da.ExecuteQuery(sql);
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

            
            PopulateProductGridView();

        }

        bool IsValidToPlaceOrder()
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

        private void ClearOrderContent()
        {
            this.txtCustomerID.Clear();
            this.txtCustomerName.Clear();
            this.txtPrice.Text = "0";
            this.txtCustomerPhone.Clear();
            ProductIdGenerator();

            dgvProductOrder.ClearSelection();
        }

        private void TotalPriceAmount()
        {
            int sum = 0;
            for (int i = 0; i < this.dgvOrder.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dgvOrder.Rows[i].Cells["TotalPrice"].Value);
            }
            this.txtPrice.Text = sum.ToString();
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (!IsValidToAddToCart())
            {
                MessageBox.Show("Select an product from ordered table first");
                return;
            }

            try
            {
                int quantity = Convert.ToInt32(this.nudQuantity.Text);
                int price = Convert.ToInt32(this.txtPreviewPorductPrice.Text);
                int totalPrice = quantity * price;

                string sql = @"update OrderPlace
                              set  Quantity ='" + this.nudQuantity.Text + @"',
                                   TotalPrice ='" + totalPrice + @"'
                                   where ID ='" + this.txtPreviewProductID.Text + "';";
                this.Da.ExecutiveDMLQuery(sql);
            }
            catch(Exception exe)
            {
                MessageBox.Show(exe.Message);
            }

            PopulateProductGridView();
            ClearCartContent();
            TotalPriceAmount();
        }

        private void dgvOrder_DoubleClick(object sender, EventArgs e)
        {
            this.txtPreviewProductID.Text = this.dgvOrder.CurrentRow.Cells["OrderedProductID"].Value.ToString();
            this.txtPreviewProductName.Text = this.dgvOrder.CurrentRow.Cells["OrderedProductName"].Value.ToString();
            this.txtPreviewProductCompany.Text = this.dgvOrder.CurrentRow.Cells["OrderedProductCompany"].Value.ToString();
            this.txtPreviewPorductPrice.Text = this.dgvOrder.CurrentRow.Cells["OrderPrice"].Value.ToString();
            this.nudQuantity.Text = this.dgvOrder.CurrentRow.Cells["OrderQuantity"].Value.ToString();
        }

        bool IsValidToAddToCart()
        {
            if(String.IsNullOrEmpty(this.txtPreviewProductID.Text) || String.IsNullOrWhiteSpace(this.txtPreviewProductID.Text) ||
                String.IsNullOrEmpty(this.txtPreviewProductName.Text) || String.IsNullOrWhiteSpace(this.txtPreviewProductName.Text) ||
                String.IsNullOrEmpty(this.txtPreviewProductCompany.Text) || String.IsNullOrWhiteSpace(this.txtPreviewProductCompany.Text) ||
                String.IsNullOrEmpty(this.txtPreviewPorductPrice.Text) || String.IsNullOrWhiteSpace(this.txtPreviewPorductPrice.Text) ||
                String.IsNullOrEmpty(this.nudQuantity.Text) || String.IsNullOrWhiteSpace(this.nudQuantity.Text))
            {
                return false;
            }
            return true;
        }

        private void ClearCartContent()
        {
            this.txtPreviewProductID.Clear();
            this.txtPreviewProductName.Clear();
            this.txtPreviewProductCompany.Clear();
            this.txtPreviewPorductPrice.Clear();
            this.nudQuantity.Text = "0";
        }

        private void Order_Load_1(object sender, EventArgs e)
        {
            try {
                string sql = "delete from OrderPlace";
                this.Da.ExecuteQuery(sql);
            }
            catch(Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }
    }
}
