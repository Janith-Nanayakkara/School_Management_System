using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnlog_Click(object sender, EventArgs e)
        {
            if (username.Text == "admin" && txtpw.Text == "admin")
            {


                Form1 f1 = new Form1();
                f1.Show();
                this.Visible = false;




            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                username.Clear();
                txtpw.Clear();
                username.Focus();
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
