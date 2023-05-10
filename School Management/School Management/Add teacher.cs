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
    public partial class Add_teacher : Form
    {
        public Add_teacher()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
           
            String name = txtname.Text;
            

            String gender = cmbgender.Text;

            String dob = dtdob.Text;
            
            Int64 mobile = Int64.Parse(txtconno.Text);

            String adrs = txtadrs.Text;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-DSQ9UN0\SQLEXPRESS;Initial Catalog=student;User ID=sa;Password=123456789";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "insert into teacher (name,gender,DOB,number,adrs) values ('" + name + "','" + gender + "','" + dob + "'," + mobile + ",'" + adrs + "')";

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();

            MessageBox.Show("Data Saved", "Successfully Registered", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void Add_teacher_Load(object sender, EventArgs e)
        {
            
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            makanna();
        }
        private void makanna()
        {
            txtname.Clear();
            txtconno.Clear();
            txtadrs.Clear();
            cmbgender.Text= "------SELECT------";
            dtdob.Value = DateTime.Now;

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
    }

