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
    class DataAccess
    {
        private SqlConnection sqlCon;
        public SqlConnection SqlCon
        {
            get { return this.sqlCon; }
            set { this.sqlCon = value; }
        }

        private SqlCommand sqlCom;
        public SqlCommand SqlCom
        {
            get { return this.sqlCom; }
            set { this.sqlCom = value; }
        }

        private SqlDataAdapter sda;
        public SqlDataAdapter Sda
        {
            get { return this.sda; }
            set { this.sda = value; }
        }

        private DataSet ds;
        public DataSet Ds
        {
            get { return this.ds; }
            set { this.ds = value; }
        }

        public DataAccess()
        {
            this.SqlCon = new SqlConnection("Data Source=IFTE_13\\IFTE_13;Initial Catalog=MediStop;Persist Security Info=True;User ID=sa;Password=ifte1234");
            SqlCon.Open();
        }

        private void QueryText(string query)
        {
            this.sqlCom = new SqlCommand(query, this.SqlCon);
        }

        public DataSet ExecuteQuery(string sql)
        {
            this.QueryText(sql);
            this.Sda = new SqlDataAdapter(this.SqlCom);
            this.Ds = new DataSet();
            this.Sda.Fill(this.Ds);
            return Ds;
        }

        public DataTable ExecuteQueryTable(string sql)
        {
            this.QueryText(sql);
            this.Sda = new SqlDataAdapter(this.SqlCom);
            this.Ds = new DataSet();
            this.Sda.Fill(this.Ds);
            return Ds.Tables[0];
        }

        public int ExecutiveDMLQuery(string sql)
        {
            this.QueryText(sql);
            int aff = this.SqlCom.ExecuteNonQuery();
            return aff;
        }
    }
}
