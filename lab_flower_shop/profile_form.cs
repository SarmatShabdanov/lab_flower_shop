﻿using System;
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
    public partial class profile_form : Form
    {
        public profile_form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void supportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            support_form support_Form = new support_form();
            this.Hide();

            support_Form.StartPosition = FormStartPosition.Manual;
            support_Form.Location = this.Location;

            support_Form.ShowDialog();
        }

        private void goHomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 HomeForm = new Form1();
            this.Hide();


            HomeForm.StartPosition = FormStartPosition.Manual;
            HomeForm.Location = this.Location;

            HomeForm.ShowDialog();
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

        private void productsInCartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cart_form cart_Form = new cart_form();
            this.Hide();

            cart_Form.StartPosition = FormStartPosition.Manual;
            cart_Form.Location = this.Location;

            cart_Form.ShowDialog();

        }

        private void fastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buy_form buy_Form = new buy_form();
            this.Hide();

            buy_Form.StartPosition = FormStartPosition.Manual;
            buy_Form.Location = this.Location;
            buy_Form.ShowDialog();
        }
    }
}
