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
    public partial class Admin : Form
    {
        private Login login { set; get; }
        internal string Id { set; get; }
        public Admin()
        {
            InitializeComponent();
        }

        public Admin(Login logIn, string ID) : this()
        {
            this.login = logIn;
            this.Id = ID;
            //ProfileComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("Logged Out");
            this.login.Show();
        }

        private void btnStuffList_Click(object sender, EventArgs e)
        {
            StuffList stuffList = new StuffList();
            this.pnlAdmin.Controls.Clear();
            this.pnlAdmin.Controls.Add(stuffList);
            stuffList.PopulateStuffGridView();
            stuffList.Show();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            Product products = new Product();
            this.pnlAdmin.Controls.Clear();
            this.pnlAdmin.Controls.Add(products);
            products.PopulateProductGridView();
            products.Show();
        }

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnAdminProfile_Click(object sender, EventArgs e)
        {
            ProfileComponent();
        }

        private void ProfileComponent()
        {
            Profile profile = new Profile(this.Id);
            this.pnlAdmin.Controls.Clear();
            this.pnlAdmin.Controls.Add(profile);
            profile.Show();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Settings stuffSettings = new Settings(this.Id);
            this.pnlAdmin.Controls.Clear();
            this.pnlAdmin.Controls.Add(stuffSettings);
        }

        private void btnSalesReport_Click(object sender, EventArgs e)
        {
            StuffHistory stuffHistory = new StuffHistory();
            this.pnlAdmin.Controls.Clear();
            this.pnlAdmin.Controls.Add(stuffHistory);
            stuffHistory.Show();
        }
    }
}

