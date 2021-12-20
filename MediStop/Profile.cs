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
    public partial class Profile : UserControl
    {
        private DataAccess Da { get; set; }
        private string id { set; get; }
        public Profile()
        {
            InitializeComponent();
        }

        public Profile(string Id)
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.id = Id.ToString();
            ShowData();
        }

        private void ShowData()
        {
            string sql = "select * from stuff where ID ='" + this.id + "';";
            DataSet ds = this.Da.ExecuteQuery(sql);

            this.txtID.Text = ds.Tables[0].Rows[0][0].ToString();
            this.txtName.Text = ds.Tables[0].Rows[0][1].ToString();
            this.dtpDateOfBirth.Text = ds.Tables[0].Rows[0][2].ToString();
            this.txtPhone.Text = ds.Tables[0].Rows[0][3].ToString();
            this.dtpJoiningDate.Text = ds.Tables[0].Rows[0][4].ToString();
            this.txtSalary.Text = ds.Tables[0].Rows[0][6].ToString();
            this.txtAddress.Text = ds.Tables[0].Rows[0][5].ToString();
        }
    }
}
