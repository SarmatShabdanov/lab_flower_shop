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
    public partial class support_form : Form
    {
        public support_form()
        {
            InitializeComponent();
        }

        private void fastOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            search_form search_form = new search_form();
            this.Hide();

            search_form.StartPosition = FormStartPosition.Manual;
            search_form.Location = this.Location;

            search_form.ShowDialog();
        }

        private void goHomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 Home = new Form1();
            this.Hide();

            Home.StartPosition = FormStartPosition.Manual;
            Home.Location = this.Location;

            Home.ShowDialog();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cart_form cart_form = new cart_form();
            this.Hide();

            cart_form.StartPosition = FormStartPosition.Manual;
            cart_form.Location = this.Location;

            cart_form.ShowDialog();
        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login_form2 logInForm = new login_form2();
            this.Hide();


            logInForm.StartPosition = FormStartPosition.Manual;
            logInForm.Location = this.Location;

            logInForm.ShowDialog();
        }

        private void signInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            registration_form registration_Form = new registration_form();
            this.Hide();

            registration_Form.StartPosition = FormStartPosition.Manual;
            registration_Form.Location = this.Location;

            registration_Form.ShowDialog();
        }
    }
}
