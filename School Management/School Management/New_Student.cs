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

namespace School_Management
{
    public partial class New_Student : Form
    {
        public New_Student()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
           // int no = int.Parse(lblid.Text);
            String name = txtname.Text;
            String gname = txtgname.Text;

            String gender = cmbgender.Text;
            
            String dob = dtdob.Text;
            Int64 grade = Int64.Parse(cmbgrade.Text);
            Int64 mobile = Int64.Parse(txtconno.Text);
           
            String adrs = txtadrs.Text;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-DSQ9UN0\SQLEXPRESS;Initial Catalog=student;User ID=sa;Password=123456789";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "insert into student1 (name,guardian,gender,DOB,grade,number,adrs) values ('" + name + "','" + gname + "','" + gender + "','" + dob + "'," + grade + "," + mobile + ",'" + adrs + "')";

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();

            MessageBox.Show("Data Saved", "Successfully Registered", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            makanna();
        }

        private void makanna()
        {
            txtname.Clear();
            txtgname.Clear();
            txtconno.Clear();
            txtadrs.Clear();
            cmbgender.Text = "------SELECT------";
            cmbgrade.Text = "------SELECT------";
            dtdob.Value = DateTime.Now;

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void New_Student_Load(object sender, EventArgs e)
        {
            
            
        }
    }
}
