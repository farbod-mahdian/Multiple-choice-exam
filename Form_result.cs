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
    public partial class Form_result : Form
    {
        public Form_result()
        {
            InitializeComponent();
        }

        private void Form_result_Load(object sender, EventArgs e)
        {
            GlobalValv.rchTxt_result.Size = new Size(panel1.Size.Width, panel1.Size.Height);
            GlobalValv.rchTxt_result.ReadOnly = true; // In order to prevent the user to change the result of the exam
            panel1.Controls.Add(GlobalValv.rchTxt_result);
        }

        private void Form_result_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
