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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            New_Student ns = new New_Student();
            ns.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            View_Delete_Student vs = new View_Delete_Student();
            vs.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Upgrade_Student us = new Upgrade_Student();
            us.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Add_teacher at = new Add_teacher();
            at.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            View_Teacher vt = new View_Teacher();
            vt.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Please confirm to exit??", "EXIT", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Please confirm to LOGOUT??", "LOGOUT", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Dispose();
                login ll = new login();
                ll.Show();
            }
           
        }
    }
}
