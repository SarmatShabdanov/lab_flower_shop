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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

      

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void catalogToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void supportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void signInToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cartToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void productsInCartToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fastOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void searchToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            search_form searchForm = new search_form();
            this.Hide();

            searchForm.StartPosition = FormStartPosition.Manual;
            searchForm.Location = this.Location;

            searchForm.ShowDialog();
            
        }

        private void productsInCartToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            cart_form cart_form = new cart_form();
            this.Hide();

            cart_form.StartPosition = FormStartPosition.Manual;
            cart_form.Location = this.Location;

            cart_form.ShowDialog();
         
        }

        private void supportToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            support_form support_Form = new support_form();
            this.Hide();

            support_Form.StartPosition = FormStartPosition.Manual;
            support_Form.Location = this.Location;

            support_Form.ShowDialog();
        }

        private void cartToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void logInToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            login_form2 logInForm = new login_form2();
            this.Hide();


            logInForm.StartPosition = FormStartPosition.Manual;
            logInForm.Location = this.Location;

            logInForm.ShowDialog();
        }

        private void signInToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            registration_form registration_Form = new registration_form();
            this.Hide();

            registration_Form.StartPosition = FormStartPosition.Manual;
            registration_Form.Location = this.Location;

            registration_Form.ShowDialog();
        }

        private void profileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            profile_form profile_Form = new profile_form();
            this.Hide();

            profile_Form.StartPosition = FormStartPosition.Manual;
            profile_Form.Location = this.Location;
            profile_Form.ShowDialog();
        }

        private void fastOrderToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            buy_form buy_Form = new buy_form();
            this.Hide();

            buy_Form.StartPosition = FormStartPosition.Manual;
            buy_Form.Location = this.Location;
            buy_Form.ShowDialog();
        }
    }
}
