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
    public partial class Form_inst : Form
    {
        public Form_inst()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_login frm_login = new Form_login();
            frm_login.ShowDialog();
        }
    }
}
