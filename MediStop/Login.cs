using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MediStop
{
    public partial class Login : Form
    {
        private WelcomePage wp { set; get; }
        private DataAccess Da { get; set; }

        public Login()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.lblCurrentDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            this.lblCurrentTime.Text = DateTime.Now.ToString("h:mm tt");
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!this.isValidToLogin())
            {
                MessageBox.Show("Please fill the informations");
                return;
            }

            try
            {
                string sql = "select * from stuff;";
                DataSet ds = this.Da.ExecuteQuery(sql);

                int index = 0;
                bool flag = false;
                while (index < ds.Tables[0].Rows.Count)
                {
                    if (this.txtUserID.Text == ds.Tables[0].Rows[index][0].ToString() && this.txtPassword.Text == ds.Tables[0].Rows[index][8].ToString())
                    {
                        MessageBox.Show("Login Confirmed");
                        flag = true;
                        if (ds.Tables[0].Rows[index][7].ToString() == "Admin")
                        {
                            this.Hide();
                            Admin admin = new Admin(this, this.txtUserID.Text);
                            admin.Show();
                        }
                        else
                        {
                            this.Hide();
                            Stuff stuff = new Stuff(this, this.txtUserID.Text);
                            stuff.Show();
                        }

                        this.txtUserID.Clear();
                        this.txtPassword.Clear();
                        break;
                    }
                    index++;
                }
                if (!flag)
                {
                    MessageBox.Show("No user Found");
                }
            }
            catch(Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }

        bool isValidToLogin()
        {
            if(String.IsNullOrEmpty(this.txtUserID.Text) || String.IsNullOrWhiteSpace(this.txtUserID.Text) || 
                String.IsNullOrEmpty(this.txtPassword.Text) || String.IsNullOrWhiteSpace(this.txtPassword.Text))
            {
                return false;
            }
            return true;
        }

        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
            this.btnLogin.BackColor = SystemColors.Highlight;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            this.btnLogin.BackColor = Color.SteelBlue;
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public Login(WelcomePage welcomePage) : this()
        {
            this.wp = welcomePage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.wp.Show();
        }

        private void btnBack_MouseHover(object sender, EventArgs e)
        {
            this.btnBack.BackColor = SystemColors.Highlight;
        }

        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            this.btnBack.BackColor = Color.SteelBlue;
        }
    }
}
