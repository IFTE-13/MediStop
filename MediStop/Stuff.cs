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
    public partial class Stuff : Form
    {
        private Login login { set; get; }
        internal string Id { set; get; }
        public Stuff()
        {
            InitializeComponent();
        }

        public Stuff(Login logIn, string ID) : this()
        {
            this.Id = ID;
            this.login = logIn;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("Logged Out");
            this.login.Show();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile(this.Id);
            this.pnlStuff.Controls.Clear();
            this.pnlStuff.Controls.Add(profile);
        }

        private void Stuff_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Settings stuffSettings = new Settings(this.Id);
            this.pnlStuff.Controls.Clear();
            this.pnlStuff.Controls.Add(stuffSettings);
        }

        private void btnCustomerList_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            this.pnlStuff.Controls.Clear();
            this.pnlStuff.Controls.Add(customer);
            customer.PopulateCustomerGridView();
            customer.Show();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            Product products = new Product();
            this.pnlStuff.Controls.Clear();
            this.pnlStuff.Controls.Add(products);
            products.PopulateProductGridView();
            products.Show();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            Order order = new Order(this.Id);
            this.pnlStuff.Controls.Clear();
            this.pnlStuff.Controls.Add(order);
            order.PopulateCustomerOrderGridView();
            order.Show();
        }

        private void btnSalesReport_Click(object sender, EventArgs e)
        {
            SalesReport salesReport = new SalesReport(this.Id);
            this.pnlStuff.Controls.Clear();
            this.pnlStuff.Controls.Add(salesReport);
            salesReport.Show();
        }
    }
}
