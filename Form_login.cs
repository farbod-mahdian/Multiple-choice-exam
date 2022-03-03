using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// GlobalValv is declared in the "Program.cs" file

namespace Lab4
{
    public partial class Form_login : Form
    {
        int counter = 0; // For three tries of login

        public Form_login()
        {
            InitializeComponent();
        }

        private void Form_login_Load(object sender, EventArgs e)
        {
            txtbox_ID.Select(); // Start from ID textbox
        }

        private void btn_login_Click(object sender, EventArgs e) //Validating data to login
        {
            counter++;

            if((txtbox_username.Text != "") && (txtbox_ID.Text != ""))
            {
                GlobalValv.user_ = txtbox_username.Text;
                GlobalValv.id = txtbox_ID.Text;
            }
            if ((GlobalValv.user_ != "") && (txtbox_pass.Text == GlobalValv.pass_) && (GlobalValv.id != ""))
            {
                Form_question frm_q = new Form_question();
                this.Hide();
                frm_q.ShowDialog();
            }
            else
            {
                MessageBox.Show("Wrong infomartion!\nYou only have " + (3 - counter) + " chance(s).");
                GlobalValv.user_ = "";
                GlobalValv.id = "";
                if (counter >= 3)
                {
                    MessageBox.Show("ERROR: You have entered wrong information for three times.\nTry again later.");
                    Application.Exit();
                }
            }
        }

        private void Form_login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_showPass_MouseDown(object sender, MouseEventArgs e) // To preview the entered password in order to avoid mistake (show when holding the click) - red button
        {
            txtbox_pass.UseSystemPasswordChar = false;
        }

        private void btn_showPass_MouseUp(object sender, MouseEventArgs e) // To preview the entered password in order to avoid mistake (hide when releasing the click) - red button
        {
            txtbox_pass.UseSystemPasswordChar = true;
        }
    }
}
