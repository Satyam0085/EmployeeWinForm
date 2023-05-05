using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormEmployeeApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet("Data set");
            DataTable dt = new DataTable("Data");
            ds.Tables.Add(dt);
            dt.Columns.Add("EmpID", typeof(int));
            dt.Columns.Add("EmpName", typeof(string));
            dt.Columns.Add("City", typeof(string));

            dt.Rows.Add(new Object[] { "txtempid", txtempid.Text });
            dt.Rows.Add(new Object[] { "txtempname", txtempname.Text });
            dt.Rows.Add(new Object[] { "txtcity", txtcity.Text });
            ds.Tables.Add(dt);


         
            
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet("Data set");
            DataTable dt = new DataTable("Data");
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            txtempid.Text = string.Empty;
            txtempname.Text = string.Empty;
            txtcity.Text = string.Empty;

            SqlConnection con = new SqlConnection();
            string query = "Delete from data from Employeee";
            SqlCommand cmd = new SqlCommand(query, con);
           

            
        }
    }
}
