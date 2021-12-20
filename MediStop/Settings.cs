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
    public partial class Settings : UserControl
    {
        private DataAccess Da { get; set; }
        private string id { set; get; }
        public Settings()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        public Settings(string Id)
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.id = Id.ToString();
        }

        private void ChangePassword()
        {
            string sql = "select * from stuff where ID ='" + this.id + "';";
            DataSet ds = this.Da.ExecuteQuery(sql);

            if (this.txtOldPassword.Text == ds.Tables[0].Rows[0][8].ToString())
            {
                if(this.txtNewPassword.Text == this.txtNewConfirmPassword.Text)
                {
                    string passwordUpdate = @"update Stuff
                                   set  Password = '" + this.txtNewPassword.Text + @"'
                                   where ID = '" + this.id + "';";
                    int count = this.Da.ExecutiveDMLQuery(passwordUpdate);
                    if (count == 1)
                    {
                        MessageBox.Show("Password Changed");
                        ClearPasswordContent();
                    }
                    else
                    {
                        MessageBox.Show("Operation Failed");
                    }
                }
                else
                {
                    MessageBox.Show("Passwords don't match");
                }
            }
            else
            {
                MessageBox.Show("Incorrect Old Password");
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ChangePassword();
        }

        private void ClearPasswordContent()
        {
            this.txtOldPassword.Clear();
            this.txtNewPassword.Clear();
            this.txtNewConfirmPassword.Clear();
        }
    }
}
