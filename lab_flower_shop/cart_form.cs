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
    public partial class cart_form : Form
    {
        public cart_form()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            search_form search_form = new search_form();
            this.Hide();

            search_form.StartPosition = FormStartPosition.Manual;
            search_form.Location = this.Location;

            search_form.ShowDialog();
            this.Close();

        }

        private void goHomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 Home = new Form1();
            this.Hide();

            Home.StartPosition = FormStartPosition.Manual;
            Home.Location = this.Location;

            Home.ShowDialog();
            this.Close();

        }

        private void supportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            support_form support_Form = new support_form();
            this.Hide();

            support_Form.StartPosition = FormStartPosition.Manual;
            support_Form.Location = this.Location;

            support_Form.ShowDialog();
            this.Close();
        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login_form2 logInForm = new login_form2();
            this.Hide();


            logInForm.StartPosition = FormStartPosition.Manual;
            logInForm.Location = this.Location;

            logInForm.ShowDialog();
            this.Close();
        }

        private void signInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            registration_form registration_Form = new registration_form();
            this.Hide();

            registration_Form.StartPosition = FormStartPosition.Manual;
            registration_Form.Location = this.Location;

            registration_Form.ShowDialog();
            this.Close();
        }

        private void fastOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buy_form buy_Form = new buy_form();
            this.Hide();

            buy_Form.StartPosition = FormStartPosition.Manual;
            buy_Form.Location = this.Location;
            buy_Form.ShowDialog();
            this.Close();
        }

        private void profileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            profile_form profile_Form = new profile_form();
            this.Hide();

            profile_Form.StartPosition = FormStartPosition.Manual;
            profile_Form.Location = this.Location;
            profile_Form.ShowDialog();
            this.Close();
        }
    }
}
