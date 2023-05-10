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
    public partial class View_Delete_Student : Form
    {
        public View_Delete_Student()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will DELETE the record of the user", "CONFIRM?", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=DESKTOP-DSQ9UN0\SQLEXPRESS;Initial Catalog=student;User ID=sa;Password=123456789";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "Delete from student1 where StID=" + txtID.Text + "";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                MessageBox.Show("Deleted successfull", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void View_Delete_Student_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-DSQ9UN0\SQLEXPRESS;Initial Catalog=student;User ID=sa;Password=123456789";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from student1";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dt1.DataSource = ds.Tables[0];
        
    }

        private void btnreset_Click(object sender, EventArgs e)
        {

            if (txtID.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=DESKTOP-DSQ9UN0\SQLEXPRESS;Initial Catalog=student;User ID=sa;Password=123456789";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from student1 where StID=" + txtID.Text + "";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);


                dt1.DataSource = ds.Tables[0];
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
