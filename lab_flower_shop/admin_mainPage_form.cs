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
    public partial class admin_mainPage_form : Form
    {
        public admin_mainPage_form()
        {
            InitializeComponent();
        }

        private void goToUserToolStripMenuItem_Click(object sender, EventArgs e)
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
