using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_flower_shop
{
    public partial class admin_login : Form
    {
        public admin_login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            admin_mainPage_form Admin = new admin_mainPage_form();
            this.Hide();

            Admin.StartPosition = FormStartPosition.Manual;
            Admin.Location = this.Location;

            Admin.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();

            form1.StartPosition = FormStartPosition.Manual;
            form1.Location = this.Location;

            form1.ShowDialog();
            this.Close();
        }
    }
}
