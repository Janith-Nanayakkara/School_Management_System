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
    public partial class Upgrade_Student : Form
    {
        public Upgrade_Student()
        {
            InitializeComponent();
        }

        private void Upgrade_Student_Load(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnup_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("GRADE UPDATE WARNING!!", "CONFIRM??", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=DESKTOP-DSQ9UN0\SQLEXPRESS;Initial Catalog=student;User ID=sa;Password=123456789";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "update student1 set grade='" + cmb2.Text + "' where grade='" + cmbfrom.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                MessageBox.Show("UPDATE WAS SUCCESSFULL!!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {
                MessageBox.Show("UPDATE CANCELLED!!", "CANCEL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
